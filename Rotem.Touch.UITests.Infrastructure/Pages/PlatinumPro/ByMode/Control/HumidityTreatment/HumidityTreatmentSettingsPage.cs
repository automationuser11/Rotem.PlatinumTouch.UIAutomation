using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.HumidityTreatment
{
    public class HumidityTreatmentSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Humidity Treatment - Settings"; }
        }
        public KeyPadSettingsField HumidityBand
        {
            get { return _humidityBand ?? (_humidityBand = new KeyPadSettingsField() { Name = "Humidity Band (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidityBand = value; }
        }
        private KeyPadSettingsField _humidityBand;
        public ToggleButtonSettingsField HumidityTreatmentBelowHeat
        {
            get { return _humidityTreatmentBelowHeat ?? (_humidityTreatmentBelowHeat = new ToggleButtonSettingsField("Humidity Treatment Below Heat")); }
            set { _humidityTreatmentBelowHeat = value; }
        }
        private ToggleButtonSettingsField _humidityTreatmentBelowHeat;

        public ComboboxSettingsField HumidityTreatmentBy
        {
            get { return _humidityTreatmentBy ?? (_humidityTreatmentBy = new ComboboxSettingsField("Humidity Treatment By")); }
            set { _humidityTreatmentBy = value; }
        }
        private ComboboxSettingsField _humidityTreatmentBy;
        
        public ToggleButtonSettingsField HumidityTreatmentByHeater
        {
            get { return _humidityTreatmentByHeater ?? (_humidityTreatmentByHeater = new ToggleButtonSettingsField("Humidity Treatment By Heater")); }
            set { _humidityTreatmentByHeater = value; }
        }
        private ToggleButtonSettingsField _humidityTreatmentByHeater;

        public KeyPadSettingsField OutsideTempTreatmentByHeater
        {
            get { return _outsideTempTreatmentByHeater ?? (_outsideTempTreatmentByHeater = new KeyPadSettingsField() { Name = "Outside Temp. Treatment By Heaters", InputMethod = new BaseNumericKeyPad() }); }
            set { _outsideTempTreatmentByHeater = value; }
        }
        private KeyPadSettingsField _outsideTempTreatmentByHeater;

        public KeyPadSettingsField DiffToStopTreatmentByHeaters
        {
            get { return _diffToStopTreatmentByHeaters ?? (_diffToStopTreatmentByHeaters = new KeyPadSettingsField() { Name = "Diff To Stop Treatment By Heaters", InputMethod = new BaseNumericKeyPad() }); }
            set { _diffToStopTreatmentByHeaters = value; }
        }
        private KeyPadSettingsField _diffToStopTreatmentByHeaters;

        public KeyPadSettingsField BandBelowTarget
        {
            get { return _bandBelowTarget ?? (_bandBelowTarget = new KeyPadSettingsField() { Name = "Band (Below Target) %", InputMethod = new BaseNumericKeyPad() }); }
            set { _bandBelowTarget = value; }
        }
        private KeyPadSettingsField _bandBelowTarget;

        public KeyPadSettingsField DelayBeforeTreatment
        {
            get { return _delayBeforeTreatment ?? (_delayBeforeTreatment = new KeyPadSettingsField() { Name = "Delay Before Treatment (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _delayBeforeTreatment = value; }
        }
        private KeyPadSettingsField _delayBeforeTreatment;

        public KeyPadSettingsField CycleMinOffTime
        {
            get { return _cycleMinOffTime ?? (_cycleMinOffTime = new KeyPadSettingsField() { Name = "Cycle Min Off Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _cycleMinOffTime = value; }
        }
        private KeyPadSettingsField _cycleMinOffTime;
    }
}
