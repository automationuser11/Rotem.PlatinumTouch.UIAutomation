using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.AnalogOutputsInstallation;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.RelayLayout;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class TablePagesTest
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
        public void AccordionTable_TablsCanExpandAndCollapsRegions_Passed()
        {
            Navigator.NavigateTo<RelayLayoutPage>();
            var relayLayout = PagesFactory.GetPage<RelayLayoutPage>();

            relayLayout.TableView.ExpandAll();
            relayLayout.TableView.CollapsedRegionByName("Card 4 ,Main, Slot 4");
            relayLayout.TableView.CollapseAll();
            relayLayout.TableView.ExpandRegionByName("Card 4 ,Main, Slot 4");
        }

        [TestMethod]
        [InfrastructureTest]
        public void AccordionTable_EditRandomCellContent_Passed()
        {
            Navigator.NavigateTo<DashboardPage>();
            Navigator.NavigateTo<AnalogOutputsInstallationPage>();
            var relayLayout = PagesFactory.GetPage<AnalogOutputsInstallationPage>();

            relayLayout.TableView.EditRandomCellContent("23", "Card 1 ,Main, Slot 3", @"Min V.Out");
        }
    }
}
