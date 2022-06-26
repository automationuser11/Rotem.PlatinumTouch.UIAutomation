using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class NaturalVentilationPageHotkey : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<NaturalVentilationPageHotkey>()); }
        }
        private Uri _pageUri;

        public string Name
        {
            get { return "Natural Ventilation"; }
        }
        public string MenuName
        {
            get { return "Natural Ventilation"; }
        }
        public string SubMenu { get { return "Hot Key"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        #region Fields Definition

        #region Group Name: Wind Speed

        public ReadonlyTextSettingsField WindSpeed
        {
            get { return _windSpeed ?? (_windSpeed = new ReadonlyTextSettingsField("Wind Speed")); }
            set { _windSpeed = value; }
        }
        private ReadonlyTextSettingsField _windSpeed;

        #endregion

        #region Group Name: Wind Direction

        public ReadonlyTextSettingsField WindDirection
        {
            get { return _windDirection ?? (_windDirection = new ReadonlyTextSettingsField("Wind Direction")); }
            set { _windDirection = value; }
        }
        private ReadonlyTextSettingsField _windDirection;

        #endregion

        #region Group Name: Out Temperature

        public ReadonlyTextSettingsField OutTemperature
        {
            get { return _outTemperature ?? (_outTemperature = new ReadonlyTextSettingsField("Out Temp.")); }
            set { _outTemperature = value; }
        }
        private ReadonlyTextSettingsField _outTemperature;

        #endregion

        #region Group Name: Average Temperature

        public ReadonlyTextSettingsField AverageTemperature 
        {
            get { return _averageTemperature ?? (_averageTemperature = new ReadonlyTextSettingsField("Avg Temp.")); }
            set { _averageTemperature = value; }
        }
        private ReadonlyTextSettingsField _averageTemperature;

        #endregion

        #region Group Name: Target Temperature

        public ReadonlyTextSettingsField TargetTemperature
        {
            get { return _targetTemperature ?? (_targetTemperature = new ReadonlyTextSettingsField("Target Temp.")); }
            set { _targetTemperature = value; }
        }
        private ReadonlyTextSettingsField _targetTemperature;

        #endregion

        #region Group Name: Rain

        public ReadonlyTextSettingsField Rain
        {
            get { return _rain ?? (_rain = new ReadonlyTextSettingsField("Rain")); }
            set { _rain = value; }
        }
        private ReadonlyTextSettingsField _rain;

        #endregion

        #region Group Name: Humidity In

        public ReadonlyTextSettingsField HumidityIn
        {
            get { return _humidityIn ?? (_humidityIn = new ReadonlyTextSettingsField("Humidity In")); }
            set { _humidityIn = value; }
        }
        private ReadonlyTextSettingsField _humidityIn;

        #endregion

        #region Group Name: Humidity Out

        public ReadonlyTextSettingsField HumidityOut
        {
            get { return _humidityOut ?? (_humidityOut = new ReadonlyTextSettingsField("Humidity Out")); }
            set { _humidityOut = value; }
        }
        private ReadonlyTextSettingsField _humidityOut;

        #endregion

        #region Group Name: Between Growth Days

        public ReadonlyTextSettingsField BetweenGrowthDays
        {
            get { return _betweenGrowthDays ?? (_betweenGrowthDays = new ReadonlyTextSettingsField("Between Growth Days")); }
            set { _betweenGrowthDays = value; }
        }
        private ReadonlyTextSettingsField _betweenGrowthDays;

        #endregion

        #region Group Name: Time Frame

        public ReadonlyTextSettingsField TimeFrame
        {
            get { return _timeFrame ?? (_timeFrame = new ReadonlyTextSettingsField("Time Frame")); }
            set { _timeFrame = value; }
        }
        private ReadonlyTextSettingsField _timeFrame;

        #endregion

        #region Group Name: Inside Temperature From

        public ReadonlyTextSettingsField InsideTemperatureFrom
        {
            get { return _insideTempFrom ?? (_insideTempFrom = new ReadonlyTextSettingsField("Inside Temp From")); }
            set { _insideTempFrom = value; }
        }
        private ReadonlyTextSettingsField _insideTempFrom;

        #endregion

        #region Group Name: Inside Temperature To

        public ReadonlyTextSettingsField InsideTemperatureTo
        {
            get { return _insideTempTo ?? (_insideTempTo = new ReadonlyTextSettingsField("Inside Temp To")); }
            set { _insideTempTo = value; }
        }
        private ReadonlyTextSettingsField _insideTempTo;


        #endregion

        #region Group Name: Outside Temperature From

        public ReadonlyTextSettingsField OutsideTemperatureFrom
        {
            get { return _outsideTemperatureFrom ?? (_outsideTemperatureFrom = new ReadonlyTextSettingsField("Outside Temp From")); }
            set { _outsideTemperatureFrom = value; }
        }
        private ReadonlyTextSettingsField _outsideTemperatureFrom;

        #endregion

        #region Group Name: Outside Temperature To

        public ReadonlyTextSettingsField OutsideTemperatureTo
        {
            get { return _outsideTemperatureTo ?? (_outsideTemperatureTo = new ReadonlyTextSettingsField("Outside Temp To")); }
            set { _outsideTemperatureTo = value; }
        }
        private ReadonlyTextSettingsField _outsideTemperatureTo;

        #endregion

        #region Group Name: Wind Speed From

        public ReadonlyTextSettingsField WindSpeedFrom
        {
            get { return _windSpeedFrom ?? (_windSpeedFrom = new ReadonlyTextSettingsField("Wind Speed From")); }
            set { _windSpeedFrom = value; }
        }
        private ReadonlyTextSettingsField _windSpeedFrom;

        #endregion

        #region Group Name: Wind Speed To

        public ReadonlyTextSettingsField WindSpeedTo
        {
            get { return _windSpeedTo ?? (_windSpeedTo = new ReadonlyTextSettingsField("Wind Speed To")); }
            set { _windSpeedTo = value; }
        }
        private ReadonlyTextSettingsField _windSpeedTo;

        #endregion
        #endregion
        public enum NaturalVentilationHotkeySettings
        {
            [StringValue("Wind Direction")]
            WindDirection,
            [StringValue("Wind Speed")]
            WindSpeed,
            [StringValue("Out Temp.")]
            OutTemperature,
            [StringValue("Avg Temp.")]
            AverageTemperature,
            [StringValue("Target Temp.")]
            TargetTemperature,
            [StringValue("Rain")]
            Rain,
            [StringValue("Humidity In")]
            HumidityIn,
            [StringValue("Humidity Out")]
            HumidityOut,
            [StringValue("Between Growth Days")]
            BetweenGrowthDays,
            [StringValue("Time Frame")]
            TimeFrame,
            [StringValue("Inside Temp From")]
            InsideTemperatureFrom,
            [StringValue("Inside Temp To")]
            InsideTemperatureTo,
            [StringValue("Outside Temp From")]
            OutsideTemperatureFrom,
            [StringValue("Outside Temp To")]
            OutsideTemperatureTo,
        }
        public Metadata Metadata { get; set; }
        public PageInitialSetup<NaturalVentilationPageHotkey> PageInitialSetup { get; set; }
    }
}
