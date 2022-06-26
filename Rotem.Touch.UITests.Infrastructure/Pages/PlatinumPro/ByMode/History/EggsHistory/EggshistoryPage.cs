using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EggsHistory
{
    public class EggshistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<EggshistoryPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<EggshistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Eggs History"; }
        }
        public string MenuName
        {
            get { return "Eggs"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public ReadonlyGridTablePage<EggshistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<EggshistoryPage>()); }
        }
        private ReadonlyGridTablePage<EggshistoryPage> _tableView;
        public void WaitForDataFromController()
        {
            Waits.Wait(60);
        }
    }
}
