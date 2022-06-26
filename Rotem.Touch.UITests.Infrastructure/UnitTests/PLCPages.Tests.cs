using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class PlcPagesTests
    {
        public INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            Navigator.NavigateTo<DashboardPage>();
            var dashboardPage = PagesFactory.GetPage<DashboardPage>();

             Navigator.NavigateTo<PlcTemperatureSensorsPage>();
            var temperatureSensorsPage = PagesFactory.GetPage<PlcTemperatureSensorsPage>();
            temperatureSensorsPage.Sensor1Temp.SetValue("660");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Navigator.NavigateTo<DashboardPage>();
            var dashboardPage = PagesFactory.GetPage<DashboardPage>();

            var s = dashboardPage.Sensors.GetSensorValue("Temp. 4");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Navigator.NavigateTo<PlcTemperatureSensorsPage>();
            var tempPlc = PagesFactory.GetPage<PlcTemperatureSensorsPage>();

            tempPlc.SetValueToSpecificSensor("300", 3);
        }
    }
}
