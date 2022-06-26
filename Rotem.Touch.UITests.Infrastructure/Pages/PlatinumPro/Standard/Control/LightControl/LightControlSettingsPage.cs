using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.LightControl
{
    public class LightControlSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Light - Settings"; }
        }
        public KeyPadSettingsField SunriseTimeminutes
        {
            get { return _sunriseTimeminutes ?? (_sunriseTimeminutes = new KeyPadSettingsField() { Name = "Sunrise Time (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _sunriseTimeminutes = value; }
        }
        private KeyPadSettingsField _sunriseTimeminutes;

        public KeyPadSettingsField AllowSpikingFomDay
        {
            get { return _allowSpikingFomDay ?? (_allowSpikingFomDay = new KeyPadSettingsField() { Name = "Allow Spiking From Day", InputMethod = new BaseNumericKeyPad() }); }
            set { _allowSpikingFomDay = value; }
        }
        private KeyPadSettingsField _allowSpikingFomDay;

        public KeyPadSettingsField SpikeDurationminutes
        {
            get { return _spikeDurationminutes ?? (_spikeDurationminutes = new KeyPadSettingsField() { Name = "Spike Duration (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _spikeDurationminutes = value; }
        }
        private KeyPadSettingsField _spikeDurationminutes;
        public ComboboxSettingsField SignalLightIs
        {
            get { return _signalLightIs ?? (_signalLightIs = new ComboboxSettingsField("Signal Light Is:")); }
            set { _signalLightIs = value; }
        }
        private ComboboxSettingsField _signalLightIs;

        public KeyPadSettingsField SignalDuringFeedseconds
        {
            get { return _signalDuringFeedseconds ?? (_signalDuringFeedseconds = new KeyPadSettingsField() { Name = "Signal During Feed (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _signalDuringFeedseconds = value; }
        }
        private KeyPadSettingsField _signalDuringFeedseconds;

        public KeyPadSettingsField SunsetTimeminutes
        {
            get { return _sunsetTimeminutes ?? (_sunsetTimeminutes = new KeyPadSettingsField() { Name = "Sunset Time (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _sunsetTimeminutes = value; }
        }
        private KeyPadSettingsField _sunsetTimeminutes;

        public KeyPadSettingsField SpikeCycleminutes
        {
            get { return _spikeCycleminutes ?? (_spikeCycleminutes = new KeyPadSettingsField() { Name = "Spike Cycle (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _spikeCycleminutes = value; }
        }
        private KeyPadSettingsField _spikeCycleminutes;

        public KeyPadSettingsField SpikeIncreaseAmount
        {
            get { return _spikeIncreaseAmount ?? (_spikeIncreaseAmount = new KeyPadSettingsField() { Name = "Spike Increase Amount (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _spikeIncreaseAmount = value; }
        }
        private KeyPadSettingsField _spikeIncreaseAmount;

        public KeyPadSettingsField SignalBeforeFeedseconds
        {
            get { return _signalBeforeFeedseconds ?? (_signalBeforeFeedseconds = new KeyPadSettingsField() { Name = "Signal Before Feed (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _signalBeforeFeedseconds = value; }
        }
        private KeyPadSettingsField _signalBeforeFeedseconds;
        public ToggleButtonSettingsField LightSensorActive
        {
            get { return _lightSensorActive ?? (_lightSensorActive = new ToggleButtonSettingsField("Light Sensor Active")); }
            set { _lightSensorActive = value; }
        }
        private ToggleButtonSettingsField _lightSensorActive;
    }
}
