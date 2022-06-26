using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.FanAirCapacity
{
    public class FanAirCapacityPage : IApplicationPage, ITableViewProvider<GridTablePage<FanAirCapacityPage>>, IMetadataDependentPageObject, IErrorMessagePage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<FanAirCapacityPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Fan Air Capacity"; }
        }
        public string MenuName
        {
            get { return "Fan Air Capacity"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<FanAirCapacityPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<FanAirCapacityPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<FanAirCapacityPage> _tableView;
        public string ErrorMessage
        {
            get { return PageErrorMessageService.GetDisplayedErrorMessage(); }
        }
        public void ApproveErrorMessage()
        {
            PageErrorMessageService.ApproveErrorMessage();
        }

        public FanAirCapacityPage fanAirCapacityPage
        {
            get { return _fanAirCapacityPage ?? (_fanAirCapacityPage = new FanAirCapacityPage()); }
            set { _fanAirCapacityPage = value; }
        }
        private FanAirCapacityPage _fanAirCapacityPage;



    }
}
