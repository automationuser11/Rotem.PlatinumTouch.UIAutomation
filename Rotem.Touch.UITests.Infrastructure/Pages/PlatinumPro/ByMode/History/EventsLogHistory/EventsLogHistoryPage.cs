using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EventsLogHistory
{
    public class EventsLogHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<EventsLogHistoryPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<EventsLogHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Table of Events"; }
        }
        public string MenuName
        {
            get { return "Table Of Events"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<EventsLogHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<EventsLogHistoryPage>()); }
        }
        private ReadonlyGridTablePage<EventsLogHistoryPage> _tableView;
    }
}
