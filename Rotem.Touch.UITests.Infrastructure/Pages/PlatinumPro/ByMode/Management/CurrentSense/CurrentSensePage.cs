using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.CurrentSense
{   
    public class CurrentSensePage : ISettingsModalViewProvider<CurrentSenseTable>, IApplicationPage, ITableViewProvider<DeviceInstallationPage<CurrentSensePage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<CurrentSensePage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Current Sense Installation"; }
        }
        public string MenuName
        {
            get { return "Current Sense"; }
        }
        public string SubMenu { get { return "Management"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        //public CurrentSenseTable TableView
        //{
        //    get { return _tableView ?? (_tableView = new CurrentSenseTable()); }
        //}
        //private CurrentSenseTable _tableView;

        //Ben added



        public DeviceInstallationPage<CurrentSensePage> TableView
        {
            get { return _tableView ?? (_tableView = new DeviceInstallationPage<CurrentSensePage>("RelayLayout_Device")); }
        }
        private DeviceInstallationPage<CurrentSensePage> _tableView;

        public CurrentSenseTable SettingsView
        {
            get { return _currentSenseTablePage ?? (_currentSenseTablePage = new CurrentSenseTable()); }
            set { _currentSenseTablePage = value; }
        }
        private CurrentSenseTable _currentSenseTablePage;




        public KeyPadSettingsField Min
        {
            get { return _min ?? (_min = new KeyPadSettingsField() { Name = "Min", InputMethod = new PointNumericKeyPad() }); }
            set { _min = value; }
        }
        private KeyPadSettingsField _min;

        public KeyPadSettingsField Nominal
        {
            get { return _nominal ?? (_nominal = new KeyPadSettingsField() { Name = "Nominal", InputMethod = new PointNumericKeyPad() }); }
            set { _nominal = value; }
        }
        private KeyPadSettingsField _nominal;

        public KeyPadSettingsField Max
        {
            get { return _max ?? (_max = new KeyPadSettingsField() { Name = "Maximum", InputMethod = new PointNumericKeyPad() }); }
            set { _max = value; }
        }
        private KeyPadSettingsField _max;

        public ToggleButtonSettingsField Volt
        {
            get { return _volt ?? (_volt = new ToggleButtonSettingsField("Volt")); }
            set { _volt = value; }
        }
        private ToggleButtonSettingsField _volt;

        public ComboboxSettingsField Alarm
        {
            get { return new ComboboxSettingsField("Alarm"); }
            set { _alarm = value; }
        }
        private ComboboxSettingsField _alarm;
    }
}
