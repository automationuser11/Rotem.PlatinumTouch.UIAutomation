using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.NaturalVentilation
{
    public class NaturalVentilationSettingsPage : SimpleSettingsModal
    {
        #region Group Name: Natural Enterance Condition

        public string Name
        {
            get { return "Natural Ventilation - Settings"; }
        }
        public ToggleButtonSettingsField EnableNaturalInTunnel
        {
            get { return _enableNaturalInTunnel ?? (_enableNaturalInTunnel = new ToggleButtonSettingsField("Enable Natural in Tunnel:")); }
            set { _enableNaturalInTunnel = value; }
        }
        private ToggleButtonSettingsField _enableNaturalInTunnel;

        public KeyPadSettingsField WindGustDelayTime
        {
            get { return _windGustDelayTime ?? (_windGustDelayTime = new KeyPadSettingsField() { Name = "Wind Gust Delay Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _windGustDelayTime = value; }
        }
        private KeyPadSettingsField _windGustDelayTime;

        public KeyPadSettingsField DisableStirFanAboveWSpeed
        {
            get { return _disableStirFanAboveWSpeed ?? (_disableStirFanAboveWSpeed = new KeyPadSettingsField() { Name = "Disable Stir Fan above Wind Speed:", InputMethod = new PointNumericKeyPad() }); }
            set { _disableStirFanAboveWSpeed = value; }
        }
        private KeyPadSettingsField _disableStirFanAboveWSpeed;
        public KeyPadSettingsField MinTimeInAnyVentModemin
        {
            get { return _minTimeInAnyVentModemin ?? (_minTimeInAnyVentModemin = new KeyPadSettingsField() { Name = "Min Time in any Vent Mode (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _minTimeInAnyVentModemin = value; }
        }
        private KeyPadSettingsField _minTimeInAnyVentModemin;

        public ToggleButtonSettingsField UseTunnelAsNaturalCurtain
        {
            get { return _useTunnelAsNaturalCurtain ?? (_useTunnelAsNaturalCurtain = new ToggleButtonSettingsField("Use Tunnel As Natural Curtain:")); }
            set { _useTunnelAsNaturalCurtain = value; }
        }
        private ToggleButtonSettingsField _useTunnelAsNaturalCurtain;

        #endregion

        #region Group Name: Natural Mode Operation

        public KeyPadSettingsField LowWindSpeed
        {
            get { return _lowWindSpeed ?? (_lowWindSpeed = new KeyPadSettingsField() { Name = "Low Wind Speed:", InputMethod = new PointNumericKeyPad() }); }
            set { _lowWindSpeed = value; }
        }
        private KeyPadSettingsField _lowWindSpeed;
        public KeyPadSettingsField HighWindSpeed
        {
            get { return _highWindSpeed ?? (_highWindSpeed = new KeyPadSettingsField() { Name = "High Wind Speed:", InputMethod = new PointNumericKeyPad() }); }
            set { _highWindSpeed = value; }
        }
        private KeyPadSettingsField _highWindSpeed;

        public KeyPadSettingsField LowWindSpeedWithRain
        {
            get { return _lowWindSpeedWithRain ?? (_lowWindSpeedWithRain = new KeyPadSettingsField() { Name = "Low Wind Speed with Rain:", InputMethod = new PointNumericKeyPad() }); }
            set { _lowWindSpeedWithRain = value; }
        }
        private KeyPadSettingsField _lowWindSpeedWithRain;

        public KeyPadSettingsField HighWindSpeedWithRain
        {
            get { return _highWindSpeedWithRain ?? (_highWindSpeedWithRain = new KeyPadSettingsField() { Name = "High Wind Speed with Rain:", InputMethod = new PointNumericKeyPad() }); }
            set { _highWindSpeedWithRain = value; }
        }
        private KeyPadSettingsField _highWindSpeedWithRain;

        #endregion 
    }
}
