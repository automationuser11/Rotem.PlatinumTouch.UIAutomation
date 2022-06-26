using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.Humidity
{
    public class HumidityPage : IApplicationPage, ITableViewProvider<GridTablePage<HumidityPage>>, ISettingsModalViewProvider<HumiditySettingsPage>, IMetadataDependentPageObject, IErrorMessagePage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<HumidityPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Humidity Treatment"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public GridTablePage<HumidityPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<HumidityPage>()); }
        }
        private GridTablePage<HumidityPage> _tableView;

        public HumiditySettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new HumiditySettingsPage()); }
        }
        private HumiditySettingsPage _settingsView;

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
