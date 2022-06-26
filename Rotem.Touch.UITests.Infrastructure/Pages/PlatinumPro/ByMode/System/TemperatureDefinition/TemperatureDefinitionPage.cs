using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TemperatureDefinition
{
    public class TemperatureDefinitionPage : IApplicationPage, ITableViewProvider<GridTablePage<TemperatureDefinitionPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<TemperatureDefinitionPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Temperature Definition"; }
        }
        public string MenuName
        {
            get { return "Temperature Definition"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<TemperatureDefinitionPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<TemperatureDefinitionPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<TemperatureDefinitionPage> _tableView;
    }
}
