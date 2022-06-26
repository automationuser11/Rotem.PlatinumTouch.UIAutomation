using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HumidityHistory
{
    public class HumidityHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<HumidityHistoryPage>>, IGraphViewProvider<SimpleGraphPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<HumidityHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Humidity History"; }
        }
        public string MenuName
        {
            get { return "Humidity"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<HumidityHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<HumidityHistoryPage>()); }
        }
        private ReadonlyGridTablePage<HumidityHistoryPage> _tableView;
        public SimpleGraphPage GraphView
        {
            get { return _graphPage ?? (_graphPage = new SimpleGraphPage()); }
        }
        private SimpleGraphPage _graphPage;
    }
}
