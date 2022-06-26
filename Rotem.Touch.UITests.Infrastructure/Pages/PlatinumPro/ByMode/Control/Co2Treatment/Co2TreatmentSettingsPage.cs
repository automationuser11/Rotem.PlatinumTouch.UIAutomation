using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Co2Treatment
{
    public class Co2TreatmentSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "CO2 Treatment - Settings"; }
        }
        public ToggleButtonSettingsField Co2TreatmentBelowHeat
        {
            get { return _co2TreatmentBelowHeat ?? (_co2TreatmentBelowHeat = new ToggleButtonSettingsField("CO2 Treatment Below Heat")); }
            set { _co2TreatmentBelowHeat = value; }
        }
        private ToggleButtonSettingsField _co2TreatmentBelowHeat;

        public ComboboxSettingsField Co2TreatmentBy
        {
            get { return _co2TreatmentBy ?? (_co2TreatmentBy = new ComboboxSettingsField("CO2 Treatment By")); }
            set { _co2TreatmentBy = value; }
        }
        private ComboboxSettingsField _co2TreatmentBy;

        public ToggleButtonSettingsField Co2TreatmentByHeaters
        {
            get { return _co2TreatmentByHeaters ?? (_co2TreatmentByHeaters = new ToggleButtonSettingsField("CO2 Treatment By Heaters")); }
            set { _co2TreatmentByHeaters = value; }
        }
        private ToggleButtonSettingsField _co2TreatmentByHeaters;

        public KeyPadSettingsField OutsideTempTreatmentByHeaters
        {
            get { return _outsideTempTreatmentByHeaters ?? (_outsideTempTreatmentByHeaters = new KeyPadSettingsField() { Name = "Outside Temp. Treatment By Heaters", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _outsideTempTreatmentByHeaters = value; }
        }
        private KeyPadSettingsField _outsideTempTreatmentByHeaters;

        public KeyPadSettingsField DiffToStopTreatmentByHeaters
        {
            get { return _diffToStopTreatmentByHeaters ?? (_diffToStopTreatmentByHeaters = new KeyPadSettingsField() { Name = "Diff To Stop Treatment By Heaters", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _diffToStopTreatmentByHeaters = value; }
        }
        private KeyPadSettingsField _diffToStopTreatmentByHeaters;

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
