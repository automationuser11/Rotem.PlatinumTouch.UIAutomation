using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.AirInletsSetup
{
    public class AirInletsSetupPage : IApplicationPage, ITableViewProvider<GridTablePage<AirInletsSetupPage>>, ISettingsModalViewProvider<AirInletsSetupSettingsPage>, IMetadataDependentPageObject, IErrorMessagePage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<AirInletsSetupPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Vent/Curt Setup"; }
        }
        public string MenuName
        {
            get { return "Vent/Curt Setup"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<AirInletsSetupPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<AirInletsSetupPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<AirInletsSetupPage> _tableView;
        public string ErrorMessage
        {
            get { return PageErrorMessageService.GetDisplayedErrorMessage(); }
        }
        public AirInletsSetupSettingsPage SettingsView
        {
            get { return _airInletsSetupSettingsPage ?? (_airInletsSetupSettingsPage = new AirInletsSetupSettingsPage()); }
            set { _airInletsSetupSettingsPage = value; }
        }
        private AirInletsSetupSettingsPage _airInletsSetupSettingsPage;
        public void ApproveErrorMessage()
        {
            PageErrorMessageService.ApproveErrorMessage();
        }
    }
}
