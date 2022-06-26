using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedInventory
{
    public class FeedInventoryPage : IApplicationPage, ITableViewProvider<FeedInventoryTable>, ISettingsModalViewProvider<FeedInventorySettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<FeedInventoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Feed Inventory"; }
        }
        public string MenuName
        {
            get { return "Feed Inventory"; }
        }
        public string SubMenu { get { return "Management"; } }

        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public FeedInventoryTable TableView
        {
            get { return _tableView ?? (_tableView = new FeedInventoryTable()); }
        }
        private FeedInventoryTable _tableView;

        public FeedInventorySettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new FeedInventorySettingsPage()); }
        }
        private FeedInventorySettingsPage _settingsView;
    }
}
