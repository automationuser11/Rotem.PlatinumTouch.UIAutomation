using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.LevelsOfVentilation
{
    public class ExhaustAndTunnelFansSettingsPage : SimpleSettingsModal
    {
        #region Group Name: Ventilation Levels
        public string Name
        {
            get
            {
                return "Exhaust & Tunnel Fans Levels - Settings";
            }
        }
        public string SubMenu { get { return "System"; } }
        public KeyPadSettingsField MaximumLevelsOfVentilation
        {
            get { return _maximumLevelsOfVentilation ?? (_maximumLevelsOfVentilation = new KeyPadSettingsField() { Name = "Maximum Levels Of Ventilation", InputMethod = new BaseNumericKeyPad() }); }
            set { _maximumLevelsOfVentilation = value; }
        }
        private KeyPadSettingsField _maximumLevelsOfVentilation;

        public KeyPadSettingsField MaxFansSwitchToTunnel
        {
            get { return _maxFansSwitchToTunnel ?? (_maxFansSwitchToTunnel = new KeyPadSettingsField() { Name = @"""Maximum Fans, Switch To Tunnel""", InputMethod = new BaseNumericKeyPad() }); }
            set { _maxFansSwitchToTunnel = value; }
        }
        private KeyPadSettingsField _maxFansSwitchToTunnel;

        public KeyPadSettingsField TunExitOuttDiffFromTunnel
        {
            get { return _tunExitOuttDiffFromTunnel ?? (_tunExitOuttDiffFromTunnel = new KeyPadSettingsField() { Name = "Tunnel Exit - Out Temperature Diff. Above Tunnel", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _tunExitOuttDiffFromTunnel = value; }
        }
        private KeyPadSettingsField _tunExitOuttDiffFromTunnel;

        public KeyPadSettingsField DecreaseLevelDelayTimesec
        {
            get { return _decreaseLevelDelayTimesec ?? (_decreaseLevelDelayTimesec = new KeyPadSettingsField() { Name = "Decrease Level Delay Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _decreaseLevelDelayTimesec = value; }
        }
        private KeyPadSettingsField _decreaseLevelDelayTimesec;

        public KeyPadSettingsField TunnelExitDelayminutes
        {
            get { return _tunnelExitDelayminutes ?? (_tunnelExitDelayminutes = new KeyPadSettingsField() { Name = "Tunnel Exit Delay (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _tunnelExitDelayminutes = value; }
        }
        private KeyPadSettingsField _tunnelExitDelayminutes;

        public KeyPadSettingsField FirstTunnelLevel
        {
            get { return _firstTunnelLevel ?? (_firstTunnelLevel = new KeyPadSettingsField() { Name = "First Tunnel Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _firstTunnelLevel = value; }
        }
        private KeyPadSettingsField _firstTunnelLevel;

        public KeyPadSettingsField TunnelExitDiffBelowTunnel
        {
            get { return _tunnelExitDiffBelowTunnel ?? (_tunnelExitDiffBelowTunnel = new KeyPadSettingsField() { Name = "Tunnel Exit - Diff. Below Tunnel", InputMethod = new PointNumericKeyPad() }); }
            set { _tunnelExitDiffBelowTunnel = value; }
        }
        private KeyPadSettingsField _tunnelExitDiffBelowTunnel;

        public KeyPadSettingsField IncreaseLevelDelayTimesec
        {
            get { return _increaseLevelDelayTimesec ?? (_increaseLevelDelayTimesec = new KeyPadSettingsField() { Name = "Increase Level Delay Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _increaseLevelDelayTimesec = value; }
        }
        private KeyPadSettingsField _increaseLevelDelayTimesec;

        public KeyPadSettingsField FanCycleTimesec0Manual
        {
            get { return _fanCycleTimesec0Manual ?? (_fanCycleTimesec0Manual = new KeyPadSettingsField() { Name = @"""Fan Cycle Time (Sec., 0-Manual)""", InputMethod = new BaseNumericKeyPad() }); }
            set { _fanCycleTimesec0Manual = value; }
                                                                                                                   
        }
        private KeyPadSettingsField _fanCycleTimesec0Manual;

        public ToggleButtonSettingsField EnableWindChill
        {
            get { return _enableWindChill ?? (_enableWindChill = new ToggleButtonSettingsField("Enable Wind Chill")); }
            set { _enableWindChill = value; }
        }
        private ToggleButtonSettingsField _enableWindChill;

        public KeyPadSettingsField WindChillLimit
        {
            get { return _windChillLimit ?? (_windChillLimit = new KeyPadSettingsField() { Name = "Wind Chill Limit", InputMethod = new PointNumericKeyPad() }); }
            set { _windChillLimit = value; }
        }
        private KeyPadSettingsField _windChillLimit;

        public KeyPadSettingsField RHEffect
        {
            get { return _rHEffect ?? (_rHEffect = new KeyPadSettingsField() { Name = "RH Effect", InputMethod = new PointNumericKeyPad() }); }
            set { _rHEffect = value; }
        }
        private KeyPadSettingsField _rHEffect;

        #endregion 
    }
}
