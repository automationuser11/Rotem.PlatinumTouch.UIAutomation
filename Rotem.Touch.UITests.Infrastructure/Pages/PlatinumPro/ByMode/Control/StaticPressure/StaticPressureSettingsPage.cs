using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.StaticPressure
{
    public class StaticPressureSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Static Pressure - Settings"; }
        }
        public KeyPadSettingsField WindGustDelayTimesec
        {
            get { return _windGustDelayTimesec ?? (_windGustDelayTimesec = new KeyPadSettingsField() { Name = "Wind Gust Delay Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _windGustDelayTimesec = value; }
        }
        private KeyPadSettingsField _windGustDelayTimesec;

        public ToggleButtonSettingsField TrunsitionalTunnel
        {
            get { return _trunsitionalTunnel ?? (_trunsitionalTunnel = new ToggleButtonSettingsField("Transitional Tunnel")); }
            set { _trunsitionalTunnel = value; }
        }
        private ToggleButtonSettingsField _trunsitionalTunnel;

        public ComboboxSettingsField MinVentUsing
        {
            get { return _minVentUsing ?? (_minVentUsing = new ComboboxSettingsField("Minimum Ventilation Using")); }
            set { _minVentUsing = value; }
        }
        private ComboboxSettingsField _minVentUsing;

        public KeyPadSettingsField LowIncomingTempDifftoTrg
        {
            get { return _lowIncomingTempDifftoTrg ?? (_lowIncomingTempDifftoTrg = new KeyPadSettingsField() { Name = "Low Incoming Temp(Diff. To Target)", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _lowIncomingTempDifftoTrg = value; }
        }
        private KeyPadSettingsField _lowIncomingTempDifftoTrg;

        public KeyPadSettingsField EmergencySPressDelaysec
        {
            get { return _emergencySPressDelaysec ?? (_emergencySPressDelaysec = new KeyPadSettingsField() { Name = "Emergency S.Pressure Delay (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _emergencySPressDelaysec = value; }
        }
        private KeyPadSettingsField _emergencySPressDelaysec;

        public KeyPadSettingsField LowSPAlarmMinLevelMinV
        {
            get { return _lowSPAlarmMinLevelMinV ?? (_lowSPAlarmMinLevelMinV = new KeyPadSettingsField() { Name = "Low St.Pressure Alarm Minimum Level (MinVent)", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowSPAlarmMinLevelMinV = value; }
        }
        private KeyPadSettingsField _lowSPAlarmMinLevelMinV;

        public KeyPadSettingsField TimeToProduceSPressuresec
        {
            get { return _timeToProduceSPressuresec ?? (_timeToProduceSPressuresec = new KeyPadSettingsField() { Name = "Time To Produce S.Pressure (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _timeToProduceSPressuresec = value; }
        }
        private KeyPadSettingsField _timeToProduceSPressuresec;
        public ToggleButtonSettingsField SPressureDuringTunnel
        {
            get { return _sPressureDuringTunnel ?? (_sPressureDuringTunnel = new ToggleButtonSettingsField("S.Pressure During Tunnel")); }
            set { _sPressureDuringTunnel = value; }
        }
        private ToggleButtonSettingsField _sPressureDuringTunnel;

        public ComboboxSettingsField MinimumVentilationUsing
        {
            get { return _minimumVentilationUsing ?? (_minimumVentilationUsing = new ComboboxSettingsField("Min Vent Using")); }
            set { _minimumVentilationUsing = value; }
        }
        private ComboboxSettingsField _minimumVentilationUsing;

        public KeyPadSettingsField MinTunnelCurtainToStartFan
        {
            get { return _minTunnelCurtainToStartFan ?? (_minTunnelCurtainToStartFan = new KeyPadSettingsField() { Name = "Min Tunnel Curtain (%) To Start Fan", InputMethod = new BaseNumericKeyPad() }); }
            set { _minTunnelCurtainToStartFan = value; }
        }
        private KeyPadSettingsField _minTunnelCurtainToStartFan;

        public KeyPadSettingsField MinTunnelCurtainPosition
        {
            get { return _minTunnelCurtainPosition ?? (_minTunnelCurtainPosition = new KeyPadSettingsField() { Name = "Min Tunnel Curtain Position (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _minTunnelCurtainPosition = value; }
        }
        private KeyPadSettingsField _minTunnelCurtainPosition;


        public ComboboxSettingsField SecondSPAtThisFanTempOn
        {
            get { return _secondSPAtThisFanTempOn ?? (_secondSPAtThisFanTempOn = new ComboboxSettingsField("2nd S.P At This Fan Temp. On")); }
            set { _secondSPAtThisFanTempOn = value; }
        }
        private ComboboxSettingsField _secondSPAtThisFanTempOn;

        public KeyPadSettingsField HighIncomingTempDifftoTrg
        {
            get { return _highIncomingTempDifftoTrg ?? (_highIncomingTempDifftoTrg = new KeyPadSettingsField() { Name = "High Incoming Temp(Diff. To Target)", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _highIncomingTempDifftoTrg = value; }
        }
        private KeyPadSettingsField _highIncomingTempDifftoTrg;

        public KeyPadSettingsField CurtPosInEmergSPDis0
        {
            get { return _curtPosInEmergSPDis0 ?? (_curtPosInEmergSPDis0 = new KeyPadSettingsField() { Name = "Curtain Position In Emergency S.Pressure (%) (0-Disabled)", InputMethod = new BaseNumericKeyPad() }); }
            set { _curtPosInEmergSPDis0 = value; }
        }
        private KeyPadSettingsField _curtPosInEmergSPDis0;

        public KeyPadSettingsField LowSPAlarmMinLevelTun
        {
            get { return _lowSPAlarmMinLevelTun ?? (_lowSPAlarmMinLevelTun = new KeyPadSettingsField() { Name = "Low S.Pressure Alarm Min Level (Tunnel)", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowSPAlarmMinLevelTun = value; }
        }
        private KeyPadSettingsField _lowSPAlarmMinLevelTun;

        public KeyPadSettingsField AtticAdvanceOpeningTimesec
        {
            get { return _atticAdvanceOpeningTimesec ?? (_atticAdvanceOpeningTimesec = new KeyPadSettingsField() { Name = "Attic Advance Opening Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _atticAdvanceOpeningTimesec = value; }
        }
        private KeyPadSettingsField _atticAdvanceOpeningTimesec;

        public KeyPadSettingsField EmergencySPressureDelaySec
        {
            get {return _emergencySPressureDelaySec ?? (_emergencySPressureDelaySec = new KeyPadSettingsField() {Name = "Emergency S.Pressure Delay (Sec.)", InputMethod = new BaseNumericKeyPad() });  }
            set { _emergencySPressureDelaySec = value; }
        }
        private KeyPadSettingsField _emergencySPressureDelaySec;

        public KeyPadSettingsField LowSPAlarmMinLevelMinVent
        {
            get { return _lowSPAlarmMinLevelMinVent ?? (_lowSPAlarmMinLevelMinVent = new KeyPadSettingsField() { Name = "Low S.Pressure Alarm Min Level (MinVent)", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowSPAlarmMinLevelMinVent = value; }
        }
        private KeyPadSettingsField _lowSPAlarmMinLevelMinVent;


    }
}
