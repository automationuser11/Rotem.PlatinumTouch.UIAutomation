using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.Scales
{
    public class ScalesPage : IApplicationPage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<ScalesPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Scales Testing & Calibration"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
    }
}
