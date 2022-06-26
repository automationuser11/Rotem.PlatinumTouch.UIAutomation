using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.AirInletsSetup
{
    public class AirInletsSetupSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Vent/Curt Calibration"; }
        }

        public KeyPadSettingsField FromTime
        {
            get { return _fromTime ?? (_fromTime = new KeyPadSettingsField() { Name = "From Time", InputMethod = new TimeKeyPad() }); }
            set { _fromTime = value; }
        }
        private KeyPadSettingsField _fromTime;

        public KeyPadSettingsField ToTime
        {
            get { return _toTime ?? (_toTime = new KeyPadSettingsField() { Name = "To Time", InputMethod = new TimeKeyPad() }); }
            set { _toTime = value; }
        }
        private KeyPadSettingsField _toTime;

        public KeyPadSettingsField NumberOfSteps
        {
            get { return _numberOfSteps ?? (_numberOfSteps = new KeyPadSettingsField() { Name = "Number Of Steps", InputMethod = new BaseNumericKeyPad() }); }
            set { _numberOfSteps = value; }
        }
        private KeyPadSettingsField _numberOfSteps;

        public ToggleButtonSettingsField PowerUpVentsCalibration
        {
            get { return _powerUpVentsCalibration ?? (_powerUpVentsCalibration = new ToggleButtonSettingsField("Power Up Vents Calibration")); }
            set { _powerUpVentsCalibration = value; }
        }
        private ToggleButtonSettingsField _powerUpVentsCalibration;

        public KeyPadSettingsField ProximityToEdge
        {
            get { return _proximityToEdge ?? (_proximityToEdge = new KeyPadSettingsField() { Name = "Proximity To Edge (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _proximityToEdge = value; }
        }
        private KeyPadSettingsField _proximityToEdge;

        public KeyPadSettingsField CloseBelowThisTempOut
        {
            get { return _closeBelowThisTempOut ?? (_closeBelowThisTempOut = new KeyPadSettingsField() { Name = "Close Below This Temp. (Out)", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _closeBelowThisTempOut = value; }
        }
        private KeyPadSettingsField _closeBelowThisTempOut;

        public KeyPadSettingsField PrecisionAroundTarget
        {
            get { return _precisionAroundTarget ?? (_precisionAroundTarget = new KeyPadSettingsField() { Name = "Precision Around Target %", InputMethod = new BaseNumericKeyPad() }); }
            set { _precisionAroundTarget = value; }
        }
        private KeyPadSettingsField _precisionAroundTarget;
    }
}
