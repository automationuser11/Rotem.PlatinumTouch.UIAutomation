using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.EggRoomControl
{
    public class EggRoomControlPage : SimpleSettingsPage, IApplicationPage, ISettingsModalViewProvider<EggRoomControlSettingsPage>, IMetadataDependentPageObject
    {
        #region Elements Mapping

        internal IWebElement EggRoomControlPageTable
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div[class='setting-control EggRoom col-xs-12']"));
            }
        }
        #endregion

        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<EggRoomControlPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Egg Room Control"; }
        }
        public string MenuName
        {
            get { return "Egg Room Control"; }
        }
        public string SubMenu { get { return "Control"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get
            {
                return ApplicationPageService.Titles;
            }
        }
        public EggRoomControlSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new EggRoomControlSettingsPage()); }
        }
        private EggRoomControlSettingsPage _settingsPage;

        #region Building Blocks Validation

        public bool IsEggRoomControlTableExists()
        {
            return DriverManager.Driver.IsElementExists(() => EggRoomControlPageTable);
        }

        #endregion

        #region Group Name: Egg Room Control

        public KeyPadSettingsField HeaterTempOn
        {
            get { return _heaterTempOn ?? (_heaterTempOn = new KeyPadSettingsField() { Name = "Heater (Temp) On", InputMethod = new PointNumericKeyPad() }); }
            set { _heaterTempOn = value; }
        }
        private KeyPadSettingsField _heaterTempOn;

        public KeyPadSettingsField Fan1TempOn
        {
            get { return _fan1TempOn ?? (_fan1TempOn = new KeyPadSettingsField() { Name = "Fan 1 (Temp) On", InputMethod = new PointNumericKeyPad() }); }
            set { _fan1TempOn = value; }
        }
        private KeyPadSettingsField _fan1TempOn;

        public KeyPadSettingsField Fan2TempOn
        {
            get { return _fan2TempOn ?? (_fan2TempOn = new KeyPadSettingsField() { Name = "Fan 2 (Temp) On", InputMethod = new PointNumericKeyPad() }); }
            set { _fan2TempOn = value; }
        }
        private KeyPadSettingsField _fan2TempOn;

        public KeyPadSettingsField CoolingTempOn
        {
            get { return _coolingTempOn ?? (_coolingTempOn = new KeyPadSettingsField() { Name = "Cooling (Temp) On", InputMethod = new PointNumericKeyPad() }); }
            set { _coolingTempOn = value; }
        }
        private KeyPadSettingsField _coolingTempOn;

        public KeyPadSettingsField HumidifierrhOn
        {
            get { return _humidifierrhOn ?? (_humidifierrhOn = new KeyPadSettingsField() { Name = "Humidifier (%rh) On", InputMethod = new PointNumericKeyPad() }); }
            set { _humidifierrhOn = value; }
        }
        private KeyPadSettingsField _humidifierrhOn;

        public KeyPadSettingsField HeaterTempOff
        {
            get { return _heaterTempOff ?? (_heaterTempOff = new KeyPadSettingsField() { Name = "Heater (Temp) Off", InputMethod = new PointNumericKeyPad() }); }
            set { _heaterTempOff = value; }
        }
        private KeyPadSettingsField _heaterTempOff;

        public KeyPadSettingsField Fan1TempOff
        {
            get { return _fan1TempOff ?? (_fan1TempOff = new KeyPadSettingsField() { Name = "Fan 1 (Temp) Off", InputMethod = new PointNumericKeyPad() }); }
            set { _fan1TempOff = value; }
        }
        private KeyPadSettingsField _fan1TempOff;

        public KeyPadSettingsField Fan2TempOff
        {
            get { return _fan2TempOff ?? (_fan2TempOff = new KeyPadSettingsField() { Name = "Fan 2 (Temp) Off", InputMethod = new PointNumericKeyPad() }); }
            set { _fan2TempOff = value; }
        }
        private KeyPadSettingsField _fan2TempOff;

        public KeyPadSettingsField CoolingTempOff
        {
            get { return _coolingTempOff ?? (_coolingTempOff = new KeyPadSettingsField() { Name = "Cooling (Temp) Off", InputMethod = new PointNumericKeyPad() }); }
            set { _coolingTempOff = value; }
        }
        private KeyPadSettingsField _coolingTempOff;

        public KeyPadSettingsField HumidifierrhOff
        {
            get { return _humidifierrhOff ?? (_humidifierrhOff = new KeyPadSettingsField() { Name = "Humidifier (%rh) Off", InputMethod = new PointNumericKeyPad() }); }
            set { _humidifierrhOff = value; }
        }
        private KeyPadSettingsField _humidifierrhOff;

        #endregion
    }
}
