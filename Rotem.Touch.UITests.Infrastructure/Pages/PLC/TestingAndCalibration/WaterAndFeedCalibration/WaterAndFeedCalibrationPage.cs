using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WaterAndFeedCalibration
{
    public class WaterAndFeedCalibrationPage : SimpleTabsPage
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<WaterAndFeedCalibrationPage>()); }
        }
        private Uri _pageUri;
        public override string Name
        {
            get { return "Water & Feed Calibration"; }
        }
        public override string MenuName
        {
            get { return ""; }
        }
        public override string SubMenu { get { return ""; } }
        public WaterTabPage WaterTabPage
        {
            get { return _waterTabPage ?? (_waterTabPage = new WaterTabPage()); }
            set { _waterTabPage = value; }
        }
        private WaterTabPage _waterTabPage;

        public FeedTabPage FeedTabPage
        {
            get { return _feedTabPage  ?? (_feedTabPage = new FeedTabPage()); }
            set { _feedTabPage  = value; }
        }
        private FeedTabPage _feedTabPage;
    }
}
