using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.GeneralSetup;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class PageInitialSetupTests
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
        public void PageInitialSetup_StoreInitialSetup_Passed()
        {
            PagesFactory.RefreshFactory();
            Navigator.NavigateTo<GeneralSetupPage>();
            var setup = new PageInitialSetup<GeneralSetupPage>();
            
            setup.StoreInitialSetup();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Browser.Close();
        }
    }
}
