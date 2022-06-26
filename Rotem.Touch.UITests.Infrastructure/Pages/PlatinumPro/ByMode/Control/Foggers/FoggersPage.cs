using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Foggers
{
    public class FoggersPage : IApplicationPage, ITableViewProvider<GridTablePage<FoggersPage>>, ISettingsModalViewProvider<FoggersSettingsPage>, IMetadataDependentPageObject, IErrorMessagePage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<FoggersPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Foggers"; }
        }
        public string MenuName
        {
            get { return "Foggers"; }
        }
        public string SubMenu { get { return "Control"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public GridTablePage<FoggersPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<FoggersPage>()); }
        }
        private GridTablePage<FoggersPage> _tableView;

        public FoggersSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new FoggersSettingsPage()); }
        }
        private FoggersSettingsPage _settingsView;

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
