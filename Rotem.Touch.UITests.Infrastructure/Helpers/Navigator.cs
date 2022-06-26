using System;
using System.Linq;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;
using System.Threading;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public class Navigator : INavigator
    {
        protected const int DefaultTimeout = 15;
        public string CurrentPageUrl
        {
            get { return DriverManager.Driver.Url; }
        }
        public string BaseUrl
        {
            get { return string.Format("http://{0}:8080/main.html#", ConfigurationManagerHelper.ControllerAddress); }
        }
        public void NavigateTo<T>() where T : class, IApplicationPage, new()
        {
            var resultPage = PagesFactory.GetPage<T>();
            var page = Cast(resultPage, resultPage.GetType());

            NavigateToPageByMenu(page);
        }

        public void NavigateToPageByMenu(IApplicationPage page)
        {
            try
            {
                if (page.PageUrl.ToString() == DriverManager.Driver.Url.ToString())
                    return;
                //if (!DriverManager.Driver.FindElement(By.Id("modal-overlay")).GetAttribute("class").Contains("ng-hide") && DriverManager.Driver.FindElement(By.XPath("//div[contains(@class, 'settings-modal')]")).GetAttribute("class").Contains("ng-hide"))
                //    DriverManager.Driver.Navigate().Refresh();
                DriverManager.Driver.Navigate().GoToUrl(PagesFactory.GetPage<DashboardPage>().PageUrl);
                if (!DriverManager.Driver.FindElement(By.Id("modal-overlay")).GetAttribute("class").Contains("ng-hide") && DriverManager.Driver.FindElement(By.XPath("//div[contains(@class, 'settings-modal')]")).GetAttribute("class").Contains("ng-hide"))
                    DriverManager.Driver.Navigate().Refresh();
                TopMenuBarPage menu = new TopMenuBarPage();
                if (page.SubMenu != "Hot Key")
                    menu.MenuClick();
                else
                    menu.HotKeysMenuClick();
                var subMenuList = DriverManager.Driver.FindElements(By.XPath("//ul[@id='nav-floater-top']/li"));
                var SubMenuID = "";
                switch (page.SubMenu)
                {
                    case "Control":
                        SubMenuID = "1";
                        subMenuList[0].Click();
                        break;
                    case "Management":
                        SubMenuID = "2";
                        subMenuList[1].Click();
                        break;
                    case "History":
                        SubMenuID = "3";
                        subMenuList[2].Click();
                        break;
                    case "Hot Key":
                        SubMenuID = "4";
                        break;
                    case "System":
                        SubMenuID = "5";
                        subMenuList[3].Click();
                        break;
                }
                if (SubMenuID != "4")
                {
                    var RightMenuList = DriverManager.Driver.FindElements(By.XPath(string.Format("//div[@data-parent-id='{0}']/ul/li", SubMenuID)));
                    foreach (var tbl in RightMenuList)
                    {
                        if (tbl.Text == page.MenuName)
                        {
                            tbl.Click();
                            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
                            DriverManager.Driver.WaitForAjax();
                            DriverManager.Driver.WaitForDomReady();
                            return;

                        }
                    }
                }
                else
                {
                    var HotKeysMenuList = DriverManager.Driver.FindElements(By.XPath("//div[@id='homeMenu']/ul/li"));
                    foreach (var tbl in HotKeysMenuList)
                    {
                        if (tbl.Text == page.MenuName)
                        {
                            tbl.Click();
                            return;

                        }
                    }
                }

                var Page_Url = page.PageUrl.AbsoluteUri;
                if (CurrentPageUrl != Page_Url)
                {
                    DriverManager.Driver.Navigate().Refresh();
                    DriverManager.Driver.WaitForAjax();
                    DriverManager.Driver.WaitForPageContainerToLoaded(30);
                    DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
                    Assert.Fail("Page: " + page.Name + " Does not exist in the current controller mode");
                }
            }
            catch(NoSuchElementException e)
            {
                DriverManager.Driver.Navigate().Refresh();
                NavigateToPageByMenu(page);
            }
            catch(Exception e)
            {
                Assert.Fail("Navigation error" + e.Message + " - " + e.StackTrace);
            }
        }

        public void NavigateTo(IApplicationPage page)
        {
            if (DriverManager.Driver.Url == page.PageUrl.ToString()) return;

            DriverManager.Driver.Navigate().GoToUrl(PagesFactory.GetPage<DashboardPage>().PageUrl);
            //PagesFactory.GetPage<TopMenuBarPage>().ClickUnLockButton();
            
            // DriverManager.Driver.WaitForLoadingMaessageDissapear();
            // DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
           // DriverManager.Driver.WaitForDomReady();

           //sefi add handling page not exist in specific controller mode
            DriverManager.Driver.Navigate().GoToUrl(page.PageUrl);
            var Page_Url = page.PageUrl.AbsoluteUri;
            if (CurrentPageUrl != Page_Url) {
                Assert.Fail("Page: " + page.Name + " Does not exist in the current controller mode");
            }

            // the following line is to wait for the elemets to be loaded
            DriverManager.Driver.WaitForPageContainerToLoaded(30);
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
           // DriverManager.Driver.WaitForAjax();
           // DriverManager.Driver.WaitForDomReady();
        }
        private void NavigateTo(IPlcApplicationPage page)
        {
            DriverManager.Driver.Navigate().GoToUrl(page.PageUrl);
        }
        public dynamic Cast(dynamic obj, Type castTo)
        {
            return Convert.ChangeType(obj, castTo);
        }
        public void NavigateTo<T>(NavigationOption option) where T : class, IApplicationPage, new()
        {
            if (option == NavigationOption.InNewWindow)
                throw new NotSupportedException("Currently there is no support for operation of this kind.");

            var body = DriverManager.Driver.FindElement(By.TagName("body"));
            body.SendKeys(Keys.Control + 't');

            T page = PagesFactory.GetPage<T>();
            if (DriverManager.Driver.Url == page.PageUrl.ToString()) return;

            var handles = DriverManager.Driver.WindowHandles;
            DriverManager.Driver.SwitchTo().Window(handles.Last());

            DriverManager.Driver.Navigate().GoToUrl(page.PageUrl);
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
        }
        public void SwitchTab()
        {
            //Switch between tabs using Ctrl + \t
            DriverManager.Driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "\t");
        }
        public void NavigateToDashboard()
        {
            DriverManager.Driver.Navigate().GoToUrl(UrlFactory.GetDashboardUrl());
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            DriverManager.Driver.WaitForDomReady();
        }
    }

    public enum NavigationOption
    {
        InNewTab,
        SearchInOpendTabs,
        InNewWindow
    }
}
