using System;
using System.Collections.Generic;
using System.Linq;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Co2Treatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.TemperatureCurve;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ControlMode;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.CoolPad;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ExtraSystems;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Foggers;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.HumidityTreatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.LightControl;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinVentTimer;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.NaturalVentilation;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.StaticPressure;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.SystemParameters;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.AmmoniaTreatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.WaterAndFeedControl;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.FeedScaleProgram;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.TimerSettings;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.LightDimmers;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.EggRoomControl;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.WorkRoomControl;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Nests;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.AlarmsHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.BirdWeightHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.Co2History;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EventsLogHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.FeedConsumptionHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.FeedConversionHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HeatersHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HistoryView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HumidityHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.Mortality;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.PowerConsumptionHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.RadiantHeatersHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.TemperatureHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.WaterHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.AmmoniaHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EggRoomHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EggBeltHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EggsHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AlarmReset;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AlarmSettings;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.BirdInventory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AnimalInventory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FailSafeSetting;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedersAndDrinkers;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedInventory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.GrowthDayAndGroup;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.GrowthDayAndFlock;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.NippleFlushing;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.Password;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.WaterOnDemand;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.CurrentSense;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.SwitchesAndRelays;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedLinesCalibration;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.AnalogOutputsInstallation;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.BirdCurve;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.Communication;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.FanAirCapacity;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.GeneralSetup;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.HouseDimensions;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.LevelsOfVentilation;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.RelayLayout;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleSettings;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.SensorsInstallation;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.SiloAugerLayout;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.StirFanProgram;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TemperatureDefinition;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TimeAndDate;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.Version;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleTesting;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleLayout;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.MuntersDrive;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.HardwareChecklist;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.VariableSpeedFansSetting;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TemperatureAndTimer;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.VentCurtSetup;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.SiloSettings;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.AnalogSensors;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.DigitalSensors;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.Scales;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.StaticPressureCalibration;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WaterAndFeedCalibration;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WindDirectionCalibration;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.AirInletsSetup;
using System.IO;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.BirdWeight;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public class MetadataFactory
    {
        public static RotemWebNavigator navigator = new RotemWebNavigator();
        private static readonly Dictionary<Type, Metadata> BroilerStandardPagesMetadataDictionary = new Dictionary<Type, Metadata>()
        {
            #region Control Pages:
            {typeof(AmmoniaTreatmentPage), new Metadata() { MenuId = "131" }},
            {typeof(TemperatureCurvePage), new Metadata() { MenuItem = "Temperature Curve", MenuId = "6"}},
            {typeof(MinVentTimerPage), new Metadata() { MenuItem = "Min Vent Timer", MenuId = "94" }},
            {typeof(TimerSettingsPage), new Metadata() { MenuItem = "Timer Settings", MenuId = "95" }},
            {typeof(HumidityTreatmentPage), new Metadata() { MenuItem = "Humidity Treatment", MenuId = "97" }},
            {typeof(Co2TreatmentPage), new Metadata() { MenuItem = "CO2 Treatment", MenuId = "132" }},
            {typeof(StaticPressurePage), new Metadata() { MenuItem = "Static Pressure", MenuId = "96" }},
            {typeof(CoolPadPage), new Metadata() { MenuItem = "Cool Pad", MenuId = "16" }},
            {typeof(FoggersPage), new Metadata() { MenuItem = "Foggers", MenuId = "17" }},
            {typeof(WaterAndFeedPage), new Metadata() { MenuId = "18" }},
            {typeof(LightFeedTabPage), new Metadata() { MenuId = "92" }},
            {typeof(LightNoFeedTabPage), new Metadata() { MenuId = "93" }},
            {typeof(LightControlPage), new Metadata() { MenuItem = "Light", MenuId = "19" }},
            {typeof(ExtraSystemsPage), new Metadata() { MenuId = "20" }},
            {typeof(ControlModePage), new Metadata() { MenuItem = "Control Mode", MenuId = "21" }},
            {typeof(SystemParametersPage), new Metadata() { MenuItem = "System Parameters", MenuId = "22" }},
            {typeof(FeedScaleProgramPage), new Metadata() { MenuItem = "Feed Scale Program", MenuId = "135" }},
            {typeof(LightDimmersPage), new Metadata() { MenuItem = "Light Dimmers", MenuId = "143" }},
            #endregion

            #region Management Pages:

            {typeof(BirdInventoryPage), new Metadata() { MenuItem = "Bird Inventory", MenuId = "23" , ContainerId = "Data"}},
            {typeof(FeedInventoryPage), new Metadata() { MenuItem = "Feed Inventory", MenuId = "24" }},
            {typeof(GrowthDayAndFlockPage), new Metadata() { MenuItem = "Growth Day & Flock", MenuId = "25" }},
            {typeof(AlarmSettingsPage), new Metadata() { MenuItem = "Alarm Settings", MenuId = "26" }},
            {typeof(AlarmResetPage), new Metadata() { MenuItem = "Alarm Reset", MenuId = "27" }},
            {typeof(AlarmResetTabPage), new Metadata() { MenuId = "27" }},
            {typeof(FailSafeSettingPage), new Metadata() { MenuItem = "Fail Safe Settings", MenuId = "28" }},
            {typeof(PasswordPage), new Metadata() { MenuItem = "Password", MenuId = "30" }},
            {typeof(FeedersAndDrinkersPage), new Metadata() { MenuItem = "Feeders & Drinkers", MenuId = "32" }},
            {typeof(NippleFlushingPage), new Metadata() { MenuItem = "Nipple Flushing", MenuId = "33" }},
            {typeof(ScheduleTabPage), new Metadata() { MenuId = "121" }},
            {typeof(OrderTabPage), new Metadata() { MenuId = "80" }},
            {typeof(WaterOnDemandPage), new Metadata() { MenuItem = "Water On Demand", MenuId = "34" }},
            {typeof(CurrentSensePage), new Metadata() { MenuItem = "Current Sense", MenuId = "56" }},
            {typeof(SwitchesAndRelaysPage), new Metadata() { MenuItem = "Switches & Relays", MenuId = "57" }},
	        #endregion

            #region History Pages:

            {typeof(TemperatureHistoryPage), new Metadata() { MenuItem = "Temprature", MenuId = "35" }},
            {typeof(HumidityHistoryPage), new Metadata() { MenuItem = "Humidity", MenuId = "36" }},
            {typeof(Co2HistoryPage), new Metadata() { MenuItem = "CO2", MenuId = "37" }},
            {typeof(BirdWeightHistoryPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "38" }},
            {typeof(FeedConversionHistoryPage), new Metadata() { MenuItem = "Feed Conversion", MenuId = "39" }},
            {typeof(WaterHistoryPage), new Metadata() { MenuItem = "Water", MenuId = "40" }},
            {typeof(FeedConsumptionHistoryPage), new Metadata() {MenuItem = "Feed", MenuId = "41"}},
            {typeof(MortalityHistoryPage), new Metadata() { MenuItem = "Mortality", MenuId = "42" }},
            {typeof(HeatersHistoryPage), new Metadata() { MenuItem = "Heaters", MenuId = "43" }},
            {typeof(RadiantHeatersHistoryPage), new Metadata() { MenuItem = "Radiant Heaters", MenuId = "44" }},
            {typeof(AlarmsHistoryPage), new Metadata() { MenuItem = "Alarms", MenuId = "45" }},
            {typeof(EventsLogHistoryPage), new Metadata() { MenuItem = "Table Of Events", MenuId = "46" }},
            {typeof(PowerConsumptionHistoryPage), new Metadata() { MenuItem = "Power Consumption", MenuId = "47" }},
            {typeof(HistoryViewPage), new Metadata() { MenuItem = "History View", MenuId = "48" }},
            {typeof(AmmoniaHistoryPage), new Metadata() { MenuItem = "Ammonia", MenuId = "130" }},
            #endregion

            #region System Pages:

            {typeof(ScaleTestingPage), new Metadata() { MenuItem = "Scale Testing", MenuId = "55" }},
            {typeof(HardwareChecklistPage), new Metadata(){ MenuItem= "Hardware Checklist", MenuId= "60"}},
            {typeof(GeneralSetupPage), new Metadata() { MenuItem = "Setup", MenuId = "63" }},
            {typeof(TimeAndDatePage), new Metadata() { MenuItem = "Time & Date", MenuId = "64" }},
            {typeof(RelayLayoutPage), new Metadata() { MenuItem = "Relay Layout", MenuId = "67" }},
            {typeof(VariableSpeedFansSettingPage), new Metadata() {MenuItem = "Variable Speed Fans Setting", MenuId="115"}},
            {typeof(SensorsInstallationPage), new Metadata() { MenuItem = "Sensors Installation", MenuId = "68" }},
            {typeof(AnalogTabPage), new Metadata() { MenuId = "181" }},
            {typeof(DigitalTabPage), new Metadata() { MenuId = "81" }},
            {typeof(AnalogOutputsInstallationPage), new Metadata() { MenuItem = "Analog Output", MenuId = "69" }},
            {typeof(TemperatureDefinitionPage), new Metadata() { MenuItem = "Temp Definition", MenuId = "71" }},
            {typeof(TemperatureAndTimerPage), new Metadata() { MenuItem = "Temperature & Timer Settings", MenuId = "98" }},
            {typeof(VentCurtSetupPage), new Metadata() {MenuItem = "Vent/Curt Setup", MenuId="72"}},
            {typeof(AirInletsSetupPage), new Metadata() {MenuItem = "Vent/Curt Setup", MenuId="72"}},
            {typeof(HouseDimensionsPage), new Metadata() { MenuItem = "House Dimensions", MenuId = "72" }},
            {typeof(FanAirCapacityPage), new Metadata() { MenuItem = "Fan Air Capacity", MenuId = "74" }},
            {typeof(BirdCurvePage), new Metadata() { MenuItem = "Bird Curve", MenuId = "75" }},
            {typeof(ScaleSettingsPage), new Metadata() { MenuItem = "Scale Settings", MenuId = "76" }},
            {typeof(SiloAugerLayoutPage), new Metadata() { MenuItem = "Silo/Auger Layout", MenuId = "77" }},
            {typeof(CommunicationPage), new Metadata() { MenuItem = "Communication", MenuId = "78" }},
            {typeof(ScaleLayoutPage), new Metadata() { MenuItem = "Scale Layout", MenuId = "99" }},
            {typeof(VersionPage), new Metadata() { MenuItem = "Version", MenuId = "108" }},
            {typeof(BirdWeightPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "162" }},

            #endregion

            #region Hot Key Pages:

            {typeof(CurvePage), new Metadata(){ MenuItem = "Curve Status", MenuId= "101"}} ,
            {typeof(LightStatusPage), new Metadata(){ MenuItem = "Light Status",  MenuId= "102"}},
            {typeof(LightStatusTabPage), new Metadata(){ MenuId= "107" }},
            {typeof(LightTabPage), new Metadata(){ MenuId= "109" }},
            {typeof(TemperatureandHumidityPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "111"}},
            {typeof(AnalogOutputStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "110"}},
            {typeof(FeedScaleStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "138"}},
            {typeof(WaterMetersPage), new Metadata(){ MenuItem = "Water Meters",  MenuId= "141"}},
            {typeof(BirdScalePage), new Metadata(){ MenuItem = "Bird Scale",  MenuId= "155"}},
            {typeof(SiloPage), new Metadata(){ MenuItem = "Silo",  MenuId= "148"}},
            {typeof(CurtainPositionPage), new Metadata(){ MenuItem = "Curtain Position",  MenuId= "149"}},


            #endregion
        };

        private static readonly Dictionary<Type, Metadata> BroilerPrecisionPagesMetadataDictionary = new Dictionary<Type, Metadata>()
        {
            #region Control Pages:

            {typeof(TemperatureCurvePage), new Metadata() { MenuItem = "Temperature Curve", MenuId = "6"}},
            {typeof(MinMaxLevelByDaysPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "7" /* Todo: Need to figure what level control was set, and then set the correct value*/ }},
            {typeof(MinMaxLevelByDaysCurvePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "8" }},
            {typeof(MinMaxLevelByTimePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "9" }},
            {typeof(MinMaxLevelBySoftMinPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "10" }},
            {typeof(MinMaxLevelByWeightPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "11" }},
            {typeof(HumidityTreatmentPage), new Metadata() { MenuItem = "Humidity Treatment", MenuId = "12" }},
            {typeof(Co2TreatmentPage), new Metadata() { MenuItem = "CO2 Treatment", MenuId = "13" }},
            {typeof(CoolPadPage), new Metadata() { MenuItem = "Cool Pad", MenuId = "16" }},
            {typeof(NaturalVentilationPage), new Metadata() { MenuItem = "Natural Ventilation", MenuId = "14" }},
            {typeof(StaticPressurePage), new Metadata() { MenuItem = "S.Pressure", MenuId = "15" }},
            {typeof(FoggersPage), new Metadata() { MenuItem = "Foggers", MenuId = "17" }},
            {typeof(WaterAndFeedPage), new Metadata() { MenuItem = @"Water & Feed", MenuId = "18" }},
            {typeof(LightControlPage), new Metadata() { MenuItem = "Light Control", MenuId = "19" }},
            {typeof(LightFeedTabPage), new Metadata() { MenuId = "92" }},
            {typeof(LightNoFeedTabPage), new Metadata() { MenuId = "93" }},
            {typeof(ExtraSystemsPage), new Metadata() { MenuItem = "Extra Systems", MenuId = "20" }},
            {typeof(ControlModePage), new Metadata() { MenuItem = "Control Mode", MenuId = "21" }},
            {typeof(SystemParametersPage), new Metadata() { MenuItem = "System Parameters", MenuId = "22" }},
            {typeof(AmmoniaTreatmentPage), new Metadata() { MenuItem = "Ammonia Treatment", MenuId = "129" }},
            {typeof(FeedScaleProgramPage), new Metadata() { MenuItem = "Feed Scale Program", MenuId = "135" }},
            {typeof(LightDimmersPage), new Metadata() { MenuItem = "Light Dimmers", MenuId = "143" }},


            #endregion

            #region Management Pages:

            {typeof(BirdInventoryPage), new Metadata() { MenuItem = "Bird Inventory", MenuId = "23" , ContainerId = "Data"}},
            {typeof(FeedInventoryPage), new Metadata() { MenuItem = "Feed Inventory", MenuId = "24" }},
            {typeof(GrowthDayAndFlockPage), new Metadata() { MenuItem = "Growth Day & Flock", MenuId = "25" }},
            {typeof(AlarmSettingsPage), new Metadata() { MenuItem = "Alarm Settings", MenuId = "26" }},
            {typeof(AlarmResetPage), new Metadata() { MenuItem = "Alarm Reset", MenuId = "27" }},
            {typeof(AlarmResetTabPage), new Metadata() { MenuId = "27" }},
            {typeof(FailSafeSettingPage), new Metadata() { MenuItem = "Fail Safe Settings", MenuId = "28" }},
            {typeof(PasswordPage), new Metadata() { MenuItem = "Password", MenuId = "30" }},
            {typeof(FeedersAndDrinkersPage), new Metadata() { MenuItem = "Feeders & Drinkers", MenuId = "32" }},
            {typeof(NippleFlushingPage), new Metadata() { MenuItem = "Nipple Flushing", MenuId = "33" }},
            {typeof(ScheduleTabPage), new Metadata() { MenuId = "121" }},
            {typeof(OrderTabPage), new Metadata() { MenuId = "80" }},
            {typeof(WaterOnDemandPage), new Metadata() { MenuItem = "Water On Demand", MenuId = "34" }},
            {typeof(CurrentSensePage), new Metadata() { MenuItem = "Current Sense", MenuId = "56" }},
            {typeof(SwitchesAndRelaysPage), new Metadata() { MenuItem = "Switches & Relays", MenuId = "57" }},
	        #endregion

            #region History Pages:

            {typeof(TemperatureHistoryPage), new Metadata() { MenuItem = "Temprature", MenuId = "35" }},
            {typeof(HumidityHistoryPage), new Metadata() { MenuItem = "Humidity", MenuId = "36" }},
            {typeof(Co2HistoryPage), new Metadata() { MenuItem = "CO2", MenuId = "37" }},
            {typeof(BirdWeightHistoryPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "38" }},
            {typeof(FeedConversionHistoryPage), new Metadata() { MenuItem = "Feed Conversion", MenuId = "39" }},
            {typeof(WaterHistoryPage), new Metadata() { MenuItem = "Water", MenuId = "40" }},
            {typeof(FeedConsumptionHistoryPage), new Metadata() {MenuItem = "Feed", MenuId = "41"}},
            {typeof(MortalityHistoryPage), new Metadata() { MenuItem = "Mortality", MenuId = "42" }},
            {typeof(HeatersHistoryPage), new Metadata() { MenuItem = "Heaters", MenuId = "43" }},
            {typeof(RadiantHeatersHistoryPage), new Metadata() { MenuItem = "Radiant Heaters", MenuId = "44" }},
            {typeof(AlarmsHistoryPage), new Metadata() { MenuItem = "Alarms", MenuId = "45" }},
            {typeof(EventsLogHistoryPage), new Metadata() { MenuItem = "Table Of Events", MenuId = "46" }},
            {typeof(PowerConsumptionHistoryPage), new Metadata() { MenuItem = "Power Consumption", MenuId = "47" }},
            {typeof(HistoryViewPage), new Metadata() { MenuItem = "History View", MenuId = "48" }},
            {typeof(AmmoniaHistoryPage), new Metadata() { MenuItem = "Ammonia", MenuId = "130" }},
	        #endregion

            #region Testing & Calibration Pages:
		 
            {typeof(AnalogSensorsPage), new Metadata() { MenuItem = "Analog Sensors", MenuId = "49" }},
            {typeof(DigitalSensorsPage), new Metadata() { MenuItem = "Digital Sensors", MenuId = "50" }},
            {typeof(StaticPressureCalibrationPage), new Metadata(){MenuItem = "S.Pressure", MenuId = "51"}},
            {typeof(WaterTabPage), new Metadata() { MenuId = "53" }},
            {typeof(WaterAndFeedCalibrationPage), new Metadata() { MenuItem = "Water & Feed Calibration", MenuId = "53" }},
            {typeof(FeedTabPage), new Metadata(){ MenuId = "84"}},
            {typeof(ScalesPage), new Metadata() { MenuItem = "Scales Testing & Calibration", MenuId = "55" }},
            {typeof(HardwareChecklistPage), new Metadata(){ MenuItem= "Hardware Checklist", MenuId= "60"}},
            {typeof(WindDirectionCalibrationPage), new Metadata(){ MenuItem= "Hardware Checklist",MenuId= "62"}},

	        #endregion

            #region System Pages:
		 
            {typeof(ExhaustAndTunnelFansTabPage), new Metadata(){ MenuId= "85", ParentId="65"}},//85
            {typeof(VentAndCurtainTabPage), new Metadata(){ MenuId= "86",ParentId="65"}},//86
            {typeof(VariableSpeedFansTabPage), new Metadata(){ MenuId= "87",ParentId="65"}},//87
            {typeof(StirAndVariableStirFansTabFansPage), new Metadata(){ MenuId= "88",ParentId="65"}},//88
            {typeof(GeneralSetupPage), new Metadata() { MenuItem = "Setup", MenuId = "63" }},
            {typeof(HouseDimensionsPage), new Metadata() { MenuItem = "House Dimensions", MenuId = "63" }},
            {typeof(TimeAndDatePage), new Metadata() { MenuItem = "Time & Date", MenuId = "64" }},
            {typeof(StirFanProgramPage), new Metadata() { MenuItem = "Stir Fan Program", MenuId = "66" }},
            {typeof(RelayLayoutPage), new Metadata() { MenuItem = "Relay Layout", MenuId = "67" }},
            {typeof(AnalogTabPage), new Metadata() { MenuId = "181" }},
            {typeof(DigitalTabPage), new Metadata() { MenuId = "81" }},
            {typeof(AnalogOutputsInstallationPage), new Metadata() { MenuItem = "Analog Output", MenuId = "69" }},
            {typeof(LevelsOfVentilationPage), new Metadata() { MenuItem = "Level Of Ventilation", MenuId = "65" }},
            {typeof(SensorsInstallationPage), new Metadata() { MenuItem = "Sensors Installation", MenuId = "68" }},
            {typeof(TemperatureDefinitionPage), new Metadata() { MenuItem = "Temp Definition", MenuId = "71" }},
            {typeof(VentCurtSetupPage), new Metadata() {MenuItem = "Vent/Curt Setup", MenuId="72"}},
            {typeof(AirInletsSetupPage), new Metadata() { MenuItem = "Air Inlets Setup", MenuId = "72" }},
            {typeof(FanAirCapacityPage), new Metadata() { MenuItem = "Fan Air Capacity", MenuId = "74" }},
            {typeof(BirdCurvePage), new Metadata() { MenuItem = "Bird Curve", MenuId = "75" }},
            {typeof(ScaleSettingsPage), new Metadata() { MenuItem = "Scale Settings", MenuId = "76" }},
            {typeof(SiloAugerLayoutPage), new Metadata() { MenuItem = "Silo/Auger Layout", MenuId = "77" }},
            {typeof(CommunicationPage), new Metadata() { MenuItem = "Communication", MenuId = "78" }},
            {typeof(VersionPage), new Metadata() { MenuItem = "Version", MenuId = "108" }},
            {typeof(ScaleTestingPage), new Metadata() { MenuItem = "Scale Testing", MenuId = "55" }},
            {typeof(ScaleLayoutPage), new Metadata() { MenuItem = "Scale Layout", MenuId = "99" }},
            {typeof(MuntersDrivePage), new Metadata() { MenuItem = "Munters Drive", MenuId = "140" }},
            {typeof(BirdWeightPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "162" }},

	        #endregion

            #region Hot Key Pages:

            {typeof(CurvePage), new Metadata(){ MenuItem = "Curve Status", MenuId= "101"}} , 
            {typeof(LightStatusPage), new Metadata(){ MenuItem = "Light Status",  MenuId= "102"}},
            {typeof(LightStatusTabPage), new Metadata(){ MenuId= "107" }},
            {typeof(LightTabPage), new Metadata(){ MenuId= "109" }},
            {typeof(NaturalVentilationPageHotkey), new Metadata(){ MenuItem = "Natural Ventilation",  MenuId= "103"}},
            {typeof(AnalogOutputStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "110"}},
            //{typeof(AirPage), new Metadata(){ MenuItem = "Air Status",  MenuId= "104"}},
            {typeof(TemperatureandHumidityPage), new Metadata(){ MenuItem = "Temperature And Humidity",  MenuId= "111"}},
            {typeof(FeedScaleStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "138"}},
            {typeof(WaterMetersPage), new Metadata(){ MenuItem = "Water Meters",  MenuId= "141"}},
            {typeof(BirdScalePage), new Metadata(){ MenuItem = "Bird Scale",  MenuId= "155"}},
            {typeof(SiloPage), new Metadata(){ MenuItem = "Silo",  MenuId= "148"}},
            {typeof(CurtainPositionPage), new Metadata(){ MenuItem = "Curtain Position",  MenuId= "149"}},
            {typeof(AirStatusPage), new Metadata(){ MenuItem = "Air Status",  MenuId= "150"}},
            {typeof(WaterAndFeedStatusPage), new Metadata(){ MenuItem = "Water & Feed Status",  MenuId= "151"}},
            
            
            #endregion
        };

        private static readonly Dictionary<Type, Metadata> BreederPrecisionBasicFeedingPagesMetadataDictionary = new Dictionary<Type, Metadata>()
        {
            #region Control Pages:

            {typeof(TemperatureCurvePage), new Metadata() { MenuItem = "Temperature Curve", MenuId = "6"}},
            {typeof(MinMaxLevelByDaysPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "7" /* Todo: Need to figure what level control was set, and then set the correct value*/ }},
            {typeof(MinMaxLevelByDaysCurvePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "8" }},
            {typeof(MinMaxLevelByTimePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "9" }},
            {typeof(MinMaxLevelBySoftMinPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "10" }},
            {typeof(MinMaxLevelByWeightPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "11" }},
            {typeof(HumidityTreatmentPage), new Metadata() { MenuItem = "Humidity Treatment", MenuId = "12" }},
            {typeof(Co2TreatmentPage), new Metadata() { MenuItem = "CO2 Treatment", MenuId = "13" }},
            {typeof(CoolPadPage), new Metadata() { MenuItem = "Cool Pad", MenuId = "16" }},
            {typeof(NaturalVentilationPage), new Metadata() { MenuItem = "Natural Ventilation", MenuId = "14" }},
            {typeof(StaticPressurePage), new Metadata() { MenuItem = "S.Pressure", MenuId = "15" }},
            {typeof(FoggersPage), new Metadata() { MenuItem = "Foggers", MenuId = "17" }},
            {typeof(WaterAndFeedPage), new Metadata() { MenuItem = @"Water & Feed", MenuId = "136" }},
            {typeof(LightControlPage), new Metadata() { MenuItem = "Light Control", MenuId = "19" }},
            {typeof(LightFeedTabPage), new Metadata() { MenuId = "92" }},
            {typeof(LightNoFeedTabPage), new Metadata() { MenuId = "93" }},
            {typeof(ExtraSystemsPage), new Metadata() { MenuItem = "Extra Systems", MenuId = "20" }},
            {typeof(ControlModePage), new Metadata() { MenuItem = "Control Mode", MenuId = "21" }},
            {typeof(SystemParametersPage), new Metadata() { MenuItem = "System Parameters", MenuId = "22" }},
            {typeof(AmmoniaTreatmentPage), new Metadata() { MenuItem = "Ammonia Treatment", MenuId = "129" }},
            {typeof(FeedScaleProgramPage), new Metadata() { MenuItem = "Feed Scale Program", MenuId = "135" }},
            {typeof(LightDimmersPage), new Metadata() { MenuItem = "Light Dimmers", MenuId = "143" }},
            {typeof(EggRoomControlPage), new Metadata() { MenuItem = "Egg Room Control", MenuId = "116" }},
            {typeof(WorkRoomControlPage), new Metadata() { MenuItem = "Work Room Control", MenuId = "133" }},
            {typeof(NestsPage), new Metadata() { MenuItem = "Nests", MenuId = "134" }},

            #endregion

            #region Management Pages:

            {typeof(BirdInventoryPage), new Metadata() { MenuItem = "Bird Inventory", MenuId = "23" , ContainerId = "Data"}},
            {typeof(FeedInventoryPage), new Metadata() { MenuItem = "Feed Inventory", MenuId = "24" }},
            {typeof(GrowthDayAndFlockPage), new Metadata() { MenuItem = "Growth Day & Flock", MenuId = "25" }},
            {typeof(AlarmSettingsPage), new Metadata() { MenuItem = "Alarm Settings", MenuId = "26" }},
            {typeof(AlarmResetPage), new Metadata() { MenuItem = "Alarm Reset", MenuId = "27" }},
            {typeof(AlarmResetTabPage), new Metadata() { MenuId = "27" }},
            {typeof(FailSafeSettingPage), new Metadata() { MenuItem = "Fail Safe Settings", MenuId = "28" }},
            {typeof(PasswordPage), new Metadata() { MenuItem = "Password", MenuId = "30" }},
            {typeof(FeedersAndDrinkersPage), new Metadata() { MenuItem = "Feeders & Drinkers", MenuId = "32" }},
            {typeof(NippleFlushingPage), new Metadata() { MenuItem = "Nipple Flushing", MenuId = "33" }},
            {typeof(ScheduleTabPage), new Metadata() { MenuId = "121" }},
            {typeof(OrderTabPage), new Metadata() { MenuId = "80" }},
            {typeof(WaterOnDemandPage), new Metadata() { MenuItem = "Water On Demand", MenuId = "34" }},
            {typeof(CurrentSensePage), new Metadata() { MenuItem = "Current Sense", MenuId = "56" }},
            {typeof(SwitchesAndRelaysPage), new Metadata() { MenuItem = "Switches & Relays", MenuId = "57" }},
            {typeof(FeedLinesCalibrationPage), new Metadata() { MenuItem = "Feed Lines Calibration", MenuId = "106" }},
	        #endregion

            #region History Pages:

            {typeof(TemperatureHistoryPage), new Metadata() { MenuItem = "Temprature", MenuId = "35" }},
            {typeof(HumidityHistoryPage), new Metadata() { MenuItem = "Humidity", MenuId = "36" }},
            {typeof(Co2HistoryPage), new Metadata() { MenuItem = "CO2", MenuId = "37" }},
            {typeof(BirdWeightHistoryPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "38" }},
            {typeof(FeedConversionHistoryPage), new Metadata() { MenuItem = "Feed Conversion", MenuId = "39" }},
            {typeof(WaterHistoryPage), new Metadata() { MenuItem = "Water", MenuId = "40" }},
            {typeof(FeedConsumptionHistoryPage), new Metadata() {MenuItem = "Feed", MenuId = "41"}},
            {typeof(MortalityHistoryPage), new Metadata() { MenuItem = "Mortality", MenuId = "42" }},
            {typeof(HeatersHistoryPage), new Metadata() { MenuItem = "Heaters", MenuId = "43" }},
            {typeof(RadiantHeatersHistoryPage), new Metadata() { MenuItem = "Radiant Heaters", MenuId = "44" }},
            {typeof(AlarmsHistoryPage), new Metadata() { MenuItem = "Alarms", MenuId = "45" }},
            {typeof(EventsLogHistoryPage), new Metadata() { MenuItem = "Table Of Events", MenuId = "46" }},
            {typeof(PowerConsumptionHistoryPage), new Metadata() { MenuItem = "Power Consumption", MenuId = "47" }},
            {typeof(HistoryViewPage), new Metadata() { MenuItem = "History View", MenuId = "48" }},
            {typeof(AmmoniaHistoryPage), new Metadata() { MenuItem = "Ammonia", MenuId = "130" }},
            {typeof(EggRoomhistoryPage), new Metadata() { MenuItem = "Egg Room", MenuId = "120" }},
            {typeof(EggBelthistoryPage), new Metadata() { MenuItem = "Egg Belt Run Time", MenuId = "124" }},
            {typeof(EggshistoryPage), new Metadata() { MenuItem = "Eggs History", MenuId = "127" }},
	        #endregion

            #region Testing & Calibration Pages:
		 
            {typeof(AnalogSensorsPage), new Metadata() { MenuItem = "Analog Sensors", MenuId = "49" }},
            {typeof(DigitalSensorsPage), new Metadata() { MenuItem = "Digital Sensors", MenuId = "50" }},
            {typeof(StaticPressureCalibrationPage), new Metadata(){MenuItem = "S.Pressure", MenuId = "51"}},
            {typeof(WaterTabPage), new Metadata() { MenuId = "53" }},
            {typeof(WaterAndFeedCalibrationPage), new Metadata() { MenuItem = "Water & Feed Calibration", MenuId = "53" }},
            {typeof(FeedTabPage), new Metadata(){ MenuId = "84"}},
            {typeof(ScalesPage), new Metadata() { MenuItem = "Scales Testing & Calibration", MenuId = "55" }},
            {typeof(HardwareChecklistPage), new Metadata(){ MenuItem= "Hardware Checklist", MenuId= "60"}},
            {typeof(WindDirectionCalibrationPage), new Metadata(){ MenuItem= "Hardware Checklist",MenuId= "62"}},

	        #endregion

            #region System Pages:
		 
            {typeof(ExhaustAndTunnelFansTabPage), new Metadata(){ MenuId= "85", ParentId="65"}},//85
            {typeof(VentAndCurtainTabPage), new Metadata(){ MenuId= "86",ParentId="65"}},//86
            {typeof(VariableSpeedFansTabPage), new Metadata(){ MenuId= "87",ParentId="65"}},//87
            {typeof(StirAndVariableStirFansTabFansPage), new Metadata(){ MenuId= "88",ParentId="65"}},//88
            {typeof(GeneralSetupPage), new Metadata() { MenuItem = "Setup", MenuId = "63" }},
            {typeof(HouseDimensionsPage), new Metadata() { MenuItem = "House Dimensions", MenuId = "63" }},
            {typeof(TimeAndDatePage), new Metadata() { MenuItem = "Time & Date", MenuId = "64" }},
            {typeof(StirFanProgramPage), new Metadata() { MenuItem = "Stir Fan Program", MenuId = "66" }},
            {typeof(RelayLayoutPage), new Metadata() { MenuItem = "Relay Layout", MenuId = "67" }},
            {typeof(AnalogTabPage), new Metadata() { MenuId = "181" }},
            {typeof(DigitalTabPage), new Metadata() { MenuId = "81" }},
            {typeof(AnalogOutputsInstallationPage), new Metadata() { MenuItem = "Analog Output", MenuId = "69" }},
            {typeof(LevelsOfVentilationPage), new Metadata() { MenuItem = "Level Of Ventilation", MenuId = "65" }},
            {typeof(SensorsInstallationPage), new Metadata() { MenuItem = "Sensors Installation", MenuId = "68" }},
            {typeof(TemperatureDefinitionPage), new Metadata() { MenuItem = "Temp Definition", MenuId = "71" }},
            {typeof(VentCurtSetupPage), new Metadata() {MenuItem = "Vent/Curt Setup", MenuId="72"}},
            {typeof(AirInletsSetupPage), new Metadata() { MenuItem = "Air Inlets Setup", MenuId = "72" }},
            {typeof(FanAirCapacityPage), new Metadata() { MenuItem = "Fan Air Capacity", MenuId = "74" }},
            {typeof(BirdCurvePage), new Metadata() { MenuItem = "Bird Curve", MenuId = "75" }},
            {typeof(ScaleSettingsPage), new Metadata() { MenuItem = "Scale Settings", MenuId = "76" }},
            {typeof(SiloAugerLayoutPage), new Metadata() { MenuItem = "Silo/Auger Layout", MenuId = "77" }},
            {typeof(CommunicationPage), new Metadata() { MenuItem = "Communication", MenuId = "78" }},
            {typeof(VersionPage), new Metadata() { MenuItem = "Version", MenuId = "108" }},
            {typeof(ScaleTestingPage), new Metadata() { MenuItem = "Scale Testing", MenuId = "55" }},
            {typeof(ScaleLayoutPage), new Metadata() { MenuItem = "Scale Layout", MenuId = "99" }},
            {typeof(MuntersDrivePage), new Metadata() { MenuItem = "Munters Drive", MenuId = "140" }},
            {typeof(BirdWeightPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "162" }},

	        #endregion

            #region Hot Key Pages:

            {typeof(CurvePage), new Metadata(){ MenuItem = "Curve Status", MenuId= "101"}} ,
            {typeof(LightStatusPage), new Metadata(){ MenuItem = "Light Status",  MenuId= "102"}},
            {typeof(LightStatusTabPage), new Metadata(){ MenuId= "107" }},
            {typeof(LightTabPage), new Metadata(){ MenuId= "109" }},
            {typeof(NaturalVentilationPageHotkey), new Metadata(){ MenuItem = "Natural Ventilation",  MenuId= "103"}},
            {typeof(AnalogOutputStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "110"}},
            {typeof(TemperatureandHumidityPage), new Metadata(){ MenuItem = "Temperature And Humidity",  MenuId= "111"}},
            {typeof(FeedScaleStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "138"}},
            {typeof(WaterMetersPage), new Metadata(){ MenuItem = "Water Meters",  MenuId= "141"}},
            {typeof(EggRoomStatusPage), new Metadata(){ MenuItem = "Egg Room Status",  MenuId= "117"}},
            {typeof(EggCounterStatePage), new Metadata(){ MenuItem = "Egg Counter State",  MenuId= "128"}},
            {typeof(BirdScalePage), new Metadata(){ MenuItem = "Bird Scale",  MenuId= "155"}},
            {typeof(SiloPage), new Metadata(){ MenuItem = "Silo",  MenuId= "148"}},
            {typeof(CurtainPositionPage), new Metadata(){ MenuItem = "Curtain Position",  MenuId= "149"}},
            {typeof(AirStatusPage), new Metadata(){ MenuItem = "Air Status",  MenuId= "150"}},
            {typeof(WaterAndFeedStatusPage), new Metadata(){ MenuItem = "Water & Feed Status",  MenuId= "151"}},
            #endregion
        };


        private static readonly Dictionary<Type, Metadata> BreederPrecisionAdvancedFeedingPagesMetadataDictionary = new Dictionary<Type, Metadata>()
        {
            #region Control Pages:

            {typeof(TemperatureCurvePage), new Metadata() { MenuItem = "Temperature Curve", MenuId = "6"}},
            {typeof(MinMaxLevelByDaysPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "7" /* Todo: Need to figure what level control was set, and then set the correct value*/ }},
            {typeof(MinMaxLevelByDaysCurvePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "8" }},
            {typeof(MinMaxLevelByTimePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "9" }},
            {typeof(MinMaxLevelBySoftMinPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "10" }},
            {typeof(MinMaxLevelByWeightPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "11" }},
            {typeof(HumidityTreatmentPage), new Metadata() { MenuItem = "Humidity Treatment", MenuId = "12" }},
            {typeof(Co2TreatmentPage), new Metadata() { MenuItem = "CO2 Treatment", MenuId = "13" }},
            {typeof(CoolPadPage), new Metadata() { MenuItem = "Cool Pad", MenuId = "16" }},
            {typeof(NaturalVentilationPage), new Metadata() { MenuItem = "Natural Ventilation", MenuId = "14" }},
            {typeof(StaticPressurePage), new Metadata() { MenuItem = "S.Pressure", MenuId = "15" }},
            {typeof(FoggersPage), new Metadata() { MenuItem = "Foggers", MenuId = "17" }},
            {typeof(WaterAndFeedPage), new Metadata() { MenuItem = @"Water & Feed", MenuId = "136" }},
            {typeof(LightControlPage), new Metadata() { MenuItem = "Light Control", MenuId = "19" }},
            {typeof(LightFeedTabPage), new Metadata() { MenuId = "92" }},
            {typeof(LightNoFeedTabPage), new Metadata() { MenuId = "93" }},
            {typeof(ExtraSystemsPage), new Metadata() { MenuItem = "Extra Systems", MenuId = "20" }},
            {typeof(ControlModePage), new Metadata() { MenuItem = "Control Mode", MenuId = "21" }},
            {typeof(SystemParametersPage), new Metadata() { MenuItem = "System Parameters", MenuId = "22" }},
            {typeof(AmmoniaTreatmentPage), new Metadata() { MenuItem = "Ammonia Treatment", MenuId = "129" }},
            {typeof(FeedScaleProgramPage), new Metadata() { MenuItem = "Feed Scale Program", MenuId = "145" }},
            {typeof(LightDimmersPage), new Metadata() { MenuItem = "Light Dimmers", MenuId = "143" }},
            {typeof(EggRoomControlPage), new Metadata() { MenuItem = "Egg Room Control", MenuId = "116" }},
            {typeof(WorkRoomControlPage), new Metadata() { MenuItem = "Work Room Control", MenuId = "133" }},
            {typeof(NestsPage), new Metadata() { MenuItem = "Nests", MenuId = "134" }},

            #endregion

            #region Management Pages:

            {typeof(BirdInventoryPage), new Metadata() { MenuItem = "Bird Inventory", MenuId = "23" , ContainerId = "Data"}},
            {typeof(FeedInventoryPage), new Metadata() { MenuItem = "Feed Inventory", MenuId = "24" }},
            {typeof(GrowthDayAndFlockPage), new Metadata() { MenuItem = "Growth Day & Flock", MenuId = "25" }},
            {typeof(AlarmSettingsPage), new Metadata() { MenuItem = "Alarm Settings", MenuId = "26" }},
            {typeof(AlarmResetPage), new Metadata() { MenuItem = "Alarm Reset", MenuId = "27" }},
            {typeof(AlarmResetTabPage), new Metadata() { MenuId = "27" }},
            {typeof(FailSafeSettingPage), new Metadata() { MenuItem = "Fail Safe Settings", MenuId = "28" }},
            {typeof(PasswordPage), new Metadata() { MenuItem = "Password", MenuId = "30" }},
            {typeof(FeedersAndDrinkersPage), new Metadata() { MenuItem = "Feeders & Drinkers", MenuId = "32" }},
            {typeof(NippleFlushingPage), new Metadata() { MenuItem = "Nipple Flushing", MenuId = "33" }},
            {typeof(ScheduleTabPage), new Metadata() { MenuId = "121" }},
            {typeof(OrderTabPage), new Metadata() { MenuId = "80" }},
            {typeof(WaterOnDemandPage), new Metadata() { MenuItem = "Water On Demand", MenuId = "34" }},
            {typeof(CurrentSensePage), new Metadata() { MenuItem = "Current Sense", MenuId = "56" }},
            {typeof(SwitchesAndRelaysPage), new Metadata() { MenuItem = "Switches & Relays", MenuId = "57" }},
            {typeof(FeedLinesCalibrationPage), new Metadata() { MenuItem = "Feed Lines Calibration", MenuId = "106" }},
	        #endregion

            #region History Pages:

            {typeof(TemperatureHistoryPage), new Metadata() { MenuItem = "Temprature", MenuId = "35" }},
            {typeof(HumidityHistoryPage), new Metadata() { MenuItem = "Humidity", MenuId = "36" }},
            {typeof(Co2HistoryPage), new Metadata() { MenuItem = "CO2", MenuId = "37" }},
            {typeof(BirdWeightHistoryPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "38" }},
            {typeof(FeedConversionHistoryPage), new Metadata() { MenuItem = "Feed Conversion", MenuId = "39" }},
            {typeof(WaterHistoryPage), new Metadata() { MenuItem = "Water", MenuId = "40" }},
            {typeof(FeedConsumptionHistoryPage), new Metadata() {MenuItem = "Feed", MenuId = "41"}},
            {typeof(MortalityHistoryPage), new Metadata() { MenuItem = "Mortality", MenuId = "42" }},
            {typeof(HeatersHistoryPage), new Metadata() { MenuItem = "Heaters", MenuId = "43" }},
            {typeof(RadiantHeatersHistoryPage), new Metadata() { MenuItem = "Radiant Heaters", MenuId = "44" }},
            {typeof(AlarmsHistoryPage), new Metadata() { MenuItem = "Alarms", MenuId = "45" }},
            {typeof(EventsLogHistoryPage), new Metadata() { MenuItem = "Table Of Events", MenuId = "46" }},
            {typeof(PowerConsumptionHistoryPage), new Metadata() { MenuItem = "Power Consumption", MenuId = "47" }},
            {typeof(HistoryViewPage), new Metadata() { MenuItem = "History View", MenuId = "48" }},
            {typeof(AmmoniaHistoryPage), new Metadata() { MenuItem = "Ammonia", MenuId = "130" }},
            {typeof(EggRoomhistoryPage), new Metadata() { MenuItem = "Egg Room", MenuId = "120" }},
            {typeof(EggBelthistoryPage), new Metadata() { MenuItem = "Egg Belt Run Time", MenuId = "124" }},
            {typeof(EggshistoryPage), new Metadata() { MenuItem = "Eggs History", MenuId = "127" }},
	        #endregion

            #region Testing & Calibration Pages:
		 
            {typeof(AnalogSensorsPage), new Metadata() { MenuItem = "Analog Sensors", MenuId = "49" }},
            {typeof(DigitalSensorsPage), new Metadata() { MenuItem = "Digital Sensors", MenuId = "50" }},
            {typeof(StaticPressureCalibrationPage), new Metadata(){MenuItem = "S.Pressure", MenuId = "51"}},
            {typeof(WaterTabPage), new Metadata() { MenuId = "53" }},
            {typeof(WaterAndFeedCalibrationPage), new Metadata() { MenuItem = "Water & Feed Calibration", MenuId = "53" }},
            {typeof(FeedTabPage), new Metadata(){ MenuId = "84"}},
            {typeof(ScalesPage), new Metadata() { MenuItem = "Scales Testing & Calibration", MenuId = "55" }},
            {typeof(HardwareChecklistPage), new Metadata(){ MenuItem= "Hardware Checklist", MenuId= "60"}},
            {typeof(WindDirectionCalibrationPage), new Metadata(){ MenuItem= "Hardware Checklist",MenuId= "62"}},

	        #endregion

            #region System Pages:
		 
            {typeof(ExhaustAndTunnelFansTabPage), new Metadata(){ MenuId= "85", ParentId="65"}},//85
            {typeof(VentAndCurtainTabPage), new Metadata(){ MenuId= "86",ParentId="65"}},//86
            {typeof(VariableSpeedFansTabPage), new Metadata(){ MenuId= "87",ParentId="65"}},//87
            {typeof(StirAndVariableStirFansTabFansPage), new Metadata(){ MenuId= "88",ParentId="65"}},//88
            {typeof(GeneralSetupPage), new Metadata() { MenuItem = "Setup", MenuId = "63" }},
            {typeof(HouseDimensionsPage), new Metadata() { MenuItem = "House Dimensions", MenuId = "63" }},
            {typeof(TimeAndDatePage), new Metadata() { MenuItem = "Time & Date", MenuId = "64" }},
            {typeof(StirFanProgramPage), new Metadata() { MenuItem = "Stir Fan Program", MenuId = "66" }},
            {typeof(RelayLayoutPage), new Metadata() { MenuItem = "Relay Layout", MenuId = "67" }},
            {typeof(AnalogTabPage), new Metadata() { MenuId = "181" }},
            {typeof(DigitalTabPage), new Metadata() { MenuId = "81" }},
            {typeof(AnalogOutputsInstallationPage), new Metadata() { MenuItem = "Analog Output", MenuId = "69" }},
            {typeof(LevelsOfVentilationPage), new Metadata() { MenuItem = "Level Of Ventilation", MenuId = "65" }},
            {typeof(SensorsInstallationPage), new Metadata() { MenuItem = "Sensors Installation", MenuId = "68" }},
            {typeof(TemperatureDefinitionPage), new Metadata() { MenuItem = "Temp Definition", MenuId = "71" }},
            {typeof(VentCurtSetupPage), new Metadata() {MenuItem = "Vent/Curt Setup", MenuId="72"}},
            {typeof(AirInletsSetupPage), new Metadata() { MenuItem = "Air Inlets Setup", MenuId = "72" }},
            {typeof(FanAirCapacityPage), new Metadata() { MenuItem = "Fan Air Capacity", MenuId = "74" }},
            {typeof(BirdCurvePage), new Metadata() { MenuItem = "Bird Curve", MenuId = "75" }},
            {typeof(ScaleSettingsPage), new Metadata() { MenuItem = "Scale Settings", MenuId = "76" }},
            {typeof(SiloAugerLayoutPage), new Metadata() { MenuItem = "Silo/Auger Layout", MenuId = "77" }},
            {typeof(CommunicationPage), new Metadata() { MenuItem = "Communication", MenuId = "78" }},
            {typeof(VersionPage), new Metadata() { MenuItem = "Version", MenuId = "108" }},
            {typeof(ScaleTestingPage), new Metadata() { MenuItem = "Scale Testing", MenuId = "55" }},
            {typeof(ScaleLayoutPage), new Metadata() { MenuItem = "Scale Layout", MenuId = "99" }},
            {typeof(MuntersDrivePage), new Metadata() { MenuItem = "Munters Drive", MenuId = "140" }},
            {typeof(BirdWeightPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "162" }},

	        #endregion

            #region Hot Key Pages:

            {typeof(CurvePage), new Metadata(){ MenuItem = "Curve Status", MenuId= "101"}} ,
            {typeof(LightStatusPage), new Metadata(){ MenuItem = "Light Status",  MenuId= "102"}},
            {typeof(LightStatusTabPage), new Metadata(){ MenuId= "107" }},
            {typeof(LightTabPage), new Metadata(){ MenuId= "109" }},
            {typeof(NaturalVentilationPageHotkey), new Metadata(){ MenuItem = "Natural Ventilation",  MenuId= "103"}},
            {typeof(AnalogOutputStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "110"}},
            {typeof(TemperatureandHumidityPage), new Metadata(){ MenuItem = "Temperature And Humidity",  MenuId= "111"}},
            {typeof(FeedScaleStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "138"}},
            {typeof(WaterMetersPage), new Metadata(){ MenuItem = "Water Meters",  MenuId= "141"}},
            {typeof(EggRoomStatusPage), new Metadata(){ MenuItem = "Egg Room Status",  MenuId= "117"}},
            {typeof(EggCounterStatePage), new Metadata(){ MenuItem = "Egg Counter State",  MenuId= "128"}},
            {typeof(BirdScalePage), new Metadata(){ MenuItem = "Bird Scale",  MenuId= "155"}},
            {typeof(SiloPage), new Metadata(){ MenuItem = "Silo",  MenuId= "148"}},
            {typeof(CurtainPositionPage), new Metadata(){ MenuItem = "Curtain Position",  MenuId= "149"}},
            {typeof(AirStatusPage), new Metadata(){ MenuItem = "Air Status",  MenuId= "150"}},
            {typeof(WaterAndFeedStatusPage), new Metadata(){ MenuItem = "Water & Feed Status",  MenuId= "151"}},
            #endregion
        };

        private static readonly Dictionary<Type, Metadata> BreederStandardBasicFeedingPagesMetadataDictionary = new Dictionary<Type, Metadata>()
        {
            #region Control Pages:
            {typeof(AmmoniaTreatmentPage), new Metadata() { MenuId = "131" }},
            {typeof(TemperatureCurvePage), new Metadata() { MenuItem = "Temperature Curve", MenuId = "6"}},
            {typeof(MinVentTimerPage), new Metadata() { MenuItem = "Min Vent Timer", MenuId = "94" }},
            {typeof(TimerSettingsPage), new Metadata() { MenuItem = "Timer Settings", MenuId = "95" }},
            {typeof(HumidityTreatmentPage), new Metadata() { MenuItem = "Humidity Treatment", MenuId = "97" }},
            {typeof(Co2TreatmentPage), new Metadata() { MenuItem = "CO2 Treatment", MenuId = "132" }},
            {typeof(StaticPressurePage), new Metadata() { MenuItem = "Static Pressure", MenuId = "96" }},
            {typeof(CoolPadPage), new Metadata() { MenuItem = "Cool Pad", MenuId = "16" }},
            {typeof(FoggersPage), new Metadata() { MenuItem = "Foggers", MenuId = "17" }},
            {typeof(WaterAndFeedPage), new Metadata() { MenuId = "136" }},
            {typeof(LightFeedTabPage), new Metadata() { MenuId = "92" }},
            {typeof(LightNoFeedTabPage), new Metadata() { MenuId = "93" }},
            {typeof(LightControlPage), new Metadata() { MenuItem = "Light", MenuId = "19" }},
            {typeof(ExtraSystemsPage), new Metadata() { MenuId = "20" }},
            {typeof(ControlModePage), new Metadata() { MenuItem = "Control Mode", MenuId = "21" }},
            {typeof(SystemParametersPage), new Metadata() { MenuItem = "System Parameters", MenuId = "22" }},
            {typeof(NestsPage), new Metadata() { MenuItem = "Nests", MenuId = "134" }},
            {typeof(LightDimmersPage), new Metadata() { MenuItem = "Light Dimmers", MenuId = "143" }},
            {typeof(EggRoomControlPage), new Metadata() { MenuItem = "Egg Room Control", MenuId = "116" }},
            {typeof(WorkRoomControlPage), new Metadata() { MenuItem = "Work Room Control", MenuId = "133" }},
            #endregion

            #region Management Pages:

            {typeof(BirdInventoryPage), new Metadata() { MenuItem = "Bird Inventory", MenuId = "23" , ContainerId = "Data"}},
            {typeof(FeedInventoryPage), new Metadata() { MenuItem = "Feed Inventory", MenuId = "24" }},
            {typeof(GrowthDayAndFlockPage), new Metadata() { MenuItem = "Growth Day & Flock", MenuId = "25" }},
            {typeof(AlarmSettingsPage), new Metadata() { MenuItem = "Alarm Settings", MenuId = "26" }},
            {typeof(AlarmResetPage), new Metadata() { MenuItem = "Alarm Reset", MenuId = "27" }},
            {typeof(AlarmResetTabPage), new Metadata() { MenuId = "27" }},
            {typeof(FailSafeSettingPage), new Metadata() { MenuItem = "Fail Safe Settings", MenuId = "28" }},
            {typeof(PasswordPage), new Metadata() { MenuItem = "Password", MenuId = "30" }},
            {typeof(FeedLinesCalibrationPage), new Metadata() { MenuItem = "Password", MenuId = "106" }},
            {typeof(NippleFlushingPage), new Metadata() { MenuItem = "Nipple Flushing", MenuId = "33" }},
            {typeof(ScheduleTabPage), new Metadata() { MenuId = "121" }},
            {typeof(OrderTabPage), new Metadata() { MenuId = "80" }},
            {typeof(WaterOnDemandPage), new Metadata() { MenuItem = "Water On Demand", MenuId = "34" }},
            {typeof(CurrentSensePage), new Metadata() { MenuItem = "Current Sense", MenuId = "56" }},
            {typeof(SwitchesAndRelaysPage), new Metadata() { MenuItem = "Switches & Relays", MenuId = "57" }},
	        #endregion

            #region History Pages:

            {typeof(TemperatureHistoryPage), new Metadata() { MenuItem = "Temprature", MenuId = "35" }},
            {typeof(HumidityHistoryPage), new Metadata() { MenuItem = "Humidity", MenuId = "36" }},
            {typeof(Co2HistoryPage), new Metadata() { MenuItem = "CO2", MenuId = "37" }},
            {typeof(BirdWeightHistoryPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "38" }},
            {typeof(FeedConversionHistoryPage), new Metadata() { MenuItem = "Feed Conversion", MenuId = "39" }},
            {typeof(WaterHistoryPage), new Metadata() { MenuItem = "Water", MenuId = "40" }},
            {typeof(FeedConsumptionHistoryPage), new Metadata() {MenuItem = "Feed", MenuId = "41"}},
            {typeof(MortalityHistoryPage), new Metadata() { MenuItem = "Mortality", MenuId = "42" }},
            {typeof(HeatersHistoryPage), new Metadata() { MenuItem = "Heaters", MenuId = "43" }},
            {typeof(RadiantHeatersHistoryPage), new Metadata() { MenuItem = "Radiant Heaters", MenuId = "44" }},
            {typeof(AlarmsHistoryPage), new Metadata() { MenuItem = "Alarms", MenuId = "45" }},
            {typeof(EventsLogHistoryPage), new Metadata() { MenuItem = "Table Of Events", MenuId = "46" }},
            {typeof(PowerConsumptionHistoryPage), new Metadata() { MenuItem = "Power Consumption", MenuId = "47" }},
            {typeof(HistoryViewPage), new Metadata() { MenuItem = "History View", MenuId = "48" }},
            {typeof(AmmoniaHistoryPage), new Metadata() { MenuItem = "Ammonia", MenuId = "130" }},
            {typeof(EggRoomhistoryPage), new Metadata() { MenuItem = "Egg Room", MenuId = "120" }},
            {typeof(EggBelthistoryPage), new Metadata() { MenuItem = "Egg Belt Run Time", MenuId = "124" }},
            {typeof(EggshistoryPage), new Metadata() { MenuItem = "Eggs History", MenuId = "127" }},
            #endregion

            #region System Pages:

            {typeof(ScaleTestingPage), new Metadata() { MenuItem = "Scale Testing", MenuId = "55" }},
            {typeof(HardwareChecklistPage), new Metadata(){ MenuItem= "Hardware Checklist", MenuId= "60"}},
            {typeof(GeneralSetupPage), new Metadata() { MenuItem = "Setup", MenuId = "63" }},
            {typeof(TimeAndDatePage), new Metadata() { MenuItem = "Time & Date", MenuId = "64" }},
            {typeof(RelayLayoutPage), new Metadata() { MenuItem = "Relay Layout", MenuId = "67" }},
            {typeof(VariableSpeedFansSettingPage), new Metadata() {MenuItem = "Variable Speed Fans Setting", MenuId="115"}},
            {typeof(SensorsInstallationPage), new Metadata() { MenuItem = "Sensors Installation", MenuId = "68" }},
            {typeof(AnalogTabPage), new Metadata() { MenuId = "181" }},
            {typeof(DigitalTabPage), new Metadata() { MenuId = "81" }},
            {typeof(AnalogOutputsInstallationPage), new Metadata() { MenuItem = "Analog Output", MenuId = "69" }},
            {typeof(TemperatureDefinitionPage), new Metadata() { MenuItem = "Temp Definition", MenuId = "71" }},
            {typeof(TemperatureAndTimerPage), new Metadata() { MenuItem = "Temperature & Timer Settings", MenuId = "98" }},
            {typeof(VentCurtSetupPage), new Metadata() {MenuItem = "Vent/Curt Setup", MenuId="72"}},
            {typeof(AirInletsSetupPage), new Metadata() { MenuItem = "Air Inlets Setup", MenuId = "72" }},
            {typeof(HouseDimensionsPage), new Metadata() { MenuItem = "House Dimensions", MenuId = "72" }},
            {typeof(FanAirCapacityPage), new Metadata() { MenuItem = "Fan Air Capacity", MenuId = "74" }},
            {typeof(BirdCurvePage), new Metadata() { MenuItem = "Bird Curve", MenuId = "75" }},
            {typeof(ScaleSettingsPage), new Metadata() { MenuItem = "Scale Settings", MenuId = "76" }},
            {typeof(CommunicationPage), new Metadata() { MenuItem = "Communication", MenuId = "78" }},
            {typeof(ScaleLayoutPage), new Metadata() { MenuItem = "Scale Layout", MenuId = "99" }},
            {typeof(VersionPage), new Metadata() { MenuItem = "Version", MenuId = "108" }},
            {typeof(BirdWeightPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "162" }},

            #endregion

            #region Hot Key Pages:

            {typeof(CurvePage), new Metadata(){ MenuItem = "Curve Status", MenuId= "101"}} ,
            {typeof(LightStatusPage), new Metadata(){ MenuItem = "Light Status",  MenuId= "102"}},
            {typeof(LightStatusTabPage), new Metadata(){ MenuId= "107" }},
            {typeof(LightTabPage), new Metadata(){ MenuId= "109" }},
            {typeof(TemperatureandHumidityPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "111"}},
            {typeof(AnalogOutputStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "110"}},
            {typeof(EggRoomStatusPage), new Metadata(){ MenuItem = "Egg Room Status",  MenuId= "117"}},
            {typeof(EggCounterStatePage), new Metadata(){ MenuItem = "Egg Counter State",  MenuId= "128"}},
            {typeof(WaterMetersPage), new Metadata(){ MenuItem = "Water Meters",  MenuId= "141"}},
            {typeof(BirdScalePage), new Metadata(){ MenuItem = "Bird Scale",  MenuId= "155"}},
            {typeof(SiloPage), new Metadata(){ MenuItem = "Silo",  MenuId= "148"}},
            {typeof(CurtainPositionPage), new Metadata(){ MenuItem = "Curtain Position",  MenuId= "149"}},


            #endregion
        };

        private static readonly Dictionary<Type, Metadata> BreederStandardAdvancedFeedingPagesMetadataDictionary = new Dictionary<Type, Metadata>()
        {
            #region Control Pages:
            {typeof(AmmoniaTreatmentPage), new Metadata() { MenuId = "131" }},
            {typeof(TemperatureCurvePage), new Metadata() { MenuItem = "Temperature Curve", MenuId = "6"}},
            {typeof(MinVentTimerPage), new Metadata() { MenuItem = "Min Vent Timer", MenuId = "94" }},
            {typeof(TimerSettingsPage), new Metadata() { MenuItem = "Timer Settings", MenuId = "95" }},
            {typeof(HumidityTreatmentPage), new Metadata() { MenuItem = "Humidity Treatment", MenuId = "97" }},
            {typeof(Co2TreatmentPage), new Metadata() { MenuItem = "CO2 Treatment", MenuId = "132" }},
            {typeof(StaticPressurePage), new Metadata() { MenuItem = "Static Pressure", MenuId = "96" }},
            {typeof(CoolPadPage), new Metadata() { MenuItem = "Cool Pad", MenuId = "16" }},
            {typeof(FoggersPage), new Metadata() { MenuItem = "Foggers", MenuId = "17" }},
            {typeof(WaterAndFeedPage), new Metadata() { MenuId = "136" }},
            {typeof(LightFeedTabPage), new Metadata() { MenuId = "92" }},
            {typeof(LightNoFeedTabPage), new Metadata() { MenuId = "93" }},
            {typeof(LightControlPage), new Metadata() { MenuItem = "Light", MenuId = "19" }},
            {typeof(ExtraSystemsPage), new Metadata() { MenuId = "20" }},
            {typeof(ControlModePage), new Metadata() { MenuItem = "Control Mode", MenuId = "21" }},
            {typeof(SystemParametersPage), new Metadata() { MenuItem = "System Parameters", MenuId = "22" }},
            {typeof(NestsPage), new Metadata() { MenuItem = "Nests", MenuId = "134" }},
            {typeof(LightDimmersPage), new Metadata() { MenuItem = "Light Dimmers", MenuId = "143" }},
            {typeof(EggRoomControlPage), new Metadata() { MenuItem = "Egg Room Control", MenuId = "116" }},
            {typeof(WorkRoomControlPage), new Metadata() { MenuItem = "Work Room Control", MenuId = "133" }},
            {typeof(FeedScaleProgramPage), new Metadata() { MenuItem = "Feed Scale Program", MenuId = "145" }},
            #endregion

            #region Management Pages:

            {typeof(BirdInventoryPage), new Metadata() { MenuItem = "Bird Inventory", MenuId = "23" , ContainerId = "Data"}},
            {typeof(FeedInventoryPage), new Metadata() { MenuItem = "Feed Inventory", MenuId = "24" }},
            {typeof(GrowthDayAndFlockPage), new Metadata() { MenuItem = "Growth Day & Flock", MenuId = "25" }},
            {typeof(AlarmSettingsPage), new Metadata() { MenuItem = "Alarm Settings", MenuId = "26" }},
            {typeof(AlarmResetPage), new Metadata() { MenuItem = "Alarm Reset", MenuId = "27" }},
            {typeof(AlarmResetTabPage), new Metadata() { MenuId = "27" }},
            {typeof(FailSafeSettingPage), new Metadata() { MenuItem = "Fail Safe Settings", MenuId = "28" }},
            {typeof(PasswordPage), new Metadata() { MenuItem = "Password", MenuId = "30" }},
            {typeof(FeedLinesCalibrationPage), new Metadata() { MenuItem = "Password", MenuId = "106" }},
            {typeof(NippleFlushingPage), new Metadata() { MenuItem = "Nipple Flushing", MenuId = "33" }},
            {typeof(ScheduleTabPage), new Metadata() { MenuId = "121" }},
            {typeof(OrderTabPage), new Metadata() { MenuId = "80" }},
            {typeof(WaterOnDemandPage), new Metadata() { MenuItem = "Water On Demand", MenuId = "34" }},
            {typeof(CurrentSensePage), new Metadata() { MenuItem = "Current Sense", MenuId = "56" }},
            {typeof(SwitchesAndRelaysPage), new Metadata() { MenuItem = "Switches & Relays", MenuId = "57" }},
	        #endregion

            #region History Pages:

            {typeof(TemperatureHistoryPage), new Metadata() { MenuItem = "Temprature", MenuId = "35" }},
            {typeof(HumidityHistoryPage), new Metadata() { MenuItem = "Humidity", MenuId = "36" }},
            {typeof(Co2HistoryPage), new Metadata() { MenuItem = "CO2", MenuId = "37" }},
            {typeof(BirdWeightHistoryPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "38" }},
            {typeof(FeedConversionHistoryPage), new Metadata() { MenuItem = "Feed Conversion", MenuId = "39" }},
            {typeof(WaterHistoryPage), new Metadata() { MenuItem = "Water", MenuId = "40" }},
            {typeof(FeedConsumptionHistoryPage), new Metadata() {MenuItem = "Feed", MenuId = "41"}},
            {typeof(MortalityHistoryPage), new Metadata() { MenuItem = "Mortality", MenuId = "42" }},
            {typeof(HeatersHistoryPage), new Metadata() { MenuItem = "Heaters", MenuId = "43" }},
            {typeof(RadiantHeatersHistoryPage), new Metadata() { MenuItem = "Radiant Heaters", MenuId = "44" }},
            {typeof(AlarmsHistoryPage), new Metadata() { MenuItem = "Alarms", MenuId = "45" }},
            {typeof(EventsLogHistoryPage), new Metadata() { MenuItem = "Table Of Events", MenuId = "46" }},
            {typeof(PowerConsumptionHistoryPage), new Metadata() { MenuItem = "Power Consumption", MenuId = "47" }},
            {typeof(HistoryViewPage), new Metadata() { MenuItem = "History View", MenuId = "48" }},
            {typeof(AmmoniaHistoryPage), new Metadata() { MenuItem = "Ammonia", MenuId = "130" }},
            {typeof(EggRoomhistoryPage), new Metadata() { MenuItem = "Egg Room", MenuId = "120" }},
            {typeof(EggBelthistoryPage), new Metadata() { MenuItem = "Egg Belt Run Time", MenuId = "124" }},
            {typeof(EggshistoryPage), new Metadata() { MenuItem = "Eggs History", MenuId = "127" }},
            #endregion

            #region System Pages:

            {typeof(ScaleTestingPage), new Metadata() { MenuItem = "Scale Testing", MenuId = "55" }},
            {typeof(HardwareChecklistPage), new Metadata(){ MenuItem= "Hardware Checklist", MenuId= "60"}},
            {typeof(GeneralSetupPage), new Metadata() { MenuItem = "Setup", MenuId = "63" }},
            {typeof(TimeAndDatePage), new Metadata() { MenuItem = "Time & Date", MenuId = "64" }},
            {typeof(RelayLayoutPage), new Metadata() { MenuItem = "Relay Layout", MenuId = "67" }},
            {typeof(VariableSpeedFansSettingPage), new Metadata() {MenuItem = "Variable Speed Fans Setting", MenuId="115"}},
            {typeof(SensorsInstallationPage), new Metadata() { MenuItem = "Sensors Installation", MenuId = "68" }},
            {typeof(AnalogTabPage), new Metadata() { MenuId = "181" }},
            {typeof(DigitalTabPage), new Metadata() { MenuId = "81" }},
            {typeof(AnalogOutputsInstallationPage), new Metadata() { MenuItem = "Analog Output", MenuId = "69" }},
            {typeof(TemperatureDefinitionPage), new Metadata() { MenuItem = "Temp Definition", MenuId = "71" }},
            {typeof(TemperatureAndTimerPage), new Metadata() { MenuItem = "Temperature & Timer Settings", MenuId = "98" }},
            {typeof(VentCurtSetupPage), new Metadata() {MenuItem = "Vent/Curt Setup", MenuId="72"}},
            {typeof(AirInletsSetupPage), new Metadata() { MenuItem = "Air Inlets Setup", MenuId = "72" }},
            {typeof(HouseDimensionsPage), new Metadata() { MenuItem = "House Dimensions", MenuId = "72" }},
            {typeof(FanAirCapacityPage), new Metadata() { MenuItem = "Fan Air Capacity", MenuId = "74" }},
            {typeof(BirdCurvePage), new Metadata() { MenuItem = "Bird Curve", MenuId = "75" }},
            {typeof(SiloAugerLayoutPage), new Metadata() { MenuItem = "Silo/Auger Layout", MenuId = "77" }},
            {typeof(ScaleSettingsPage), new Metadata() { MenuItem = "Scale Settings", MenuId = "76" }},
            {typeof(CommunicationPage), new Metadata() { MenuItem = "Communication", MenuId = "78" }},
            {typeof(ScaleLayoutPage), new Metadata() { MenuItem = "Scale Layout", MenuId = "99" }},
            {typeof(VersionPage), new Metadata() { MenuItem = "Version", MenuId = "108" }},
            {typeof(BirdWeightPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "162" }},

            #endregion

            #region Hot Key Pages:

            {typeof(CurvePage), new Metadata(){ MenuItem = "Curve Status", MenuId= "101"}} ,
            {typeof(LightStatusPage), new Metadata(){ MenuItem = "Light Status",  MenuId= "102"}},
            {typeof(LightStatusTabPage), new Metadata(){ MenuId= "107" }},
            {typeof(LightTabPage), new Metadata(){ MenuId= "109" }},
            {typeof(TemperatureandHumidityPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "111"}},
            {typeof(AnalogOutputStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "110"}},
            {typeof(EggRoomStatusPage), new Metadata(){ MenuItem = "Egg Room Status",  MenuId= "117"}},
            {typeof(EggCounterStatePage), new Metadata(){ MenuItem = "Egg Counter State",  MenuId= "128"}},
            {typeof(WaterMetersPage), new Metadata(){ MenuItem = "Water Meters",  MenuId= "141"}},
            {typeof(FeedScaleStatusPage), new Metadata(){ MenuItem = "Water Meters",  MenuId= "146"}},
            {typeof(BirdScalePage), new Metadata(){ MenuItem = "Bird Scale",  MenuId= "155"}},
            {typeof(SiloPage), new Metadata(){ MenuItem = "Silo",  MenuId= "148"}},
            {typeof(CurtainPositionPage), new Metadata(){ MenuItem = "Curtain Position",  MenuId= "149"}},



            #endregion
        };
        

        private static readonly Dictionary<Type, Metadata> LayerPrecisionPagesMetadataDictionary = new Dictionary<Type, Metadata>()
        {
            #region Control Pages:

            {typeof(TemperatureCurvePage), new Metadata() { MenuItem = "Temperature Curve", MenuId = "6"}},
            {typeof(MinMaxLevelByDaysPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "7" /* Todo: Need to figure what level control was set, and then set the correct value*/ }},
            {typeof(MinMaxLevelByDaysCurvePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "8" }},
            {typeof(MinMaxLevelByTimePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "9" }},
            {typeof(MinMaxLevelBySoftMinPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "10" }},
            {typeof(MinMaxLevelByWeightPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "11" }},
            {typeof(HumidityTreatmentPage), new Metadata() { MenuItem = "Humidity Treatment", MenuId = "12" }},
            {typeof(Co2TreatmentPage), new Metadata() { MenuItem = "CO2 Treatment", MenuId = "13" }},
            {typeof(CoolPadPage), new Metadata() { MenuItem = "Cool Pad", MenuId = "16" }},
            {typeof(NaturalVentilationPage), new Metadata() { MenuItem = "Natural Ventilation", MenuId = "14" }},
            {typeof(StaticPressurePage), new Metadata() { MenuItem = "S.Pressure", MenuId = "15" }},
            {typeof(FoggersPage), new Metadata() { MenuItem = "Foggers", MenuId = "17" }},
            {typeof(WaterAndFeedPage), new Metadata() { MenuItem = @"Water & Feed", MenuId = "18" }},
            {typeof(LightControlPage), new Metadata() { MenuItem = "Light Control", MenuId = "19" }},
            {typeof(LightFeedTabPage), new Metadata() { MenuId = "92" }},
            {typeof(LightNoFeedTabPage), new Metadata() { MenuId = "93" }},
            {typeof(ExtraSystemsPage), new Metadata() { MenuItem = "Extra Systems", MenuId = "20" }},
            {typeof(ControlModePage), new Metadata() { MenuItem = "Control Mode", MenuId = "21" }},
            {typeof(SystemParametersPage), new Metadata() { MenuItem = "System Parameters", MenuId = "22" }},
            {typeof(AmmoniaTreatmentPage), new Metadata() { MenuItem = "Ammonia Treatment", MenuId = "129" }},
            {typeof(LightDimmersPage), new Metadata() { MenuItem = "Light Dimmers", MenuId = "143" }},
            {typeof(NestsPage), new Metadata() { MenuItem = "Nests", MenuId = "134" }},

            #endregion

            #region Management Pages:

            {typeof(BirdInventoryPage), new Metadata() { MenuItem = "Bird Inventory", MenuId = "23" , ContainerId = "Data"}},
            {typeof(FeedInventoryPage), new Metadata() { MenuItem = "Feed Inventory", MenuId = "24" }},
            {typeof(GrowthDayAndFlockPage), new Metadata() { MenuItem = "Growth Day & Flock", MenuId = "25" }},
            {typeof(AlarmSettingsPage), new Metadata() { MenuItem = "Alarm Settings", MenuId = "26" }},
            {typeof(AlarmResetPage), new Metadata() { MenuItem = "Alarm Reset", MenuId = "27" }},
            {typeof(AlarmResetTabPage), new Metadata() { MenuId = "27" }},
            {typeof(FailSafeSettingPage), new Metadata() { MenuItem = "Fail Safe Settings", MenuId = "28" }},
            {typeof(PasswordPage), new Metadata() { MenuItem = "Password", MenuId = "30" }},
            {typeof(FeedersAndDrinkersPage), new Metadata() { MenuItem = "Feeders & Drinkers", MenuId = "144" }},
            {typeof(NippleFlushingPage), new Metadata() { MenuItem = "Nipple Flushing", MenuId = "33" }},
            {typeof(ScheduleTabPage), new Metadata() { MenuId = "121" }},
            {typeof(OrderTabPage), new Metadata() { MenuId = "80" }},
            {typeof(WaterOnDemandPage), new Metadata() { MenuItem = "Water On Demand", MenuId = "34" }},
            {typeof(CurrentSensePage), new Metadata() { MenuItem = "Current Sense", MenuId = "56" }},
            {typeof(SwitchesAndRelaysPage), new Metadata() { MenuItem = "Switches & Relays", MenuId = "57" }},
	        #endregion

            #region History Pages:

            {typeof(TemperatureHistoryPage), new Metadata() { MenuItem = "Temprature", MenuId = "35" }},
            {typeof(HumidityHistoryPage), new Metadata() { MenuItem = "Humidity", MenuId = "36" }},
            {typeof(Co2HistoryPage), new Metadata() { MenuItem = "CO2", MenuId = "37" }},
            {typeof(BirdWeightHistoryPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "38" }},
            {typeof(FeedConversionHistoryPage), new Metadata() { MenuItem = "Feed Conversion", MenuId = "39" }},
            {typeof(WaterHistoryPage), new Metadata() { MenuItem = "Water", MenuId = "40" }},
            {typeof(FeedConsumptionHistoryPage), new Metadata() {MenuItem = "Feed", MenuId = "41"}},
            {typeof(MortalityHistoryPage), new Metadata() { MenuItem = "Mortality", MenuId = "42" }},
            {typeof(HeatersHistoryPage), new Metadata() { MenuItem = "Heaters", MenuId = "43" }},
            {typeof(RadiantHeatersHistoryPage), new Metadata() { MenuItem = "Radiant Heaters", MenuId = "44" }},
            {typeof(AlarmsHistoryPage), new Metadata() { MenuItem = "Alarms", MenuId = "45" }},
            {typeof(EventsLogHistoryPage), new Metadata() { MenuItem = "Table Of Events", MenuId = "46" }},
            {typeof(PowerConsumptionHistoryPage), new Metadata() { MenuItem = "Power Consumption", MenuId = "47" }},
            {typeof(HistoryViewPage), new Metadata() { MenuItem = "History View", MenuId = "48" }},
            {typeof(AmmoniaHistoryPage), new Metadata() { MenuItem = "Ammonia", MenuId = "130" }},
            {typeof(EggshistoryPage), new Metadata() { MenuItem = "Eggs History", MenuId = "127" }},
	        #endregion

            #region Testing & Calibration Pages:
		 
            {typeof(AnalogSensorsPage), new Metadata() { MenuItem = "Analog Sensors", MenuId = "49" }},
            {typeof(DigitalSensorsPage), new Metadata() { MenuItem = "Digital Sensors", MenuId = "50" }},
            {typeof(StaticPressureCalibrationPage), new Metadata(){MenuItem = "S.Pressure", MenuId = "51"}},
            {typeof(WaterTabPage), new Metadata() { MenuId = "53" }},
            {typeof(WaterAndFeedCalibrationPage), new Metadata() { MenuItem = "Water & Feed Calibration", MenuId = "53" }},
            {typeof(FeedTabPage), new Metadata(){ MenuId = "84"}},
            {typeof(ScalesPage), new Metadata() { MenuItem = "Scales Testing & Calibration", MenuId = "55" }},
            {typeof(HardwareChecklistPage), new Metadata(){ MenuItem= "Hardware Checklist", MenuId= "60"}},
            {typeof(WindDirectionCalibrationPage), new Metadata(){ MenuItem= "Hardware Checklist",MenuId= "62"}},

	        #endregion

            #region System Pages:
		 
            {typeof(ExhaustAndTunnelFansTabPage), new Metadata(){ MenuId= "85", ParentId="65"}},//85
            {typeof(VentAndCurtainTabPage), new Metadata(){ MenuId= "86",ParentId="65"}},//86
            {typeof(VariableSpeedFansTabPage), new Metadata(){ MenuId= "87",ParentId="65"}},//87
            {typeof(StirAndVariableStirFansTabFansPage), new Metadata(){ MenuId= "88",ParentId="65"}},//88
            {typeof(GeneralSetupPage), new Metadata() { MenuItem = "Setup", MenuId = "63" }},
            {typeof(HouseDimensionsPage), new Metadata() { MenuItem = "House Dimensions", MenuId = "63" }},
            {typeof(TimeAndDatePage), new Metadata() { MenuItem = "Time & Date", MenuId = "64" }},
            {typeof(StirFanProgramPage), new Metadata() { MenuItem = "Stir Fan Program", MenuId = "66" }},
            {typeof(RelayLayoutPage), new Metadata() { MenuItem = "Relay Layout", MenuId = "67" }},
            {typeof(AnalogTabPage), new Metadata() { MenuId = "181" }},
            {typeof(DigitalTabPage), new Metadata() { MenuId = "81" }},
            {typeof(AnalogOutputsInstallationPage), new Metadata() { MenuItem = "Analog Output", MenuId = "69" }},
            {typeof(LevelsOfVentilationPage), new Metadata() { MenuItem = "Level Of Ventilation", MenuId = "65" }},
            {typeof(SensorsInstallationPage), new Metadata() { MenuItem = "Sensors Installation", MenuId = "68" }},
            {typeof(TemperatureDefinitionPage), new Metadata() { MenuItem = "Temp Definition", MenuId = "71" }},
            {typeof(VentCurtSetupPage), new Metadata() {MenuItem = "Vent/Curt Setup", MenuId="72"}},
            {typeof(AirInletsSetupPage), new Metadata() { MenuItem = "Air Inlets Setup", MenuId = "72" }},
            {typeof(FanAirCapacityPage), new Metadata() { MenuItem = "Fan Air Capacity", MenuId = "74" }},
            {typeof(BirdCurvePage), new Metadata() { MenuItem = "Bird Curve", MenuId = "75" }},
            {typeof(BirdWeightPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "162" }},
            {typeof(ScaleSettingsPage), new Metadata() { MenuItem = "Scale Settings", MenuId = "76" }},
            {typeof(SiloAugerLayoutPage), new Metadata() { MenuItem = "Silo/Auger Layout", MenuId = "77" }},
            {typeof(CommunicationPage), new Metadata() { MenuItem = "Communication", MenuId = "78" }},
            {typeof(VersionPage), new Metadata() { MenuItem = "Version", MenuId = "108" }},
            {typeof(ScaleTestingPage), new Metadata() { MenuItem = "Scale Testing", MenuId = "55" }},
            {typeof(ScaleLayoutPage), new Metadata() { MenuItem = "Scale Layout", MenuId = "99" }},
            {typeof(MuntersDrivePage), new Metadata() { MenuItem = "Munters Drive", MenuId = "140" }},

	        #endregion

            #region Hot Key Pages:

            {typeof(CurvePage), new Metadata(){ MenuItem = "Curve Status", MenuId= "101"}} ,
            {typeof(LightStatusPage), new Metadata(){ MenuItem = "Light Status",  MenuId= "102"}},
            {typeof(LightStatusTabPage), new Metadata(){ MenuId= "107" }},
            {typeof(LightTabPage), new Metadata(){ MenuId= "109" }},
            {typeof(NaturalVentilationPageHotkey), new Metadata(){ MenuItem = "Natural Ventilation",  MenuId= "103"}},
            {typeof(AnalogOutputStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "110"}},
            {typeof(TemperatureandHumidityPage), new Metadata(){ MenuItem = "Temperature And Humidity",  MenuId= "111"}},
            {typeof(WaterMetersPage), new Metadata(){ MenuItem = "Water Meters",  MenuId= "141"}},
            {typeof(EggCounterStatePage), new Metadata(){ MenuItem = "Egg Counter State",  MenuId= "128"}},
            {typeof(ZoneInletPositionPage), new Metadata(){ MenuItem = "Zone Inlet Position",  MenuId= "122"}},
            {typeof(BirdScalePage), new Metadata(){ MenuItem = "Bird Scale",  MenuId= "155"}},
            {typeof(SiloPage), new Metadata(){ MenuItem = "Silo",  MenuId= "148"}},
            {typeof(CurtainPositionPage), new Metadata(){ MenuItem = "Curtain Position",  MenuId= "149"}},
            {typeof(WaterAndFeedStatusPage), new Metadata(){ MenuItem = "Water & Feed Status",  MenuId= "151"}},
            {typeof(AirStatusPage), new Metadata(){ MenuItem = "Air Status",  MenuId= "150"}},
            
            #endregion
        };

        private static readonly Dictionary<Type, Metadata> PigsPrecisionRoomPagesMetadataDictionary = new Dictionary<Type, Metadata>()
        {
            #region Control Pages:

            {typeof(TemperatureCurvePage), new Metadata() { MenuItem = "Temperature Curve", MenuId = "6"}},
            {typeof(MinMaxLevelByDaysPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "7" /* Todo: Need to figure what level control was set, and then set the correct value*/ }},
            {typeof(MinMaxLevelByDaysCurvePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "8" }},
            {typeof(MinMaxLevelByTimePage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "9" }},
            {typeof(MinMaxLevelBySoftMinPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "10" }},
            {typeof(MinMaxLevelByWeightPage), new Metadata() { MenuItem = @"Min / Max Level", MenuId = "11" }},
            {typeof(HumidityTreatmentPage), new Metadata() { MenuItem = "Humidity Treatment", MenuId = "12" }},
            {typeof(Co2TreatmentPage), new Metadata() { MenuItem = "CO2 Treatment", MenuId = "13" }},
            {typeof(CoolPadPage), new Metadata() { MenuItem = "Cool Pad", MenuId = "16" }},
            {typeof(NaturalVentilationPage), new Metadata() { MenuItem = "Natural Ventilation", MenuId = "14" }},
            {typeof(StaticPressurePage), new Metadata() { MenuItem = "S.Pressure", MenuId = "15" }},
            {typeof(FoggersPage), new Metadata() { MenuItem = "Foggers", MenuId = "17" }},
            {typeof(WaterAndFeedPage), new Metadata() { MenuItem = @"Water & Feed", MenuId = "18" }},
            {typeof(LightControlPage), new Metadata() { MenuItem = "Light Control", MenuId = "19" }},
            {typeof(LightFeedTabPage), new Metadata() { MenuId = "92" }},
            {typeof(LightNoFeedTabPage), new Metadata() { MenuId = "93" }},
            {typeof(ExtraSystemsPage), new Metadata() { MenuItem = "Extra Systems", MenuId = "20" }},
            {typeof(ControlModePage), new Metadata() { MenuItem = "Control Mode", MenuId = "21" }},
            {typeof(SystemParametersPage), new Metadata() { MenuItem = "System Parameters", MenuId = "22" }},
            {typeof(AmmoniaTreatmentPage), new Metadata() { MenuItem = "Ammonia Treatment", MenuId = "129" }},

            #endregion

            #region Management Pages:

            {typeof(AnimalInventoryPage), new Metadata() { MenuItem = "Animal Inventory", MenuId = "23" }},
            {typeof(FeedInventoryPage), new Metadata() { MenuItem = "Feed Inventory", MenuId = "24" }},
            {typeof(GrowthDayAndGroupPage), new Metadata() { MenuItem = "Growth Day & Group", MenuId = "25" }},
            {typeof(AlarmSettingsPage), new Metadata() { MenuItem = "Alarm Settings", MenuId = "26" }},
            {typeof(AlarmResetPage), new Metadata() { MenuItem = "Alarm Reset", MenuId = "27" }},
            {typeof(AlarmResetTabPage), new Metadata() { MenuId = "27" }},
            {typeof(FailSafeSettingPage), new Metadata() { MenuItem = "Fail Safe Settings", MenuId = "28" }},
            {typeof(PasswordPage), new Metadata() { MenuItem = "Password", MenuId = "30" }},
            {typeof(ScheduleTabPage), new Metadata() { MenuId = "121" }},
            {typeof(OrderTabPage), new Metadata() { MenuId = "80" }},
            {typeof(WaterOnDemandPage), new Metadata() { MenuItem = "Water On Demand", MenuId = "34" }},
            {typeof(CurrentSensePage), new Metadata() { MenuItem = "Current Sense", MenuId = "56" }},
            {typeof(SwitchesAndRelaysPage), new Metadata() { MenuItem = "Switches & Relays", MenuId = "57" }},
	        #endregion

            #region History Pages:

            {typeof(TemperatureHistoryPage), new Metadata() { MenuItem = "Temprature", MenuId = "35" }},
            {typeof(HumidityHistoryPage), new Metadata() { MenuItem = "Humidity", MenuId = "36" }},
            {typeof(Co2HistoryPage), new Metadata() { MenuItem = "CO2", MenuId = "37" }},
            {typeof(BirdWeightHistoryPage), new Metadata() { MenuItem = "Bird Weight", MenuId = "38" }},
            {typeof(FeedConversionHistoryPage), new Metadata() { MenuItem = "Feed Conversion", MenuId = "39" }},
            {typeof(WaterHistoryPage), new Metadata() { MenuItem = "Water", MenuId = "40" }},
            {typeof(FeedConsumptionHistoryPage), new Metadata() {MenuItem = "Feed", MenuId = "41"}},
            {typeof(MortalityHistoryPage), new Metadata() { MenuItem = "Mortality", MenuId = "42" }},
            {typeof(HeatersHistoryPage), new Metadata() { MenuItem = "Heaters", MenuId = "43" }},
            {typeof(RadiantHeatersHistoryPage), new Metadata() { MenuItem = "Radiant Heaters", MenuId = "44" }},
            {typeof(AlarmsHistoryPage), new Metadata() { MenuItem = "Alarms", MenuId = "45" }},
            {typeof(EventsLogHistoryPage), new Metadata() { MenuItem = "Table Of Events", MenuId = "46" }},
            {typeof(PowerConsumptionHistoryPage), new Metadata() { MenuItem = "Power Consumption", MenuId = "47" }},
            {typeof(HistoryViewPage), new Metadata() { MenuItem = "History View", MenuId = "48" }},
            {typeof(AmmoniaHistoryPage), new Metadata() { MenuItem = "Ammonia", MenuId = "130" }},
	        #endregion

            #region Testing & Calibration Pages:
		 
            {typeof(AnalogSensorsPage), new Metadata() { MenuItem = "Analog Sensors", MenuId = "49" }},
            {typeof(DigitalSensorsPage), new Metadata() { MenuItem = "Digital Sensors", MenuId = "50" }},
            {typeof(StaticPressureCalibrationPage), new Metadata(){MenuItem = "S.Pressure", MenuId = "51"}},
            {typeof(WaterTabPage), new Metadata() { MenuId = "53" }},
            {typeof(WaterAndFeedCalibrationPage), new Metadata() { MenuItem = "Water & Feed Calibration", MenuId = "53" }},
            {typeof(FeedTabPage), new Metadata(){ MenuId = "84"}},
            {typeof(ScalesPage), new Metadata() { MenuItem = "Scales Testing & Calibration", MenuId = "55" }},
            {typeof(HardwareChecklistPage), new Metadata(){ MenuItem= "Hardware Checklist", MenuId= "60"}},
            {typeof(WindDirectionCalibrationPage), new Metadata(){ MenuItem= "Hardware Checklist",MenuId= "62"}},

	        #endregion

            #region System Pages:
		 
            {typeof(ExhaustAndTunnelFansTabPage), new Metadata(){ MenuId= "85", ParentId="65"}},//85
            {typeof(VentAndCurtainTabPage), new Metadata(){ MenuId= "86",ParentId="65"}},//86
            {typeof(VariableSpeedFansTabPage), new Metadata(){ MenuId= "87",ParentId="65"}},//87
            {typeof(StirAndVariableStirFansTabFansPage), new Metadata(){ MenuId= "88",ParentId="65"}},//88
            {typeof(GeneralSetupPage), new Metadata() { MenuItem = "Setup", MenuId = "63" }},
            {typeof(HouseDimensionsPage), new Metadata() { MenuItem = "House Dimensions", MenuId = "63" }},
            {typeof(TimeAndDatePage), new Metadata() { MenuItem = "Time & Date", MenuId = "64" }},
            {typeof(StirFanProgramPage), new Metadata() { MenuItem = "Stir Fan Program", MenuId = "66" }},
            {typeof(RelayLayoutPage), new Metadata() { MenuItem = "Relay Layout", MenuId = "67" }},
            {typeof(AnalogTabPage), new Metadata() { MenuId = "181" }},
            {typeof(DigitalTabPage), new Metadata() { MenuId = "81" }},
            {typeof(AnalogOutputsInstallationPage), new Metadata() { MenuItem = "Analog Output", MenuId = "69" }},
            {typeof(LevelsOfVentilationPage), new Metadata() { MenuItem = "Level Of Ventilation", MenuId = "65" }},
            {typeof(SensorsInstallationPage), new Metadata() { MenuItem = "Sensors Installation", MenuId = "68" }},
            {typeof(TemperatureDefinitionPage), new Metadata() { MenuItem = "Temp Definition", MenuId = "71" }},
            {typeof(VentCurtSetupPage), new Metadata() {MenuItem = "Vent/Curt Setup", MenuId="72"}},
            {typeof(AirInletsSetupPage), new Metadata() { MenuItem = "Air Inlets Setup", MenuId = "72" }},
            {typeof(FanAirCapacityPage), new Metadata() { MenuItem = "Fan Air Capacity", MenuId = "74" }},
            {typeof(CommunicationPage), new Metadata() { MenuItem = "Communication", MenuId = "78" }},
            {typeof(VersionPage), new Metadata() { MenuItem = "Version", MenuId = "108" }},
            {typeof(ScaleTestingPage), new Metadata() { MenuItem = "Scale Testing", MenuId = "55" }},
            {typeof(ScaleLayoutPage), new Metadata() { MenuItem = "Scale Layout", MenuId = "99" }},
            {typeof(SiloSettingsPage), new Metadata() { MenuItem = "Silo Settings", MenuId = "137" }},

	        #endregion

            #region Hot Key Pages:

            {typeof(CurvePage), new Metadata(){ MenuItem = "Curve Status", MenuId= "101"}} ,
            {typeof(LightStatusPage), new Metadata(){ MenuItem = "Light Status",  MenuId= "102"}},
            {typeof(LightStatusTabPage), new Metadata(){ MenuId= "107" }},
            {typeof(LightTabPage), new Metadata(){ MenuId= "109" }},
            {typeof(NaturalVentilationPageHotkey), new Metadata(){ MenuItem = "Natural Ventilation",  MenuId= "103"}},
            {typeof(AnalogOutputStatusPage), new Metadata(){ MenuItem = "Temperature & Humidity Status",  MenuId= "110"}},
            {typeof(TemperatureandHumidityPage), new Metadata(){ MenuItem = "Temperature And Humidity",  MenuId= "111"}},
            {typeof(WaterMetersPage), new Metadata(){ MenuItem = "Water Meters",  MenuId= "141"}},
            {typeof(SiloPage), new Metadata(){ MenuItem = "Silo",  MenuId= "148"}},
            {typeof(CurtainPositionPage), new Metadata(){ MenuItem = "Curtain Position",  MenuId= "149"}},
            #endregion
        };

        public static Metadata GetMetadata<T>() where T : class, IMetadataDependentPageObject
        {
            //switch (navigator.GetActiveHouse())
            switch (Configuration.ConfigurationManagerHelper.ControllerType)
            {
                case "BroilerPrecision":
                    if (!BroilerPrecisionPagesMetadataDictionary.ContainsKey(typeof(T)))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", typeof(T)));
                    return BroilerPrecisionPagesMetadataDictionary[typeof(T)];

                case "BroilerStandard":
                    if (!BroilerStandardPagesMetadataDictionary.ContainsKey(typeof(T)))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", typeof(T)));
                    return BroilerStandardPagesMetadataDictionary[typeof(T)];

                case "BreederPrecisionBasicFeeding":
                    if (!BreederPrecisionBasicFeedingPagesMetadataDictionary.ContainsKey(typeof(T)))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", typeof(T)));
                    return BreederPrecisionBasicFeedingPagesMetadataDictionary[typeof(T)];

                case "BreederPrecisionAdvancedFeeding":
                    if (!BreederPrecisionAdvancedFeedingPagesMetadataDictionary.ContainsKey(typeof(T)))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", typeof(T)));
                    return BreederPrecisionAdvancedFeedingPagesMetadataDictionary[typeof(T)];

                case "BreederStandardBasicFeeding":
                    if (!BreederStandardBasicFeedingPagesMetadataDictionary.ContainsKey(typeof(T)))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", typeof(T)));
                    return BreederStandardBasicFeedingPagesMetadataDictionary[typeof(T)];

                case "BreederStandardAdvancedFeeding":
                    if (!BreederStandardAdvancedFeedingPagesMetadataDictionary.ContainsKey(typeof(T)))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", typeof(T)));
                    return BreederStandardAdvancedFeedingPagesMetadataDictionary[typeof(T)];

                case "LayerPrecision":
                    if (!LayerPrecisionPagesMetadataDictionary.ContainsKey(typeof(T)))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", typeof(T)));
                    return LayerPrecisionPagesMetadataDictionary[typeof(T)];

                case "PigsPrecisionRoom":
                    if (!PigsPrecisionRoomPagesMetadataDictionary.ContainsKey(typeof(T)))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", typeof(T)));
                    return PigsPrecisionRoomPagesMetadataDictionary[typeof(T)];
            }
            return BroilerPrecisionPagesMetadataDictionary[typeof(T)];
        }
        public static Metadata GetMetadata(IMetadataDependentPageObject metadataObject)
        {
            switch (Configuration.ConfigurationManagerHelper.ControllerType)
            {
                case "BroilerPrecision":
                    if (!BroilerPrecisionPagesMetadataDictionary.ContainsKey(metadataObject.GetType()))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", metadataObject.GetType()));
                    return BroilerPrecisionPagesMetadataDictionary[metadataObject.GetType()];

                case "BroilerStandard":
                    if (!BroilerStandardPagesMetadataDictionary.ContainsKey(metadataObject.GetType()))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", metadataObject.GetType()));
                    return BroilerStandardPagesMetadataDictionary[metadataObject.GetType()];

                case "BreederPrecisionBasicFeeding":
                    if (!BreederPrecisionBasicFeedingPagesMetadataDictionary.ContainsKey(metadataObject.GetType()))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", metadataObject.GetType()));
                    return BreederPrecisionBasicFeedingPagesMetadataDictionary[metadataObject.GetType()];

                case "BreederPrecisionAdvancedFeeding":
                    if (!BreederPrecisionAdvancedFeedingPagesMetadataDictionary.ContainsKey(metadataObject.GetType()))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", metadataObject.GetType()));
                    return BreederPrecisionAdvancedFeedingPagesMetadataDictionary[metadataObject.GetType()];

                case "BreederStandardBasicFeeding":
                    if (!BreederStandardBasicFeedingPagesMetadataDictionary.ContainsKey(metadataObject.GetType()))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", metadataObject.GetType()));
                    return BreederStandardBasicFeedingPagesMetadataDictionary[metadataObject.GetType()];

                case "BreederStandardAdvancedFeeding":
                    if (!BreederStandardAdvancedFeedingPagesMetadataDictionary.ContainsKey(metadataObject.GetType()))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", metadataObject.GetType()));
                    return BreederStandardAdvancedFeedingPagesMetadataDictionary[metadataObject.GetType()];

                case "LayerPrecision":
                    if (!LayerPrecisionPagesMetadataDictionary.ContainsKey(metadataObject.GetType()))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", metadataObject.GetType()));
                    return LayerPrecisionPagesMetadataDictionary[metadataObject.GetType()];

                case "PigsPrecisionRoom":
                    if (!PigsPrecisionRoomPagesMetadataDictionary.ContainsKey(metadataObject.GetType()))
                        throw new KeyNotFoundException(string.Format("Page named: {0} is does not implement IMetadataDependentPageObject interface.", metadataObject.GetType()));
                    return PigsPrecisionRoomPagesMetadataDictionary[metadataObject.GetType()];
            }
            return BroilerPrecisionPagesMetadataDictionary[metadataObject.GetType()];
        }
        public static IPageObject GetOwnerPage(Metadata metadata)
        {
            var metadataPairs = BroilerPrecisionPagesMetadataDictionary.Where(pair => pair.Value.MenuId == metadata.MenuId).Select(pair => pair).ToList();
            switch (Configuration.ConfigurationManagerHelper.ControllerType)
            {
                case "BroilerPrecision":
                    if (metadataPairs.Count() == 2)
                    {
                        var metadataPair = metadataPairs.FirstOrDefault(pair => pair.Value.MenuItem == null);
                        return PagesFactory.GetPage(metadataPair.Key);
                    }

                    return PagesFactory.GetPage(metadataPairs.Single().Key);

                case "BroilerStandard":
                    metadataPairs = BroilerStandardPagesMetadataDictionary.Where(pair => pair.Value.MenuId == metadata.MenuId).Select(pair => pair).ToList();
                    if (metadataPairs.Count() == 2)
                    {
                        var metadataPair = metadataPairs.FirstOrDefault(pair => pair.Value.MenuItem == null);
                        return PagesFactory.GetPage(metadataPair.Key);
                    }

                    return PagesFactory.GetPage(metadataPairs.Single().Key);

                case "BreederPrecisionBasicFeeding":
                    metadataPairs = BreederPrecisionBasicFeedingPagesMetadataDictionary.Where(pair => pair.Value.MenuId == metadata.MenuId).Select(pair => pair).ToList();
                    if (metadataPairs.Count() == 2)
                    {
                        var metadataPair = metadataPairs.FirstOrDefault(pair => pair.Value.MenuItem == null);
                        return PagesFactory.GetPage(metadataPair.Key);
                    }

                    return PagesFactory.GetPage(metadataPairs.Single().Key);

                case "BreederPrecisionAdvancedFeeding":
                    metadataPairs = BreederPrecisionAdvancedFeedingPagesMetadataDictionary.Where(pair => pair.Value.MenuId == metadata.MenuId).Select(pair => pair).ToList();
                    if (metadataPairs.Count() == 2)
                    {
                        var metadataPair = metadataPairs.FirstOrDefault(pair => pair.Value.MenuItem == null);
                        return PagesFactory.GetPage(metadataPair.Key);
                    }

                    return PagesFactory.GetPage(metadataPairs.Single().Key);

                case "BreederStandardBasicFeeding":
                    metadataPairs = BreederStandardBasicFeedingPagesMetadataDictionary.Where(pair => pair.Value.MenuId == metadata.MenuId).Select(pair => pair).ToList();
                    if (metadataPairs.Count() == 2)
                    {
                        var metadataPair = metadataPairs.FirstOrDefault(pair => pair.Value.MenuItem == null);
                        return PagesFactory.GetPage(metadataPair.Key);
                    }
                    return PagesFactory.GetPage(metadataPairs.Single().Key);

                case "BreederStandardAdvancedFeeding":
                    metadataPairs = BreederStandardAdvancedFeedingPagesMetadataDictionary.Where(pair => pair.Value.MenuId == metadata.MenuId).Select(pair => pair).ToList();
                    if (metadataPairs.Count() == 2)
                    {
                        var metadataPair = metadataPairs.FirstOrDefault(pair => pair.Value.MenuItem == null);
                        return PagesFactory.GetPage(metadataPair.Key);
                    }
                    return PagesFactory.GetPage(metadataPairs.Single().Key);


                case "LayerPrecision":
                    metadataPairs = LayerPrecisionPagesMetadataDictionary.Where(pair => pair.Value.MenuId == metadata.MenuId).Select(pair => pair).ToList();
                    if (metadataPairs.Count() == 2)
                    {
                        var metadataPair = metadataPairs.FirstOrDefault(pair => pair.Value.MenuItem == null);
                        return PagesFactory.GetPage(metadataPair.Key);
                    }

                    return PagesFactory.GetPage(metadataPairs.Single().Key);

                case "PigsPrecisionRoom":
                    metadataPairs = PigsPrecisionRoomPagesMetadataDictionary.Where(pair => pair.Value.MenuId == metadata.MenuId).Select(pair => pair).ToList();
                    if (metadataPairs.Count() == 2)
                    {
                        var metadataPair = metadataPairs.FirstOrDefault(pair => pair.Value.MenuItem == null);
                        return PagesFactory.GetPage(metadataPair.Key);
                    }

                    return PagesFactory.GetPage(metadataPairs.Single().Key);

            }
            // this scenario is for controller type broiler precision
            if (metadataPairs.Count() == 2)
            {
                var metadataPair = metadataPairs.FirstOrDefault(pair => pair.Value.MenuItem == null);
                return PagesFactory.GetPage(metadataPair.Key);
            }

            return PagesFactory.GetPage(metadataPairs.Single().Key);
        }
    }
}
