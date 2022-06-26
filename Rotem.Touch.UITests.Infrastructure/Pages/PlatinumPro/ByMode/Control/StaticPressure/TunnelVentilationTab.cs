using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.StaticPressure
{
    public class TunnelVentilationTab : SimpleSettingsPage, IApplicationPageTab, IErrorMessagePage
    {
        public string Name
        {
            get { return "Tunnel Ventilation"; }
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

        #region Settings Fields
        public KeyPadSettingsField TargetStaticPressure
        {
            get { return _targetStaticPressure ?? (_targetStaticPressure = new KeyPadSettingsField() { Name = "Target S.Pressure", InputMethod = new BaseNumericKeyPad() }); }
            set { _targetStaticPressure = value; }
        }
        private KeyPadSettingsField _targetStaticPressure;
        public KeyPadSettingsField LowStaticPressureAlarm
        {
            get { return _lowStaticPressureAlarm ?? (_lowStaticPressureAlarm = new KeyPadSettingsField() { Name = "Low S.Pressure Alarm", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowStaticPressureAlarm = value; }
        }
        private KeyPadSettingsField _lowStaticPressureAlarm;

        public KeyPadSettingsField HighStaticPressureAlarm
        {
            get { return _highStaticPressureAlarm ?? (_highStaticPressureAlarm = new KeyPadSettingsField() { Name = "High S.Pressure Alarm", InputMethod = new BaseNumericKeyPad() }); }
            set { _highStaticPressureAlarm = value; }
        }
        private KeyPadSettingsField _highStaticPressureAlarm;

        public KeyPadSettingsField StaticPressureBand
        {
            get { return _staticPressureBand ?? (_staticPressureBand = new KeyPadSettingsField() { Name = "S.Pressure Band", InputMethod = new BaseNumericKeyPad() }); }
            set { _staticPressureBand = value; }
        }
        private KeyPadSettingsField _staticPressureBand;
        #endregion

        public KeyPadSettingsField LowS_Pressure
        {
            get { return _lowS_Pressure ?? (_lowS_Pressure = new KeyPadSettingsField() { Name = "Low S.Pressure", InputMethod = new PointNumericKeyPad() }); }
            set { _lowS_Pressure = value; }
        }
        private KeyPadSettingsField _lowS_Pressure;

        public KeyPadSettingsField HighS_Pressure
        {
            get { return _highS_Pressure ?? (_highS_Pressure = new KeyPadSettingsField() { Name = "High S.Pressure", InputMethod = new PointNumericKeyPad() }); }
            set { _highS_Pressure = value; }
        }
        private KeyPadSettingsField _highS_Pressure;

        public KeyPadSettingsField LowS_PressureAlarm
        {
            get { return _lowS_PressureAlarm ?? (_lowS_PressureAlarm = new KeyPadSettingsField() { Name = "Low S.Pressure Alarm", InputMethod = new PointNumericKeyPad() }); }
            set { _lowS_PressureAlarm = value; }
        }
        private KeyPadSettingsField _lowS_PressureAlarm;

        public KeyPadSettingsField HighS_PressureAlarm
        {
            get { return _highS_PressureAlarm ?? (_highS_PressureAlarm = new KeyPadSettingsField() { Name = "High S.Pressure Alarm", InputMethod = new PointNumericKeyPad() }); }
            set { _highS_PressureAlarm = value; }
        }
        private KeyPadSettingsField _highS_PressureAlarm;

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
