using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode
{
    public class TopMenuBarPage : IPageObject
    {
        #region Elements Mapping

        private IWebElement HomeButton
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("i[class='icon-farm']"));

                return DriverManager.Driver.FindElement(By.CssSelector("span[class='nav-icon icon-home']"));
            }
        }

        private IWebElement MenuButton
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("i[class='icon-lines']"));

                return DriverManager.Driver.FindElement(By.CssSelector("span[class='nav-icon icon-lines']"));
            }
        }

        private IWebElement MenuPanel
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("div[class*='mobile-menu opened']"));

                return DriverManager.Driver.FindElement(By.CssSelector("div[class='floater floater-pointer floater-pointer-top floater-nav floater-2col']"));
            }
        }

        private IWebElement TimeBlock
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("div[class='house-info'] li[class*='time']"));

                return DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-time noWrap']"));
            }
        }

        private IWebElement DayBlock
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("div[class='house-info'] li[class*='day']"));

                return DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-growth-day noWrap']"));
            }
        }

        private IWebElement HouseModeBlock
        {
            get
            {
                // Does not exists in cellularmode.
                return DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-brood noWrap']"));
            }
        }

        private IWebElement LockButton
        {
            get
            {
                // Does not exists in cellularmode.
                return DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-lock noWrap']"));
            }
        }
        private string GetLockButtonState()
        {
            var lockState = LockButton.Text;
            return lockState;
        }

        public void ClickUnLockButton()
        {
            if (GetLockButtonState().ToString() == "Unlock")
                ClickLockButton();
        }

        private void ClickLockButton()
        {
            DriverManager.Driver.WaitForPageContainerToLoaded(30);
            LockButton.ClickAndWait();
        }

        private IWebElement SirenButton
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("li.alarms"));
                
                return DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-alarm text-center noWrap']"));
            }
        }

        private IWebElement MessagesButton
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("ul[class='nav mobile-buttons'] i[class*='icon-email']"));

                return DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-msg text-center noWrap']"));
            }
        }

        private IWebElement MessagesPanel
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("div.alarms-sidebar.opened div.list ul"));

                return DriverManager.Driver.FindElement(By.CssSelector("div[class='floater-messages floater floater-pointer floater-pointer-top floater-nav']"));
            }
        }

        private IWebElement LanguageButton
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("li[class='settings'] ul[class='dropdown-menu'] li[class='dropdown-submenu'] a i"));

                return DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-lang text-center noWrap ']"));
            }
        }

        private IWebElement LanguagePanel
        {
            get
            {
                if (ConfigurationManagerHelper.IsCellularMode)
                    return DriverManager.Driver.FindElement(By.CssSelector("ul[class='dropdown-menu'] li a[ng-click='changeLanguage(language)']"));

                return DriverManager.Driver.FindElement(By.CssSelector("div[class='floater-messages floater floater-pointer floater-pointer-top floater-nav nav-ntf']"));
            }
        }
        private IWebElement HotKeysMenuButton
        {
            get
            {
                // Does not exists in cellularmode.
                return DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-help noWrap']"));
            }
        }

        private IWebElement HotKeysMenuPanel
        {
            get
            {
                // Does not exists in cellularmode.
                return DriverManager.Driver.FindElement(By.CssSelector("div[id='homeMenu']"));
            }
        }

        #endregion

        public void HotKeysMenuClick()
        {
            try
            {
                TempReminderPage Message = new TempReminderPage();
                Message.ClickConfirmButton();
                Waits.Wait(2);
                HotKeysMenuButton.Click();
            }
            catch
            {
                throw new NoSuchElementException("Menu hot keys not exists");
            }
        }

        public void ClickHomeButton()
        {
            DriverManager.Driver.WaitForPageContainerToLoaded(30);
            HomeButton.ClickAndWait();
        }
        public string GetCurrentDay()
        {
            string[] currentDay = DayBlock.Text.Split(new[] { "Day " }, StringSplitOptions.None);

            return currentDay[1];
        }
        public string GetHouseMode()
        {
            if (ConfigurationManagerHelper.IsCellularMode) return string.Empty;

            var currentMode = HouseModeBlock.Text;
            return currentMode;
        }
        public string GetCurrentMessagesNumber()
        {
            var messageCount = MessagesButton.FindElement(By.CssSelector("div[class='counter ng-binding']")).Text;
            return messageCount;
        }
        public bool IsHomeButtonExist()
        {
            return DriverManager.Driver.IsElementExists(() => HomeButton);
        }
        public void MenuClick()
        {
            try
            {
                TempReminderPage Message = new TempReminderPage();
                Message.ClickConfirmButton();
                Waits.Wait(2);
                MenuButton.Click();
            }
            catch
            {
                throw new NoSuchElementException("Menu not exists");
            }
        }
        public bool IsMenuButtonExist()
        {
            return DriverManager.Driver.IsElementExists(() => MenuButton);
        }
        public bool IsMenuPanelExist()
        {
            MenuButton.ClickAndWait();

            try
            {
                IWebElement Element = DriverManager.Driver.FindElement(By.Id("nav-floater"));
                return Element.Displayed;//element is found and if it is displayed the returned value is true otherwise false
            }
            catch (NoSuchElementException)
            {
                //element not found 
                return false;
            }

            //return DriverManager.Driver.IsElementExists(() => MenuPanel);//removed gutman
        }
        public bool IsTimeBlockExist()
        {
            return DriverManager.Driver.IsElementExists(() => TimeBlock);
        }
        public bool IsDayBlockExist()
        {
            return DriverManager.Driver.IsElementExists(() => DayBlock);
        }
        public bool IsHouseModeBlockExist()
        {
            if (ConfigurationManagerHelper.IsCellularMode) return true;
            return DriverManager.Driver.IsElementExists(() => HouseModeBlock);
        }
        public bool IsLockButtonExist()
        {
            if (ConfigurationManagerHelper.IsCellularMode) return true;
            return DriverManager.Driver.IsElementExists(() => LockButton);
        }
        public bool IsSirenButtonExist()
        {
            return DriverManager.Driver.IsElementExists(() => SirenButton);
        }
        public bool IsMessagesButtonExist()
        {
            return DriverManager.Driver.IsElementExists(() => MessagesButton);
        }
        public bool IsMessagesPanelExist()
        {
            MessagesButton.ClickAndWait();
            return DriverManager.Driver.IsElementExists(() => MessagesPanel);
        }
        public bool IsLanguageButtonExist()
        {
            if (ConfigurationManagerHelper.IsFarmMode)
            {
                DriverManager.Driver.SwitchTo().DefaultContent();

                var languageArea = DriverManager.Driver.FindElements(By.CssSelector("li[class='settings'] ul[class='dropdown-menu'] li[class='dropdown-submenu'] a i"));

                if (languageArea.Count == 1) return true;
                return false;
            }

            var languageButton = DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-lang text-center noWrap']"));
            return DriverManager.Driver.IsElementExists(() => languageButton);
        }
        public bool IsLanguagePanelExist()
        {
            try
            {
                IWebElement languageButton = null;
                if (ConfigurationManagerHelper.IsFarmMode)
                {
                    DriverManager.Driver.SwitchTo().DefaultContent();
                    languageButton = DriverManager.Driver.FindElement(By.CssSelector("li[class='settings'] ul[class='dropdown-menu'] li:nth-child(3)"));
                    languageButton.ClickAndWait();

                    var languagesList = DriverManager.Driver.FindElements(By.CssSelector("li[class='settings'] ul[class='dropdown-menu'] li[class='dropdown-submenu open'] ul li"));

                    if (languagesList.Count == 1) return true;
                    return false;
                }

                languageButton = DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-lang text-center noWrap']"));
                languageButton.ClickAndWait();
                return DriverManager.Driver.IsElementExists(() => LanguagePanel);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Could not find Language element. The problem is: {0}.", ex.Message));
            }
        }
        public bool IsHotKeyMenuButtonExist()
        {
            if (ConfigurationManagerHelper.IsCellularMode) return true;
            return DriverManager.Driver.IsElementExists(() => HotKeysMenuButton);
        }
        public bool IsHotKeysMenuPanelExist()
        {
            if (ConfigurationManagerHelper.IsCellularMode) return true;

            HotKeysMenuButton.ClickAndWait();
            return DriverManager.Driver.IsElementExists(() => HotKeysMenuPanel);
        }
        public string GetCurrentTime()
        {
            var currentTime = TimeBlock.Text;
            return currentTime;
        }


        // this func is not in use - please unmark this line if used!!
        public string GetControllerMode()
        {
            try
            {

                var subMenus = DriverManager.Driver.FindElements(By.CssSelector("li[ng-repeat='topLevelMenuItem in menuObj.SubMenus']"));
                var pages = DriverManager.Driver.FindElements(By.CssSelector("li[ng-repeat='subMenu in subMenuItemGroup']"));

                MenuButton.ClickAndWait();
                WaitUntilMenuOpened();
           
                var requiredMenu = subMenus.Where(menu => menu.Text == "System").SingleOrDefault();
                requiredMenu.ClickAndWait();
                var requiredPage = pages.Where((page => page.Text == "Version")).SingleOrDefault();
                requiredPage.ClickAndWait();
                    
                var Version = DriverManager.Driver.FindElement(By.CssSelector("div[class*='#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(1) > td:nth-child(2)'] "));


                return Version.Text;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Could not find controller version element. The problem is: {0}.", ex.Message));
            }
        }


        public string GetCurrentLanguage()
        {
            try
            {
                IWebElement languageButton = null;
                if (ConfigurationManagerHelper.IsFarmMode)
                {
                    DriverManager.Driver.SwitchTo().DefaultContent();

                    var languageArea =
                        DriverManager.Driver.FindElement(By.CssSelector("li[class*='language']"));
                    languageButton = languageArea.FindElement(By.CssSelector("div[class='btn dropdown-toggle'] span"));
                }
                else
                {
                    languageButton = DriverManager.Driver.FindElement(By.CssSelector("div[class*='nav-lang text-center noWrap ']"));
                }
                
                return languageButton.Text;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Could not find Language element. The problem is: {0}.", ex.Message));
            }
        }
        public void WaitUntilMenuOpened()
        {
            var timout = new TimeSpan(0, 0, 20);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedMilliseconds < timout.TotalMilliseconds)
            {
                try
                {
                    if (DriverManager.Driver.FindElement(By.CssSelector("div[id='nav-floater']")).Displayed)
                        return;
                }
                catch(NoSuchElementException)
                {
                    Thread.Sleep(1000);
                }
            }

            throw new TimeoutException("Waiting for menu to open has exceeded its time limit.");
        }
        public bool IsPageButtonClickable(string subMenu, string pageName)
        {
            var subMenus = DriverManager.Driver.FindElements(By.CssSelector("li[ng-repeat='topLevelMenuItem in menuObj.SubMenus']"));
            var pages = DriverManager.Driver.FindElements(By.CssSelector("li[ng-repeat='subMenu in subMenuItemGroup']"));

            MenuButton.ClickAndWait();
            WaitUntilMenuOpened();

            var requiredMenu = subMenus.Where(menu => menu.Text == subMenu).SingleOrDefault();
            if (requiredMenu == null) return false;

            requiredMenu.ClickAndWait();

            var requiredPage = pages.Where((page => page.Text == pageName)).SingleOrDefault();
            if (requiredPage == null) return false;
            if (requiredPage.GetAttribute("class").Contains("menu-disabled")) return false;

            requiredPage.ClickAndWait();
            return true;
        }

        // Yosef: For self use only
        //public void PrintAllPagesTofile()
        //{
        //    string FileLocation = @"C:\Users\yosef\Desktop\WriteFromC\Text.txt";
        //    List<string> SubMenuList = new List<string>();
        //    List<string> PagesList = new List<string>();

        //    var SubMenus = DriverManager.Driver.FindElements(By.CssSelector("li[ng-repeat='topLevelMenuItem in menuObj.SubMenus']"));
        //    var Pages = DriverManager.Driver.FindElements(By.CssSelector("li[ng-repeat='subMenu in subMenuItemGroup']"));

        //    MenuButton.Click();
        //    for (int i = 0; i < Pages.Count; i++)
        //    {
        //        if (SubMenus[i].Text != "Testing & Calibration")
        //            SubMenuList.Add(SubMenus[i].Text);
        //        SubMenus[i].Click();

        //        for (int k = 0; k < Pages.Count; k++)
        //        {
        //            if (Pages[k].Text != "")
        //                PagesList.Add(Pages[k].Text);
        //        }
        //        File.WriteAllLines(FileLocation, PagesList);
        //    }
        //}

    }
}