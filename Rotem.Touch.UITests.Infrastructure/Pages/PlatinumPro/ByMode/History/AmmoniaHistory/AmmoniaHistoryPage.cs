using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.AmmoniaHistory
{
    public class AmmoniaHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<AmmoniaHistoryPage>>, IGraphViewProvider<SimpleGraphPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<AmmoniaHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Ammonia History"; }
        }
        public string MenuName
        {
            get { return "Ammonia"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<AmmoniaHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<AmmoniaHistoryPage>()); }
        }
        private ReadonlyGridTablePage<AmmoniaHistoryPage> _tableView;
        public SimpleGraphPage GraphView
        {
            get { return _graphPage ?? (_graphPage = new SimpleGraphPage()); }
        }
        private SimpleGraphPage _graphPage;
    }
}
