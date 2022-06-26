using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.BirdInventory
{
    public class BirdInventoryPage : IApplicationPage, ITableViewProvider<BirdInventoryTable>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<BirdInventoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Bird Inventory"; }
        }
        public string MenuName
        {
            get { return "Bird Inventory"; }
        }
        public string SubMenu { get { return "Management"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public BirdInventoryTable TableView
        {
            get { return _tableView ?? (_tableView = new BirdInventoryTable()); }
        }
        private BirdInventoryTable _tableView;
    }
}
