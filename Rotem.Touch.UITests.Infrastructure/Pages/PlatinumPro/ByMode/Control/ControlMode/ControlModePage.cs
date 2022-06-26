using System;
using System.Collections.Generic;
using System.Linq;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ControlMode
{
    public class ControlModePage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<ControlModePage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Control Mode"; }
        }
        public string SubMenu { get { return "Control"; } }
        public string MenuName { get { return "Control Mode"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public virtual KeyPadSettingsField this[ControlModeSettings filed]
        {
            get
            {
                var settingsFields = GetType().GetProperties().Where(p => p.PropertyType == typeof(KeyPadSettingsField) || p.PropertyType.IsSubclassOf(typeof(KeyPadSettingsField)) || p.PropertyType.IsAssignableFrom(typeof(KeyPadSettingsField)));

                foreach (var settingsField in settingsFields)
                {
                    var filedProp = settingsField.GetValue(this, null);
                    var name = filedProp.GetType().GetProperty("Name");

                    if (name.GetValue(filedProp, null).ToString() == StringEnum.GetStringValue(filed))
                        return filedProp as KeyPadSettingsField;

                }

                return new KeyPadSettingsField();
            }
        }

        public ComboboxSettingsField HouseMode
        {
            get { return _houseMode ?? (_houseMode = new ComboboxSettingsField("House Mode")); }
            set { _houseMode = value; }
        }
        private ComboboxSettingsField _houseMode;

        public ToggleButtonSettingsField EmptyHouseMode
        {
            get { return _emptyHouseMode ?? (_emptyHouseMode = new ToggleButtonSettingsField("Empty House Mode")); }
            set { _emptyHouseMode = value; }
        }
        private ToggleButtonSettingsField _emptyHouseMode;

        public ToggleButtonSettingsField TemperatureCurve
        {
            get { return _temperatureCurve ?? (_temperatureCurve = new ToggleButtonSettingsField("Temperature Curve")); }
            set { _temperatureCurve = value; }
        }
        private ToggleButtonSettingsField _temperatureCurve;

        public ComboboxSettingsField MinMaxLevelControl
        {
            get { return new ComboboxSettingsField(@"Min Max Levels Control"); }
            set { _minMaxLevelControl = value; }
        }
        private ComboboxSettingsField _minMaxLevelControl;

        public ToggleButtonSettingsField HeatCycle
        {
            get { return _heatCycle ?? (_heatCycle = new ToggleButtonSettingsField("Heat Cycle")); }
            set { _heatCycle = value; }
        }
        private ToggleButtonSettingsField _heatCycle;

        public ComboboxSettingsField AnalogHeatMode
        {
            get { return _analogHeatMode ?? (_analogHeatMode = new ComboboxSettingsField("Analog Heat Mode")); }
            set { _analogHeatMode = value; }
        }
        private ComboboxSettingsField _analogHeatMode;
        
        public ToggleButtonSettingsField MinVentCurve
        {
            get { return _minVentCurve ?? (_minVentCurve = new ToggleButtonSettingsField("Min Vent Curve")); }
            set { _minVentCurve = value; }
        }
        private ToggleButtonSettingsField _minVentCurve;

        public ComboboxSettingsField Tunnel
        {
            get { return new ComboboxSettingsField("Tunnel"); }
            set { _tunnel = value; }
        }
        private ComboboxSettingsField _tunnel;
    }

    public enum ControlModeSettings
    {
        [StringValue("House Mode")]
        HouseMode,
        [StringValue("Empty House Mode")]
        EmptyHouseMode,
        [StringValue("TemperatureCurv")]
        TemperatureCurv,
        [StringValue(@"Min Max Level Control")]
        MinMaxLevelControl,
    }
}
