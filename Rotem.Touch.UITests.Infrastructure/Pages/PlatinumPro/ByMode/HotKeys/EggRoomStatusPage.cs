using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class EggRoomStatusPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<EggRoomStatusPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Egg Room Status"; }
        }
        public string MenuName
        {
            get { return "Egg Room Status"; }
        }
        public string SubMenu { get { return "Hot Key"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }


        public ReadonlyGridTablePage<EggRoomStatusPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<EggRoomStatusPage>()); }
        }
        private ReadonlyGridTablePage<EggRoomStatusPage> _tableView;

        public Metadata Metadata { get; set; }

        #region Fields Definition

        #region Group Name: Temperature
        public ReadonlyTextSettingsField Temperature
        {
            get { return _Temperature ?? (_Temperature = new ReadonlyTextSettingsField("Temperature")); }
            set { _Temperature = value; }
        }
        private ReadonlyTextSettingsField _Temperature;

        public ReadonlyTextSettingsField Humidity
        {
            get { return _humidity ?? (_humidity = new ReadonlyTextSettingsField("Humidity")); }
            set { _humidity = value; }
        }
        private ReadonlyTextSettingsField _humidity;

        public ReadonlyTextSettingsField HeatTemp
        {
            get { return _heatTemp ?? (_heatTemp = new ReadonlyTextSettingsField("Heat Temp.")); }
            set { _heatTemp = value; }
        }
        private ReadonlyTextSettingsField _heatTemp;

        public ReadonlyTextSettingsField Fan1Temp
        {
            get { return _fan1Temp ?? (_fan1Temp = new ReadonlyTextSettingsField("Fan 1 Temp")); }
            set { _fan1Temp = value; }
        }
        private ReadonlyTextSettingsField _fan1Temp;
        public ReadonlyTextSettingsField Fan2Temp
        {
            get { return _fan2Temp ?? (_fan2Temp = new ReadonlyTextSettingsField("Fan 2 Temp")); }
            set { _fan2Temp = value; }
        }
        private ReadonlyTextSettingsField _fan2Temp;
        public ReadonlyTextSettingsField CoolingTemp
        {
            get { return _coolingTemp ?? (_coolingTemp = new ReadonlyTextSettingsField("Cooling Temp")); }
            set { _coolingTemp = value; }
        }
        private ReadonlyTextSettingsField _coolingTemp;

        public ReadonlyTextSettingsField HumidifierRH
        {
            get { return _humidifierRH ?? (_humidifierRH = new ReadonlyTextSettingsField("Humidifier %RH")); }
            set { _humidifierRH = value; }
        }
        private ReadonlyTextSettingsField _humidifierRH;

        #endregion


        #endregion
        public enum EggRoomStatusSettings
        {
            [StringValue("Temperature")]
            Temperature,
            [StringValue("Humidity")]
            Humidity,
            [StringValue("Heat Temp.")]
            HeatTemp,
            [StringValue("Fan 1 Temp")]
            Fan1Temp,
            [StringValue("Fan 2 Temp")]
            Fan2Temp,
            [StringValue("Cooling Temp")]
            CoolingTemp,
            [StringValue("Humidifier %RH")]
            HumidifierRH,
        }
    }
}


