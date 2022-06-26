using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedersAndDrinkers
{
    public class FeedersAndDrinkersPage : IApplicationPage, ITableViewProvider<GridTablePage<FeedersAndDrinkersPage>>, ISettingsModalViewProvider<WaterAndFeedLinesSettingsPage>, IMetadataDependentPageObject, IErrorMessagePage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<FeedersAndDrinkersPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Feeders & Drinkers"; }
        }
        public string MenuName
        {
            get { return "Feeders & Drinkers"; }
        }
        public string SubMenu { get { return "Management"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<FeedersAndDrinkersPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<FeedersAndDrinkersPage>()); }
        }
        private GridTablePage<FeedersAndDrinkersPage> _tableView;

        public WaterAndFeedLinesSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new WaterAndFeedLinesSettingsPage()); }
        }
        private WaterAndFeedLinesSettingsPage _settingsView;

        public string ErrorMessage
        {
            get { return PageErrorMessageService.GetDisplayedErrorMessage(); }
        }
        public void ApproveErrorMessage()
        {
            PageErrorMessageService.ApproveErrorMessage();
        }
    }
}
