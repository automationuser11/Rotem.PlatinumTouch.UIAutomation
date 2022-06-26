using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedersAndDrinkers
{
    public class WaterAndFeedLinesSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Feeders & Drinkers - Settings"; }
        }
        public override void Navigate()
        {
            SettingsPageSerivce.Navigate();
        }

        #region Group Name: Feeders and Drinkers

        public KeyPadSettingsField AdjustAtTime
        {
            get { return _adjustAtTime ?? (_adjustAtTime = new KeyPadSettingsField() { Name = "Adjust At Time", InputMethod = new TimeKeyPad() }); }
            set { _adjustAtTime = value; }
        }
        private KeyPadSettingsField _adjustAtTime;


        #endregion

        #region Group Name: Feeder Window


        public KeyPadSettingsField StopFeedBeforeAdjustMin
        {
            get { return _stopFeedBeforeAdjustMin ?? (_stopFeedBeforeAdjustMin = new KeyPadSettingsField() { Name = "Stop Feed Before Adjust (Minute)", InputMethod = new BaseNumericKeyPad() }); }
            set { _stopFeedBeforeAdjustMin = value; }
        }
        private KeyPadSettingsField _stopFeedBeforeAdjustMin;

        public KeyPadSettingsField TimeFromCloseToOpensec
        {
            get { return _timeFromCloseToOpensec ?? (_timeFromCloseToOpensec = new KeyPadSettingsField() { Name = "Time From Close To Open (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _timeFromCloseToOpensec = value; }
        }
        private KeyPadSettingsField _timeFromCloseToOpensec;

        #endregion

        #region Group Name: Feed Line

        public KeyPadSettingsField FeedLineMovementTimePer10Cmsec
        {
            get { return _feedLineMovementTimePer10Cmsec ?? (_feedLineMovementTimePer10Cmsec = new KeyPadSettingsField() { Name = "Feed Line_Movement Time Per 10 (sec)", InputMethod = new BaseNumericKeyPad() }); }
            set { _feedLineMovementTimePer10Cmsec = value; }
        }
        private KeyPadSettingsField _feedLineMovementTimePer10Cmsec;

        #endregion

        #region Group Name: Drinkers Line

        public KeyPadSettingsField DrinkersLineMovementTimePer10Cmsec
        {
            get { return _drinkersLineMovementTimePer10Cmsec ?? (_drinkersLineMovementTimePer10Cmsec = new KeyPadSettingsField() { Name = "Drinkers Line_Movement Time Per 10 (sec)", InputMethod = new BaseNumericKeyPad() }); }
            set { _drinkersLineMovementTimePer10Cmsec = value; }
        }
        private KeyPadSettingsField _drinkersLineMovementTimePer10Cmsec;
        

        #endregion 
    }
}
