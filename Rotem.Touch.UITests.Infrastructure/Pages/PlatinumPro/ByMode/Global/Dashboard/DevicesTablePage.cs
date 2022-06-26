using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard
{
    public partial class DashboardPage
    {
        public class DevicesTablePage
        {
            public INavigator Navigator
            {
                get
                {
                    return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
                }
            }

            #region Mapping

            internal IWebElement DevicesTable
            {
                get
                {
                    return DriverManager.Driver.WaitForFieldToBeLoaded(By.CssSelector("div[class='data-grid data-grid-header k-grid k-widget']"), Timeouts.Small);
                }
            }

            #endregion

            public string DeviceName { get; set; }
            public string ActiveColumn { get; set; }
            public string TotalColumn { get; set; }

            private bool IsActualDeviceValuesAsExpected()
            {
                var deviceColumns = GetDeviceColumns(DeviceName);
                if (deviceColumns == null) return false;
                if (deviceColumns[0].Text != DeviceName) return false;
                if (deviceColumns[1].Text != ActiveColumn) return false;
                if (deviceColumns[2].Text != TotalColumn) return false; 
                return true;
            }

            internal ReadOnlyCollection<IWebElement> GetDeviceColumns(string deviceName)
            {
                var table = DevicesTable.WaitForFieldToBeLoaded(By.CssSelector("div[class='k-grid-content']"));
                var rows = table.WaitForNumberOfElementsGreaterTahnZero(By.CssSelector("tr[ng-repeat='row in gridObj']"));
                foreach (var row in rows)
                {
                    var deviceNameColumns = row.FindElements(By.TagName("td"));
                    if (deviceName == deviceNameColumns[0].Text) return deviceNameColumns;
                }
                return null;
            }

            public bool IsRowValuesAsExpected
            {
                get
                {
                        Navigator.NavigateTo<DashboardPage>();
                    var timeToWait = new TimeSpan(0, 0, Timeouts.Small);
                    var sw = Stopwatch.StartNew();
                    while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
                    {
                        if (IsActualDeviceValuesAsExpected())
                            return true;
                    }
                    return false;
                }
            }

            public string ExpectedDeviceValues
            {
                get { return string.Format("DeviceName: {0}; ActiveColumn: {1}; TotalColumn: {2}", DeviceName, ActiveColumn, TotalColumn); }
            }

            public string ActualDeviceValues
            {
                get
                {
                    var deviceColumns = GetDeviceColumns(DeviceName);
                    return string.Format("DeviceName: {0}; ActiveColumn: {1}; TotalColumn: {2}", deviceColumns[0].Text, deviceColumns[1].Text, deviceColumns[2].Text);
                }
            }
        }
    }
}
