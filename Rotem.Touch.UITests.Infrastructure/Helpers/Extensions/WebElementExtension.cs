using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Extensions
{
    public static class WebElementExtension
    {
        private static readonly IWebDriver driver;

        public static void ClickAndWait(this IWebElement webElement)
        {
            /////////////////gutman add
            //DriverManager.Driver.WaitForAjax();
           // DriverManager.Driver.ClickOnInvisibleElement(webElement);


            //////////////////
            webElement.Click();
            DriverManager.Driver.WaitForAjax();
        }
        public static void JavaDoubleClickAndWait(this IWebElement webElement)
        {
            DriverManager.Driver.WaitForAjax();//add gutman
            ((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript("arguments[0].click();", webElement);
            DriverManager.Driver.WaitForAjax();//add gutman
            ((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript("arguments[0].click();", webElement);
        }
        public static void JavaClickAndWait(this IWebElement webElement)
        {
            ((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript("arguments[0].click();", webElement);
            DriverManager.Driver.WaitForAjax();
        }

        public static void DoubleClick(this IWebElement webElement)
        {
            try
            {
                webElement.Click();
                DriverManager.Driver.WaitForAjax();
                webElement.Click();
                DriverManager.Driver.WaitForAjax();
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
