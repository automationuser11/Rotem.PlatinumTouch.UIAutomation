using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class TemperatureandHumidityPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {  
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<TemperatureandHumidityPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Temperature & Humidity Status"; }
        }
        public string MenuName
        {
            get { return "Temperature & Humidity Status"; }
        }
        public string SubMenu { get { return "Hot Key"; } }

        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }
    }
}
