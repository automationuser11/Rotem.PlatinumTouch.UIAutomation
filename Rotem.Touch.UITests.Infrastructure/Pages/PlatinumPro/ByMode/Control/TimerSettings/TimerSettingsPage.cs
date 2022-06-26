using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.TimerSettings
{
    public class TimerSettingsPage : IApplicationPage, ITableViewProvider<GridTablePage<TimerSettingsPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUrl ?? (_pageUrl = UrlFactory.GetUrl<TimerSettingsPage>()); }
        }
        private Uri _pageUrl;

        public string Name
        {
            get { return _name; }
        }
        public string MenuName
        {
            get { return "Timer Settings"; }
        }
        public string SubMenu { get { return "Control"; } }
        private string _name = "Timer Settings";

        public Metadata Metadata { get; set; }

        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public GridTablePage<TimerSettingsPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<TimerSettingsPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<TimerSettingsPage> _tableView;
    }
}

