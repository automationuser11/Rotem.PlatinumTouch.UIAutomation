using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.CoolPad
{
    public class CoolpadPage : IApplicationPage, ITableViewProvider<GridTablePage<CoolpadPage>>, ISettingsModalViewProvider<CoolapdSettingsPage>, IMetadataDependentPageObject, IErrorMessagePage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<CoolpadPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Cool Pad"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public GridTablePage<CoolpadPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<CoolpadPage>()); }
        }
        private GridTablePage<CoolpadPage> _tableView;

        public CoolapdSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new CoolapdSettingsPage()); }
        }
        private CoolapdSettingsPage _settingsView;

        public string ErrorMessage
        {
            get { return PageErrorMessageService.GetDisplayedErrorMessage(); }
        }
        public void ApproveErrorMessage()
        {
            PageErrorMessageService.ApproveErrorMessage();
        }
    }
}
