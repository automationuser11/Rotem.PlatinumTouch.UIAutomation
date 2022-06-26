using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.VentCurtSetup
{
    public class VentCurtSetupCalibrationPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Vent/Curt Calibration"; }
        }
        public string SubMenu { get { return "System"; } }
        #region Vent & Curt Calibration

        public KeyPadSettingsField FromTime
        {
            get { return _fromTime ?? (_fromTime = new KeyPadSettingsField { Name = "From Time", InputMethod = new TimeKeyPad() }); }
        }
        private KeyPadSettingsField _fromTime;

        public KeyPadSettingsField NumberOfSteps
        {
            get { return _numberOfSteps ?? (_numberOfSteps = new KeyPadSettingsField { Name = "Number Of Steps", InputMethod = new BaseNumericKeyPad() }); }
        }
        private KeyPadSettingsField _numberOfSteps;

        public KeyPadSettingsField ProximityToEdge
        {
            get { return _proximityToEdge ?? (_proximityToEdge = new KeyPadSettingsField { Name = "Proximity To Edge (%)", InputMethod = new BaseNumericKeyPad() }); }
        }
        private KeyPadSettingsField _proximityToEdge;

        public KeyPadSettingsField ToTime
        {
            get { return _toTime ?? (_toTime = new KeyPadSettingsField { Name = "To Time", InputMethod = new TimeKeyPad() }); }
        }
        private KeyPadSettingsField _toTime;

        public ComboboxSettingsField PowerUpVentsCalibration
        {
            get { return _powerUpVentsCalibration ?? (_powerUpVentsCalibration = new ComboboxSettingsField("Power Up Vents Calibration")); }
        }
        private ComboboxSettingsField _powerUpVentsCalibration;

        public KeyPadSettingsField CloseBelowThisTemp
        {
            get { return _closeBelowThisTemp ?? (_closeBelowThisTemp = new KeyPadSettingsField { Name = "Close Below This Temp. (Out)", InputMethod = new MinusPointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _closeBelowThisTemp; 
        #endregion
    }
}
