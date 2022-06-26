using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.AmmoniaTreatment
{
    public class AmmoniaTreatmentPage : IApplicationPage, ITableViewProvider<GridTablePage<AmmoniaTreatmentPage>>, ISettingsModalViewProvider<AmmoniaTreatmentSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<AmmoniaTreatmentPage>()); }
        }
        private Uri _pageUri;

        public string Name
        {
            get { return "Ammonia Treatment"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public GridTablePage<AmmoniaTreatmentPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<AmmoniaTreatmentPage>()); }
        }
        private GridTablePage<AmmoniaTreatmentPage> _tableView;

        public AmmoniaTreatmentSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new AmmoniaTreatmentSettingsPage());  }
        }
        private AmmoniaTreatmentSettingsPage _settingsView;
    }
}