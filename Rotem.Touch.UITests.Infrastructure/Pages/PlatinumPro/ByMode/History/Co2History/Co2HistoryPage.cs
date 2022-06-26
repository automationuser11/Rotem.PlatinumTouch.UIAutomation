using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.Co2History
{
    public class Co2HistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<Co2HistoryPage>>, IGraphViewProvider<SimpleGraphPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<Co2HistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "CO2 History"; }
        }
        public string MenuName
        {
            get { return "CO2"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<Co2HistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<Co2HistoryPage>()); }
        }
        private ReadonlyGridTablePage<Co2HistoryPage> _tableView;
        public SimpleGraphPage GraphView
        {
            get { return _graphPage ?? (_graphPage = new SimpleGraphPage()); }
        }
        private SimpleGraphPage _graphPage;
    }
}
