using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel
{
    public class MinMaxSoftSettingsPage : SimpleSettingsModal
    {
        public KeyPadSettingsField DiffBelowHeatForSoftMin
        {
            get { return _diffBelowHeatForSoftMin ?? (_diffBelowHeatForSoftMin = new KeyPadSettingsField() { Name = "Difference Below Heat For Soft Minimum", InputMethod = new PointNumericKeyPad() }); }
            set { _diffBelowHeatForSoftMin = value; }
        }
        private KeyPadSettingsField _diffBelowHeatForSoftMin;
        public ComboboxSettingsField TempChoiceForSoftMin
        {
            get { return _tempChoiceForSoftMin ?? (_tempChoiceForSoftMin = new ComboboxSettingsField("Temp Choice For Soft Minimum")); }
            set { _tempChoiceForSoftMin = value; }
        }
        private ComboboxSettingsField _tempChoiceForSoftMin;
    }
}
