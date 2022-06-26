using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.DigitalSensors
{
    public class DigitalSensorsPage : IApplicationPage, ITableViewProvider<AccordionTablePage<DigitalSensorsPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<DigitalSensorsPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Digital Sensors Testing & Calibration"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public AccordionTablePage<DigitalSensorsPage> TableView { get; private set; }
    }
}
