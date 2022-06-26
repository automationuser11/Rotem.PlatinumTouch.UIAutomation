using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.System.TemperatureAndTimer
{
    public class TemperatureAndTimerPage : IApplicationPage, ITableViewProvider<GridTablePage<TemperatureAndTimerPage>>, ISettingsModalViewProvider<TemperatureAndTimerSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<TemperatureAndTimerPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Temperature & Timer Settings"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public Metadata Metadata { get; set; }

        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public GridTablePage<TemperatureAndTimerPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<TemperatureAndTimerPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<TemperatureAndTimerPage> _tableView;

        public TemperatureAndTimerSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new TemperatureAndTimerSettingsPage()); }
        }
        private TemperatureAndTimerSettingsPage _settingsView;
    }
}
