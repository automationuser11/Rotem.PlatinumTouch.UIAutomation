using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedLinesCalibration
{
    public class FeedLinesCalibrationPage : IApplicationPage, ITableViewProvider<FeedLinesCalibrationTable>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<FeedLinesCalibrationPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Feed Lines Calibration"; }
        }
        public string MenuName
        {
            get { return "Feed Lines Calibration"; }
        }
        public string SubMenu { get { return "Management"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public FeedLinesCalibrationTable TableView
        {
            get { return _tableView ?? (_tableView = new FeedLinesCalibrationTable()); }
        }
        private FeedLinesCalibrationTable _tableView;
    }
}
