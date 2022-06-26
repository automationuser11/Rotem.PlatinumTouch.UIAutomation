using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.AnalogSensors
{
    public class AnalogSensorsPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<AnalogSensorsPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<AnalogSensorsPage>()); }
        }
        private Uri _pageUri;
        public string Name 
        {
            get { return "Analog Sensors Testing & Calibration"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<AnalogSensorsPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<AnalogSensorsPage>()); }
        }
        private ReadonlyGridTablePage<AnalogSensorsPage> _tableView;
    }
}
