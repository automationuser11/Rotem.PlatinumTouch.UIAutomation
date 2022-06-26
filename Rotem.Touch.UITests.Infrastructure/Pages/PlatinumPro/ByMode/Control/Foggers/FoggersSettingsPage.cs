using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Foggers
{
    public class FoggersSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Foggers - Settings"; }
        }
        public KeyPadSettingsField TemperatureBand
        {
            get { return _temperatureBand ?? (_temperatureBand = new KeyPadSettingsField() { Name = "Temperature Band", InputMethod = new PointNumericKeyPad() }); }
            set { _temperatureBand = value; }
        }
        private KeyPadSettingsField _temperatureBand;

        public KeyPadSettingsField MinLevelToEnableOperation
        {
            get { return _minLevelToEnableOperation ?? (_minLevelToEnableOperation = new KeyPadSettingsField() { Name = "Min Level To Enable Operation", InputMethod = new BaseNumericKeyPad() }); }
            set { _minLevelToEnableOperation = value; }
        }
        private KeyPadSettingsField _minLevelToEnableOperation;

        public KeyPadSettingsField HumidityBand
        {
            get { return _humidityBand ?? (_humidityBand = new KeyPadSettingsField() { Name = "Humidity Band (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidityBand = value; }
        }
        private KeyPadSettingsField _humidityBand;

        public KeyPadSettingsField MaxLevelToEnableOperation
        {
            get { return _maxLevelToEnableOperation ?? (_maxLevelToEnableOperation = new KeyPadSettingsField() { Name = "Max Level To Enable Operation", InputMethod = new BaseNumericKeyPad() }); }
            set { _maxLevelToEnableOperation = value; }
        }
        private KeyPadSettingsField _maxLevelToEnableOperation;

        public ToggleButtonSettingsField EnableRotation
        {
            get { return _enableRotation ?? (_enableRotation = new ToggleButtonSettingsField("Enable Rotation")); }
            set { _enableRotation = value; }
        }
        private ToggleButtonSettingsField _enableRotation;

        public KeyPadSettingsField DiffBetweenFoggersStage
        {
            get { return _diffBetweenFoggersStage ?? (_diffBetweenFoggersStage = new KeyPadSettingsField() { Name = "Diff. Between Foggers Stage", InputMethod = new PointNumericKeyPad() }); }
            set { _diffBetweenFoggersStage = value; }
        }
        private KeyPadSettingsField _diffBetweenFoggersStage;
    }
}
