using System;
using System.IO;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb;
using Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Login;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using System.Web;
using System.Threading;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public class RotemWebNavigator : INavigator
    {
        public static string UserToken { get; private set; }
        public static string FarmId { get; private set; }
        public string CurrentPageUrl { get { return DriverManager.Driver.Url; } }
        public string BaseUrl { get { return string.Format("https://{0}:8080/rotemWebApp/main.html#", ConfigurationManagerHelper.FarmAddress); } }
        public void NavigateTo<T>() where T : class, IApplicationPage, new()
        {
            var resultPage = PagesFactory.GetPage<T>();
            var page = Cast(resultPage, resultPage.GetType());

            NavigateTo(page);
            }
        public void NavigateTo(IApplicationPage page)
        {
            Login();
            SelectHouse(GetActiveHouse());
            if (DriverManager.Driver.Url == page.PageUrl.ToString()) return;
            DriverManager.Driver.Navigate().GoToUrl(page.PageUrl);
            //SwitchToHouse(page.PageUrl);
            //DriverManager.Driver.Navigate().GoToUrl(page.PageUrl);
            //DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            //DriverManager.Driver.WaitForAjax();
            //DriverManager.Driver.WaitForDomReady();
        }
        private void NavigateTo(IPlcApplicationPage page)
        {
            DriverManager.Driver.Navigate().GoToUrl(page.PageUrl);
        }
        private void Login()
        {
            if (LoginPage.IsLoggedIn) return;

            var loginpage = PagesFactory.GetPage<LoginPage>();
            NavigateTo(loginpage);
            loginpage.Login(new LoginArgs() { UserName = "automation@munters.co.il", Password = "%TGhy6"});
            //SelectHouse();
            //DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            if (!DriverManager.Driver.Url.Contains("Comparison"))
                DriverManager.Driver.WaitForDomReady();
        }
        private void NavigateTo(IRotemWebPage page)
        {
            DriverManager.Driver.Navigate().GoToUrl(page.PageUrl);

            var loginPage = page as LoginPage;
            if (loginPage == null) return;

            if (UserToken == null)
                loginPage.LoggedIn += OnLoggedInEvent;
        }

        private void OnLoggedInEvent(object sender, EventArgs e)
        {
            try
            {
                var urlParts = DriverManager.Driver.Url.Split(new[] {"&houseNumber=", "token=", "&farm=", "&pageID="},
                    StringSplitOptions.None);
                UserToken = urlParts[1];
                FarmId = urlParts[2];
                ActiveHouseId = ((int)GetActiveHouse()).ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new LoginFailureException(UserToken, FarmId, ActiveHouseId, ex);
            }
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
            //DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
        }
        public void SelectHouse(House house)
        {
            if(GetCurrentHouseFromUrl() != ((int)house).ToString())
            {
                SwitchToHouse(house);
                DriverManager.Driver.WaitForDomReady();
                //var dashboard = PagesFactory.GetPage<HomePage>();
                //dashboard.SelectHouse((int)house);
                ActiveHouseId = ((int)house).ToString();
            }
            
        }

        public void SwitchToHouse(House house)
        {
            if (DriverManager.Driver.Url.Contains("Comparison"))
            {
                DriverManager.Driver.FindElement(By.XPath("//*[@id='mainBody']/div[1]/div[1]/ul/li[1]/div")).Click();
                DriverManager.Driver.WaitForDomReady();
            }  
            Uri currentUri = new Uri(DriverManager.Driver.Url);
            string[] parts = currentUri.ToString().Split('&');
            string desiredHouseUri = "";
            foreach (string item in parts)
            {

                if (item.Contains("houseNumber"))
                    desiredHouseUri += item.Replace(item.Substring(item.Length - 1), ((int)house).ToString()) + "&";
                else
                    desiredHouseUri += item + "&";
            }
            desiredHouseUri = desiredHouseUri.Substring(0, desiredHouseUri.Length - 1);
            DriverManager.Driver.Navigate().GoToUrl(desiredHouseUri);
            DriverManager.Driver.WaitForDomReady();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        public void SwitchToHouse(Uri pageUri)
        {
            string[] parts = pageUri.ToString().Split('&');
            string desiredHouseUri = "";
            foreach (string item in parts)
            {

                if (item.Contains("houseNumber"))
                    desiredHouseUri += item.Replace(item.Substring(item.Length - 1), ActiveHouseId) + "&";
                else
                    desiredHouseUri += item + "&";
            }
            desiredHouseUri = desiredHouseUri.Substring(0, desiredHouseUri.Length - 1);
            DriverManager.Driver.Navigate().GoToUrl(desiredHouseUri);
            DriverManager.Driver.WaitForDomReady();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        public string GetCurrentHouseFromUrl()
        {
            Uri currentUri = new Uri(DriverManager.Driver.Url);
            string[] parts = currentUri.ToString().Split('&');
            string currentHouseValue = "";
            foreach (string item in parts)
            {
                if (item.Contains("houseNumber"))
                    currentHouseValue = item.Substring(item.Length - 1);
            }
            return currentHouseValue;
        }

        public void SelectHouse()
        {
            var dashboard = PagesFactory.GetPage<HomePage>();

            if (ActiveHouseId != null)
            {
                var house = GetActiveHouse();
                dashboard.SelectHouse((int)house);
                ActiveHouseId = ((int)house).ToString();
            }
            else
            {
                dashboard.SelectHouse((int)ActiveHouse);
            }
        }
        public House GetActiveHouse()
        {
            var agentConfigFile = ConfigurationManagerHelper.AgentConfigFile;
            House house;
            House.TryParse(File.ReadLines(agentConfigFile).First(), true, out house);
            ActiveHouse = house;

            return house;
        }
        public static string ActiveHouseId { get; private set; }
        public static House ActiveHouse { get; private set; }
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
}
