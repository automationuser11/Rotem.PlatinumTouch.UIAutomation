using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.LevelsOfVentilation;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class TabsPageTests
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
        public void TabsPage_GetTabsNamesFromUI_Passed()
        {
            Navigator.NavigateTo<DashboardPage>();
            Navigator.NavigateTo<LevelsOfVentilationPage>();
            var Page = PagesFactory.GetPage<LevelsOfVentilationPage>();
            var names = Page.TabsNames;
            
            Assert.IsNotNull(names);
            
        }

        [TestMethod]
        [InfrastructureTest]
        public void TabsPage_GetTabs_Passed()
        {
            var Page = PagesFactory.GetPage<LevelsOfVentilationPage>();
            var tabs = Page.Tabs;
            Assert.IsNotNull(tabs);
        }

        [TestMethod]
        [InfrastructureTest]
        public void TabsPage_GetExpectedTabsCollection_Passed()
        {
            var page = PagesFactory.GetPage<LevelsOfVentilationPage>();
            var expectedTabs = page.ExpectedView.GetExpectedTabsNames();

            Assert.IsNotNull(expectedTabs);
        }
    }
}
