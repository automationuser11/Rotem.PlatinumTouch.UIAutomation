using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.LevelsOfVentilation
{
    public class VentAndCurtainTabPage : GridTablePage<VentAndCurtainTabPage>, ISettingsModalViewProvider<VentAndCurtainSettingsPage>, IApplicationPageTab, IMetadataDependentPageObject, IErrorMessagePage
    {
        public string Name
        {
            get
            {
                return "Vent & Curtain";
            }
        }
        public string SubMenu { get { return "System"; } }
        public ITabsPage OwnerPage
        {
            get
            {
                return PagesFactory.GetPage<LevelsOfVentilationPage>();
            }
        }
        public bool IsTabButtonExists()
        {
            return DriverManager.Driver.IsElementExists(() => TabPageService.GetTabButton(Name));
        }
        public new void Navigate()
        {
            if (TabPageService.IsTabAlreadyPressed(Name)) return;
            if (SettingsView.IsSettingsScreenOpen()) SettingsView.Close();
            TabPageService.Navigate(Name);
        }

        public Metadata Metadata { get; set; }

        public VentAndCurtainSettingsPage SettingsView
        {
            get { return _ventAndCurtainSettingsPage  ?? (_ventAndCurtainSettingsPage = new VentAndCurtainSettingsPage()); }
            set { _ventAndCurtainSettingsPage  = value; }
        }
        private VentAndCurtainSettingsPage _ventAndCurtainSettingsPage;

        public string ErrorMessage
        {
            get { return PageErrorMessageService.GetDisplayedErrorMessage(); }
        }

        public void ApproveErrorMessage()
        {
            PageErrorMessageService.ApproveErrorMessage();
        }
    }
}
