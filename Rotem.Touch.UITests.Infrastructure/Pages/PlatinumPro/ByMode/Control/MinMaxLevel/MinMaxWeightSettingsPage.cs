using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel
{
    public class MinMaxWeightSettingsPage : SimpleSettingsModal
    {
        public KeyPadSettingsField WarmTempDiffBelowHeat
        {
            get { return _warmTempDiffBelowHeat ?? (_warmTempDiffBelowHeat = new KeyPadSettingsField() { Name = "Warm Temperature - Difference Below Heat", InputMethod = new PointNumericKeyPad() }); }
            set { _warmTempDiffBelowHeat = value; }
        }
        private KeyPadSettingsField _warmTempDiffBelowHeat;

        public KeyPadSettingsField AirChange
        {
            get { return _airChange ?? (_airChange = new KeyPadSettingsField() { Name = "Air Change", InputMethod = new PointNumericKeyPad() }); }
            set { _airChange = value; }
        }
        private KeyPadSettingsField _airChange;

        public KeyPadSettingsField MinimumONTimeInVentCycle
        {
            get { return _minimumONTimeInVentCycle ?? (_minimumONTimeInVentCycle = new KeyPadSettingsField() { Name = "Min On Time In Vent Cycle (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _minimumONTimeInVentCycle = value; }
        }
        private KeyPadSettingsField _minimumONTimeInVentCycle;

        public KeyPadSettingsField AirChangeByHumidityCO2
        {
            get { return _airChangeByHumidityCO2 ?? (_airChangeByHumidityCO2 = new KeyPadSettingsField() { Name = "Air Change By Humidity / CO2 %", InputMethod = new BaseNumericKeyPad() }); }
            set { _airChangeByHumidityCO2 = value; }
        }
        private KeyPadSettingsField _airChangeByHumidityCO2;

        public KeyPadSettingsField ColdTemperature
        {
            get { return _coldTemperature ?? (_coldTemperature = new KeyPadSettingsField() { Name = "Cold Temp.", InputMethod = new PointNumericKeyPad() }); }
            set { _coldTemperature = value; }
        }
        private KeyPadSettingsField _coldTemperature;

        public KeyPadSettingsField FanCycleTime
        {
            get { return _fanCycleTime ?? (_fanCycleTime = new KeyPadSettingsField() { Name = "Fan Cycle Time(Sec., 0 - Manual)", InputMethod = new BaseNumericKeyPad() }); }
            set { _fanCycleTime = value; }
        }
        private KeyPadSettingsField _fanCycleTime;

        public KeyPadSettingsField MinimumOFFTimeInVentCycle
        {
            get { return _minimumOFFTimeInVentCycle ?? (_minimumOFFTimeInVentCycle = new KeyPadSettingsField() { Name = "Min Off Time In Vent Cycle (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _minimumOFFTimeInVentCycle = value; }
        }
        private KeyPadSettingsField _minimumOFFTimeInVentCycle;

        public KeyPadSettingsField AirPerWeightCurveMode
        {
            get { return _airPerWeightCurveMode ?? (_airPerWeightCurveMode = new KeyPadSettingsField() { Name = "Air Per Weight Curve Mode", InputMethod = new BaseNumericKeyPad() }); }
            set { _airPerWeightCurveMode = value; }
        }
        private KeyPadSettingsField _airPerWeightCurveMode;
    }
}
