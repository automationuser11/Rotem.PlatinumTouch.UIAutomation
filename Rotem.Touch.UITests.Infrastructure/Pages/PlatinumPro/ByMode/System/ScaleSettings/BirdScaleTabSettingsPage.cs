using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleSettings
{
    public class BirdScaleTabSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Scale Settings"; }
        }
        #region Settings Fields
        public KeyPadSettingsField UpperRange
        {
            get { return _upperRange ?? (_upperRange = new KeyPadSettingsField() { Name = "Upper Range", InputMethod = new BaseNumericKeyPad() }); }
            set { _upperRange = value; }
        }
        private KeyPadSettingsField _upperRange;

        public KeyPadSettingsField LowerRange
        {
            get { return _lowerRange ?? (_lowerRange = new KeyPadSettingsField() { Name = "Lower Range", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowerRange = value; }
        }
        private KeyPadSettingsField _lowerRange;

        public KeyPadSettingsField FemaleUpperRange
        {
            get { return _femaleUpperRange ?? (_femaleUpperRange = new KeyPadSettingsField() { Name = "FEMALE_Upper Range", InputMethod = new BaseNumericKeyPad() }); }
            set { _femaleUpperRange = value; }
        }
        private KeyPadSettingsField _femaleUpperRange;

        public KeyPadSettingsField MaleLowerRange
        {
            get { return _maleLowerRange ?? (_maleLowerRange = new KeyPadSettingsField() { Name = "MALE_Lower Range", InputMethod = new BaseNumericKeyPad() }); }
            set { _maleLowerRange = value; }
        }
        private KeyPadSettingsField _maleLowerRange;

        public KeyPadSettingsField MaleUpperRange
        {
            get { return _maleUpperRange ?? (_maleUpperRange = new KeyPadSettingsField() { Name = "MALE_Upper Range", InputMethod = new BaseNumericKeyPad() }); }
            set { _maleUpperRange = value; }
        }
        private KeyPadSettingsField _maleUpperRange;

        public KeyPadSettingsField FemaleLowerRange
        {
            get { return _femaleLowerRange ?? (_femaleLowerRange = new KeyPadSettingsField() { Name = "FEMALE_Lower Range", InputMethod = new BaseNumericKeyPad() }); }
            set { _femaleLowerRange = value; }
        }
        private KeyPadSettingsField _femaleLowerRange;

        #endregion 
    }
}
