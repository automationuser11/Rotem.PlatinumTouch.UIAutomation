using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HistoryView
{
    public class HistoryViewPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<HistoryViewPage>>, ISettingsModalViewProvider<HistoryViewSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<HistoryViewPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "History View"; }
        }
        public string MenuName
        {
            get { return "History View"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<HistoryViewPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<HistoryViewPage>()); }
        }
        private ReadonlyGridTablePage<HistoryViewPage> _tableView;

        public HistoryViewSettingsPage SettingsView { get
        {
            return _settingsPage ?? (_settingsPage = new HistoryViewSettingsPage());
        }}
        private HistoryViewSettingsPage _settingsPage;
    }
}
