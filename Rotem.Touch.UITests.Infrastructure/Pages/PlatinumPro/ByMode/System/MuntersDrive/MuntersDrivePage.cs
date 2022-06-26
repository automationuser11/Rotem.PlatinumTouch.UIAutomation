using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.MuntersDrive
{
    public class MuntersDrivePage : IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<MuntersDrivePage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Munters Drive"; }
        }
        public string MenuName
        {
            get { return "Munters Drive"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public GridTablePage<MuntersDrivePage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<MuntersDrivePage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<MuntersDrivePage> _tableView;

        #region Fields

        public ComboboxSettingsField ExhTun
        {
            get { return _exhTun ?? (_exhTun = new ComboboxSettingsField("Exh/Tun")); }
            set { _exhTun = value; }
        }
        private ComboboxSettingsField _exhTun;

        public ComboboxSettingsField Type
        {
            get { return _type ?? (_type = new ComboboxSettingsField("Type")); }
            set { _type = value; }
        }
        private ComboboxSettingsField _type;

        public KeyPadSettingsField FanNo
        {
            get { return _fanNo ?? (_fanNo = new KeyPadSettingsField() { Name = "Uniformity Range (5-30%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _fanNo = value; }
        }
        private KeyPadSettingsField _fanNo;


        #endregion 
    }
}
