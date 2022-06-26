using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AnimalInventory
{
    public class AnimalInventoryPage : IApplicationPage, ITableViewProvider<AnimalInventoryTable>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<AnimalInventoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Animal Inventory"; }
        }
        public string MenuName
        {
            get { return "Animal Inventory"; }
        }
        public string SubMenu { get { return "Management"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public AnimalInventoryTable TableView
        {
            get { return _tableView ?? (_tableView = new AnimalInventoryTable()); }
        }
        private AnimalInventoryTable _tableView;
    }
}
