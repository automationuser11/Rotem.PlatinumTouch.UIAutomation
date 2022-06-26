using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Co2Treatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.BirdInventory;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WaterAndFeedCalibration;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class PageFactoryTests
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
        public void PagesFactory_GetPage_Passed()
        {
            PagesFactory.RefreshFactory();
            var page = PagesFactory.GetPage<Co2TreatmentPage>();
            Assert.IsNotNull(page);
        }

        [TestMethod]
        [InfrastructureTest]
        public void PagesFactory_GetSimplePageTable_Passed()
        {
            var page = PagesFactory.GetPage<Co2TreatmentPage>();
            var columns = page.TableView.TableColumns;
            
            Assert.IsNotNull(columns);
        }

        [TestMethod]
        [InfrastructureTest]
        public void PagesFactory_GetTabsPage_Passed()
        {

            Navigator.NavigateTo<DashboardPage>();
            Navigator.NavigateTo<WaterAndFeedCalibrationPage>();
            var page = PagesFactory.GetPage<WaterAndFeedCalibrationPage>();
            page.FeedTabPage.Navigate();
            var tabPage = PagesFactory.GetPage<FeedTabPage>();

            tabPage.Navigate();
            var columns = tabPage.TableColumns;

            Assert.IsNotNull(columns);
        }

        [TestMethod]
        [InfrastructureTest]
        public void PagesFactory_GetCustomTablePage_Passed()
        {
            Navigator.NavigateTo<DashboardPage>();
            Navigator.NavigateTo<BirdInventoryPage>();
            var page = PagesFactory.GetPage<BirdInventoryPage>();
            var columns = page.TableView.Total.TableColumns;
            Assert.IsNotNull(columns);
        }
        
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Browser.Close();
        }
    }
}
