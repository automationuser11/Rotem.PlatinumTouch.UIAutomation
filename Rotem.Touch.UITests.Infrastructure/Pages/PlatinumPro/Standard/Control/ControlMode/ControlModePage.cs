using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.ControlMode
{
    public class StandardControlModePage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<StandardControlModePage>()); }
        }
        private Uri _pageUri;
       
        public string Name
        {
            get { return "Control Mode"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public Metadata Metadata { get; set; }
       
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
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
      
        public ToggleButtonSettingsField MinVentCurve
        {
            get { return new ToggleButtonSettingsField("Min Vent Curve"); }
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
}
