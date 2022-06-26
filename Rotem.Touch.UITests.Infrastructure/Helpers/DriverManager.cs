using System;
using System.IO;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard;
using Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Login;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public static class DriverManager
    {
        private static readonly RotemWebNavigator _rotemWebNavigator;
        static DriverManager()
        {
            _rotemWebNavigator = new RotemWebNavigator();
            //PagesFactory.PageGetEvent += Instance_PageGetEvent;
            //PagesFactory.Instance.PagesFactoryRefreshed += Instance_PagesFactoryRefreshed;
        }

        static void Instance_PagesFactoryRefreshed(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        static void Instance_PageGetEvent(object sender, PageGetEventArgs e)
        {
            if (!ConfigurationManagerHelper.IsFarmMode) return;

            try
            {
                Driver.SwitchTo().DefaultContent(); // you are now outside all frames
                if (!(e.PageObject is IRotemWebPage))
                {
                    Driver.SwitchTo().Frame("ifrmHouseDetails");
                    _rotemWebNavigator.SelectHouse();
                    Driver.WaitForDomReady();
                }
            }
            catch (NoSuchFrameException)
            {
            }
        }

        public static IWebDriver Driver
        {
            get
            {
                if (_driver != null) return _driver;
                //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                Browser.KillChromeDriverProcesses();
                Browser.KillChromeProcesses();

                var options = new ChromeOptions();

                if (ConfigurationManagerHelper.IsCellularMode)
                    options.EnableMobileEmulation("Apple iPhone 6");

                var driverDir = Path.GetFullPath(ConfigurationManagerHelper.WebDriverFolder);
                //var profile = Path.GetFullPath(ConfigurationManagerHelper.WebDriverFolder + "/ChromeProfile");
                //var extensions = Path.GetFullPath(ConfigurationManagerHelper.WebDriverFolder + "/ChromeExtensions/0.1.3.2_0.crx");
                //options.AddExtensions(extensions);
                //options.AddArguments(string.Format(@"user-data-dir={0}", profile));
                options.AddArguments("start-maximized");
                options.AddArguments("incognito");

                if (!ConfigurationManagerHelper.IsFarmMode)
                {
                    _driver = new ChromeDriver(driverDir, options) { Url = (new DashboardPage()).PageUrl.ToString() };
                    _driver.WaitForPageContainerToLoaded(Timeouts.Small);
                }
                else
                {
                    _driver = new ChromeDriver(driverDir, options) { Url = (new LoginPage().PageUrl.ToString()) };
                }

                return _driver;
            }
            set
            {
                _driver = value;
            }
        }

        private static IWebDriver _driver;

        /// <summary>
        /// This driver should be used for testing and debugging purposes only.
        /// </summary>
        public static IWebDriver TestDriver
        {
            get
            {
                if (_testDriver != null) return _testDriver;

                var options = new ChromeOptions();
                var driverDir = Path.GetFullPath(ConfigurationManagerHelper.WebDriverFolder);
                //var profile = Path.GetFullPath(ConfigurationManagerHelper.WebDriverFolder + "/ChromeProfile");
                //var extensions = Path.GetFullPath(ConfigurationManagerHelper.WebDriverFolder + "/ChromeExtensions/0.1.3.2_0.crx");
                //options.AddExtensions(extensions);
                //options.AddArguments(string.Format(@"user-data-dir={0}", profile));
                options.AddArguments("start-maximized");
                _testDriver = new ChromeDriver(driverDir, options);

                return _testDriver;
            }
            set
            {
                _testDriver = value;
            }
        }
        private static IWebDriver _testDriver;
    }
}