using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class ZoneInletPositionPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<ZoneInletPositionPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Zone Inlet Position"; }
        }
        public string MenuName
        {
            get { return "Zone Inlet Position"; }
        }
        public string SubMenu { get { return "Hot Key"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public ReadonlyGridTablePage<ZoneInletPositionPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<ZoneInletPositionPage>()); }
        }
        private ReadonlyGridTablePage<ZoneInletPositionPage> _tableView;
        public Metadata Metadata { get; set; }        
    }
}


