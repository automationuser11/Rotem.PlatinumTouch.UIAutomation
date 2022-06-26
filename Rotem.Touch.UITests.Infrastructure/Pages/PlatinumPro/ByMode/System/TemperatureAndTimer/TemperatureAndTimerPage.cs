using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TemperatureAndTimer
{
    public class TemperatureAndTimerPage : IApplicationPage, ISettingsModalViewProvider<TemperatureAndTimerSettingsPage>, ITableViewProvider<GridTablePage<TemperatureAndTimerPage>>, IMetadataDependentPageObject
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
        public string MenuName
        {
            get { return "Temperature & Timer Settings"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<TemperatureAndTimerPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<TemperatureAndTimerPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<TemperatureAndTimerPage> _tableView;

        public TemperatureAndTimerSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new TemperatureAndTimerSettingsPage()); }
            set { _settingsView = value; }
        }
        private TemperatureAndTimerSettingsPage _settingsView;


    }
}
