using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.System.TemperatureAndTimer
{
    public class TemperatureAndTimerSettingsPage : SimpleSettingsModal
    {
        #region Temp Timer Settings header
        public KeyPadSettingsField MinTunnelFansOn
        {
            get { return _minTunnelFansOn ?? (_minTunnelFansOn = new KeyPadSettingsField { Name = "Min Tunnel Fans On", InputMethod = new BaseNumericKeyPad() }); }
        }
        private KeyPadSettingsField _minTunnelFansOn;

        public KeyPadSettingsField TunnelExitDelayMin
        {
            get { return _tunnelExitDelayMin ?? (_tunnelExitDelayMin = new KeyPadSettingsField { Name = "Tunnel Exit Delay (Min.) ", InputMethod = new BaseNumericKeyPad() }); }
        }
        private KeyPadSettingsField _tunnelExitDelayMin;

        public KeyPadSettingsField NonBroodAreaDiffFromHeat
        {
            get { return _nonBroodAreaDiffFromHeat ?? (_nonBroodAreaDiffFromHeat = new KeyPadSettingsField { Name = "Non Brood Area Diff. From Heat", InputMethod = new MinusPointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _nonBroodAreaDiffFromHeat;

        #endregion

        #region Stir Fans header
        public KeyPadSettingsField OffCycleDelayTimeSec
        {
            get { return _offCycleDelayTimeSec ?? (_offCycleDelayTimeSec = new KeyPadSettingsField { Name = "Off Cycle Delay Time (Sec.)", InputMethod = new MinusNumericKeyPad() }); }
        }
        private KeyPadSettingsField _offCycleDelayTimeSec;

        public KeyPadSettingsField OnTimeSec
        {
            get { return _onTimeSec ?? (_onTimeSec = new KeyPadSettingsField { Name = "On Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
        }
        private KeyPadSettingsField _onTimeSec;

        public ComboboxSettingsField OnTempOutputMV
        {
            get { return _onTempOutputMV ?? (_onTempOutputMV = new ComboboxSettingsField("On Temp. Output (MV)")); }
        }
        private ComboboxSettingsField _onTempOutputMV;

        public KeyPadSettingsField VariableStirOutput
        {
            get { return _variableStirOutput ?? (_variableStirOutput = new KeyPadSettingsField { Name = "Variable Stir Output (%)", InputMethod = new BaseNumericKeyPad() }); }
        }
        private KeyPadSettingsField _variableStirOutput; 
        #endregion

        #region Radiant Heaters header
        public KeyPadSettingsField RadiantHeaterHighDiff
        {
            get { return _radiantHeaterHighDiff ?? (_radiantHeaterHighDiff = new KeyPadSettingsField { Name = "Radiant Heater High Diff", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _radiantHeaterHighDiff;

        public KeyPadSettingsField RadiantIgnitionTimeSec
        {
            get { return _radiantIgnitionTimeSec ?? (_radiantIgnitionTimeSec = new KeyPadSettingsField { Name = "Radiant Ignition Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
        }
        private KeyPadSettingsField _radiantIgnitionTimeSec; 
        #endregion

        #region Attic 
        public KeyPadSettingsField MinAtticTemperature
        {
            get { return _minAtticTemperature ?? (_minAtticTemperature = new KeyPadSettingsField { Name = "Min Attic Temperature", InputMethod = new MinusPointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _minAtticTemperature;

        public KeyPadSettingsField MaxAtticTemperature
        {
            get { return _maxAtticTemperature ?? (_maxAtticTemperature = new KeyPadSettingsField { Name = "Max Attic Temperature", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _maxAtticTemperature;

        public KeyPadSettingsField FromTime
        {
            get { return _fromTime ?? (_fromTime = new KeyPadSettingsField { Name = "From Time", InputMethod = new TimeKeyPad() }); }
        }
        private KeyPadSettingsField _fromTime;

        public KeyPadSettingsField ToTime
        {
            get { return _toTime ?? (_toTime = new KeyPadSettingsField { Name = "To Time", InputMethod = new TimeKeyPad() }); }
        }
        private KeyPadSettingsField _toTime;

        public ComboboxSettingsField StopAtticWhenThisFanOn
        {
            get { return _stopAtticWhenThisFanOn ?? (_stopAtticWhenThisFanOn = new ComboboxSettingsField("Stop Attic When This Fan On")); }
        }
        private ComboboxSettingsField _stopAtticWhenThisFanOn; 
        #endregion
    }
}
