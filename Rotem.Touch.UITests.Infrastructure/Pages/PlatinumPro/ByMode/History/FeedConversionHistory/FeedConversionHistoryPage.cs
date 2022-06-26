using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.FeedConversionHistory
{
    public class FeedConversionHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<FeedConversionHistoryPage>>, IGraphViewProvider<SimpleGraphPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<FeedConversionHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Feed Conversion History"; }
        }
        public string MenuName
        {
            get { return "Feed Conversion"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }
        
        public ReadonlyGridTablePage<FeedConversionHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<FeedConversionHistoryPage>()); }
        }
        private ReadonlyGridTablePage<FeedConversionHistoryPage> _tableView;
        public SimpleGraphPage GraphView
        {
            get { return _graphPage ?? (_graphPage = new SimpleGraphPage()); }
        }
        private SimpleGraphPage _graphPage;
    }
}
