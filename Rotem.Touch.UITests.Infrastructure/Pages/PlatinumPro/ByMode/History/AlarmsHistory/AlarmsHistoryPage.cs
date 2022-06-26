using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.AlarmsHistory
{
    public class AlarmsHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<AlarmsHistoryPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<AlarmsHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Alarms History"; }
        }
        public string MenuName
        {
            get { return "Alarms"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<AlarmsHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<AlarmsHistoryPage>()); }
        }
        private ReadonlyGridTablePage<AlarmsHistoryPage> _tableView;
        public void WaitForDataFromController()
        {
            Waits.Wait(60);
        }
    }
}
