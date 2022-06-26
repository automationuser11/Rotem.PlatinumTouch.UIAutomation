using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EggBeltHistory
{
    public class EggBelthistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<EggBelthistoryPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<EggBelthistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Egg Belt Run Time"; }
        }
        public string MenuName
        {
            get { return "Egg Belt"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<EggBelthistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<EggBelthistoryPage>()); }
        }
        private ReadonlyGridTablePage<EggBelthistoryPage> _tableView;
        public void WaitForDataFromController()
        {
            Waits.Wait(60);
        }
    }
}
