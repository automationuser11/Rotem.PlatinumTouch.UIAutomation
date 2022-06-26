using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.CoolPad;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class NavigatorTests
    {
        public INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }

        [TestMethod]
        [InfrastructureTest]
        public void Navigator_CallToNavigateToWithNavigationOption_ShouldNavigateToUrlInNewTab()
        {
            Navigator.NavigateTo<CoolPadPage>();
            Navigator.NavigateTo<PlcTemperatureSensorsPage>(NavigationOption.InNewTab);
            Navigator.SwitchTab();

            Assert.IsTrue(DriverManager.Driver.Url == PagesFactory.GetPage<CoolPadPage>().PageUrl.ToString(), "Navigate to a page in a different tab in the same browser session, not works correctly.");
        }
    }
}
