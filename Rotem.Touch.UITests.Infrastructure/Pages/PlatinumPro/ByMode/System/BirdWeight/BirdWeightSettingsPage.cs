using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.BirdWeight
{
    public class BirdWeightSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Bird Weight"; }
        }

        public KeyPadSettingsField BirdWeightOffset
        {
            get { return _birdWeightOffset ?? (_birdWeightOffset = new KeyPadSettingsField() { Name = "Bird Curve Offset", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _birdWeightOffset = value; }
        }
        private KeyPadSettingsField _birdWeightOffset;

        public KeyPadSettingsField BirdWeightOffsetFemale
        {
            get { return _birdWeightOffsetFemale ?? (_birdWeightOffsetFemale = new KeyPadSettingsField() { Name = "FEMALE_Bird Curve Offset", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _birdWeightOffsetFemale = value; }
        }
        private KeyPadSettingsField _birdWeightOffsetFemale;

        public KeyPadSettingsField BirdWeightOffsetMale
        {
            get { return _birdWeightOffsetMale ?? (_birdWeightOffsetMale = new KeyPadSettingsField() { Name = "MALE_Bird Curve Offset", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _birdWeightOffsetMale = value; }
        }
        private KeyPadSettingsField _birdWeightOffsetMale;

        public ComboboxSettingsField SelectCurveFemale
        {
            get { return _selectCurveFemale ?? (_selectCurveFemale = new ComboboxSettingsField("FEMALE_Select Curve")); }
            set { _selectCurveFemale = value; }
        }
        private ComboboxSettingsField _selectCurveFemale;

        public ComboboxSettingsField SelectCurveMale
        {
            get { return _selectCurveMale ?? (_selectCurveMale = new ComboboxSettingsField("MALE_Select Curve")); }
            set { _selectCurveMale = value; }
        }
        private ComboboxSettingsField _selectCurveMale;
    }

}
