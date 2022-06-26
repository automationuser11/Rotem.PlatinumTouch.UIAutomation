using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleTesting
{
    public class ScaleTestingPage : IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<ScaleTestingPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Scale Testing"; }
        }
        public string MenuName
        {
            get { return "Scale Testing"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<ScaleTestingPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<ScaleTestingPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<ScaleTestingPage> _tableView;
    }
}
