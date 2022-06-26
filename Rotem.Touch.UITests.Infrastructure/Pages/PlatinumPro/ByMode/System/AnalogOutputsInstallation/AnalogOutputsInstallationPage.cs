using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.AnalogOutputsInstallation
{
    public class AnalogOutputsInstallationPage : IApplicationPage, ITableViewProvider<DeviceInstallationPage<AnalogOutputsInstallationPage>>,ISettingsModalViewProvider<AnalogOutputsInstallationSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<AnalogOutputsInstallationPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Analog Outputs Installation"; }
        }
        public string MenuName
        {
            get { return "Analog Output"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public DeviceInstallationPage<AnalogOutputsInstallationPage> TableView
        {
            get { return _tableView ?? (_tableView = new DeviceInstallationPage<AnalogOutputsInstallationPage>("AnalogOutput_Function")); }
            set { _tableView  = value; }
        }
        private DeviceInstallationPage<AnalogOutputsInstallationPage> _tableView;

        public AnalogOutputsInstallationSettingsPage SettingsView
        {
            get { return _analogOutputsInstallationSettingsPage ?? (_analogOutputsInstallationSettingsPage = new AnalogOutputsInstallationSettingsPage()); }
            set { _analogOutputsInstallationSettingsPage = value; }
        }
        private AnalogOutputsInstallationSettingsPage _analogOutputsInstallationSettingsPage;
    }
}
