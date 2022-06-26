
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public class MainCategory
    {
        public const string BuildingBlocksValidation = "Building Blocks Validation";
        public const string BoundariesVerification = "Boundaries Verification";
        public const string DefaultValuesVerification = "Default Values Verification";
        public const string AffectedFieldsValidation = "Affected Fields Validation";
        public const string SortingTests = "Sorting Tests";
        public const string UnitsMeasurments = "Units Measurments";
        public const string E2E = "E2E";
        public const string DisabledPagesValidation = "Disabled Pages Validation";
        public const string SmartUI = "SmartUI";
        public const string SaveData = "SaveData";
        public const string Sanity = "Sanity";
    }

    public class SubCategory
    {
        public const string Dashboard = "Dashboard";

        #region CONTROL

        public const string TemperatureCurve = "CONTROL | Temperature Curve";
        public const string TemperatureCurveSettings = "CONTROL | Temperature Curve (Settings)";
        public const string TemperatureCurveFahrenheit = "CONTROL | Temperature Curve (Fahrenheit)";
        public const string MinMaxLevel = "CONTROL | Min\\Max Level (Table)";
        public const string HumidityTreatment = "CONTROL | Humidity Treatment";
        public const string HumidityTreatmentSettings = "CONTROL | Humidity Treatment (Settings)";
        public const string CO2Treatment = "CONTROL | CO2 Treatment";
        public const string CO2TreatmentSettings = "CONTROL | CO2 Treatment (Settings)";
        public const string NaturalVentilation = "CONTROL | Natural Ventilation";
        public const string NaturalVentilationSettings = "CONTROL | Natural Ventilation (Settings)";
        public const string StaticPressure = "CONTROL | S.Pressure";
        public const string StaticPressureSettings = "CONTROL | S.Pressure (Settings)";
        public const string CoolPad = "CONTROL | Cool Pad";
        public const string CoolPadSettings = "CONTROL | Cool Pad (Settings)";
        public const string CoolPadFullTableDefinition = "CONTROL | Cool Pad (Full Table)";
        public const string Foggers = "CONTROL | Foggers";
        public const string FoggersSettings = "CONTROL | Foggers (Settings)";
        public const string WaterAndFeedControl = @"CONTROL | Water & Feed Control";
        public const string WaterAndFeedControlSettings = @"CONTROL | Water & Feed Control (Settings)";
        public const string LightControl = "CONTROL | Light";
        public const string LightControlSettings = "CONTROL | Light (Settings)";
        public const string ExtraSystems = "CONTROL | Extra Systems";
        public const string ControlMode = "CONTROL | Control Mode ";
        public const string SystemParameters = "CONTROL | System Parameters ";
        public const string AmmoniaTreatment = "CONTROL | Ammonia Treatment";
        public const string AmmoniaTreatmentSettings = "CONTROL | Ammonia Treatment (Settings)";
        public const string FeedScaleProgram = "CONTROL | Feed Scale Program";
        public const string FeedScaleProgramSettings = "CONTROL | Feed Scale Program (Settings)";
        public const string LightDimmers = "CONTROL | Light Dimmers";
        public const string EggRoomControl = "CONTROL | Egg Room Control";
        public const string EggRoomControlSettings = "CONTROL | Egg Room Control (Settings)";
        public const string WorkRoomControl = "CONTROL | Work Room Control";
        public const string Nests = "CONTROL | Nests";

        #endregion

        #region MANAGEMENT
        
        public const string BirdInventory = "MANAGEMENT | Bird Inventory";
        public const string FeedInventory = "MANAGEMENT | Feed Inventory";
        public const string FeedInventorySettings = "MANAGEMENT | Feed Inventory (Settings)";
        public const string GrowDayAndFlock = "MANAGEMENT | Growth Day And Flock";
        public const string GrowDayAndGroup = "MANAGEMENT | Growth Day And Group";
        public const string AlarmSettings = "MANAGEMENT | Alarm Settings";
        public const string AlarmSettingSettings = "MANAGEMENT | Alarm Setting (Settings)";
        public const string AlarmReset = "MANAGEMENT | Alarm Reset";
        public const string FailSafeSetting = "MANAGEMENT | Fail Safe Setting";
        public const string Password = "MANAGEMENT | Password";
        public const string FeedersAndDrinkers = @"MANAGEMENT | Feeders & Drinkers";
        public const string FeedersAndDrinkersSettings = @"MANAGEMENT | Feeders & Drinkers (Settings)";
        public const string WaterAndFeedLines = "MANAGEMENT | Water And Feed Lines";
        public const string NippleFlushing = "MANAGEMENT | Nipple Flushing";
        public const string NippleFlushingSettings = "MANAGEMENT | Nipple Flushing (Settings)";
        public const string WaterOnDemand = "MANAGEMENT | Water On Demand";
        public const string WaterOnDemandSettings = "MANAGEMENT | Water On Demand (Settings)";
        public const string CurrentSense = "MANAGEMENT | Current Sense Installation";
        public const string SwitchesAndRelays = "MANAGEMENT | Switches & Relays";
        public const string FeedLinesCalibration = "MANAGEMENT | Feed Lines Calibration";
        public const string AnimalInventory = "MANAGEMENT | Animal Inventory";
        #endregion

        #region HISTORY

        public const string TemperatureHistory = "HISTORY | Temperature";
        public const string HumidityHistory = "HISTORY | Humidity";
        public const string CO2History = "HISTORY | CO2";
        public const string BirdWeightHistory = "HISTORY | Bird Weight History";
        public const string FeedConversionHistory = "HISTORY | Feed Conversion";
        public const string WaterConsumptionHistory = "HISTORY | Water Consumption";
        public const string FeedConsumptionHistory = "HISTORY | Feed Consumption";
        public const string Mortality = "HISTORY | Mortality";
        public const string HeatersHistory = "HISTORY | Heaters";
        public const string RadiantHeatersHistory = "HISTORY | Radiant Heaters";
        public const string AlarmsHistory = "HISTORY | Alarms History";
        public const string EventsLogHistory = "HISTORY | Events Log History";
        public const string PowerConsumptionHistory = "HISTORY | Power Consumption History";
        public const string HistoryView = "HISTORY | History View";
        public const string AmmoniaHistory = "HISTORY | Ammonia History";
        public const string EggRoomHistory = "HISTORY | Egg Room History";
        public const string EggBeltHistory = "HISTORY | Egg Belt History";
        public const string EggsHistory = "HISTORY | Egg History";

        #endregion

        #region Testig And Calibration

        public const string AnalogSensors = "TestigAndCalibration | Analog Sensors";
        public const string DigitalSensors = "TestigAndCalibration | Digital Sensors";
        public const string StaticPressureCalibration = "TestigAndCalibration | Static Pressure";
        public const string WaterAndFeedCalibration = "TestigAndCalibration | Water And Feed Calibration";
        public const string Scales = "TestigAndCalibration | Scales";
        //public const string HardwareChecklist = "TestigAndCalibration | Hardware Checklist";
        public const string WindDirectionCalibration = "TestigAndCalibration | Wind Direction Calibration";

        #endregion

        #region SYSTEM

        public const string Setup = "SYSTEM | General Setup";
        public const string TimeAndDate = "SYSTEM | Time And Date";
        public const string LevelsOfVentilation = "SYSTEM | Levels of Ventalation";
        public const string LevelsOfVentilationSettings = "SYSTEM | Levels of Ventalation (Settings)";
        public const string StirFanProgram = "SYSTEM | Stir Fan Program";
        public const string StirFanProgramSettings = "SYSTEM | Stir Fan Program (Settings)";
        public const string RelayLayout = "SYSTEM | Relay Layout";
        public const string RelayLayoutSettings = "SYSTEM | Relay Layout (Settings)";
        public const string SensorsInstallation = "SYSTEM | Sensors Installation";
        public const string AnalogOutputsInstallation = "SYSTEM | Analog Outputs Installation";
        public const string AnalogOutputsInstallationSettings = "SYSTEM | Analog Output - Settings";
        public const string TemperatureDefinition = "SYSTEM | Temperature Definition";
        public const string AirInletsSetup = "SYSTEM | Vent/Curt Setup";
        public const string AirInletsSetupSetting = "SYSTEM | Vent/Curt Calibration";
        public const string VentCurtSetupCalibrationSettings = "SYSTEM | Vent/Curt Calibration (Settings)";
        public const string VentCurtSetupCalibration = "SYSTEM | Vent/Curt Calibration";
        public const string HouseDimensions = "SYSTEM | House Dimensions";
        public const string FanAirCapacity = "SYSTEM | Fan Air Capacity";
        public const string BirdCurve = "SYSTEM | Bird Curve";
        public const string BirdWeight = "SYSTEM | Bird Weight";
        public const string BirdCurveSettings = "SYSTEM | Bird Curve";
        public const string BirdWeightSettings = "SYSTEM | Bird Weight";
        public const string ScaleSettings = "SYSTEM | Scale Settings";
        public const string ScaleSettingsSettings = "SYSTEM | Scale Settings (Settings)";
        public const string ScaleTesting = "SYSTEM | Scale Testing";
        public const string ScaleLayout = "SYSTEM | Scale Layout";
        public const string SiloAugerLayout = "SYSTEM | Silo/Auger Layout";
        public const string Communication = "SYSTEM | Communication";
        public const string Version = "SYSTEM | Version";
        public const string HardwareChecklist = "SYSTEM | Hardware Checklist";
        public const string VariableSpeedFansSetting = "SYSTEM | Variable Speed Fans Setting";
        public const string VariableSpeedFansSettingSettings = "SYSTEM | Variable Speed Fans Setting (Settings)";
        public const string VariableSpeedFansSettings = "SYSTEM | V. Speed Settings";
        public const string TemperatureAndTimerSetting = "SYSTEM | Temperature & Timer Settings";
        public const string TemperatureAndTimerSettings = "SYSTEM | Temperature & Timer - Settings";
        public const string MuntersDrive = "SYSTEM | Munters Drive";
        public const string SiloSettings = "SYSTEM | Silo Settings";
        

        #endregion

        #region Hot Keys

        public const string CurveStatus = "HotKeys | Curve Status";
        public const string LightStatus = "HotKeys | Light Status";
        public const string NaturalVentilationStatus = "HotKeys | Natural Ventilation Status";
        public const string AnalogOutPutStatus = "HotKeys | Analog OutPut Status";
        public const string TemperatureAndHumidityStatus = "HotKeys | Temperature And Humidity Status";
        public const string AirStatus = "HotKeys | Air Status";
        public const string FeedScaleStatus = "HotKeys | Feed Scale Status";
        public const string WaterMeters = "HotKeys | Water Meters";
        public const string EggRoomStatus = "HotKeys | Egg Room Status";
        public const string EggCounterState = "HotKeys | Egg Counter State";
        public const string ZoneInletPosition = "HotKeys | Zone Inlet Position";
        public const string BirdScale = "HotKeys | Bird Scale";
        public const string Silo = "HotKeys | Silo";
        public const string CurtainPosition = "HotKeys | Curtain Position";
        public const string WaterAndFeedStatus = "HotKeys | Water & Feed Status";
        

        #endregion

        #region Broiler.Standard
        #region Control

        public const string MinVentTimer = "Control | Min Vent Timer";
        public const string MinVentTimerSettings = "Control | Min Vent Timer - Settings";
        public const string TimerSettings = "Control | Timer Settings";
        public const string Standard_HumidityTreatment = "Control | Humidity Treatment";
        public const string Standard_StaticPressure = "Control | Static Pressure";

        #endregion
        #endregion
    }

    public class SourceType
    {
        public const string TestCase = "Microsoft.VisualStudio.TestTools.DataSource.TestCase";
        public const string CSV = "Microsoft.VisualStudio.TestTools.DataSource.CSV";
        public const string XML = "Microsoft.VisualStudio.TestTools.DataSource.XML";
    }

    public class DataSource
    {
        public const string URL = "http://rotemapl10:8080/tfs/DefaultCollection;RotemNet";
    }

    public class InfrastructureTestAttribute : TestCategoryBaseAttribute
    {
        public override IList<string> TestCategories
        {
            get { return new List<string>() { "Infrastructure Test" }; }
        }
    }
}
