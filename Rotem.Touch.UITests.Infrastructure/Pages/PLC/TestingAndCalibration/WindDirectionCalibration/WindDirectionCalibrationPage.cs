using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WindDirectionCalibration
{
    public class WindDirectionCalibrationPage : ITableViewProvider<GridTablePage<WindDirectionCalibrationPage>>, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<WindDirectionCalibrationPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Wind Direction Calibration"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<WindDirectionCalibrationPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<WindDirectionCalibrationPage>()); }
        }
        private GridTablePage<WindDirectionCalibrationPage> _tableView;
    }
}
