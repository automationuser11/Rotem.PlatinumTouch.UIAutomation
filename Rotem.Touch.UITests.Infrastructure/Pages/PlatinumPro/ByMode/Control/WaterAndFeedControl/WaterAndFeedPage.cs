using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.WaterAndFeedControl
{
    public class WaterAndFeedPage : IApplicationPage, ITableViewProvider<GridTablePage<WaterAndFeedPage>>, ISettingsModalViewProvider<WaterAndFeedSettingsPage>, IMetadataDependentPageObject, IErrorMessagePage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<WaterAndFeedPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return @"Water & Feed Control"; }
        }
        public string MenuName
        {
            get { return @"Water & Feed"; }
        }
        public string SubMenu { get { return "Control"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get
            {
                return ApplicationPageService.Titles;
            }
        }
        public GridTablePage<WaterAndFeedPage> TableView
        {
            get { return _tableView  ?? (_tableView = new GridTablePage<WaterAndFeedPage>()); }
        }
        private GridTablePage<WaterAndFeedPage> _tableView;

        public WaterAndFeedSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new WaterAndFeedSettingsPage()); }
        }
        private WaterAndFeedSettingsPage _settingsPage;
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
