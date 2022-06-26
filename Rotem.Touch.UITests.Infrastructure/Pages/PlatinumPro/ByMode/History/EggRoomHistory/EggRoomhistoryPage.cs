using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EggRoomHistory
{
    public class EggRoomhistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<EggRoomhistoryPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<EggRoomhistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Egg Room"; }
        }
        public string MenuName
        {
            get { return "Egg Room"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<EggRoomhistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<EggRoomhistoryPage>()); }
        }
        private ReadonlyGridTablePage<EggRoomhistoryPage> _tableView;
        public void WaitForDataFromController()
        {
            Waits.Wait(60);
        }
    }
}
