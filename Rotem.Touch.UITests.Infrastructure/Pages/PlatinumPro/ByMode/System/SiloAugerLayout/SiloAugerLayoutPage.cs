using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.SiloAugerLayout
{
    public class SiloAugerLayoutPage : IApplicationPage, ITableViewProvider<GridTablePage<SiloAugerLayoutPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<SiloAugerLayoutPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Silo/Auger Layout"; }
        }
        public string MenuName
        {
            get { return "Silo/Auger Layout"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<SiloAugerLayoutPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<SiloAugerLayoutPage>()); }
        }
        private GridTablePage<SiloAugerLayoutPage> _tableView;
    }
}
