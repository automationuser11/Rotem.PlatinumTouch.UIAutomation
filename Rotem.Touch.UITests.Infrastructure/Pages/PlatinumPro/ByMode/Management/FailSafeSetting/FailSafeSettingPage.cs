using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FailSafeSetting
{
    public class FailSafeSettingPage : SimpleSettingsPage ,IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<FailSafeSettingPage>()); }
        }
        private Uri _pageUri;

        public string Name
        {
            get { return "Fail Safe Settings"; }
        }
        public string MenuName
        {
            get { return "Fail Safe Settings"; }
        }
        public string SubMenu { get { return "Management"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public ToggleButtonSettingsField HighTemperature
        {
            get { return _highTemperature ?? (_highTemperature = new ToggleButtonSettingsField("High Temperature")); }
            set { _highTemperature = value; }
        }
        private ToggleButtonSettingsField _highTemperature;
        public ToggleButtonSettingsField LowTemperature
        {
            get { return _lowTemperature ?? (_lowTemperature = new ToggleButtonSettingsField("Low Temperature")); }
            set { _lowTemperature = value; }
        }
        private ToggleButtonSettingsField _lowTemperature;
        public ToggleButtonSettingsField HighStaticPressure
        {
            get { return _highStaticPressure ?? (_highStaticPressure = new ToggleButtonSettingsField("High S.Pressure")); }
            set { _highStaticPressure = value; }
        }
        private ToggleButtonSettingsField _highStaticPressure;
        public ToggleButtonSettingsField LowStaticPressure
        {
            get { return _lowStaticPressure ?? (_lowStaticPressure = new ToggleButtonSettingsField("Low S.Pressure")); }
            set { _lowStaticPressure = value; }
        }
        private ToggleButtonSettingsField _lowStaticPressure;
        public ToggleButtonSettingsField AvgTemperatureFail
        {
            get { return _avgTemperatureFail ?? (_avgTemperatureFail = new ToggleButtonSettingsField("Avg Temperature Fail")); }
            set { _avgTemperatureFail = value; }
        }
        private ToggleButtonSettingsField _avgTemperatureFail;
        public ToggleButtonSettingsField Auxiliary
        {
            get { return _auxiliary ?? (_auxiliary = new ToggleButtonSettingsField("Auxiliary (Dry Contact)")); }
            set { _auxiliary = value; }
        }
        private ToggleButtonSettingsField _auxiliary;
    }
}
