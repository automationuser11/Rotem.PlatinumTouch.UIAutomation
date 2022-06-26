using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.MinVentTimer
{
    public class MinVentTimerPage : IApplicationPage, ITableViewProvider<GridTablePage<MinVentTimerPage>>, ISettingsModalViewProvider<MinVentTimerSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUrl ?? (_pageUrl = UrlFactory.GetUrl<MinVentTimerPage>()); }
        }
        private Uri _pageUrl;

        public string Name
        {
            get { return _name; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        private string _name = "Min Vent Tiemr";

        public Metadata Metadata { get; set; }

        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public GridTablePage<MinVentTimerPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<MinVentTimerPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<MinVentTimerPage> _tableView;

        public MinVentTimerSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new MinVentTimerSettingsPage()) ; }
        }
        private MinVentTimerSettingsPage _settingsView;

    }
}

