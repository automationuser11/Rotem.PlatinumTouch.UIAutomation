using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.RelayLayout
{
    public class RelayLayoutPage : ISettingsModalViewProvider<RelayLayoutSettingsPage>, IApplicationPage, ITableViewProvider<DeviceInstallationPage<RelayLayoutPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<RelayLayoutPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Relay Layout"; }
        }
        public string MenuName
        {
            get { return "Relay Layout"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public DeviceInstallationPage<RelayLayoutPage> TableView
        {
            get { return _tableView ?? (_tableView = new DeviceInstallationPage<RelayLayoutPage>("RelayLayout_Device")); }
        }
        private DeviceInstallationPage<RelayLayoutPage> _tableView;

        public RelayLayoutSettingsPage SettingsView
        {
            get { return _relayLayoutSettingsPage ?? (_relayLayoutSettingsPage = new RelayLayoutSettingsPage()); }
            set { _relayLayoutSettingsPage = value; }
        }
        private RelayLayoutSettingsPage _relayLayoutSettingsPage;

    }
}
