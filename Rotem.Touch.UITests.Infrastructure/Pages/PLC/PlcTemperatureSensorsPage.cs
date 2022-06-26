using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using OpenQA.Selenium;
using System.Linq;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC
{
    public class PlcTemperatureSensorsPage : IPlcApplicationPage
    {
        public Uri PageUrl
        {
            get { return new Uri(string.Format("http://10.16.0.175/001.html")); }
        }
        public string Name
        {
            get { return @"Temperature Sensors"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles
        {
            get { return new List<string>() {"Temperature Sensors"}; }
        }
        public PlcDataField Sensor1Temp
        {
            get { return _sensor1Temp ?? (_sensor1Temp = new PlcDataField("Temp. Sensor 1")); }
            set { _sensor1Temp  = value; }
        }
        private PlcDataField _sensor1Temp;

        public void SetValueToAllSensors(string value)
        {
            var deviceName = "Temp. Sensor";
            DriverManager.Driver.Navigate().GoToUrl(PageUrl.ToString());
            var sensorList = new List<PlcDataField>();
            var devices = DriverManager.Driver.FindElements(By.XPath(string.Format("//label[contains(text(), '{0}')]", deviceName)));
            for (var i = 0; i < devices.Count(); i++)
                sensorList.Add(new PlcDataField(string.Format("Temp. Sensor {0}", i + 1)));

            foreach (var sensor in sensorList)
            {
                if (sensor.CurrentValue != value)
                    sensor.SetValue(value);                
            }
        }
        public void SetValueToSpecificSensor(string value, int sensorNumber)
        {
            DriverManager.Driver.Navigate().GoToUrl(PageUrl.ToString());
            var sensorToEdit = new PlcDataField(string.Format("Temp. Sensor {0}", sensorNumber));
            sensorToEdit.SetValue(value);
        }
    }
}
