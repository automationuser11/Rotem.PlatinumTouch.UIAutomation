using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC
{
    public class PlcRelaysPage : IPlcApplicationPage
    {
        //public Uri PageUrl
        //{
        //    get { return new Uri(string.Format("http://10.16.0.175/003.html")); }
        //}
        public Uri PageUrl
        {
            get { return new Uri(string.Format("http://10.16.0.199/001.html")); }
        }
        public string Name
        {
            get { return @"Relays"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles
        {
            get { return new List<string>() { "Relays" }; }
        }

        public bool IsAllDevicesStatusEqualsTo(string deviceName, RelayStatus status)
        {
            DriverManager.Driver.Navigate().GoToUrl(PageUrl.ToString());
            var timeout = new TimeSpan(0, 0, Timeouts.Small);
            var sw = Stopwatch.StartNew();

            var amountOfDevicesOnTheHTMLPage = DriverManager.Driver.FindElements(By.XPath("//*[contains(@id, 'RowName')]"));

            while (sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
            {
                DriverManager.Driver.Navigate().Refresh();
                var isFieldsUpdated = false;
                for (var i = 0; i < amountOfDevicesOnTheHTMLPage.Count(); i++)
                {
                    var elementOnThePage = DriverManager.Driver.FindElement(By.Id(string.Format("RowName{0}", i))).Text;
                    if (elementOnThePage.Contains(deviceName))
                    {
                        var relayValue = DriverManager.Driver.FindElement(By.Id(string.Format("uRow{0}", i))).Text;
                        if (relayValue == StringEnum.GetStringValue(status))
                            isFieldsUpdated = true;
                    }
                }
                if (isFieldsUpdated)
                    return true;
            }
            return false;
        }

        public bool IsSpecificPlcRelayValueEqualsTo(RelayStatus status, int relayNumber)
        {
            DriverManager.Driver.Navigate().GoToUrl(PageUrl.ToString());
            var timeout = new TimeSpan(0, 0, Timeouts.Small);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
            {
                DriverManager.Driver.Navigate().Refresh();
                var relayValue = DriverManager.Driver.FindElement(By.Id(string.Format("uRow{0}", (relayNumber - 1)))).Text;
                if (relayValue == StringEnum.GetStringValue(status))
                    return true;
            }
            return false;
        }

    }
}
