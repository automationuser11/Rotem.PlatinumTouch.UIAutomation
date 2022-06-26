using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.StirFanProgram
{
    public class StirFanProgramPage : IApplicationPage, ISettingsModalViewProvider<StirFanProgramSettingsPage>, ITableViewProvider<GridTablePage<StirFanProgramPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<StirFanProgramPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Stir Fan Program"; }
        }
        public string MenuName
        {
            get { return "Stir Fan Program"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<StirFanProgramPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<StirFanProgramPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<StirFanProgramPage> _tableView;

        public StirFanProgramSettingsPage SettingsView
        {
            get { return _stirFanProgramSettingsPage ?? (_stirFanProgramSettingsPage = new StirFanProgramSettingsPage()); }
            set { _stirFanProgramSettingsPage = value; }
        }
        private StirFanProgramSettingsPage _stirFanProgramSettingsPage;
    }
}
