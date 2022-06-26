using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.HumidityTreatment
{
    public class HumidityTreatmentPage : IApplicationPage, ITableViewProvider<GridTablePage<HumidityTreatmentPage>>, ISettingsModalViewProvider<HumidityTreatmentSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<HumidityTreatmentPage>()); }
        }
        private Uri _pageUri;

        public string Name
        {
            get { return "Humidity Treatment"; }
        }
        public string MenuName
        {
            get { return "Humidity Treatment"; }
        }
        public string SubMenu { get { return "Control"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public GridTablePage<HumidityTreatmentPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<HumidityTreatmentPage>()); }
        }
        private GridTablePage<HumidityTreatmentPage> _tableView;

        public HumidityTreatmentSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new HumidityTreatmentSettingsPage());  }
        }
        private HumidityTreatmentSettingsPage _settingsView;
    }
}