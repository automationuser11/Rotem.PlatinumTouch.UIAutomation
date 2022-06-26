using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.BirdWeight
{
    public class BirdWeightPage : IApplicationPage, ITableViewProvider<BirdWeightTable>, ISettingsModalViewProvider<BirdWeightSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<BirdWeightPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Bird Weight"; }
        }
        public string MenuName
        {
            get { return "Bird Weight"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public BirdWeightSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new BirdWeightSettingsPage()); }
        }
        private BirdWeightSettingsPage _settingsPage;

        public BirdWeightTable TableView
        {
            get { return _tableView ?? (_tableView = new BirdWeightTable()); }
        }
        private BirdWeightTable _tableView;
    }
}
