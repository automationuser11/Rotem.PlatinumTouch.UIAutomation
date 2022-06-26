using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.StaticPressureCalibration
{
    public class StaticPressureCalibrationPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<StaticPressureCalibrationPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<StaticPressureCalibrationPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Static Pressure Testing & Calibration"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<StaticPressureCalibrationPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<StaticPressureCalibrationPage>()); }
        }
        private ReadonlyGridTablePage<StaticPressureCalibrationPage> _tableView;
    }
}
