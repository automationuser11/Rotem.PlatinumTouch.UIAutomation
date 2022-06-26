using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.PowerConsumptionHistory
{
    public class PowerConsumptionHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<PowerConsumptionHistoryPage>>, IGraphViewProvider<SimpleGraphPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<PowerConsumptionHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Power Consumption"; }
        }
        public string MenuName
        {
            get { return "Power Consumption"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<PowerConsumptionHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<PowerConsumptionHistoryPage>()); }
        }
        private ReadonlyGridTablePage<PowerConsumptionHistoryPage> _tableView;

        public SimpleGraphPage GraphView
        {
            get { return _graphPage ?? (_graphPage = new SimpleGraphPage()); }
        }
        private SimpleGraphPage _graphPage;
    }
}
