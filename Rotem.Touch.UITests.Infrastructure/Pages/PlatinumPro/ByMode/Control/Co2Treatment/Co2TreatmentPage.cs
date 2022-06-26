using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Co2Treatment
{
    public class Co2TreatmentPage :  IApplicationPage, ITableViewProvider<GridTablePage<Co2TreatmentPage>>, ISettingsModalViewProvider<Co2TreatmentSettingsPage>, IMetadataDependentPageObject
    {      
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<Co2TreatmentPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "CO2 Treatment"; }
        }
        public string MenuName { get { return "CO2 Treatment"; } }
        public string SubMenu { get { return "Control"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public GridTablePage<Co2TreatmentPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<Co2TreatmentPage>()); }
            set { _tableView  = value; }
        }
        private GridTablePage<Co2TreatmentPage> _tableView;
        public Co2TreatmentSettingsPage SettingsView
        {
            get { return _co2TreatmentSettingsPage  ?? (_co2TreatmentSettingsPage = new Co2TreatmentSettingsPage()); }
            set { _co2TreatmentSettingsPage  = value; }
        }
        private Co2TreatmentSettingsPage _co2TreatmentSettingsPage;
    }
}
