using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.StaticPressure
{
    public class MinimumVentilationTab : SimpleSettingsPage, IApplicationPageTab, IErrorMessagePage
    {
        public string Name
        {
            get { return "Minimum Ventilation"; }
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
        public KeyPadSettingsField StaticPressureAtLowTemperature
        {
            get { return _staticPressureAtLowTemperature ?? (_staticPressureAtLowTemperature = new KeyPadSettingsField() { Name = "S.Pressure At Low Temp.", InputMethod = new PointNumericKeyPad() }); }
            set { _staticPressureAtLowTemperature = value; }                                                                       
        }
        private KeyPadSettingsField _staticPressureAtLowTemperature;
      
        public KeyPadSettingsField StaticPressureAtHighTemperature
        {
            get { return _staticPressureAtHighTemperature ?? (_staticPressureAtHighTemperature = new KeyPadSettingsField() { Name = "S.Pressure At High Temp.", InputMethod = new PointNumericKeyPad() }); }
            set { _staticPressureAtHighTemperature = value; }
        }
        private KeyPadSettingsField _staticPressureAtHighTemperature;

        public KeyPadSettingsField LowStaticPressureAlarm
        {
            get { return _lowStaticPressureAlarm ?? (_lowStaticPressureAlarm = new KeyPadSettingsField() { Name = "Low S.Pressure Alarm (0 = A.Disabled)", InputMethod = new PointNumericKeyPad() }); }
            set { _lowStaticPressureAlarm = value; }
        }
        private KeyPadSettingsField _lowStaticPressureAlarm;

        public KeyPadSettingsField HighStaticPressureAlarm
        {
            get { return _highStaticPressureAlarm ?? (_highStaticPressureAlarm = new KeyPadSettingsField() { Name = "High S.Pressure Alarm", InputMethod = new PointNumericKeyPad() }); }
            set { _highStaticPressureAlarm = value; }
        }
        private KeyPadSettingsField _highStaticPressureAlarm;

        public KeyPadSettingsField StaticPressureBand
        {
            get { return _staticPressureBand ?? (_staticPressureBand = new KeyPadSettingsField() { Name = "S.Pressure Band", InputMethod = new PointNumericKeyPad() }); }
            set { _staticPressureBand = value; }
        }
        private KeyPadSettingsField _staticPressureBand;

        public KeyPadSettingsField FirstLowStaticPressure
        {
            get { return _firstLowStaticPressure ?? (_firstLowStaticPressure = new KeyPadSettingsField() { Name = "First Low S.Pressure", InputMethod = new PointNumericKeyPad() }); }
            set { _firstLowStaticPressure = value; }
        }
        private KeyPadSettingsField _firstLowStaticPressure;

        public KeyPadSettingsField FirstHighStaticPressure
        {
            get { return _firstHighStaticPressure ?? (_firstHighStaticPressure = new KeyPadSettingsField() { Name = "First High S.Pressure", InputMethod = new PointNumericKeyPad() }); }
            set { _firstHighStaticPressure = value; }
        }
        private KeyPadSettingsField _firstHighStaticPressure;

        public KeyPadSettingsField SecondLowStaticPressure
        {
            get { return _secondLowStaticPressure ?? (_secondLowStaticPressure = new KeyPadSettingsField() { Name = "Second Low S.Pressure", InputMethod = new PointNumericKeyPad() }); }
            set { _secondLowStaticPressure = value; }
        }
        private KeyPadSettingsField _secondLowStaticPressure;

        public KeyPadSettingsField SecondHighStaticPressure
        {
            get { return _secondHighStaticPressure ?? (_secondHighStaticPressure = new KeyPadSettingsField() { Name = "Second High S.Pressure", InputMethod = new PointNumericKeyPad() }); }
            set { _secondHighStaticPressure = value; }
        }
        private KeyPadSettingsField _secondHighStaticPressure;

        public KeyPadSettingsField LowS_PressureAlarm
        {
            get { return _lowS_PressureAlarm ?? (_lowS_PressureAlarm = new KeyPadSettingsField() { Name = "Low S.Pressure Alarm", InputMethod = new PointNumericKeyPad() }); }
            set { _lowS_PressureAlarm = value; }
        }
        private KeyPadSettingsField _lowS_PressureAlarm;

        public KeyPadSettingsField HighS_PressureAlarm 
        {
            get { return _highS_PressureAlarm ?? (_highS_PressureAlarm = new KeyPadSettingsField() { Name = "High  S.Pressure Alarm", InputMethod = new PointNumericKeyPad() }); }
            set { _highS_PressureAlarm = value; }
        }
        private KeyPadSettingsField _highS_PressureAlarm;

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
