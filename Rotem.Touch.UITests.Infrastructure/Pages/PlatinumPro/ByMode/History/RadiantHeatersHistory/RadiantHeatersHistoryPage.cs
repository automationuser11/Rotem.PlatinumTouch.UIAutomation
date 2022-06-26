using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.RadiantHeatersHistory
{
    public class RadiantHeatersHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<RadiantHeatersHistoryPage>>, IGraphViewProvider<SimpleGraphPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<RadiantHeatersHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Radiant Heaters History"; }
        }
        public string MenuName
        {
            get { return "Radiant Heaters"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<RadiantHeatersHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<RadiantHeatersHistoryPage>()); }
        }
        private ReadonlyGridTablePage<RadiantHeatersHistoryPage> _tableView;
        public SimpleGraphPage GraphView
        {
            get { return _graphPage ?? (_graphPage = new SimpleGraphPage()); }
        }
        private SimpleGraphPage _graphPage;
    }
}
