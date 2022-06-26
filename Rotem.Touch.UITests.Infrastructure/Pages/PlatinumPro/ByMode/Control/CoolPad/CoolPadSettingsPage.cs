using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.CoolPad
{
    public class CoolPadSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Cool Pad - Settings"; }
        }
        public KeyPadSettingsField TemperatureBand
        {
            get { return _temperatureBand ?? (_temperatureBand = new KeyPadSettingsField() { Name = "Temperature Band", InputMethod = new PointNumericKeyPad() }); }
            set { _temperatureBand = value; }
        }
        private KeyPadSettingsField _temperatureBand;

        public KeyPadSettingsField HumidityBand
        {
            get { return _humidityBand ?? (_humidityBand = new KeyPadSettingsField() { Name = "Humidity Band (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidityBand = value; }
        }
        private KeyPadSettingsField _humidityBand;

        public KeyPadSettingsField DiffBetweenCoolPadStage
        {
            get { return _diffBetweenCoolPadStage ?? (_diffBetweenCoolPadStage = new KeyPadSettingsField() { Name = "Diff. Between Cool Pads Stage", InputMethod = new PointNumericKeyPad() }); }
            set { _diffBetweenCoolPadStage = value; }
        }
        private KeyPadSettingsField _diffBetweenCoolPadStage;

        public KeyPadSettingsField MinLevelToEnableOperation1
        {
            get { return _minLevelToEnableOperation1 ?? (_minLevelToEnableOperation1 = new KeyPadSettingsField() { Name = "Cool Pad-1 Min Level To Operate", InputMethod = new BaseNumericKeyPad() }); }
            set { _minLevelToEnableOperation1 = value; }
        }
        private KeyPadSettingsField _minLevelToEnableOperation1;

        public KeyPadSettingsField MinLevelToEnableOperation2
        {
            get { return _minLevelToEnableOperation2 ?? (_minLevelToEnableOperation2 = new KeyPadSettingsField() { Name = "Cool Pad-2 Min Level To Operate", InputMethod = new BaseNumericKeyPad() }); }
            set { _minLevelToEnableOperation2 = value; }
        }
        private KeyPadSettingsField _minLevelToEnableOperation2;

        public KeyPadSettingsField MinLevelToEnableOperation3
        {
            get { return _minLevelToEnableOperation3 ?? (_minLevelToEnableOperation3 = new KeyPadSettingsField() { Name = "Cool Pad-3 Min Level To Operate", InputMethod = new BaseNumericKeyPad() }); }
            set { _minLevelToEnableOperation3 = value; }
        }
        private KeyPadSettingsField _minLevelToEnableOperation3;

        public KeyPadSettingsField MinLevelToEnableOperation4
        {
            get { return _minLevelToEnableOperation4 ?? (_minLevelToEnableOperation4 = new KeyPadSettingsField() { Name = "Cool Pad-4 Min Level To Operate", InputMethod = new BaseNumericKeyPad() }); }
            set { _minLevelToEnableOperation4 = value; }
        }
        private KeyPadSettingsField _minLevelToEnableOperation4;

        public KeyPadSettingsField FlushCoolPadAt
        {
            get { return _flushCoolPadAt ?? (_flushCoolPadAt = new KeyPadSettingsField() { Name = "Flush Cool Pad At", InputMethod = new TimeKeyPad() }); }
            set { _flushCoolPadAt = value; }
        }
        private KeyPadSettingsField _flushCoolPadAt;

        public KeyPadSettingsField CoolPadFlushDurationmin
        {
            get { return _coolPadFlushDurationmin ?? (_coolPadFlushDurationmin = new KeyPadSettingsField() { Name = "Cool Pad Flush Duration (Minutes)", InputMethod = new BaseNumericKeyPad() }); }
            set { _coolPadFlushDurationmin = value; }
        }
        private KeyPadSettingsField _coolPadFlushDurationmin;

    }
}
