using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.StaticPressure
{
    public class AtticVentilationTab : SimpleSettingsPage, IApplicationPageTab, IErrorMessagePage
    {
        public string Name
        {
            get { return "Attic Ventilation"; }
        }
        public string SubMenu { get { return "Control"; } }
        public ITabsPage OwnerPage
        {
            get
            {
                return PagesFactory.GetPage<StaticPressurePage>();
            }
        }
        public bool IsTabButtonExists()
        {
            return DriverManager.Driver.IsElementExists(() => TabPageService.GetTabButton(Name));
        }
        public void Navigate()
        {
            TabPageService.Navigate(Name);
        }

        #region Settigns Fields
        public KeyPadSettingsField TargetStaticPressure
        {
            get { return _targetStaticPressure ?? (_targetStaticPressure = new KeyPadSettingsField() { Name = "Target S.Pressure", InputMethod = new PointNumericKeyPad() }); }
            set { _targetStaticPressure = value; }
        }
        private KeyPadSettingsField _targetStaticPressure;
        public KeyPadSettingsField StaticPressureBand
        {
            get { return _staticPressureBand ?? (_staticPressureBand = new KeyPadSettingsField() { Name = "S.Pressure Band", InputMethod = new PointNumericKeyPad() }); }
            set { _staticPressureBand = value; }
        }
        private KeyPadSettingsField _staticPressureBand;

        public KeyPadSettingsField LowStaticPressureSetting
        {
            get { return _lowStaticPressureSetting ?? (_lowStaticPressureSetting = new KeyPadSettingsField() { Name = "Low S.Pressure Setting", InputMethod = new PointNumericKeyPad() }); }
            set { _lowStaticPressureSetting = value; }
        }
        private KeyPadSettingsField _lowStaticPressureSetting;

        public KeyPadSettingsField HighStaticPressureSetting
        {
            get { return _highStaticPressureSetting ?? (_highStaticPressureSetting = new KeyPadSettingsField() { Name = "High S.Pressure Setting", InputMethod = new PointNumericKeyPad() }); }
            set { _highStaticPressureSetting = value; }
        }
        private KeyPadSettingsField _highStaticPressureSetting;
        #endregion
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
