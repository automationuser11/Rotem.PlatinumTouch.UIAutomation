using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class WaterAndFeedStatusPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<WaterAndFeedStatusPage>()); }
        }
        private Uri _pageUri;

        public string Name
        {
            get { return "Water & Feed Status"; }
        }
        public string MenuName
        {
            get { return "Water & Feed Status"; }
        }
        public string SubMenu { get { return "Hot Key"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public ReadonlyGridTablePage<WaterAndFeedStatusPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<WaterAndFeedStatusPage>()); }
        }
        private ReadonlyGridTablePage<WaterAndFeedStatusPage> _tableView;
        public Metadata Metadata { get; set; }
        public PageInitialSetup<AirStatusPage> PageInitialSetup { get; set; }
    }
}
