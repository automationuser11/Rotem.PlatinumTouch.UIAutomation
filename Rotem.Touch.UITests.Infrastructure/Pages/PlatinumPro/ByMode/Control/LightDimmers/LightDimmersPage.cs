using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.LightDimmers
{
    public class LightDimmersPage : IApplicationPage, ITableViewProvider<GridTablePage<LightDimmersPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUrl ?? (_pageUrl = UrlFactory.GetUrl<LightDimmersPage>()); }
        }
        private Uri _pageUrl;

        public string Name
        {
            get { return _name; }
        }
        public string MenuName
        {
            get { return "Light Dimmers"; }
        }
        public string SubMenu { get { return "Control"; } }
        private string _name = "Light Dimmers";

        public Metadata Metadata { get; set; }

        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public GridTablePage<LightDimmersPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<LightDimmersPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<LightDimmersPage> _tableView;
    }
}

