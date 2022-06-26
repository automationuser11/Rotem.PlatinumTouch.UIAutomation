using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class CurvePage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<CurvePage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Curve Status"; }
        }
        public string MenuName
        {
            get { return "Curve Status"; }
        }
        public string SubMenu { get { return "Hot Key"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        #region Fields Definition

        #region Group Name: Target Temperature
        public ReadonlyTextSettingsField TargetTemperature
        {
            get { return _TargetTemperature ?? (_TargetTemperature = new ReadonlyTextSettingsField("Target Temp.")); }
            set { _TargetTemperature = value; }
        }
        private ReadonlyTextSettingsField _TargetTemperature;

        public ReadonlyTextSettingsField HeatTargetTemperature
        {
            get { return _heatTemp ?? (_heatTemp = new ReadonlyTextSettingsField("Heat Temp.")); }
            set { _heatTemp = value; }
        }
        private ReadonlyTextSettingsField _heatTemp;

        public ReadonlyTextSettingsField TunnelTemperatureStatus
        {
            get { return _tunnelTemperature ?? (_tunnelTemperature = new ReadonlyTextSettingsField("Tunnel Temp.")); }
            set { _tunnelTemperature = value; }
        }
        private ReadonlyTextSettingsField _tunnelTemperature;

        public ReadonlyTextSettingsField LowTemperature
        {
            get { return _lowTemperature ?? (_lowTemperature = new ReadonlyTextSettingsField("Low Alarm Temp.")); }
            set { _lowTemperature = value; }
        }
        private ReadonlyTextSettingsField _lowTemperature;
        public ReadonlyTextSettingsField HighTemperature
        {
            get { return _highTemperature ?? (_highTemperature = new ReadonlyTextSettingsField("High Alarm Temp.")); }
            set { _highTemperature = value; }
        }
        private ReadonlyTextSettingsField _highTemperature;
        public ReadonlyTextSettingsField TunnelHighAlarm
        {
            get { return _tunnelHighAlarm ?? (_tunnelHighAlarm = new ReadonlyTextSettingsField("Tunnel High Alarm")); }
            set { _tunnelHighAlarm = value; }
        }
        private ReadonlyTextSettingsField _tunnelHighAlarm;

        public ReadonlyTextSettingsField TargetSPressure
        {
            get { return _targetSPressure ?? (_targetSPressure = new ReadonlyTextSettingsField("Target S.Pressure")); }
            set { _targetSPressure = value; }
        }
        private ReadonlyTextSettingsField _targetSPressure;

        public ReadonlyTextSettingsField MinLevel
        {
            get { return _minLevel ?? (_minLevel = new ReadonlyTextSettingsField("Min Level")); }
            set { _minLevel = value; }
        }
        private ReadonlyTextSettingsField _minLevel;

        public ReadonlyTextSettingsField MaxLevel
        {
            get { return _maxLevel ?? (_maxLevel = new ReadonlyTextSettingsField("Max Level")); }
            set { _maxLevel = value; }
        }
        private ReadonlyTextSettingsField _maxLevel;


        #endregion

        #region Group Name: Heat Temperature
        public ReadonlyTextSettingsField HeatTemperature
        {
            get { return _HeatTemperature ?? (_HeatTemperature = new ReadonlyTextSettingsField("Heat Temperature")); }
            set { _HeatTemperature = value; }
        }
        private ReadonlyTextSettingsField _HeatTemperature;
        #endregion

        #region Group Name: Tunnel Temperature
        public ReadonlyTextSettingsField TunnelTemperature
        {
            get { return _TunnelTemperature ?? (_TunnelTemperature = new ReadonlyTextSettingsField("Tunnel Temperature")); }
            set { _TunnelTemperature = value; }
        }
        private ReadonlyTextSettingsField _TunnelTemperature;
        #endregion

        #region Group Name: Low Alarm Temperature
        public ReadonlyTextSettingsField LowAlarmTemperature
        {
            get { return _LowAlarmTemperature ?? (_LowAlarmTemperature = new ReadonlyTextSettingsField("Low Alarm Temperature")); }
            set { _LowAlarmTemperature = value; }
        }
        private ReadonlyTextSettingsField _LowAlarmTemperature;
        #endregion

        #region Group Name: High Alarm Temperature
        public ReadonlyTextSettingsField HighAlarmTemperature
        {
            get { return _HighAlarmTemperature ?? (_HighAlarmTemperature = new ReadonlyTextSettingsField("High Alarm Temperature")); }
            set { _HighAlarmTemperature = value; }
        }
        private ReadonlyTextSettingsField _HighAlarmTemperature;
        #endregion

        #region Group Name: Target Static Pressure
        public ReadonlyTextSettingsField TargetStaticPressure
        {
            get { return _TargetStaticPressure ?? (_TargetStaticPressure = new ReadonlyTextSettingsField("Target Static Pressure")); }
            set { _TargetStaticPressure = value; }
        }
        private ReadonlyTextSettingsField _TargetStaticPressure;
        #endregion

        #region Group Name: Minimum Level
        public ReadonlyTextSettingsField MinimumLevel
        {
            get { return _MinimumLevel ?? (_MinimumLevel = new ReadonlyTextSettingsField("Minimum Level")); }
            set { _MinimumLevel = value; }
        }
        private ReadonlyTextSettingsField _MinimumLevel;
        #endregion

        #region Group Name: Maximum Level
        public ReadonlyTextSettingsField MaximumLevel
        {
            get { return _MaximumLevel ?? (_MaximumLevel = new ReadonlyTextSettingsField("Maximum Level")); }
            set { _MaximumLevel = value; }
        }
        private ReadonlyTextSettingsField _MaximumLevel;
        #endregion

        #endregion
        public enum CurveStatusSettings
        {
            [StringValue("Target Temp.")]
            TargetTemperature,
            [StringValue("Heat Temp.")]
            HeatTemperature,
            [StringValue("Tunnel Temp.")]
            TunnelTemperature,
            [StringValue("Low Alarm Temp.")]
            LowAlarmTemperature,
            [StringValue("High Alarm Temp.")]
            HighAlarmTemperature,
            [StringValue("TargetS.Pressure")]
            TargetStaticPressure,
            [StringValue("Min Level")]
            MinimumLevel,
            [StringValue("Max Level")]
            MaximumLevel,
        }
    }
}


