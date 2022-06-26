using System;
using System.Diagnostics;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard
{
    public partial class DashboardPage
    {
        public class VentLevelPanel
        {
            #region Mapping

            internal IWebElement VentLevel
            {
                get
                {
                    return DriverManager.Driver.FindElement(By.CssSelector("span[class='numeric-value-big ng-binding']"));
                }
            }

            #endregion
            public string VentLevelNumber { get; set; }
            public INavigator Navigator
            {
                get
                {
                    return ConfigurationManagerHelper.IsFarmMode ? new RotemWebNavigator() : (INavigator)new Navigator();
                }
            }
            private bool IsActualVentLevelAsExpected()
            {
                var ventLevel = GetVentLevel();
                if (ventLevel == null) return false;
                if (ventLevel != VentLevelNumber) return false;
                return true;
            }
            public bool IsVentLevelValueAsExpected
            {
                get
                {
                    Navigator.NavigateTo<DashboardPage>();
                    var timeToWait = new TimeSpan(0, 0, Timeouts.Small);
                    var sw = Stopwatch.StartNew();
                    while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
                    {
                        if (IsActualVentLevelAsExpected())
                            return true;
                    }
                    return false;
                }
            }
            public string GetVentLevel()
            {
                return VentLevel.Text;
            }
            public string ExpectedVentLevelValues
            {
                get { return string.Format(VentLevelNumber); }
            }
            public string ActualVentLevelValues
            {
                get
                {
                    var deviceColumns = GetVentLevel();
                    return string.Format(deviceColumns);
                }
            }
            public string Ac { get; set; }
        }
    }
}
