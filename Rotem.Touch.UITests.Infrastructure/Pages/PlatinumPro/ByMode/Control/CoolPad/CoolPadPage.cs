using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.CoolPad
{
    public class CoolPadPage : IApplicationPage, ITableViewProvider<GridTablePage<CoolPadPage>>, ISettingsModalViewProvider<CoolPadSettingsPage>, IMetadataDependentPageObject, IErrorMessagePage
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<CoolPadPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Cool Pad"; }
        }
        public string MenuName
        {
            get { return "Cool Pad"; }
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

        public GridTablePage<CoolPadPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<CoolPadPage>()); }
        }
        private GridTablePage<CoolPadPage> _tableView;

        public CoolPadSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new CoolPadSettingsPage()); }
        }
        private CoolPadSettingsPage _settingsView;
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
