using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.AmmoniaTreatment
{
    public class AmmoniaTreatmentSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Ammonia Treatment - Settings"; }
        }
        public ToggleButtonSettingsField AmmoniaTreatmentBelowHeat
        {
            get { return _ammoniaTreatmentBelowHeat ?? (_ammoniaTreatmentBelowHeat = new ToggleButtonSettingsField("Ammonia Treatment Below Heat")); }
            set { _ammoniaTreatmentBelowHeat = value; }
        }
        private ToggleButtonSettingsField _ammoniaTreatmentBelowHeat;

        public ComboboxSettingsField AmmoniaTreatmentBy
        {
            get { return _ammoniaTreatmentBy ?? (_ammoniaTreatmentBy = new ComboboxSettingsField("Ammonia Treatment By")); }
            set { _ammoniaTreatmentBy = value; }
        }
        private ComboboxSettingsField _ammoniaTreatmentBy;

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
