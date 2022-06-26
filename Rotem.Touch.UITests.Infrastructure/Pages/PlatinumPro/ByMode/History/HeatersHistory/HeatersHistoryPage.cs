using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HeatersHistory
{
    public class HeatersHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<HeatersHistoryPage>>, IGraphViewProvider<SimpleGraphPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<HeatersHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Heaters History"; }
        }
        public string MenuName
        {
            get { return "Heaters"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<HeatersHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<HeatersHistoryPage>()); }
        }
        private ReadonlyGridTablePage<HeatersHistoryPage> _tableView;
        public SimpleGraphPage GraphView
        {
            get { return _graphPage ?? (_graphPage = new SimpleGraphPage()); }
        }
        private SimpleGraphPage _graphPage;
    }
}
