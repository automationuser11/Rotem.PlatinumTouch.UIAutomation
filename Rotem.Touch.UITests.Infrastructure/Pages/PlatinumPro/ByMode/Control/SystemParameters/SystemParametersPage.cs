using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.SystemParameters
{
    public class SystemParametersPage: SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<SystemParametersPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "System Parameters"; }
        }
        public string MenuName
        {
            get { return "System Parameters"; }
        }
        public string SubMenu { get { return "Control"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        #region Group Name: Temprature Curve
        public KeyPadSettingsField TemperatureCurveOffSet
        {
            get { return _temperatureCurveOffSet ?? (_temperatureCurveOffSet = new KeyPadSettingsField() { Name = "Temperature Curve Offset", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _temperatureCurveOffSet = value; }
        }
        private KeyPadSettingsField _temperatureCurveOffSet;

        public KeyPadSettingsField SetTempReminderDiff
        {
            get { return _setTempReminderDiff ?? (_setTempReminderDiff = new KeyPadSettingsField() { Name = "Set Temperature Change Reminder (Diff.)", InputMethod = new PointNumericKeyPad() }); }
            set { _setTempReminderDiff = value; }
        }
        private KeyPadSettingsField _setTempReminderDiff;

        public KeyPadSettingsField TargetTemperatureBand
        {
            get { return _targetTemperatureBand ?? (_targetTemperatureBand = new KeyPadSettingsField() { Name = "Target Temperature Band", InputMethod = new PointNumericKeyPad() }); }
            set { _targetTemperatureBand = value; }
        }
        private KeyPadSettingsField _targetTemperatureBand;

        public KeyPadSettingsField HeaterTemperatureBand
        {
            get { return _heaterTemperatureBand ?? (_heaterTemperatureBand = new KeyPadSettingsField() { Name = "Heater Temperature Band", InputMethod = new PointNumericKeyPad() }); }
            set { _heaterTemperatureBand = value; }
        }
        private KeyPadSettingsField _heaterTemperatureBand;

        public KeyPadSettingsField CoolDownFactor
        {
            get { return _coolDownFactor ?? (_coolDownFactor = new KeyPadSettingsField() { Name = "Cool Down Factor (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _coolDownFactor = value; }
        }
        private KeyPadSettingsField _coolDownFactor;

        public KeyPadSettingsField CoolDownFastResponseDeg
        {
            get { return _coolDownFastResponseDeg ?? (_coolDownFastResponseDeg = new KeyPadSettingsField() { Name = "Cool Down Fast Response (Deg.)", InputMethod = new PointNumericKeyPad() }); }
            set { _coolDownFastResponseDeg = value; }
        }
        private KeyPadSettingsField _coolDownFastResponseDeg;

        public ButtonsGroupSettingsField MinVentBelowHeatTempBy
        {
            get { return _minVentBelowHeatTempBy ?? (_minVentBelowHeatTempBy = new ButtonsGroupSettingsField("Min Vent Below Heat Temperature By:")); }
            set { _minVentBelowHeatTempBy = value; }
        }
        private ButtonsGroupSettingsField _minVentBelowHeatTempBy;  

        public KeyPadSettingsField NonBroodAreaDiffFromHeat
        {
            get { return _nonBroodAreaDiffFromHeat ?? (_nonBroodAreaDiffFromHeat = new KeyPadSettingsField() { Name = "Non Brood Area Diff. From Heat", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _nonBroodAreaDiffFromHeat = value; }
        }
        private KeyPadSettingsField _nonBroodAreaDiffFromHeat;

        #endregion

        #region Group Name: Cycle Heater

        public KeyPadSettingsField LowHeatDifferential
        {
            get { return _lowHeatDifferential ?? (_lowHeatDifferential = new KeyPadSettingsField() { Name = "Low Heat Differential", InputMethod = new PointNumericKeyPad() }); }
            set { _lowHeatDifferential = value; }
        }
        private KeyPadSettingsField _lowHeatDifferential;

        public KeyPadSettingsField HighHeatDifferential
        {
            get { return _highHeatDifferential ?? (_highHeatDifferential = new KeyPadSettingsField() { Name = "High Heat Differential", InputMethod = new PointNumericKeyPad() }); }
            set { _highHeatDifferential = value; }
        }
        private KeyPadSettingsField _highHeatDifferential;

        public KeyPadSettingsField MinimumONTime
        {
            get { return _minimumONTime ?? (_minimumONTime = new KeyPadSettingsField() { Name = "Min On Time", InputMethod = new BaseNumericKeyPad() }); }
            set { _minimumONTime = value; }
        }
        private KeyPadSettingsField _minimumONTime;

        #endregion

        #region Group Name: Radiant Heaters

        public KeyPadSettingsField RadLowDiffFromHeatSet
        {
            get { return _radLowDiffFromHeatSet ?? (_radLowDiffFromHeatSet = new KeyPadSettingsField() { Name = "Radiant Low - Diff. From Heat Set", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _radLowDiffFromHeatSet = value; }
        }
        private KeyPadSettingsField _radLowDiffFromHeatSet;

        public KeyPadSettingsField RadLowDiffBelowHeatSet
        {
            get { return _radLowDiffBelowHeatSet ?? (_radLowDiffBelowHeatSet = new KeyPadSettingsField() { Name = "Radiant High - Diff. (Below Low Set)", InputMethod = new PointNumericKeyPad() }); }
            set { _radLowDiffBelowHeatSet = value; }
        }
        private KeyPadSettingsField _radLowDiffBelowHeatSet;

        public KeyPadSettingsField RadiantIgnitionTime
        {
            get { return _radIgnitionTime ?? (_radIgnitionTime = new KeyPadSettingsField() { Name = "Radiant Ignition Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _radIgnitionTime = value; }
        }
        private KeyPadSettingsField _radIgnitionTime;


        #endregion

        #region Group Name: Variable Heaters

        public KeyPadSettingsField LowDiffBelowHeatTemp 
        {
            get { return _lowDiffBelowHeatTemp ?? (_lowDiffBelowHeatTemp = new KeyPadSettingsField() { Name = "Low Diff. Below Heat Temp.", InputMethod = new PointNumericKeyPad() }); }
            set { _lowDiffBelowHeatTemp = value; }
        }
        private KeyPadSettingsField _lowDiffBelowHeatTemp;

        public KeyPadSettingsField HighDiffBelowHeatTemp
        {
            get { return _highDiffBelowHeatTemp ?? (_highDiffBelowHeatTemp = new KeyPadSettingsField() { Name = "High Diff. Below Heat Temp.", InputMethod = new PointNumericKeyPad() }); }
            set { _highDiffBelowHeatTemp = value; }
        }
        private KeyPadSettingsField _highDiffBelowHeatTemp;

        public KeyPadSettingsField ResponseTime
        {
            get { return _responseTime ?? (_responseTime = new KeyPadSettingsField() { Name = "Response Time", InputMethod = new BaseNumericKeyPad() }); }
            set { _responseTime = value; }
        }
        private KeyPadSettingsField _responseTime;

        #endregion

        #region Group Name: Humidity Treatment
        public KeyPadSettingsField HumidityBand5
        {
            get { return _humidityBand5 ?? (_humidityBand5 = new KeyPadSettingsField() { Name = "Humidity Treatment_Humidity Band (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidityBand5 = value; }
        }
        private KeyPadSettingsField _humidityBand5;

        public ToggleButtonSettingsField HumidityTreatmentBelowHeat
        {
            get { return _humidityTreatmentBelowHeat ?? (_humidityTreatmentBelowHeat = new ToggleButtonSettingsField("Humidity Treatment Below Heat")); }
            set { _humidityTreatmentBelowHeat = value; }
        }
        private ToggleButtonSettingsField _humidityTreatmentBelowHeat;

        public ComboboxSettingsField HumidityTreatmentBy
        {
            get { return _humidityTreatmentBy ?? (_humidityTreatmentBy = new ComboboxSettingsField("Humidity Treatment By")); }
            set { _humidityTreatmentBy = value; }
        }
        private ComboboxSettingsField _humidityTreatmentBy;

        public KeyPadSettingsField DelayBeforeTreatmentSec
        {
            get { return _delayBeforeTreatmentSec ?? (_delayBeforeTreatmentSec = new KeyPadSettingsField() { Name = "Humidity Treatment_Delay Before Treatment (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _delayBeforeTreatmentSec = value; }
        }
        private KeyPadSettingsField _delayBeforeTreatmentSec;

        public KeyPadSettingsField HTCycleMinOffTime
        {
            get { return _hTCycleMinOffTime ?? (_hTCycleMinOffTime = new KeyPadSettingsField() { Name = "Humidity Treatment_Cycle Min Off Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _hTCycleMinOffTime = value; }
        }
        private KeyPadSettingsField _hTCycleMinOffTime;

        #endregion

        #region Group Name: Humidity Treatment By Heater

        public ToggleButtonSettingsField HumidityTreatmentByHeater
        {
            get { return _humidityTreatmentByHeater ?? (_humidityTreatmentByHeater = new ToggleButtonSettingsField("Humidity Treatment By Heater")); }
            set { _humidityTreatmentByHeater = value; }
        }
        private ToggleButtonSettingsField _humidityTreatmentByHeater;


        public KeyPadSettingsField OutsideTempTreatmentByHeaters
        {
            get { return _outsideTempTreatmentByHeaters ?? (_outsideTempTreatmentByHeaters = new KeyPadSettingsField() { Name = "Outside Temp. Treatment By Heaters", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _outsideTempTreatmentByHeaters = value; }
        }
        private KeyPadSettingsField _outsideTempTreatmentByHeaters;

        public KeyPadSettingsField DiffToStopTreatmentByHeaters
        {
            get { return _diffToStopTreatmentByHeaters ?? (_diffToStopTreatmentByHeaters = new KeyPadSettingsField() { Name = "Diff To Stop Treatment By Heaters", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _outsideTempTreatmentByHeaters = value; }
        }
        private KeyPadSettingsField _diffToStopTreatmentByHeaters;

        #endregion

        #region Group Name: CO2 Treatment
        public ToggleButtonSettingsField CO2TreatmentBelowHeat
        {
            get { return _cO2TreatmentBelowHeat ?? (_cO2TreatmentBelowHeat = new ToggleButtonSettingsField("CO2 Treatment Below Heat")); }
            set { _cO2TreatmentBelowHeat = value; }
        }
        private ToggleButtonSettingsField _cO2TreatmentBelowHeat;

        public KeyPadSettingsField DelayBeforeTreatmentSecCO2
        {
            get { return _delayBeforeTreatmentSecCO2 ?? (_delayBeforeTreatmentSecCO2 = new KeyPadSettingsField() { Name = "CO2 Treatment_Delay Before Treatment (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _delayBeforeTreatmentSecCO2 = value; }
        }
        private KeyPadSettingsField _delayBeforeTreatmentSecCO2;

        public ComboboxSettingsField CO2TreatmentBy
        {
            get { return _cO2TreatmentBy ?? (_cO2TreatmentBy = new ComboboxSettingsField("CO2 Treatment By")); }
            set { _cO2TreatmentBy = value; }
        }
        private ComboboxSettingsField _cO2TreatmentBy;

        public KeyPadSettingsField CycleMinOffTimeSec
        {
            get { return _cycleMinOffTimeSec ?? (_cycleMinOffTimeSec = new KeyPadSettingsField() { Name = "CO2 Treatment_Cycle Min Off Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _cycleMinOffTimeSec = value; }
        }
        private KeyPadSettingsField _cycleMinOffTimeSec;



        #endregion

        #region Group Name: CO2 Treatment By Heaters
        public ToggleButtonSettingsField CO2TreatmentByHeaters
        {
            get { return _co2TreatmentByHeaters ?? (_co2TreatmentByHeaters = new ToggleButtonSettingsField("CO2 Treatment By Heaters")); }
            set { _co2TreatmentByHeaters = value; }
        }
        private ToggleButtonSettingsField _co2TreatmentByHeaters;

        public KeyPadSettingsField CO2OutsideTempTreatmentByHeaters
        {
            get { return _co2OutsideTempTreatmentByHeaters ?? (_co2OutsideTempTreatmentByHeaters = new KeyPadSettingsField() { Name = "Outside Temp. Treatment By Heaters", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _co2OutsideTempTreatmentByHeaters = value; }
        }
        private KeyPadSettingsField _co2OutsideTempTreatmentByHeaters;

        public KeyPadSettingsField CO2DiffToStopTreatmentByHeaters
        {
            get { return _co2diffToStopTreatmentByHeaters ?? (_co2diffToStopTreatmentByHeaters = new KeyPadSettingsField() { Name = "Diff To Stop Treatment By Heaters", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _co2diffToStopTreatmentByHeaters = value; }
        }
        private KeyPadSettingsField _co2diffToStopTreatmentByHeaters;

        #endregion

        #region Group Name: Ammonia Treatment
        public ToggleButtonSettingsField AmmoniaTreatmentBelowHeat
        {
            get { return _ammoniaTreatmentBelowHeat ?? (_ammoniaTreatmentBelowHeat = new ToggleButtonSettingsField("Ammonia Treatment Below Heat")); }
            set { _ammoniaTreatmentBelowHeat = value; }
        }
        private ToggleButtonSettingsField _ammoniaTreatmentBelowHeat;

        public ComboboxSettingsField AmmoniaTreatmentBy
        {
            get { return _ammoniaTreatmentBy ?? (_ammoniaTreatmentBy = new ComboboxSettingsField("Ammonia Treatment By")); }
            set { _ammoniaTreatmentBy = value; }
        }
        private ComboboxSettingsField _ammoniaTreatmentBy;

        public KeyPadSettingsField DelayBeforeTreatmentSecAmmonia
        {
            get { return _delayBeforeTreatmentSecAmmonia ?? (_delayBeforeTreatmentSecAmmonia = new KeyPadSettingsField() { Name = "Ammonia Treatment_Delay Before Treatment (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _delayBeforeTreatmentSecAmmonia = value; }
        }
        private KeyPadSettingsField _delayBeforeTreatmentSecAmmonia;

        public KeyPadSettingsField ATCycleMinOffTime
        {
            get { return _aTCycleMinOffTime ?? (_aTCycleMinOffTime = new KeyPadSettingsField() { Name = "Ammonia Treatment_Cycle Min Off Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _aTCycleMinOffTime = value; }
        }
        private KeyPadSettingsField _aTCycleMinOffTime;


        #endregion

        #region Group Name: Static Pressure
        public KeyPadSettingsField WindGustByTimesec
        {
            get { return _windGustByTimesec ?? (_windGustByTimesec = new KeyPadSettingsField() { Name = "Wind Gust Delay Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _windGustByTimesec = value; }
        }
        private KeyPadSettingsField _windGustByTimesec;

        public ToggleButtonSettingsField SPressureDuringTunnel
        {
            get { return _sPressureDuringTunnel ?? (_sPressureDuringTunnel = new ToggleButtonSettingsField("S.Pressure During Tunnel")); }
            set { _sPressureDuringTunnel = value; }
        }
        private ToggleButtonSettingsField _sPressureDuringTunnel;

        public ToggleButtonSettingsField TransitionalTunnel
        {
            get { return _transitionalTunnel ?? (_transitionalTunnel = new ToggleButtonSettingsField("Transitional Tunnel")); }
            set { _transitionalTunnel = value; }
        }
        private ToggleButtonSettingsField _transitionalTunnel;

        public ComboboxSettingsField MinimumVentilationUsing
        {
            get { return _minimumVentilationUsing ?? (_minimumVentilationUsing = new ComboboxSettingsField("Minimum Ventilation Using")); }
            set { _minimumVentilationUsing = value; }
        }
        private ComboboxSettingsField _minimumVentilationUsing;

        public KeyPadSettingsField LowIncomingTempdifftoTrg
        {
            get { return _lowIncomingTempdifftoTrg ?? (_lowIncomingTempdifftoTrg = new KeyPadSettingsField() { Name = "Low Incoming Temp(Diff. To Target)", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _lowIncomingTempdifftoTrg = value; }
        }
        private KeyPadSettingsField _lowIncomingTempdifftoTrg;

        public KeyPadSettingsField HighIncomingTempdifftoTrg
        {
            get { return _highIncomingTempdifftoTrg ?? (_highIncomingTempdifftoTrg = new KeyPadSettingsField() { Name = "High Incoming Temp(Diff. To Target)", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _highIncomingTempdifftoTrg = value; }
        }
        private KeyPadSettingsField _highIncomingTempdifftoTrg;

        public KeyPadSettingsField EmergencySPressureDelaysec
        {
            get { return _emergencySPressureDelaysec ?? (_emergencySPressureDelaysec = new KeyPadSettingsField() { Name = "Emergency S.Pressure Delay (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _emergencySPressureDelaysec = value; }
        }
        private KeyPadSettingsField _emergencySPressureDelaysec;

        public KeyPadSettingsField CurtPosInEmergSPDis0
        {
            get { return _curtPosInEmergSPDis0 ?? (_curtPosInEmergSPDis0 = new KeyPadSettingsField() { Name = "Curtain Position In Emergency S.Pressure (%) (0-Disabled)", InputMethod = new BaseNumericKeyPad() }); }
            set { _curtPosInEmergSPDis0 = value; }
        }
        private KeyPadSettingsField _curtPosInEmergSPDis0;

        public KeyPadSettingsField LowSPAlarmMinLevelMinV
        {
            get { return _lowSPAlarmMinLevelMinV ?? (_lowSPAlarmMinLevelMinV = new KeyPadSettingsField() { Name = "Low S.Pressure Alarm Min Level (MinVent)", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowSPAlarmMinLevelMinV = value; }
        }
        private KeyPadSettingsField _lowSPAlarmMinLevelMinV;

        public KeyPadSettingsField LowSPAlarmMinLevelTun
        {
            get { return _lowSPAlarmMinLevelTun ?? (_lowSPAlarmMinLevelTun = new KeyPadSettingsField() { Name = "Low S.Pressure Alarm Min Level (Tunnel)", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowSPAlarmMinLevelTun = value; }
        }
        private KeyPadSettingsField _lowSPAlarmMinLevelTun;

        public KeyPadSettingsField TimeToProduceSPressure
        {
            get { return _timeToProduceSPressure ?? (_timeToProduceSPressure = new KeyPadSettingsField() { Name = "Time To Produce S.Pressure (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _timeToProduceSPressure = value; }
        }
        private KeyPadSettingsField _timeToProduceSPressure;

        public KeyPadSettingsField LowhIncomingTempdifftoTrg
        {
            get { return _lowhIncomingTempdifftoTrg ?? (_lowhIncomingTempdifftoTrg = new KeyPadSettingsField() { Name = "Low Incoming Temp(Diff. To Target)", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _lowhIncomingTempdifftoTrg = value; }
        }
        private KeyPadSettingsField _lowhIncomingTempdifftoTrg;

        public KeyPadSettingsField AtticAdvancedOpeningTime
        {
            get { return _atticAdvancedOpeningTime ?? (_atticAdvancedOpeningTime = new KeyPadSettingsField() { Name = "Attic Advance Opening Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _atticAdvancedOpeningTime = value; }
        }
        private KeyPadSettingsField _atticAdvancedOpeningTime;

        public ComboboxSettingsField StopAtticWhenThisFanOn
        {
            get { return _stopAtticWhenThisFanOn ?? (_stopAtticWhenThisFanOn = new ComboboxSettingsField("Static Pressure_Stop Attic When This Fan On")); }
            set { _stopAtticWhenThisFanOn = value; }
        }
        private ComboboxSettingsField _stopAtticWhenThisFanOn;

        public KeyPadSettingsField MinTunnelCurtainToStartFan
        {
            get { return _minTunnelCurtainToStartFan ?? (_minTunnelCurtainToStartFan = new KeyPadSettingsField() { Name = "Min Tunnel Curtain (%) To Start Fan", InputMethod = new BaseNumericKeyPad() }); }
            set { _minTunnelCurtainToStartFan = value; }
        }
        private KeyPadSettingsField _minTunnelCurtainToStartFan;

        public KeyPadSettingsField MinTunnelCurtainPosition
        {
            get { return _minTunnelCurtainPosition ?? (_minTunnelCurtainPosition = new KeyPadSettingsField() { Name = "Min Tunnel Curtain Position (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _minTunnelCurtainPosition = value; }
        }
        private KeyPadSettingsField _minTunnelCurtainPosition;

        #endregion

        #region Group Name: Ventilation Levels
        public KeyPadSettingsField MaximumLevelsOfVentilation
        {
            get { return _maximumLevelsOfVentilation ?? (_maximumLevelsOfVentilation = new KeyPadSettingsField() { Name = "Maximum Levels Of Ventilation", InputMethod = new BaseNumericKeyPad() }); }
            set { _maximumLevelsOfVentilation = value; }
        }
        private KeyPadSettingsField _maximumLevelsOfVentilation;

        public KeyPadSettingsField FanCycleTimesec0Manual
        {
            get { return _fanCycleTimesec0Manual ?? (_fanCycleTimesec0Manual = new KeyPadSettingsField() { Name = @"""Fan Cycle Time (Sec., 0-Manual)""", InputMethod = new BaseNumericKeyPad() }); }
            set { _fanCycleTimesec0Manual = value; }
        }
        private KeyPadSettingsField _fanCycleTimesec0Manual;

        public KeyPadSettingsField IncreaseLevelDelayTimesec
        {
            get { return _increaseLevelDelayTimesec ?? (_increaseLevelDelayTimesec = new KeyPadSettingsField() { Name = "Increase Level Delay Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _increaseLevelDelayTimesec = value; }
        }
        private KeyPadSettingsField _increaseLevelDelayTimesec;

        public KeyPadSettingsField DecreaseLevelDelayTimesec
        {
            get { return _decreaseLevelDelayTimesec ?? (_decreaseLevelDelayTimesec = new KeyPadSettingsField() { Name = "Decrease Level Delay Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _decreaseLevelDelayTimesec = value; }
        }
        private KeyPadSettingsField _decreaseLevelDelayTimesec;

        #endregion

        #region Group Name: Tunnel

        public KeyPadSettingsField FirstTunnelLevel
        {
            get { return _firstTunnelLevel ?? (_firstTunnelLevel = new KeyPadSettingsField() { Name = "First Tunnel Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _firstTunnelLevel = value; }
        }
        private KeyPadSettingsField _firstTunnelLevel;

        public KeyPadSettingsField MaxFansSwitchToTunnel
        {
            get { return _maxFansSwitchToTunnel ?? (_maxFansSwitchToTunnel = new KeyPadSettingsField() { Name = @"""Maximum Fans, Switch To Tunnel""", InputMethod = new BaseNumericKeyPad() }); }
            set { _maxFansSwitchToTunnel = value; }
        }
        private KeyPadSettingsField _maxFansSwitchToTunnel;

        public KeyPadSettingsField TunnelExitDelaymin
        {
            get { return _tunnelExitDelaymin ?? (_tunnelExitDelaymin = new KeyPadSettingsField() { Name = "Tunnel Exit Delay (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _tunnelExitDelaymin = value; }
        }
        private KeyPadSettingsField _tunnelExitDelaymin;

        public KeyPadSettingsField TunnelExitDiffBelowTunnel
        {
            get { return _tunnelExitDiffBelowTunnel ?? (_tunnelExitDiffBelowTunnel = new KeyPadSettingsField() { Name = "Tunnel Exit - Diff. Below Tunnel", InputMethod = new PointNumericKeyPad() }); }
            set { _tunnelExitDiffBelowTunnel = value; }
        }
        private KeyPadSettingsField _tunnelExitDiffBelowTunnel;

        public KeyPadSettingsField TunExitOuttDiffFromTunnel
        {
            get { return _tunExitOuttDiffFromTunnel ?? (_tunExitOuttDiffFromTunnel = new KeyPadSettingsField() { Name = "Tunnel Exit - Out Temperature Diff. Above Tunnel", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _tunExitOuttDiffFromTunnel = value; }
        }
        private KeyPadSettingsField _tunExitOuttDiffFromTunnel;

        public ToggleButtonSettingsField EnableWindChill
        {
            get { return _enableWindChill ?? (_enableWindChill = new ToggleButtonSettingsField("Enable Wind Chill")); }
            set { _enableWindChill = value; }
        }
        private ToggleButtonSettingsField _enableWindChill;

        public KeyPadSettingsField WindChillLimit
        {
            get { return _windChillLimit ?? (_windChillLimit = new KeyPadSettingsField() { Name = "Wind Chill Limit", InputMethod = new PointNumericKeyPad() }); }
            set { _windChillLimit = value; }
        }
        private KeyPadSettingsField _windChillLimit;
        public KeyPadSettingsField RHEffect
        {
            get { return _rHEffect ?? (_rHEffect = new KeyPadSettingsField() { Name = "RH Effect", InputMethod = new PointNumericKeyPad() }); }
            set { _rHEffect = value; }
        }
        private KeyPadSettingsField _rHEffect;

        #endregion

        #region Group Name: Curtains

        public KeyPadSettingsField FirstDayFor2ndDayToOpen
        {
            get { return _1stDayFor2ndDayToOpen ?? (_1stDayFor2ndDayToOpen = new KeyPadSettingsField() { Name = "1st Day For 2nd Vent To Operate", InputMethod = new MinusNumericKeyPad() }); }
            set { _1stDayFor2ndDayToOpen = value; }
        }
        private KeyPadSettingsField _1stDayFor2ndDayToOpen;

        public KeyPadSettingsField FirstLevelFor2ndToOperate
        {
            get { return _firstLevelFor2ndToOperate ?? (_firstLevelFor2ndToOperate = new KeyPadSettingsField() { Name = "1st Level For 2nd Vent To Operate", InputMethod = new BaseNumericKeyPad() }); }
            set { _firstLevelFor2ndToOperate = value; }
        }
        private KeyPadSettingsField _firstLevelFor2ndToOperate;

        public KeyPadSettingsField CurtainStepSize
        {
            get { return _curtainStepSize ?? (_curtainStepSize = new KeyPadSettingsField() { Name = "Curtain Step Size", InputMethod = new BaseNumericKeyPad() }); }
            set { _curtainStepSize = value; }
        }
        private KeyPadSettingsField _curtainStepSize;

        public KeyPadSettingsField CurtainDelayBetweenSteps
        {
            get { return _curtainDelayBetweenSteps ?? (_curtainDelayBetweenSteps = new KeyPadSettingsField() { Name = "Curtain Delay Between Steps (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _curtainDelayBetweenSteps = value; }
        }
        private KeyPadSettingsField _curtainDelayBetweenSteps;

        public KeyPadSettingsField MinCurtainPosition
        {
            get { return _minCurtainPosition ?? (_minCurtainPosition = new KeyPadSettingsField() { Name = "Min Curtain Position", InputMethod = new BaseNumericKeyPad() }); }
            set { _minCurtainPosition = value; }
        }
        private KeyPadSettingsField _minCurtainPosition;

        //

        public KeyPadSettingsField SecondVentOperateFromDay
        {
            get { return _2ndVentOperateFromDay ?? (_2ndVentOperateFromDay = new KeyPadSettingsField() { Name = "2nd Vent Operate From Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _2ndVentOperateFromDay = value; }
        }
        private KeyPadSettingsField _2ndVentOperateFromDay;

        public KeyPadSettingsField SecondVentOperateFromLevel
        {
            get { return _2ndVentOperateFromLevel ?? (_2ndVentOperateFromLevel = new KeyPadSettingsField() { Name = "2nd Vent Operate From Level", InputMethod = new MinusNumericKeyPad() }); }
            set { _2ndVentOperateFromLevel = value; }
        }
        private KeyPadSettingsField _2ndVentOperateFromLevel;

        public KeyPadSettingsField ThirdVentOperateFromDay
        {
            get { return _3rdVentOperateFromDay ?? (_3rdVentOperateFromDay = new KeyPadSettingsField() { Name = "3rd Vent Operate From Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _3rdVentOperateFromDay = value; }
        }
        private KeyPadSettingsField _3rdVentOperateFromDay;

        public KeyPadSettingsField ThirdVentOperateFromLevel
        {
            get { return _3rdVentOperateFromLevel ?? (_3rdVentOperateFromLevel = new KeyPadSettingsField() { Name = "3rd Vent Operate From Level", InputMethod = new MinusNumericKeyPad() }); }
            set { _3rdVentOperateFromLevel = value; }
        }
        private KeyPadSettingsField _3rdVentOperateFromLevel;

        public KeyPadSettingsField FourthVentOperateFromDay
        {
            get { return _4thVentOperateFromDay ?? (_4thVentOperateFromDay = new KeyPadSettingsField() { Name = "4th Vent Operate From Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _4thVentOperateFromDay = value; }
        }
        private KeyPadSettingsField _4thVentOperateFromDay;

        public KeyPadSettingsField FourthVentOperateFromLevel
        {
            get { return _4thVentOperateFromLevel ?? (_4thVentOperateFromLevel = new KeyPadSettingsField() { Name = "4th Vent Operate From Level", InputMethod = new MinusNumericKeyPad() }); }
            set { _4thVentOperateFromLevel = value; }
        }
        private KeyPadSettingsField _4thVentOperateFromLevel;

        #endregion

        #region Group Name: Vent/Curtain Calibration

        public KeyPadSettingsField FromTime
        {
            get { return _fromTime ?? (_fromTime = new KeyPadSettingsField() { Name = "From Time", InputMethod = new TimeKeyPad() }); }
            set { _fromTime = value; }
        }
        private KeyPadSettingsField _fromTime;

        public KeyPadSettingsField ToTime
        {
            get { return _toTime ?? (_toTime = new KeyPadSettingsField() { Name = "To Time", InputMethod = new TimeKeyPad() }); }
            set { _toTime = value; }
        }

        private KeyPadSettingsField _toTime;

        public KeyPadSettingsField ToTimeCC
        {
            get { return _toTimeCC ?? (_toTimeCC = new KeyPadSettingsField() { Name = "Curtain Calibration_To Time", InputMethod = new TimeKeyPad() }); }
            set { _toTimeCC = value; }
        }

        private KeyPadSettingsField _toTimeCC;

        public KeyPadSettingsField FromTimeCC
        {
            get { return _fromTimeCC ?? (_fromTimeCC = new KeyPadSettingsField() { Name = "Curtain Calibration_From Time", InputMethod = new TimeKeyPad() }); }
            set { _fromTimeCC = value; }
        }

        private KeyPadSettingsField _fromTimeCC;

        public KeyPadSettingsField NumStepsForCurtainToCalib
        {
            get { return _numStepsForCurtainToCalib ?? (_numStepsForCurtainToCalib = new KeyPadSettingsField() { Name = "Number Of Steps", InputMethod = new BaseNumericKeyPad() }); }
            set { _numStepsForCurtainToCalib = value; }
        }
        private KeyPadSettingsField _numStepsForCurtainToCalib;

        public ToggleButtonSettingsField VentCalibrateAtPowerUp
        {
            get { return _ventCalibrateAtPowerUp ?? (_ventCalibrateAtPowerUp = new ToggleButtonSettingsField("Power Up Vents Calibration")); }
            set { _ventCalibrateAtPowerUp = value; }
        }
        private ToggleButtonSettingsField _ventCalibrateAtPowerUp;

        public KeyPadSettingsField ProximityToEdge
        {
            get { return _proximityToEdge ?? (_proximityToEdge = new KeyPadSettingsField() { Name = "Proximity To Edge (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _proximityToEdge = value; }
        }
        private KeyPadSettingsField _proximityToEdge;

        public KeyPadSettingsField CloseBelowThisTemp
        {
            get { return _closeBelowThisTemp ?? (_closeBelowThisTemp = new KeyPadSettingsField() { Name = "Close Below This Temp. (Out)", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _closeBelowThisTemp = value; }
        }
        private KeyPadSettingsField _closeBelowThisTemp;

        #endregion

        #region Group Name: Attic
        public KeyPadSettingsField MinimumAtticTempToOperate
        {
            get { return _minimumAtticTempToOperate ?? (_minimumAtticTempToOperate = new KeyPadSettingsField() { Name = "Min Attic Temperature To Operate", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _minimumAtticTempToOperate = value; }
        }
        private KeyPadSettingsField _minimumAtticTempToOperate;

        public KeyPadSettingsField OperateUntillLevel
        {
            get { return _operateUntillLevel ?? (_operateUntillLevel = new KeyPadSettingsField() { Name = "Attic Operate Until Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _operateUntillLevel = value; }
        }
        private KeyPadSettingsField _operateUntillLevel;

        public KeyPadSettingsField OperateFromTime
        {
            get { return _operateFromTime ?? (_operateFromTime = new KeyPadSettingsField() { Name = "Operate From Time", InputMethod = new TimeKeyPad() }); }
            set { _operateFromTime = value; }
        }
        private KeyPadSettingsField _operateFromTime;

        public KeyPadSettingsField OperateToTime
        {
            get { return _operateToTime ?? (_operateToTime = new KeyPadSettingsField() { Name = "Operate To Time", InputMethod = new TimeKeyPad() }); }
            set { _operateToTime = value; }
        }
        private KeyPadSettingsField _operateToTime;

        public KeyPadSettingsField MaxTemperatureToDisableAttic
        {
            get { return _maxTemperatureToDisableAttic ?? (_maxTemperatureToDisableAttic = new KeyPadSettingsField() { Name = "Max Temperature To Disable Attic", InputMethod = new PointNumericKeyPad() }); }
            set { _maxTemperatureToDisableAttic = value; }
        }
        private KeyPadSettingsField _maxTemperatureToDisableAttic;

        public ComboboxSettingsField AtticVentilationBy
        {
            get { return _atticVentilationBy ?? (_atticVentilationBy = new ComboboxSettingsField("Attic Ventilation By")); }
            set { _atticVentilationBy = value; }
        }
        private ComboboxSettingsField _atticVentilationBy;

        public KeyPadSettingsField ToTimeAttic
        {
            get { return _toTimeAttic ?? (_toTimeAttic = new KeyPadSettingsField() { Name = "Attic_To Time", InputMethod = new TimeKeyPad() }); }
            set { _toTimeAttic = value; }
        }

        private KeyPadSettingsField _toTimeAttic;

        public KeyPadSettingsField FromTimeAttic
        {
            get { return _fromTimeAttic ?? (_fromTimeAttic = new KeyPadSettingsField() { Name = "Attic_From Time", InputMethod = new TimeKeyPad() }); }
            set { _fromTimeAttic = value; }
        }

        private KeyPadSettingsField _fromTimeAttic;

        public KeyPadSettingsField MaxAtticTemperature
        {
            get { return _maxAtticTemperature ?? (_maxAtticTemperature = new KeyPadSettingsField() { Name = "Max Attic Temperature", InputMethod = new PointNumericKeyPad() }); }
            set { _maxAtticTemperature = value; }
        }
        private KeyPadSettingsField _maxAtticTemperature;

        public KeyPadSettingsField MinAtticTemperature
        {
            get { return _minAtticTemperature ?? (_minAtticTemperature = new KeyPadSettingsField() { Name = "Min Attic Temperature", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _minAtticTemperature = value; }
        }
        private KeyPadSettingsField _minAtticTemperature;

        public ComboboxSettingsField StopAtticWhenThisFanOnAttic
        {
            get { return _stopAtticWhenThisFanOnAttic ?? (_stopAtticWhenThisFanOnAttic = new ComboboxSettingsField("Attic_Stop Attic When This Fan On")); }
            set { _stopAtticWhenThisFanOnAttic = value; }
        }
        private ComboboxSettingsField _stopAtticWhenThisFanOnAttic;

        #endregion

        #region Group Name: Zone Inlet

        public ComboboxSettingsField OperationBySPressurePosition
        {
            get { return _operationBySPressurePosition ?? (_operationBySPressurePosition = new ComboboxSettingsField("Operation By S.Pressure / Position")); }
            set { _operationBySPressurePosition = value; }
        }
        private ComboboxSettingsField _operationBySPressurePosition;

        public KeyPadSettingsField ConpensationPerDegree
        {
            get { return _conpensationPerDegree ?? (_conpensationPerDegree = new KeyPadSettingsField() { Name = "Compensation (%) Per Degree", InputMethod = new BaseNumericKeyPad() }); }
            set { _conpensationPerDegree = value; }
        }
        private KeyPadSettingsField _conpensationPerDegree;

        public KeyPadSettingsField DelayForCompensation
        {
            get { return _delayForCompensation ?? (_delayForCompensation = new KeyPadSettingsField() { Name = "Delay For Compensation (Min)", InputMethod = new BaseNumericKeyPad() }); }
            set { _delayForCompensation = value; }
        }
        private KeyPadSettingsField _delayForCompensation;

        public KeyPadSettingsField MaxCompensationOpening
        {
            get { return _maxCompensationOpening ?? (_maxCompensationOpening = new KeyPadSettingsField() { Name = "Max Compensation Openning", InputMethod = new BaseNumericKeyPad() }); }
            set { _maxCompensationOpening = value; }
        }
        private KeyPadSettingsField _maxCompensationOpening;

        public KeyPadSettingsField TemperatureCompensationHysteresis
        {
            get { return _temperatureCompensationHysteresis ?? (_temperatureCompensationHysteresis = new KeyPadSettingsField() { Name = "Temperature Compensation Hysteresis", InputMethod = new PointNumericKeyPad() }); }
            set { _temperatureCompensationHysteresis = value; }
        }
        private KeyPadSettingsField _temperatureCompensationHysteresis;

        #endregion

        #region Group Name: Cool Pad
        public KeyPadSettingsField CoolPadTemperatureBand
        {
            get { return _coolPadtemperatureBand ?? (_coolPadtemperatureBand = new KeyPadSettingsField() { Name = "Cool Pad_Temperature Band", InputMethod = new PointNumericKeyPad() }); }
            set { _coolPadtemperatureBand = value; }
        }
        private KeyPadSettingsField _coolPadtemperatureBand;

        public KeyPadSettingsField HumidityBand2
        {
            get { return _humidityBand2 ?? (_humidityBand2 = new KeyPadSettingsField() { Name = "Cool Pad_Humidity Band (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidityBand2 = value; }
        }
        private KeyPadSettingsField _humidityBand2;

        public KeyPadSettingsField DiffBetweenCoolPadsStage
        {
            get { return _diffBetweenCoolPadsStage ?? (_diffBetweenCoolPadsStage = new KeyPadSettingsField() { Name = "Diff. Between Cool Pads Stage", InputMethod = new PointNumericKeyPad() }); }
            set { _diffBetweenCoolPadsStage = value; }
        }
        private KeyPadSettingsField _diffBetweenCoolPadsStage;

        public KeyPadSettingsField coolPad1MinimumLevelToOperate
        {
            get { return _coolPad1MinimumLevelToOperate ?? (_coolPad1MinimumLevelToOperate = new KeyPadSettingsField() { Name = "Cool Pad-1 Min Level To Operate", InputMethod = new BaseNumericKeyPad() }); }
            set { _coolPad1MinimumLevelToOperate = value; }
        }
        private KeyPadSettingsField _coolPad1MinimumLevelToOperate;

        public KeyPadSettingsField coolPad2MinimumLevelToOperate
        {
            get { return _coolPad2MinimumLevelToOperate ?? (_coolPad2MinimumLevelToOperate = new KeyPadSettingsField() { Name = "Cool Pad-2 Min Level To Operate", InputMethod = new BaseNumericKeyPad() }); }
            set { _coolPad2MinimumLevelToOperate = value; }
        }
        private KeyPadSettingsField _coolPad2MinimumLevelToOperate;

        public KeyPadSettingsField coolPad3MinimumLevelToOperate
        {
            get { return _coolPad3MinimumLevelToOperate ?? (_coolPad3MinimumLevelToOperate = new KeyPadSettingsField() { Name = "Cool Pad-3 Min Level To Operate", InputMethod = new BaseNumericKeyPad() }); }
            set { _coolPad3MinimumLevelToOperate = value; }
        }
        private KeyPadSettingsField _coolPad3MinimumLevelToOperate;

        public KeyPadSettingsField coolPad4MinimumLevelToOperate
        {
            get { return _coolPad4MinimumLevelToOperate ?? (_coolPad4MinimumLevelToOperate = new KeyPadSettingsField() { Name = "Cool Pad-4 Min Level To Operate", InputMethod = new BaseNumericKeyPad() }); }
            set { _coolPad4MinimumLevelToOperate = value; }
        }
        private KeyPadSettingsField _coolPad4MinimumLevelToOperate;

        #endregion

        #region Group Name: Coold Pad Flush

        public KeyPadSettingsField FlushCoolPadAt
        {
            get { return _flushCoolPadAt ?? (_flushCoolPadAt = new KeyPadSettingsField() { Name = "Flush Cool Pad At", InputMethod = new TimeKeyPad() }); }
            set { _flushCoolPadAt = value; }
        }
        private KeyPadSettingsField _flushCoolPadAt;


        public KeyPadSettingsField CoolPadFlashDurationmin
        {
            get { return _coolPadFlashDurationmin ?? (_coolPadFlashDurationmin = new KeyPadSettingsField() { Name = "Cool Pad Flush Duration (Minutes)", InputMethod = new BaseNumericKeyPad() }); }
            set { _coolPadFlashDurationmin = value; }
        }
        private KeyPadSettingsField _coolPadFlashDurationmin;

        #endregion

        #region Group Name: Foggers

        public KeyPadSettingsField HumidityBand3
        {
            get { return _humidityBand3 ?? (_humidityBand3 = new KeyPadSettingsField() { Name = "Humidity Band (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidityBand3 = value; }
        }
        private KeyPadSettingsField _humidityBand3;

        public KeyPadSettingsField HumidityBand4
        {
            get { return _humidityBand4 ?? (_humidityBand4 = new KeyPadSettingsField() { Name = "Foggers_Humidity Band (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidityBand4 = value; }
        }
        private KeyPadSettingsField _humidityBand4;

        public KeyPadSettingsField FoggersTemperatureBand
        {
            get { return _foggersTemperatureBand ?? (_foggersTemperatureBand = new KeyPadSettingsField() { Name = "Foggers_Temperature Band", InputMethod = new BaseNumericKeyPad() }); }
            set { _foggersTemperatureBand = value; }
        }
        private KeyPadSettingsField _foggersTemperatureBand;

        public KeyPadSettingsField MinLevelToEnableOperation
        {
            get { return _minLevelToEnableOperation ?? (_minLevelToEnableOperation = new KeyPadSettingsField() { Name = "Min Level To Enable Operation", InputMethod = new BaseNumericKeyPad() }); }
            set { _minLevelToEnableOperation = value; }
        }
        private KeyPadSettingsField _minLevelToEnableOperation;

        public KeyPadSettingsField MaxLevelToEnableOperation
        {
            get { return _maxLevelToEnableOperation ?? (_maxLevelToEnableOperation = new KeyPadSettingsField() { Name = "Max Level To Enable Operation", InputMethod = new BaseNumericKeyPad() }); }
            set { _maxLevelToEnableOperation = value; }
        }
        private KeyPadSettingsField _maxLevelToEnableOperation;


        public ToggleButtonSettingsField EnableRotation
        {
            get { return _enableRotation ?? (_enableRotation = new ToggleButtonSettingsField("Enable Rotation")); }
            set { _enableRotation = value; }
        }
        private ToggleButtonSettingsField _enableRotation;

        public KeyPadSettingsField DiffBetweenFoggersStage
        {
            get { return _diffBetweenFoggersStage ?? (_diffBetweenFoggersStage = new KeyPadSettingsField() { Name = "Diff. Between Foggers Stage", InputMethod = new PointNumericKeyPad() }); }
            set { _diffBetweenFoggersStage = value; }
        }
        private KeyPadSettingsField _diffBetweenFoggersStage;
        #endregion

        #region Group Name: Light
        public KeyPadSettingsField SunriseTimemin
        {
            get { return _sunriseTimemin ?? (_sunriseTimemin = new KeyPadSettingsField() { Name = "Sunrise Time (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _sunriseTimemin = value; }
        }
        private KeyPadSettingsField _sunriseTimemin;

        public KeyPadSettingsField SunsetTimemin
        {
            get { return _sunsetTimemin ?? (_sunsetTimemin = new KeyPadSettingsField() { Name = "Sunset Time (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _sunsetTimemin = value; }
        }
        private KeyPadSettingsField _sunsetTimemin;

        public KeyPadSettingsField AllowSpikingFromDay
        {
            get { return _allowSpikingFromDay ?? (_allowSpikingFromDay = new KeyPadSettingsField() { Name = "Allow Spiking From Day", InputMethod = new BaseNumericKeyPad() }); }
            set { _allowSpikingFromDay = value; }
        }
        private KeyPadSettingsField _allowSpikingFromDay;

        public KeyPadSettingsField SpikeCyclemin
        {
            get { return _spikeCyclemin ?? (_spikeCyclemin = new KeyPadSettingsField() { Name = "Spike Cycle (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _spikeCyclemin = value; }
        }
        private KeyPadSettingsField _spikeCyclemin;

        public KeyPadSettingsField SpikeDurationmin
        {
            get { return _spikeDurationmin ?? (_spikeDurationmin = new KeyPadSettingsField() { Name = "Spike Duration (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _spikeDurationmin = value; }
        }
        private KeyPadSettingsField _spikeDurationmin;

        public KeyPadSettingsField SpikeIncreaseAmount
        {
            get { return _spikeIncreaseAmount ?? (_spikeIncreaseAmount = new KeyPadSettingsField() { Name = "Spike Increase Amount (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _spikeIncreaseAmount = value; }
        }
        private KeyPadSettingsField _spikeIncreaseAmount;

        public ComboboxSettingsField SignalLightIs
        {
            get { return _signalLightIs ?? (_signalLightIs = new ComboboxSettingsField("Signal Light Is:")); }
            set { _signalLightIs = value; }
        }
        private ComboboxSettingsField _signalLightIs;

        public KeyPadSettingsField SignalBeforeFeedsec
        {
            get { return _signalBeforeFeedsec ?? (_signalBeforeFeedsec = new KeyPadSettingsField() { Name = "Signal Before Feed (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _signalBeforeFeedsec = value; }
        }
        private KeyPadSettingsField _signalBeforeFeedsec;

        public KeyPadSettingsField SignalDuringFeedsec
        {
            get { return _signalDuringFeedsec ?? (_signalDuringFeedsec = new KeyPadSettingsField() { Name = "Signal During Feed (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _signalDuringFeedsec = value; }
        }
        private KeyPadSettingsField _signalDuringFeedsec;

        public ToggleButtonSettingsField LightSensorActive
        {
            get { return _lightSensorActive ?? (_lightSensorActive = new ToggleButtonSettingsField("Light Sensor Active")); }
            set { _lightSensorActive = value; }
        }
        private ToggleButtonSettingsField _lightSensorActive;

        #endregion

        #region Group Name: Temp Target Adjust

        public KeyPadSettingsField ChangeTargetFrom
        {
            get { return _changeTargetFrom ?? (_changeTargetFrom = new KeyPadSettingsField() { Name = "Change Target From", InputMethod = new TimeKeyPad() }); }
            set { _changeTargetFrom = value; }
        }
        private KeyPadSettingsField _changeTargetFrom;

        public KeyPadSettingsField ChangeTargetTo
        {
            get { return _changeTargetTo ?? (_changeTargetTo = new KeyPadSettingsField() { Name = "Change Target To", InputMethod = new TimeKeyPad() }); }
            set { _changeTargetTo = value; }
        }
        private KeyPadSettingsField _changeTargetTo;

        public KeyPadSettingsField TargetOffset
        {
            get { return _targetOffset ?? (_targetOffset = new KeyPadSettingsField() { Name = "Target Offset", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _targetOffset = value; }
        }
        private KeyPadSettingsField _targetOffset;

        #endregion

        #region Group Name: Feed Line Operation

        public KeyPadSettingsField Line1Down
        {
            get { return _line1Down ?? (_line1Down = new KeyPadSettingsField() { Name = "Line 1 Down", InputMethod = new TimeKeyPad() }); }
            set { _line1Down = value; }
        }
        private KeyPadSettingsField _line1Down;

        public KeyPadSettingsField Line1Up
        {
            get { return _line1Up ?? (_line1Up = new KeyPadSettingsField() { Name = "Line 1 Up", InputMethod = new TimeKeyPad() }); }
            set { _line1Up = value; }
        }
        private KeyPadSettingsField _line1Up;

        public KeyPadSettingsField Line2Down
        {
            get { return _line2Down ?? (_line2Down = new KeyPadSettingsField() { Name = "Line 2 Down", InputMethod = new TimeKeyPad() }); }
            set { _line2Down = value; }
        }
        private KeyPadSettingsField _line2Down;

        public KeyPadSettingsField Line2Up
        {
            get { return _line2Up ?? (_line2Up = new KeyPadSettingsField() { Name = "Line 2 Up", InputMethod = new TimeKeyPad() }); }
            set { _line2Up = value; }
        }
        private KeyPadSettingsField _line2Up;

        #endregion

        #region Group Name: Water Cycle Time

        public KeyPadSettingsField WaterCycleOnSec
        {
            get { return _waterCycleOnSec ?? (_waterCycleOnSec = new KeyPadSettingsField() { Name = "Water Cycle Time_Cycle On (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _waterCycleOnSec = value; }
        }
        private KeyPadSettingsField _waterCycleOnSec;

        public KeyPadSettingsField WaterCycleOffSec
        {
            get { return _waterCycleOffSec ?? (_waterCycleOffSec = new KeyPadSettingsField() { Name = "Water Cycle Time_Cycle Off (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _waterCycleOffSec = value; }
        }
        private KeyPadSettingsField _waterCycleOffSec;

        #endregion
                
        #region Group Name: Feeder Cycle Time

        public KeyPadSettingsField FeederCycleOnSec
        {
            get { return _feederCycleOnSec ?? (_feederCycleOnSec = new KeyPadSettingsField() { Name = "Feeder Cycle Time_Cycle On (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _feederCycleOnSec = value; }
        }
        private KeyPadSettingsField _feederCycleOnSec;

        public KeyPadSettingsField FeederCycleOffSec
        {
            get { return _feederCycleOffSec ?? (_feederCycleOffSec = new KeyPadSettingsField() { Name = "Feeder Cycle Time_Cycle Off (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _feederCycleOffSec = value; }
        }
        private KeyPadSettingsField _feederCycleOffSec;


        #endregion

        #region Group Name: Auger Cycle Time

        public KeyPadSettingsField AugerCycleOnSec
        {
            get { return _augerCycleOnSec ?? (_augerCycleOnSec = new KeyPadSettingsField() { Name = "Auger Cycle Time_Cycle On (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _augerCycleOnSec = value; }
        }
        private KeyPadSettingsField _augerCycleOnSec;

        public KeyPadSettingsField AugerCycleOffSec
        {
            get { return _augerCycleOffSec ?? (_augerCycleOffSec = new KeyPadSettingsField() { Name = "Auger Cycle Time_Cycle Off (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _augerCycleOffSec = value; }
        }
        private KeyPadSettingsField _augerCycleOffSec;

        #endregion

        #region Group Name: Water & Feed
        public ComboboxSettingsField FeedDayCycle
        {
            get { return _feedDayCycle ?? (_feedDayCycle = new ComboboxSettingsField("Feed Day Cycle")); }
            set { _feedDayCycle = value; }
        }
        private ComboboxSettingsField _feedDayCycle;

        public ToggleButtonSettingsField Quantity
        {
            get { return _quantity ?? (_quantity = new ToggleButtonSettingsField("Feed By Quantity")); }
            set { _quantity = value; }
        }
        private ToggleButtonSettingsField _quantity;

        #endregion

        #region Group Name: Feed Inventory
        public KeyPadSettingsField TotalFeedInSilo1
        {
            get { return _totalFeedInSilo1 ?? (_totalFeedInSilo1 = new KeyPadSettingsField() { Name = "Total Feed In Silo-1", InputMethod = new BaseNumericKeyPad() }); }
            set { _totalFeedInSilo1 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo1;

        public KeyPadSettingsField TotalFeedInSilo2
        {
            get { return _totalFeedInSilo2 ?? (_totalFeedInSilo2 = new KeyPadSettingsField() { Name = "Total Feed In Silo-2", InputMethod = new BaseNumericKeyPad() }); }
            set { _totalFeedInSilo2 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo2;

        public KeyPadSettingsField TotalFeedInSilo3
        {
            get { return _totalFeedInSilo3 ?? (_totalFeedInSilo3 = new KeyPadSettingsField() { Name = "Total Feed In Silo-3", InputMethod = new BaseNumericKeyPad() }); }
            set { _totalFeedInSilo3 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo3;

        public KeyPadSettingsField TotalFeedInSilo4
        {
            get { return _totalFeedInSilo4 ?? (_totalFeedInSilo4 = new KeyPadSettingsField() { Name = "Total Feed In Silo-4", InputMethod = new BaseNumericKeyPad() }); }
            set { _totalFeedInSilo4 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo4;

        public KeyPadSettingsField TotalFeedInSilo5
        {
            get { return _totalFeedInSilo5 ?? (_totalFeedInSilo5 = new KeyPadSettingsField() { Name = "Total Feed In Silo-5", InputMethod = new BaseNumericKeyPad() }); }
            set { _totalFeedInSilo5 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo5;

        public KeyPadSettingsField TotalFeedInSilo6
        {
            get { return _totalFeedInSilo6 ?? (_totalFeedInSilo6 = new KeyPadSettingsField() { Name = "Total Feed In Silo-6", InputMethod = new BaseNumericKeyPad() }); }
            set { _totalFeedInSilo6 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo6;

        public KeyPadSettingsField TotalFeedInSilo7
        {
            get { return _totalFeedInSilo7 ?? (_totalFeedInSilo7 = new KeyPadSettingsField() { Name = "Total Feed In Silo-7", InputMethod = new BaseNumericKeyPad() }); }
            set { _totalFeedInSilo7 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo7;

        public KeyPadSettingsField TotalFeedInSilo8
        {
            get { return _totalFeedInSilo8 ?? (_totalFeedInSilo8 = new KeyPadSettingsField() { Name = "Total Feed In Silo-8", InputMethod = new BaseNumericKeyPad() }); }
            set { _totalFeedInSilo8 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo8;

        public ComboboxSettingsField ActiveSilo
        {
            get { return _activeSilo ?? (_activeSilo = new ComboboxSettingsField("Active Silo")); }
            set { _activeSilo = value; }
        }
        private ComboboxSettingsField _activeSilo;

        #endregion

        #region Group Name: Natural Entrance Conditions
        public ToggleButtonSettingsField EnableNaturaleInTunnel
        {
            get { return _enableNaturaleInTunnel ?? (_enableNaturaleInTunnel = new ToggleButtonSettingsField("Enable Natural in Tunnel:")); }
            set { _enableNaturaleInTunnel = value; }
        }
        private ToggleButtonSettingsField _enableNaturaleInTunnel;

        public KeyPadSettingsField WindGustDelayByTimesec
        {
            get { return _windGustDelayByTimesec ?? (_windGustDelayByTimesec = new KeyPadSettingsField() { Name = "Wind Gust Delay Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _windGustDelayByTimesec = value; }
        }
        private KeyPadSettingsField _windGustDelayByTimesec;

        public KeyPadSettingsField DisableStirFanaboveWSpeed
        {
            get { return _disableStirFanaboveWSpeed ?? (_disableStirFanaboveWSpeed = new KeyPadSettingsField() { Name = "Disable Stir Fan above Wind Speed:", InputMethod = new PointNumericKeyPad() }); }
            set { _disableStirFanaboveWSpeed = value; }
        }
        private KeyPadSettingsField _disableStirFanaboveWSpeed;

        public KeyPadSettingsField MinTimeinAnyVentModemin
        {
            get { return _minTimeinAnyVentModemin ?? (_minTimeinAnyVentModemin = new KeyPadSettingsField() { Name = "Min Time in any Vent Mode (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _minTimeinAnyVentModemin = value; }
        }
        private KeyPadSettingsField _minTimeinAnyVentModemin;

        public ToggleButtonSettingsField UseTunnelAsNaturalCurtain
        {
            get { return _useTunnelAsNaturalCurtain ?? (_useTunnelAsNaturalCurtain = new ToggleButtonSettingsField("Use Tunnel As Natural Curtain:")); }
            set { _useTunnelAsNaturalCurtain = value; }
        }
        private ToggleButtonSettingsField _useTunnelAsNaturalCurtain;

        #endregion

        #region Group Name: Wind & Rain Effect
        public KeyPadSettingsField LowWindSpeed
        {
            get { return _lowWindSpeed ?? (_lowWindSpeed = new KeyPadSettingsField() { Name = "Low Wind Speed:", InputMethod = new PointNumericKeyPad() }); }
            set { _lowWindSpeed = value; }
        }
        private KeyPadSettingsField _lowWindSpeed;

        public KeyPadSettingsField HighWindSpeed
        {
            get { return _highWindSpeed ?? (_highWindSpeed = new KeyPadSettingsField() { Name = "High Wind Speed:", InputMethod = new PointNumericKeyPad() }); }
            set { _highWindSpeed = value; }
        }
        private KeyPadSettingsField _highWindSpeed;

        public KeyPadSettingsField LowWindSpeedWithRain
        {
            get { return _lowWindSpeedWithRain ?? (_lowWindSpeedWithRain = new KeyPadSettingsField() { Name = "Low Wind Speed with Rain:", InputMethod = new PointNumericKeyPad() }); }
            set { _lowWindSpeedWithRain = value; }
        }
        private KeyPadSettingsField _lowWindSpeedWithRain;

        public KeyPadSettingsField HighWindSpeedWithRain
        {
            get { return _highWindSpeedWithRain ?? (_highWindSpeedWithRain = new KeyPadSettingsField() { Name = "High Wind Speed with Rain:", InputMethod = new PointNumericKeyPad() }); }
            set { _highWindSpeedWithRain = value; }
        }
        private KeyPadSettingsField _highWindSpeedWithRain;

        #endregion

        #region Group Name: Water On Demand - Nipple Flush 
        public KeyPadSettingsField WaterPressureDuringFlash
        {
            get { return _waterPressureDuringFlash ?? (_waterPressureDuringFlash = new KeyPadSettingsField() { Name = "Water Press. During Flush:", InputMethod = new PointNumericKeyPad() }); }
            set { _waterPressureDuringFlash = value; }
        }
        private KeyPadSettingsField _waterPressureDuringFlash;

        public ComboboxSettingsField RelayActiveDuringFlush
        {
            get { return _relayActiveDuringFlush ?? (_relayActiveDuringFlush = new ComboboxSettingsField("Relay Active During Flush:")); }
            set { _relayActiveDuringFlush = value; }
        }
        private ComboboxSettingsField _relayActiveDuringFlush;

        public ComboboxSettingsField RelayActiveDuringFlush1
        {
            get { return _relayActiveDuringFlush1 ?? (_relayActiveDuringFlush1 = new ComboboxSettingsField("Relay Active During Flush")); }
            set { _relayActiveDuringFlush1 = value; }
        }
        private ComboboxSettingsField _relayActiveDuringFlush1;

        #endregion

        #region Group Name: Alarm Settings

        public ToggleButtonSettingsField AdvancedAlarm
        {
            get { return _advancedAlarm ?? (_advancedAlarm = new ToggleButtonSettingsField("Advanced Alarms")); }
            set { _advancedAlarm = value; }
        }
        private ToggleButtonSettingsField _advancedAlarm;

        #endregion

        #region Group Name: V.Speed Settings

        public KeyPadSettingsField DayToDisableFanOff
        {
            get { return _dayToDisableFanOff ?? (_dayToDisableFanOff = new KeyPadSettingsField() { Name = "Day To Disable Fan Off", InputMethod = new BaseNumericKeyPad() }); }
            set { _dayToDisableFanOff = value; }
        }
        private KeyPadSettingsField _dayToDisableFanOff;

        public KeyPadSettingsField DiffToTurnFanOff
        {
            get { return _diffToTurnFanOff ?? (_diffToTurnFanOff = new KeyPadSettingsField() { Name = "Diff. To Turn Fan Off", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _diffToTurnFanOff = value; }
        }
        private KeyPadSettingsField _diffToTurnFanOff;

        public KeyPadSettingsField DayToTurnFanOff
        {
            get { return _dayToTurnFanOff ?? (_dayToTurnFanOff = new KeyPadSettingsField() { Name = "Day To Turn Fan Off", InputMethod = new BaseNumericKeyPad() }); }
            set { _dayToTurnFanOff = value; }
        }
        private KeyPadSettingsField _dayToTurnFanOff;

        #endregion

        #region Group Nam: Stir Fans

        public KeyPadSettingsField VariableStirOutput
        {
            get { return _variableStirOutput ?? (_variableStirOutput = new KeyPadSettingsField() { Name = "Variable Stir Output (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _variableStirOutput = value; }
        }
        private KeyPadSettingsField _variableStirOutput;

        public KeyPadSettingsField OnTimeSec
        {
            get { return _onTimeSec ?? (_onTimeSec = new KeyPadSettingsField() { Name = "On Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _onTimeSec = value; }
        }
        private KeyPadSettingsField _onTimeSec;

        public KeyPadSettingsField OffCycleDelayTime
        {
            get { return _offCycleDelayTime ?? (_offCycleDelayTime = new KeyPadSettingsField() { Name = "Off Cycle Delay Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _offCycleDelayTime = value; }
        }
        private KeyPadSettingsField _offCycleDelayTime;

        public KeyPadSettingsField CycleDelayTime
        {
            get { return _cycleDelayTime ?? (_cycleDelayTime = new KeyPadSettingsField() { Name = "Cycle Delay Time (sec)", InputMethod = new BaseNumericKeyPad() }); }
            set { _cycleDelayTime = value; }
        }
        private KeyPadSettingsField _cycleDelayTime;

        public ToggleButtonSettingsField OperateDuringCycle
        {
            get { return _operateDuringCycle ?? (_operateDuringCycle = new ToggleButtonSettingsField("Operate During Cycle")); }
            set { _operateDuringCycle = value; }
        }
        private ToggleButtonSettingsField _operateDuringCycle;

        public ToggleButtonSettingsField OnTempOutputMV
        {
            get { return _onTempOutputMV ?? (_onTempOutputMV = new ToggleButtonSettingsField("On Temp. Output (MV)")); }
            set { _onTempOutputMV = value; }
        }
        private ToggleButtonSettingsField _onTempOutputMV;

        #endregion

        #region Group Name: Temperature & Timer Settings

        public KeyPadSettingsField MinTunnelFansOn
        {
            get { return _minTunnelFansOn ?? (_minTunnelFansOn = new KeyPadSettingsField() { Name = "Min Tunnel Fans On", InputMethod = new BaseNumericKeyPad() }); }
            set { _minTunnelFansOn = value; }
        }
        private KeyPadSettingsField _minTunnelFansOn;

        #endregion
    }
}
