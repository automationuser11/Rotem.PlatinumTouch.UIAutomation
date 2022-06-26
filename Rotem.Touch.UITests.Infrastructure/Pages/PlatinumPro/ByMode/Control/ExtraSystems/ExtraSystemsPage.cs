using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ExtraSystems
{
    public class ExtraSystemsPage : IApplicationPage, ITableViewProvider<GridTablePage<ExtraSystemsPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<ExtraSystemsPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Extra Systems"; }
        }
        public string MenuName
        {
            get { return "Extra Systems"; }
        }
        public string SubMenu { get { return "Control"; } }
        public IEnumerable<string> Titles
        {
            get
            {
                return ApplicationPageService.Titles;
                
            }
        }
        public Metadata Metadata { get; set; }
        public GridTablePage<ExtraSystemsPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<ExtraSystemsPage>()); }
        }
        private GridTablePage<ExtraSystemsPage> _tableView;
    }
}
