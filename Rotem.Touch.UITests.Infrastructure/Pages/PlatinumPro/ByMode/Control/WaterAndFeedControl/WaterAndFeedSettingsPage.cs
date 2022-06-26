using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.WaterAndFeedControl
{
    public class WaterAndFeedSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Water & Feed - Settings"; }
        }
        public ComboboxSettingsField FeedByCycle
        {
            get { return _feedByCycle ?? (_feedByCycle = new ComboboxSettingsField("Feed Day Cycle")); }
            set { _feedByCycle = value; }
        }
        private ComboboxSettingsField _feedByCycle;
        public ToggleButtonSettingsField Quantity
        {
            get { return _quantity ?? (_quantity = new ToggleButtonSettingsField("Feed By Quantity")); }
            set { _quantity = value; }
        }
        private ToggleButtonSettingsField _quantity;


        #region Group Name: Basic Feeding
        public KeyPadSettingsField ChangeTargetFrom
        {
            get { return _changeTargetFrom ?? (_changeTargetFrom = new KeyPadSettingsField() { Name = "Change Target From", InputMethod = new TimeKeyPad() }); }
            set { _changeTargetFrom = value; }
        }
        private KeyPadSettingsField _changeTargetFrom;

        public KeyPadSettingsField ChangeTargetTo
        {
            get { return _changeTargetTo ?? (_changeTargetTo = new KeyPadSettingsField() { Name = "Change Target To", InputMethod = new TimeKeyPad() }); }
            set { _changeTargetTo = value; }
        }
        private KeyPadSettingsField _changeTargetTo;

        public KeyPadSettingsField TargetOffset
        {
            get { return _targetOffset ?? (_targetOffset = new KeyPadSettingsField() { Name = "Target Offset", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _targetOffset = value; }
        }
        private KeyPadSettingsField _targetOffset;

        public KeyPadSettingsField Line1Down
        {
            get { return _line1Down ?? (_line1Down = new KeyPadSettingsField() { Name = "Line 1 Down", InputMethod = new TimeKeyPad() }); }
            set { _line1Down = value; }
        }
        private KeyPadSettingsField _line1Down;

        public KeyPadSettingsField Line1Up
        {
            get { return _line1Up ?? (_line1Up = new KeyPadSettingsField() { Name = "Line 1 Up", InputMethod = new TimeKeyPad() }); }
            set { _line1Up = value; }
        }
        private KeyPadSettingsField _line1Up;

        public KeyPadSettingsField Line2Down
        {
            get { return _line2Down ?? (_line2Down = new KeyPadSettingsField() { Name = "Line 2 Down", InputMethod = new TimeKeyPad() }); }
            set { _line2Down = value; }
        }
        private KeyPadSettingsField _line2Down;

        public KeyPadSettingsField Line2Up
        {
            get { return _line2Up ?? (_line2Up = new KeyPadSettingsField() { Name = "Line 2 Up", InputMethod = new TimeKeyPad() }); }
            set { _line2Up = value; }
        }
        private KeyPadSettingsField _line2Up;

        public KeyPadSettingsField WaterCycleOnSec
        {
            get { return _waterCycleOnSec ?? (_waterCycleOnSec = new KeyPadSettingsField() { Name = "Water Cycle Time_Cycle On (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _waterCycleOnSec = value; }
        }
        private KeyPadSettingsField _waterCycleOnSec;

        public KeyPadSettingsField WaterCycleOffSec
        {
            get { return _waterCycleOffSec ?? (_waterCycleOffSec = new KeyPadSettingsField() { Name = "Water Cycle Time_Cycle Off (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _waterCycleOffSec = value; }
        }
        private KeyPadSettingsField _waterCycleOffSec;

        public KeyPadSettingsField FeederCycleOnSec
        {
            get { return _feederCycleOnSec ?? (_feederCycleOnSec = new KeyPadSettingsField() { Name = "Feeder Cycle Time_Cycle On (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _feederCycleOnSec = value; }
        }
        private KeyPadSettingsField _feederCycleOnSec;

        public KeyPadSettingsField FeederCycleOffSec
        {
            get { return _feederCycleOffSec ?? (_feederCycleOffSec = new KeyPadSettingsField() { Name = "Feeder Cycle Time_Cycle Off (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _feederCycleOffSec = value; }
        }
        private KeyPadSettingsField _feederCycleOffSec;

        public KeyPadSettingsField AugerCycleOnSec
        {
            get { return _augerCycleOnSec ?? (_augerCycleOnSec = new KeyPadSettingsField() { Name = "Auger Cycle Time_Cycle On (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _augerCycleOnSec = value; }
        }
        private KeyPadSettingsField _augerCycleOnSec;

        public KeyPadSettingsField AugerCycleOffSec
        {
            get { return _augerCycleOffSec ?? (_augerCycleOffSec = new KeyPadSettingsField() { Name = "Auger Cycle Time_Cycle Off (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _augerCycleOffSec = value; }
        }
        private KeyPadSettingsField _augerCycleOffSec;

        //
        public KeyPadSettingsField WaterCycleOnMin
        {
            get { return _waterCycleOnMin ?? (_waterCycleOnMin = new KeyPadSettingsField() { Name = "Water Cycle Time_Cycle On (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _waterCycleOnMin = value; }
        }
        private KeyPadSettingsField _waterCycleOnMin;

        public KeyPadSettingsField WaterCycleOffMin
        {
            get { return _waterCycleOffMin ?? (_waterCycleOffMin = new KeyPadSettingsField() { Name = "Water Cycle Time_Cycle Off (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _waterCycleOffMin = value; }
        }
        private KeyPadSettingsField _waterCycleOffMin;

        public KeyPadSettingsField FeederCycleOnMin
        {
            get { return _feederCycleOnMin ?? (_feederCycleOnMin = new KeyPadSettingsField() { Name = "Feeder Cycle Time_Cycle On (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _feederCycleOnMin = value; }
        }
        private KeyPadSettingsField _feederCycleOnMin;

        public KeyPadSettingsField FeederCycleOffMin
        {
            get { return _feederCycleOffMin ?? (_feederCycleOffMin = new KeyPadSettingsField() { Name = "Feeder Cycle Time_Cycle Off (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _feederCycleOffMin = value; }
        }
        private KeyPadSettingsField _feederCycleOffMin;

        public KeyPadSettingsField AugerCycleOnMin
        {
            get { return _augerCycleOnMin ?? (_augerCycleOnMin = new KeyPadSettingsField() { Name = "Auger Cycle Time_Cycle On (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _augerCycleOnMin = value; }
        }
        private KeyPadSettingsField _augerCycleOnMin;

        public KeyPadSettingsField AugerCycleOffMin
        {
            get { return _augerCycleOffMin ?? (_augerCycleOffMin = new KeyPadSettingsField() { Name = "Auger Cycle Time_Cycle Off (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _augerCycleOffMin = value; }
        }
        private KeyPadSettingsField _augerCycleOffMin;
        #endregion
    }
}
