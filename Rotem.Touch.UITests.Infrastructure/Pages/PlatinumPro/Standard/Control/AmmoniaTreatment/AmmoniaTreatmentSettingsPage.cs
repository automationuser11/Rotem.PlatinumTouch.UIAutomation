using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;


namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.AmmoniaTreatment
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
        public ToggleButtonSettingsField AmmoniaTreatmentByHeater
        {
            get { return _ammoniaTreatmentByHeater ?? (_ammoniaTreatmentByHeater = new ToggleButtonSettingsField("Ammonia Treatment By Heater")); }
            set { _ammoniaTreatmentByHeater = value; }
        }
        private ToggleButtonSettingsField _ammoniaTreatmentByHeater;
    }
}
