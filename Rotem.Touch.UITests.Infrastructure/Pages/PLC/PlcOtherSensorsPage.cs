using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC
{
    public class PlcOtherSensorsPage : IPlcApplicationPage
    {
        public Uri PageUrl
        {
            get { return new Uri(string.Format("http://10.16.0.175/002.html")); }
        }
        public string Name
        {
            get { return @"Other Sensors"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles
        {
            get { return new List<string>() { "Other Sensors" }; }
        }
        public PlcDataField HumidityInSensor1
        {
            get { return _plcDataField  ?? (_plcDataField = new PlcDataField("Humidity In 1")); }
            set { _plcDataField  = value; }
        }
        private PlcDataField _plcDataField;
        public PlcDataField HumidityOutSensor1
        {
            get { return _humidityOutSensor1 ?? (_humidityOutSensor1 = new PlcDataField("Humidity Out 1")); }
            set { _humidityOutSensor1 = value; }
        }
        private PlcDataField _humidityOutSensor1;
        public void SetHumidityInSensor1(string value)
        {
            DriverManager.Driver.Navigate().GoToUrl(PageUrl.ToString());
            if (HumidityInSensor1.CurrentValue != value)
                HumidityInSensor1.SetValue(value);
        }
        public void SetHumidityOutSensor1(string value)
        {
            DriverManager.Driver.Navigate().GoToUrl(PageUrl.ToString());
            if (HumidityOutSensor1.CurrentValue != value)
                HumidityOutSensor1.SetValue(value);
        }
    }
}
