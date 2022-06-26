using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.VentCurtSetup
{
    public class VentCurtSetupPage : IApplicationPage, ITableViewProvider<GridTablePage<VentCurtSetupPage>>, ISettingsModalViewProvider<VentCurtSetupCalibrationPage>,  IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<VentCurtSetupPage>()); }
        }
        private Uri _pageUri;


        public string Name
        {
            get { return "Vent/Curt Setup"; }
        }
        public string MenuName
        {
            get { return "Vent/Curt Setup"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public GridTablePage<VentCurtSetupPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<VentCurtSetupPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<VentCurtSetupPage> _tableView;

        public VentCurtSetupCalibrationPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new VentCurtSetupCalibrationPage()); }
        }
        private VentCurtSetupCalibrationPage _settingsView;

        public Metadata Metadata { get; set; }

    }
}
