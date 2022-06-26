using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleLayout
{
    public class ScaleLayoutPage : IApplicationPage, ITableViewProvider<DeviceInstallationPage<ScaleLayoutPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<ScaleLayoutPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Scale Layout"; }
        }
        public string MenuName
        {
            get { return "Scale Layout"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public DeviceInstallationPage<ScaleLayoutPage> TableView
        {
            //get { return _tableView ?? (_tableView = new DeviceInstallationPage<ScaleLayoutPage>("ScaleLayout_Device")); }
            get { return _tableView ?? (_tableView = new DeviceInstallationPage<ScaleLayoutPage>()); }
        }
        private DeviceInstallationPage<ScaleLayoutPage> _tableView;
    }
}
