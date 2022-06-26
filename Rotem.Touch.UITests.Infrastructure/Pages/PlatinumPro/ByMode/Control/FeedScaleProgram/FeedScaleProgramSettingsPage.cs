using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.FeedScaleProgram
{
    public class FeedScaleProgramSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Feed Scale Setting"; }
        }

        public KeyPadSettingsField Time
        {
            get { return _time ?? (_time = new KeyPadSettingsField() { Name = "Time [hh:mm]", InputMethod = new TimeKeyPad() }); }
            set { _time = value; }
        }
        private KeyPadSettingsField _time;

        public KeyPadSettingsField StartTime
        {
            get { return _startTime ?? (_startTime = new KeyPadSettingsField() { Name = "Start Time", InputMethod = new TimeKeyPad() }); }
            set { _startTime = value; }
        }
        private KeyPadSettingsField _startTime;

        public KeyPadSettingsField MaxPortionWeight
        {
            get { return _maxPortionWeight ?? (_maxPortionWeight = new KeyPadSettingsField() { Name = "Max Portion Weight", InputMethod = new BaseNumericKeyPad() }); }
            set { _maxPortionWeight = value; }
        }
        private KeyPadSettingsField _maxPortionWeight;

        public KeyPadSettingsField MaxAugerTimeMin
        {
            get { return _maxAugerTimeMin ?? (_maxAugerTimeMin = new KeyPadSettingsField() { Name = "Max Auger Time (Min)", InputMethod = new BaseNumericKeyPad() }); }
            set { _maxAugerTimeMin = value; }
        }
        private KeyPadSettingsField _maxAugerTimeMin;

        public KeyPadSettingsField NotEmptyTimeMin
        {
            get { return _notEmptyTimeMin ?? (_notEmptyTimeMin = new KeyPadSettingsField() { Name = "Not Empty Time (Min)", InputMethod = new BaseNumericKeyPad() }); }
            set { _notEmptyTimeMin = value; }
        }
        private KeyPadSettingsField _notEmptyTimeMin;

        public KeyPadSettingsField StopDiff1Weight
        {
            get { return _stopDiff1Weight ?? (_stopDiff1Weight = new KeyPadSettingsField() { Name = "Stop Diff. 1 Weight", InputMethod = new PointNumericKeyPad() }); }
            set { _stopDiff1Weight = value; }
        }
        private KeyPadSettingsField _stopDiff1Weight;

        public KeyPadSettingsField StopDiff2Weight
        {
            get { return _stopDiff2Weight ?? (_stopDiff2Weight = new KeyPadSettingsField() { Name = "Stop Diff. 2 Weight", InputMethod = new PointNumericKeyPad() }); }
            set { _stopDiff2Weight = value; }
        }
        private KeyPadSettingsField _stopDiff2Weight;

        public KeyPadSettingsField StopDiff3Weight
        {
            get { return _stopDiff3Weight ?? (_stopDiff3Weight = new KeyPadSettingsField() { Name = "Stop Diff. 3 Weight", InputMethod = new PointNumericKeyPad() }); }
            set { _stopDiff3Weight = value; }
        }
        private KeyPadSettingsField _stopDiff3Weight;

        public KeyPadSettingsField StopDiff4Weight
        {
            get { return _stopDiff4Weight ?? (_stopDiff4Weight = new KeyPadSettingsField() { Name = "Stop Diff. 4 Weight", InputMethod = new PointNumericKeyPad() }); }
            set { _stopDiff4Weight = value; }
        }
        private KeyPadSettingsField _stopDiff4Weight;

        public KeyPadSettingsField StopDiffWeight
        {
            get { return _stopDiffWeight ?? (_stopDiffWeight = new KeyPadSettingsField() { Name = "Stop Diff Weight", InputMethod = new PointNumericKeyPad() }); }
            set { _stopDiffWeight = value; }
        }
        private KeyPadSettingsField _stopDiffWeight;

        public ComboboxSettingsField Optimizer
        {
            get { return _optimizer ?? (_optimizer = new ComboboxSettingsField("Optimizer")); }
            set { _optimizer = value; }
        }
        private ComboboxSettingsField _optimizer;

        public KeyPadSettingsField ValveCloseTimeSec
        {
            get { return _valveCloseTimeSec ?? (_valveCloseTimeSec = new KeyPadSettingsField() { Name = "Valve Close Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _valveCloseTimeSec = value; }
        }
        private KeyPadSettingsField _valveCloseTimeSec;

        public KeyPadSettingsField FeedTare_AD_Count
        {
            get { return _feedTare_AD_Count ?? (_feedTare_AD_Count = new KeyPadSettingsField() { Name = "Feed Tare [A/D count]", InputMethod = new BaseNumericKeyPad() }); }
            set { _feedTare_AD_Count = value; }
        }
        private KeyPadSettingsField _feedTare_AD_Count;

        public KeyPadSettingsField AugerFeedRate1st
        {
            get { return _augerFeedRate1st ?? (_augerFeedRate1st = new KeyPadSettingsField() { Name = "1ST Line of Hoppers_Auger Feed Rate [weght/min]", InputMethod = new BaseNumericKeyPad() }); }
            set { _augerFeedRate1st = value; }
        }
        private KeyPadSettingsField _augerFeedRate1st;

        public KeyPadSettingsField AugerFeedRate2nd
        {
            get { return _augerFeedRate2nd ?? (_augerFeedRate2nd = new KeyPadSettingsField() { Name = "2ND Line of Hoppers_Auger Feed Rate [weght/min]", InputMethod = new BaseNumericKeyPad() }); }
            set { _augerFeedRate2nd = value; }
        }
        private KeyPadSettingsField _augerFeedRate2nd;

        public KeyPadSettingsField TimeToFirstHopper1st
        {
            get { return _timeToFirstHopper1st ?? (_timeToFirstHopper1st = new KeyPadSettingsField() { Name = "1ST Line of Hoppers_Time To First Line Hopper [sec]", InputMethod = new BaseNumericKeyPad() }); }
            set { _timeToFirstHopper1st = value; }
        }
        private KeyPadSettingsField _timeToFirstHopper1st;

        public KeyPadSettingsField TimeToFirstHopper2nd
        {
            get { return _timeToFirstHopper2nd ?? (_timeToFirstHopper2nd = new KeyPadSettingsField() { Name = "2ND Line of Hoppers_Time To First Line Hopper [sec]", InputMethod = new BaseNumericKeyPad() }); }
            set { _timeToFirstHopper2nd = value; }
        }
        private KeyPadSettingsField _timeToFirstHopper2nd;

        public KeyPadSettingsField TimeToLastHopper1st
        {
            get { return _timeToLastHopper1st ?? (_timeToLastHopper1st = new KeyPadSettingsField() { Name = "1ST Line of Hoppers_Time To Last Line Hopper [sec]", InputMethod = new BaseNumericKeyPad() }); }
            set { _timeToLastHopper1st = value; }
        }
        private KeyPadSettingsField _timeToLastHopper1st;

        public KeyPadSettingsField TimeToLastHopper2nd
        {
            get { return _timeToLastHopper2nd ?? (_timeToLastHopper2nd = new KeyPadSettingsField() { Name = "2ND Line of Hoppers_Time To Last Line Hopper [sec]", InputMethod = new BaseNumericKeyPad() }); }
            set { _timeToLastHopper2nd = value; }
        }
        private KeyPadSettingsField _timeToLastHopper2nd;

        public KeyPadSettingsField LineHooperFeedGap1st
        {
            get { return _lineHooperFeedGap1st ?? (_lineHooperFeedGap1st = new KeyPadSettingsField() { Name = "1ST Line of Hoppers_Line Hopper Feed Gap [sec]", InputMethod = new BaseNumericKeyPad() }); }
            set { _lineHooperFeedGap1st = value; }
        }
        private KeyPadSettingsField _lineHooperFeedGap1st;

        public KeyPadSettingsField LineHooperFeedGap2nd
        {
            get { return _lineHooperFeedGap2nd ?? (_lineHooperFeedGap2nd = new KeyPadSettingsField() { Name = "2ND Line of Hoppers_Line Hopper Feed Gap [sec]", InputMethod = new BaseNumericKeyPad() }); }
            set { _lineHooperFeedGap2nd = value; }
        }
        private KeyPadSettingsField _lineHooperFeedGap2nd;


    }
}
