using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.Version
{
    public class VersionPage : IApplicationPage, ITableViewProvider<VersionTable>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<VersionPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Version"; }
        }
        public string MenuName
        {
            get { return "Version"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public VersionTable TableView
        {
            get { return _tableView ?? (_tableView = new VersionTable()); }
        }
        private VersionTable _tableView;
    }

}
