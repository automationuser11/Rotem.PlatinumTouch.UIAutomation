using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.TemperatureCurve
{
    public class TemperatureCurveSettingsPage : SimpleSettingsModal
    {
        #region Group Name: Temperature Curve - Settings

        public string Name
        {
            get { return "Temperature Curve - Settings"; }
        }
        public KeyPadSettingsField TemperatureCurveOffset
        {
            get { return _temperatureCurveOffset ?? (_temperatureCurveOffset = new KeyPadSettingsField() { Name = "Temperature Curve Offset", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _temperatureCurveOffset = value; }
        }
        private KeyPadSettingsField _temperatureCurveOffset;

        public KeyPadSettingsField TargetTemperatureBand
        {
            get { return _targetTemperatureBand ?? (_targetTemperatureBand = new KeyPadSettingsField() { Name = "Target Temperature Band", InputMethod = new PointNumericKeyPad() }); }
            set { _targetTemperatureBand = value; }
        }
        private KeyPadSettingsField _targetTemperatureBand;

        public KeyPadSettingsField CoolDownFactor
        {
            get { return _coolDownFactor ?? (_coolDownFactor = new KeyPadSettingsField() { Name = "Cool Down Factor (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _coolDownFactor = value; }
        }
        private KeyPadSettingsField _coolDownFactor;

        public ButtonsGroupSettingsField MinimumVentilationBelowHeatTemperatureBy
        {
            get { return _minimumVentilationBelowHeatTemperatureBy ?? (_minimumVentilationBelowHeatTemperatureBy = new ButtonsGroupSettingsField("Min Vent Below Heat Temperature By:")); }
            set { _minimumVentilationBelowHeatTemperatureBy = value; }
        }
        private ButtonsGroupSettingsField _minimumVentilationBelowHeatTemperatureBy;

        public KeyPadSettingsField SetTemperatureChangeReminderDiff
        {
            get { return _setTemperatureChangeReminderDiff ?? (_setTemperatureChangeReminderDiff = new KeyPadSettingsField() { Name = "Set Temperature Change Reminder (Diff.)", InputMethod = new PointNumericKeyPad() }); }
            set { _setTemperatureChangeReminderDiff = value; }
        }
        private KeyPadSettingsField _setTemperatureChangeReminderDiff;

        public KeyPadSettingsField HeaterTemperatureBand
        {
            get { return _heaterTemperatureBand ?? (_heaterTemperatureBand = new KeyPadSettingsField() { Name = "Heater Temperature Band", InputMethod = new PointNumericKeyPad() }); }
            set { _heaterTemperatureBand = value; }
        }
        private KeyPadSettingsField _heaterTemperatureBand;

        public KeyPadSettingsField CoolDownFastResponseDeg
        {
            get { return _coolDownFastResponseDeg ?? (_coolDownFastResponseDeg = new KeyPadSettingsField() { Name = "Cool Down Fast Response (Deg.)", InputMethod = new PointNumericKeyPad() }); }
            set { _coolDownFastResponseDeg = value; }
        }
        private KeyPadSettingsField _coolDownFastResponseDeg;

        public KeyPadSettingsField NonBroodAreaDiffFromHeat
        {
            get { return _nonBroodAreaDiffFromHeat ?? (_nonBroodAreaDiffFromHeat = new KeyPadSettingsField() { Name = "Non Brood Area Diff. From Heat", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _nonBroodAreaDiffFromHeat = value; }
        }
        private KeyPadSettingsField _nonBroodAreaDiffFromHeat;

        #endregion

        #region Group Name: Cycle Heaters

        public KeyPadSettingsField LowHeatDifferential
        {
            get { return _lowHeatDifferential ?? (_lowHeatDifferential = new KeyPadSettingsField() { Name = "Low Heat Differential", InputMethod = new PointNumericKeyPad() }); }
            set { _lowHeatDifferential = value; }
        }
        private KeyPadSettingsField _lowHeatDifferential;

        public KeyPadSettingsField HightHeatDifferential
        {
            get { return _hightHeatDifferential ?? (_hightHeatDifferential = new KeyPadSettingsField() { Name = "High Heat Differential", InputMethod = new PointNumericKeyPad() }); }
            set { _hightHeatDifferential = value; }
        }
        private KeyPadSettingsField _hightHeatDifferential;

        public KeyPadSettingsField MinimumOnTime
        {
            get { return _minimumOnTime ?? (_minimumOnTime = new KeyPadSettingsField() { Name = "Min On Time", InputMethod = new BaseNumericKeyPad() }); }
            set { _minimumOnTime = value; }
        }
        private KeyPadSettingsField _minimumOnTime;

        #endregion

        #region Group Name: Radiant Heaters

        public KeyPadSettingsField RadiantLowDiffFromHeatSet
        {
            get { return _radiantLowDiffFromHeatSet ?? (_radiantLowDiffFromHeatSet = new KeyPadSettingsField() { Name = "Radiant Low - Diff. From Heat Set", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _radiantLowDiffFromHeatSet = value; }
        }
        private KeyPadSettingsField _radiantLowDiffFromHeatSet;

        public KeyPadSettingsField RadiantIgnitionTimesec
        {
            get { return _radiantIgnitionTimesec ?? (_radiantIgnitionTimesec = new KeyPadSettingsField() { Name = "Radiant Ignition Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _radiantIgnitionTimesec = value; }
        }
        private KeyPadSettingsField _radiantIgnitionTimesec;

        public KeyPadSettingsField RadiantHighDiffBelowLowSet
        {
            get { return _radiantHighDiffBelowLowSet ?? (_radiantHighDiffBelowLowSet = new KeyPadSettingsField() { Name = "Radiant High - Diff. (Below Low Set)", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _radiantHighDiffBelowLowSet = value; }
        }
        private KeyPadSettingsField _radiantHighDiffBelowLowSet;

        #endregion

        #region Group Name: Variable Heaters

        public KeyPadSettingsField LowDiffBelowHeat
        {
            get { return _lowDiffBelowHeat ?? (_lowDiffBelowHeat = new KeyPadSettingsField() { Name = "Variable Heaters_Low Diff. Below Heat Temp.", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _lowDiffBelowHeat = value; }
        }
        private KeyPadSettingsField _lowDiffBelowHeat;
        public ComboboxSettingsField Mode
        {
            get { return _mode ?? (_mode = new ComboboxSettingsField("Mode:")); }
            set { _mode = value; }
        }
        private ComboboxSettingsField _mode;

        public KeyPadSettingsField HighDiffBelowHeat
        {
            get { return _highDiffBelowHeat ?? (_highDiffBelowHeat = new KeyPadSettingsField() { Name = "Variable Heaters_High Diff. Below Heat Temp.", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _highDiffBelowHeat = value; }
        }
        private KeyPadSettingsField _highDiffBelowHeat;

        public KeyPadSettingsField ResponseTime
        {
            get { return _responseTimesec ?? (_responseTimesec = new KeyPadSettingsField() { Name = "Response Time", InputMethod = new BaseNumericKeyPad() }); }
            set { _responseTimesec = value; }
        }
        private KeyPadSettingsField _responseTimesec;

        public KeyPadSettingsField VarFloorHighDiffBelowHeat
        {
            get { return _varFloorHighDiffBelowHeat ?? (_varFloorHighDiffBelowHeat = new KeyPadSettingsField() { Name = "Variable Floor Heaters_High Diff. Below Heat Temp.", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _varFloorHighDiffBelowHeat = value; }
        }
        private KeyPadSettingsField _varFloorHighDiffBelowHeat;

        public KeyPadSettingsField VarFloorLowDiffBelowHeat
        {
            get { return _varFloorLowDiffBelowHeat ?? (_varFloorLowDiffBelowHeat = new KeyPadSettingsField() { Name = "Variable Floor Heaters_Low Diff. Below Heat Temp.", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _varFloorLowDiffBelowHeat = value; }
        }
        private KeyPadSettingsField _varFloorLowDiffBelowHeat;
        #endregion 
    }
}
