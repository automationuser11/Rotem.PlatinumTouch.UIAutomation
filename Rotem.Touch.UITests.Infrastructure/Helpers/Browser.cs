using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using System;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public static class Browser
    {
        public static void Close()
        {
            if (DriverManager.Driver == null) return;
            DriverManager.Driver.Quit();
            DriverManager.Driver = null;
            KillChromeDriverProcesses();
        }
        public static void KillChromeDriverProcesses()
        {
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                process.Kill();
            }
        }
        public static void KillChromeProcesses()
        {
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                process.Kill();
            }
        }
        public static void Reload()
        {
            DriverManager.Driver.ExecuteJavaScript<IWebDriver>("location.reload()");
        }

        public static void Refresh(this IApplicationPage page)
        {
            DriverManager.Driver.Navigate().Refresh();
            DriverManager.Driver.WaitForPageLoadingToComplete(page, Timeouts.Big);
        }

        public static void DomWaiting()
        {
            DriverManager.Driver.WaitForDomReady();
        }
    }
}