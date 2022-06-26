using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.GeneralSetup;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class SeleniumTests
    {
        [TestMethod]
        [InfrastructureTest]
        public void LaunchWebDriverUsingDefaultSettings()
        {
            var driver = DriverManager.Driver;
            Assert.IsNotNull(driver);
        }

        [TestMethod]
        [InfrastructureTest]
        public void LaunchWebDriverAndNavigateToPage()
        {
            var setupPage = PagesFactory.GetPage<GeneralSetupPage>();
            var driver = new ChromeDriver(@"C:\Users\Haim\Desktop\New folder\chromedriver_win32");

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(setupPage.PageUrl);
        }


        
        [TestMethod]
        [InfrastructureTest]
        public void ValidateCheckboxState()
        {
            const string isChecked = @"return $($(""[name='settingsData.AlarmReset_Reset']"")[0]).is("":checked"")";
            const string findCbx = "return $(\"[name='settingsData.AlarmReset_Reset']\").get(0);";

            var driver = new ChromeDriver(@"C:\Users\Haim\Desktop\New folder");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(@"http://10.16.1.157:8080/Main.html#/dashboard");
            driver.Navigate().GoToUrl(@"http://10.16.1.157:8080/Main.html#/template01Page?pageID=27");

            var jsExecutor = (IJavaScriptExecutor)driver;
            var checkbox = (IWebElement)jsExecutor.ExecuteScript(findCbx);

            var state = (bool)jsExecutor.ExecuteScript(isChecked);
            Assert.IsFalse(state);

            checkbox.Click();

            state = (bool)jsExecutor.ExecuteScript(isChecked);
            Assert.IsTrue(state);
        }
    }
}
