using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.WaterOnDemand
{
    public class WaterOnDemandPage : IApplicationPage, ITableViewProvider<GridTablePage<WaterOnDemandPage>>, ISettingsModalViewProvider<WaterOnDemandSettingsPage>, IMetadataDependentPageObject, IErrorMessagePage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<WaterOnDemandPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Water On Demand"; }
        }
        public string MenuName
        {
            get { return "Water On Demand"; }
        }
        public string SubMenu { get { return "Management"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<WaterOnDemandPage> TableView
        {
            get { return _tableView  ?? (_tableView = new GridTablePage<WaterOnDemandPage>()); }
            set { _tableView  = value; }
        }
        private GridTablePage<WaterOnDemandPage> _tableView;
        public WaterOnDemandSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new WaterOnDemandSettingsPage()); }
        }
        private WaterOnDemandSettingsPage _settingsView;
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
