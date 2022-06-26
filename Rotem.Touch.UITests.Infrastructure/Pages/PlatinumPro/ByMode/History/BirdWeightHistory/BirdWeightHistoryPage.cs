using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.BirdWeightHistory
{
    public class BirdWeightHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<BirdWeightHistoryPage>>, IGraphViewProvider<SimpleGraphPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<BirdWeightHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Bird Weight History"; }
        }
        public string MenuName
        {
            get { return "Bird Weight"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public SimpleGraphPage GraphView
        {
            get { return _graphPage ?? (_graphPage = new SimpleGraphPage()); }
        }
        private SimpleGraphPage _graphPage;
        public ReadonlyGridTablePage<BirdWeightHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<BirdWeightHistoryPage>()); }
        }
        private ReadonlyGridTablePage<BirdWeightHistoryPage> _tableView;
    }
}
