using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.System.VariableSpeedFansSetting
{
    public class VariableSpeedFansSettingPage : IApplicationPage, ITableViewProvider<GridTablePage<VariableSpeedFansSettingPage>>, ISettingsModalViewProvider<VariableSpeedFansSettingSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<VariableSpeedFansSettingPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Variable Speed Fans Setting"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public GridTablePage<VariableSpeedFansSettingPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<VariableSpeedFansSettingPage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<VariableSpeedFansSettingPage> _tableView;

        public VariableSpeedFansSettingSettingsPage SettingsView
        {
            get { return _temperatureCurveSettingsPage ?? (_temperatureCurveSettingsPage = new VariableSpeedFansSettingSettingsPage()); }
            set { _temperatureCurveSettingsPage = value; }
        }
        private VariableSpeedFansSettingSettingsPage _temperatureCurveSettingsPage;
    }
}
