using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.NippleFlushing
{
    public class NippleFlushingPage : SimpleTabsPage, IMetadataDependentPageObject
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<NippleFlushingPage>()); }
        }
        private Uri _pageUri;
        public override string Name
        {
            get { return "Nipple Flushing"; }
        }
        public override string MenuName
        {
            get { return "Nipple Flushing"; }
        }
        public override string SubMenu { get { return "Management"; } }

        public ScheduleTabPage ScheduleTab
        {
            get { return _scheduleTabPage ?? (_scheduleTabPage = new ScheduleTabPage()); }
            set { _scheduleTabPage = value; }
        }
        private ScheduleTabPage _scheduleTabPage;
        public OrderTabPage OrderTab
        {
            get { return _orderTabPage ?? (_orderTabPage = new OrderTabPage()); }
            set { _orderTabPage = value; }
        }
        private OrderTabPage _orderTabPage;

        public Metadata Metadata { get; set; }
    }
}
