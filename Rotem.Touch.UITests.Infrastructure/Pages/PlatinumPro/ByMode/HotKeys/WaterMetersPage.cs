using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class WaterMetersPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<WaterMetersPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Water Meters"; }
        }
        public string MenuName
        {
            get { return "Water Meters"; }
        }
        public string SubMenu { get { return "Hot Key"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public ReadonlyGridTablePage<WaterMetersPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<WaterMetersPage>()); }
        }
        private ReadonlyGridTablePage<WaterMetersPage> _tableView;
        public Metadata Metadata { get; set; }        
    }
}


