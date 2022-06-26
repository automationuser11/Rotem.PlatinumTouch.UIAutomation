using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.Co2Treatment
{
    public class Co2TreatmentSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "CO2 Treatment - Settings"; }
        }
        public ToggleButtonSettingsField Co2TreatmentBelowHeat
        {
            get { return _co2TreatmentBelowHeat  ?? (_co2TreatmentBelowHeat = new ToggleButtonSettingsField("CO2 Treatment Below Heat")); }
            set { _co2TreatmentBelowHeat  = value; }
        }
        private ToggleButtonSettingsField _co2TreatmentBelowHeat;

        public ComboboxSettingsField Co2TreatmentBy
        {
            get { return _co2TreatmentBy  ?? (_co2TreatmentBy = new ComboboxSettingsField("CO2 Treatment By")); }
            set { _co2TreatmentBy  = value; }
        }
        private ComboboxSettingsField _co2TreatmentBy;
    }
}
