using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TemperatureAndTimer
{
    public class TemperatureAndTimerSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Temperature & Timer - Settings"; }
        }
        #region Group Name: Temp & Timer Settings
        public KeyPadSettingsField MinTunnelFansOn
        {
            get { return _minTunnelFansOn ?? (_minTunnelFansOn = new KeyPadSettingsField { Name = "Min Tunnel Fans On", InputMethod = new BaseNumericKeyPad() }); }
            set { _minTunnelFansOn = value; }
        }
        private KeyPadSettingsField _minTunnelFansOn;

        public ToggleButtonSettingsField OperateDuringCycle
        {
            get { return _operateDuringCycle ?? (_operateDuringCycle = new ToggleButtonSettingsField("Operate During Cycle")); }
            set { _operateDuringCycle = value; }
        }
        private ToggleButtonSettingsField _operateDuringCycle;

        public KeyPadSettingsField TunnelExitDelayMin
        {
            get { return _tunnelExitDelayMin ?? (_tunnelExitDelayMin = new KeyPadSettingsField { Name = "Tunnel Exit Delay (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _tunnelExitDelayMin = value; }
        }
        private KeyPadSettingsField _tunnelExitDelayMin;

        public KeyPadSettingsField NonBroodAreaDiffFromHeat
        {
            get { return _nonBroodAreaDiffFromHeat ?? (_nonBroodAreaDiffFromHeat = new KeyPadSettingsField { Name = "Non Brood Area Diff. From Heat", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _nonBroodAreaDiffFromHeat = value; }
        }
        private KeyPadSettingsField _nonBroodAreaDiffFromHeat;

        #endregion

        #region Group Name: Stir Fans
        public KeyPadSettingsField OffCycleDelayTimeSec
        {
            get { return _offCycleDelayTimeSec ?? (_offCycleDelayTimeSec = new KeyPadSettingsField { Name = "Off Cycle Delay Time (Sec.)", InputMethod = new MinusNumericKeyPad() }); }
            set { _offCycleDelayTimeSec = value; }
        }
        private KeyPadSettingsField _offCycleDelayTimeSec;

        public KeyPadSettingsField OnTimeSec
        {
            get { return _onTimeSec ?? (_onTimeSec = new KeyPadSettingsField { Name = "On Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _onTimeSec = value; }
        }
        private KeyPadSettingsField _onTimeSec;

        public ToggleButtonSettingsField OnTempOutputMV
        {
            get { return _onTempOutputMV ?? (_onTempOutputMV = new ToggleButtonSettingsField("On Temp. Output (MV)")); }
            set { _onTempOutputMV = value; }
        }
        private ToggleButtonSettingsField _onTempOutputMV;

        public KeyPadSettingsField VariableStirOutput
        {
            get { return _variableStirOutput ?? (_variableStirOutput = new KeyPadSettingsField { Name = "Variable Stir Output (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _variableStirOutput = value; }
        }
        private KeyPadSettingsField _variableStirOutput;
        #endregion

        #region Group Name: Radiant Heaters
        public KeyPadSettingsField RadiantHeaterHighDiff
        {
            get { return _radiantHeaterHighDiff ?? (_radiantHeaterHighDiff = new KeyPadSettingsField { Name = "Radiant Heater High Diff", InputMethod = new PointNumericKeyPad() }); }
            set { _radiantHeaterHighDiff = value; }
        }
        private KeyPadSettingsField _radiantHeaterHighDiff;

        public KeyPadSettingsField RadiantIgnitionTimeSec
        {
            get { return _radiantIgnitionTimeSec ?? (_radiantIgnitionTimeSec = new KeyPadSettingsField { Name = "Radiant Ignition Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _radiantIgnitionTimeSec = value; }
        }
        private KeyPadSettingsField _radiantIgnitionTimeSec;
        #endregion

        #region Group Name: Curtains
        public KeyPadSettingsField MinCurtainPosition
        {
            get { return _minCurtainPosition ?? (_minCurtainPosition = new KeyPadSettingsField { Name = "Min Curtain Position", InputMethod = new BaseNumericKeyPad() }); }
            set { _minCurtainPosition = value; }
        }
        private KeyPadSettingsField _minCurtainPosition;

        public KeyPadSettingsField CurtainDelayBetweenSteps
        {
            get { return _curtainDelayBetweenSteps ?? (_curtainDelayBetweenSteps = new KeyPadSettingsField { Name = "Curtain Delay Between Steps (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _curtainDelayBetweenSteps = value; }
        }
        private KeyPadSettingsField _curtainDelayBetweenSteps;

        public KeyPadSettingsField CurtainStepSize
        {
            get { return _curtainStepSize ?? (_curtainStepSize = new KeyPadSettingsField { Name = "Curtain Step Size", InputMethod = new BaseNumericKeyPad() }); }
            set { _curtainStepSize = value; }
        }
        private KeyPadSettingsField _curtainStepSize;
        #endregion

        #region Group Name: Attic
        public KeyPadSettingsField MinAtticTemperature
        {
            get { return _minAtticTemperature ?? (_minAtticTemperature = new KeyPadSettingsField { Name = "Min Attic Temperature", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _minAtticTemperature = value; }
        }
        private KeyPadSettingsField _minAtticTemperature;

        public KeyPadSettingsField MaxAtticTemperature
        {
            get { return _maxAtticTemperature ?? (_maxAtticTemperature = new KeyPadSettingsField { Name = "Max Attic Temperature", InputMethod = new PointNumericKeyPad() }); }
            set { _maxAtticTemperature = value; }
        }
        private KeyPadSettingsField _maxAtticTemperature;

        public KeyPadSettingsField FromTime
        {
            get { return _fromTime ?? (_fromTime = new KeyPadSettingsField { Name = "From Time", InputMethod = new TimeKeyPad() }); }
            set { _fromTime = value; }
        }
        private KeyPadSettingsField _fromTime;

        public KeyPadSettingsField ToTime
        {
            get { return _toTime ?? (_toTime = new KeyPadSettingsField { Name = "To Time", InputMethod = new TimeKeyPad() }); }
            set { _toTime = value; }
        }
        private KeyPadSettingsField _toTime;

        public ComboboxSettingsField StopAtticWhenThisFanOn
        {
            get { return _stopAtticWhenThisFanOn ?? (_stopAtticWhenThisFanOn = new ComboboxSettingsField("Stop Attic When This Fan On")); }
            set { _stopAtticWhenThisFanOn = value; }
        }
        private ComboboxSettingsField _stopAtticWhenThisFanOn;

        public ComboboxSettingsField AtticVentilationBy
        {
            get { return _atticVentilationBy ?? (_atticVentilationBy = new ComboboxSettingsField("Attic Ventilation By")); }
            set { _atticVentilationBy = value; }
        }
        private ComboboxSettingsField _atticVentilationBy;
        #endregion
    }
}
