using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.AnalogOutputsInstallation
{
    public class AnalogOutputsInstallationSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Analog Output - Settings"; }
        }
        public KeyPadSettingsField MaxFanSpeedOutput
        {
            get { return _maxFanSpeedOutput ?? (_maxFanSpeedOutput = new KeyPadSettingsField() { Name = "Max Fan Speed Output (Volt)", InputMethod = new PointNumericKeyPad()}); }
            set { _maxFanSpeedOutput = value; }
        }
        private KeyPadSettingsField _maxFanSpeedOutput;

        public KeyPadSettingsField FanBoostTimeSec
        {
            get { return _fanBoostTimeSec ?? (_fanBoostTimeSec = new KeyPadSettingsField() { Name = "Fan Boost Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _fanBoostTimeSec = value; }
        }
        private KeyPadSettingsField _fanBoostTimeSec;
    }
}
