using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Co2Treatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ControlMode;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.CoolPad;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ExtraSystems;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Foggers;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.HumidityTreatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.NaturalVentilation;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.StaticPressure;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.SystemParameters;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.TemperatureCurve;
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
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AlarmReset;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AlarmSettings;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.BirdInventory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FailSafeSetting;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedersAndDrinkers;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.GrowthDayAndFlock;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.NippleFlushing;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.Password;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.WaterOnDemand;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.AirInletsSetup;
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
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TimeAndDate;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.AnalogSensors;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.DigitalSensors;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.HardwareChecklist;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.Scales;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.StaticPressureCalibration;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WaterAndFeedCalibration;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WindDirectionCalibration;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class FixedDictionaryInitialize
    {
        [TestMethod]
        [InfrastructureTest]
        public void FixedDictionaryInitialize_InitializeDictionary_Passed()
        {
            var fixedPagesSetupDictionary = new Dictionary<Type, ControllerPageSetup>()
            {
                #region CONTROL Pages

                #region Page Name: Temperature Curve
		       {
                    typeof(TemperatureCurvePage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() { "Temperature Curve" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", InputMethod = new MinusNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Target", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Heat", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Tunnel", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Low Alarm", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "High Alarm", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                            },
                            SettingsPageTitles = new List<string>(){ "Temperature Curve - Settings" }
                    }
                },
                #endregion

                #region Page Name: Humidity Treatment
                {
                    typeof(HumidityTreatmentPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Humidity Treatment" },
                        TableColumns = new List<ITableColumn>() 
                            {
                                new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Humidity (%)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Delay (min.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Duration (sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            },
                            SettingsPageTitles = new List<string>(){ "Humidity Treatment - Settings" }
                    }
                },
                #endregion

                #region Page Name: CO2 Treatment
                {
                    typeof(Co2TreatmentPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "CO2 Treatment" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Start (PPM)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Stop (PPM)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Delay (sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Duration (sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            },
                         SettingsPageTitles = new List<string>(){ "CO2 Treatment - Settings" }
                    }
                },
                #endregion

                #region Page Name: Natural Ventilation
                {
                    typeof(NaturalVentilationPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Natural Ventilation" },
                        SettingsPageTitles = new List<string>(){ "Natural Entrance Conditions - Settings" }
                    }
                },
                #endregion

                #region Page Name: Static Pressure
                {
                    typeof(StaticPressurePage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Static Pressure" },
                        SettingsPageTitles = new List<string>(){ "Static Pressure - Settings" }
                    }
                },
                #endregion

                #region Page Name: Cool Pad
                {
                    typeof(CoolPadPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() { "Cool Pad" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Temp. Above Target", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Humidity Below (%)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TimeColumn(){ DisplayName = "Start Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                                new TimeColumn(){ DisplayName = "End Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "ON (sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "OFF (sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            },
                         SettingsPageTitles = new List<string>(){ "Cool Pad - Settings" }
                    }
                },
                #endregion

                #region Page Name: Foggers
                {
                    typeof(FoggersPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() { "Foggers" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Temp. Above Tunnel", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Humidity Below (%)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TimeColumn(){ DisplayName = "Start Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                                new TimeColumn(){ DisplayName = "End Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "ON (sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "OFF (sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},

                            },
                            SettingsPageTitles = new List<string>(){ "Foggers - Settings" }
                    }
                },
                #endregion

                #region Page Name: Extra Systems
                {
                    typeof(ExtraSystemsPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() { "Extra Systems" },
                        TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "System", IsReadOnly = true},
                            new TimeColumn(){ DisplayName = "Start Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "End Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group= "Temperature" ,DisplayName = "From", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group= "Temperature" ,DisplayName = "To", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group = "Humidity (%)" ,DisplayName = "From", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group = "Humidity (%)" ,DisplayName = "To", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "ON (sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "OFF (sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false}
                        }
                    }
                }, 
                #endregion

                #region Page Name: Control Mode
                {
                    typeof(ControlModePage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Control Mode" }
                    }
                },
	            #endregion

                #region Page Name: System Parameters
                {
                    typeof(SystemParametersPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "System Parameters" }
                    }
                },
	            #endregion

	            #endregion

                #region MANAGEMENT Pages

                #region PAGE name: Bird Inventory
                {
                    typeof(BirdInventoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() { "Bird Inventory" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextWithImageColumn(){ DisplayName = "", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Birds Placed", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ Group = "Dead Birds", DisplayName = "Update", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ Group = "Dead Birds", DisplayName = "Total", IsReadOnly = true },
                                new TextColumn(){ Group = "Culled Birds", DisplayName = "Update", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ Group = "Culled Birds", DisplayName = "Total", IsReadOnly = true },
                                new TextColumn(){ Group = "Birds Moved", DisplayName = "Update", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "Total", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Bird Count", IsReadOnly = true },
                            }
                    }
                }, 
                #endregion

                #region PAGE name: Growth Day & Flock
                {
                    typeof(GrowthDayAndFlockPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Flock Settings" },
                    }
                }, 
                #endregion

                #region PAGE name: Alarm Settings
                {
                    typeof(AlarmSettingsPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Alarm Settings" },
                        SettingsPageTitles = new List<string>(){ "Alarm - Settings" },
                    }
                }, 
                #endregion

                #region PAGE name: Alarm Reset
                {
                    typeof(AlarmResetPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Alarm Reset" },
                    }
                }, 
                #endregion

                #region PAGE name: Fail Safe Setting
                {
                    typeof(FailSafeSettingPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Fail Safe Setting" },
                    }
                }, 
                #endregion

                #region PAGE name: User Permission
                {
                    typeof(PasswordPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "User Permission" },
                    }
                }, 
                #endregion

                #region PAGE name: Water And Feed Lines
                {
                    typeof(FeedersAndDrinkersPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Water & Feed Lines" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "Window Pos (%)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "Feeder Line Lift (In)", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "Water Line Lift (In)", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                            },
                            SettingsPageTitles = new List<string>(){ "Feeders And Drinkers - Settings" },
                    }
                }, 
                #endregion

                #region PAGE name: Nipple Flushing
                {
                    typeof(NippleFlushingPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Nipple Flushing" },
                    }
                }, 
                {
                    typeof(ScheduleTabPage), new ControllerPageSetup()
                    {
                        TableColumns = new List<ITableColumn>()
                            {
                                new TimeColumn(){ Group ="Nipple Flush", DisplayName = "Start Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                                new TextColumn(){ Group ="Nipple Flush", DisplayName = "Duration (Min.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ Group ="Nipple Flush", DisplayName = "Status", InputMethod = new ButtonsGroup(), IsReadOnly = false},
                            },
                    }
                },
                {
                    typeof(OrderTabPage), new ControllerPageSetup()
                    {
                        // Todo: Tab has day week control, currently does not supported.
                        TableColumns = new List<ITableColumn>()
                    }
                },
                #endregion

                #region PAGE name: Water On Demand
                {
                    typeof(WaterOnDemandPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Water on Demand" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TimeColumn(){ DisplayName = "From Time (hh:mm:ss)", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                                new TimeColumn(){ DisplayName = "To Time (hh:mm:ss)", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "WOD", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            },
                    }
                }, 
                #endregion

                #endregion

                #region HISTORY Pages
            
                #region Page Name: Temperature History
                {

                    typeof(TemperatureHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() { "Temperature History", "(F)"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Minimum", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Average", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Maximum", IsReadOnly = true },
                            }
                    } 
                }, 
                #endregion

                #region Page Name: Humidity History
                        {
                    typeof(HumidityHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Humidity History", "(%)"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Minimum (%)", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Average (%)", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Maximum (%)", IsReadOnly = true },
                            }
                    }
                }, 
                #endregion

                #region Page Name: CO2 History
                        {
                    typeof(Co2HistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"CO2 History", "(PPM)"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Minimum (PPM)", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Average (PPM)", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Maximum (PPM)", IsReadOnly = true },
                            }
                    }
                }, 
                #endregion

                #region Page Name: Bird Weight
                        {
                    typeof(BirdWeightHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Bird Weight History"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                                new TextColumn(){ Group = "Common", DisplayName = "Actual (Lb)", IsReadOnly = true },
                                new TextColumn(){ Group = "Common", DisplayName = "Daily Gain (Lb)", IsReadOnly = true },
                                new TextColumn(){ Group = "Common", DisplayName = "No. Of Weights", IsReadOnly = true },
                                new TextColumn(){ Group = "Common", DisplayName = "Std. Dev.", IsReadOnly = true },
                                new TextColumn(){ Group = "Common", DisplayName = "Uniformuty", IsReadOnly = true },
                                new TextColumn(){ Group = "Common", DisplayName = "C.V.", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 1", DisplayName = "Actual (Lb)", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 1", DisplayName = "Daily Gain (Lb)", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 1", DisplayName = "No. Of Weights", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 1", DisplayName = "Std. Dev.", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 1", DisplayName = "Uniformuty", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 1", DisplayName = "C.V.", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 2", DisplayName = "Actual (Lb)", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 2", DisplayName = "Daily Gain (Lb)", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 2", DisplayName = "No. Of Weights", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 2", DisplayName = "Std. Dev.", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 2", DisplayName = "Uniformuty", IsReadOnly = true },
                                new TextColumn(){ Group = "Scale 2", DisplayName = "C.V.", IsReadOnly = true },
                            }
                    }
                }, 
                #endregion

                #region Page Name: Feed Conversion History
                {
                    typeof(FeedConversionHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Feed Conversion History"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Bird Weight (Kg)", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Daily Feed (kg)", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Daily Water (lt)", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Feed Conversion Rate", IsReadOnly = true },
                            }
                    }
                },
 
                #endregion

                #region Page Name: Water History
                        {
                    typeof(WaterHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Water Consumption History"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                                new TextColumn(){ Group = "Total Water" ,DisplayName = "Total (lt)", IsReadOnly = true },
                                new TextColumn(){ Group = "Total Water" ,DisplayName = "Change (%)", IsReadOnly = true },
                            }
                    }
                }, 
        #endregion

                #region Page Name: Feed Consumption History
                {
                    typeof(FeedConsumptionHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Feed Consumption History"}, 
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                                new TextColumn(){ Group = "Daily Feed" ,DisplayName = "Total (kg)", IsReadOnly = true },
                                new TextColumn(){ Group = "Daily Feed" ,DisplayName = "Change (%)", IsReadOnly = true },
                            }
                    }
                }, 
                #endregion

                #region Page Name: Mortality
                {
                    typeof(MortalityHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Mortality"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                                new TextColumn(){ Group = "Total Mortality (%)" ,DisplayName = "Female", IsReadOnly = true },
                                new TextColumn(){ Group = "Total Mortality (%)" ,DisplayName = "Male", IsReadOnly = true },
                                new TextColumn(){ Group = "Total Mortality (%)" ,DisplayName = "Total", IsReadOnly = true },
                                new TextColumn(){ Group = "Total Mortality (No.)" ,DisplayName = "Female", IsReadOnly = true },
                                new TextColumn(){ Group = "Total Mortality (No.)" ,DisplayName = "Male", IsReadOnly = true },
                                new TextColumn(){ Group = "Total Mortality (No.)" ,DisplayName = "Total", IsReadOnly = true },
                                new TextColumn(){ Group = "Dead Birds" ,DisplayName = "Female", IsReadOnly = true },
                                new TextColumn(){ Group = "Dead Birds" ,DisplayName = "Male", IsReadOnly = true },
                                new TextColumn(){ Group = "Dead Birds" ,DisplayName = "Total", IsReadOnly = true },
                                new TextColumn(){ Group = "Culled Birds" ,DisplayName = "Female", IsReadOnly = true },
                                new TextColumn(){ Group = "Culled Birds" ,DisplayName = "Male", IsReadOnly = true },
                                new TextColumn(){ Group = "Culled Birds" ,DisplayName = "Total", IsReadOnly = true },
                                new TextColumn(){ Group = "Bird Count" ,DisplayName = "Female", IsReadOnly = true },
                                new TextColumn(){ Group = "Bird Count" ,DisplayName = "Male", IsReadOnly = true },
                                new TextColumn(){ Group = "Bird Count" ,DisplayName = "Total", IsReadOnly = true },
                            }
                    }
                },
                #endregion

                #region Page Name: Heaters
                        {
                    typeof(HeatersHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Heaters History", "(Hours)"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                            }
                    }
                }, 
                #endregion

                #region Page Name: Radiant Heaters History
                {
                    typeof(RadiantHeatersHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Radiant Heaters History" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                            }
                    }
                },
                #endregion

                #region Page Name: Alarms History
                {
                    typeof(AlarmsHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Alarms History"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Time", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Message", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Active", IsReadOnly = true},
                            }
                    }
                },
                #endregion

                #region Page Name: Events Log History
                {
                    typeof(EventsLogHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Events Log History"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Time", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Message", IsReadOnly = true},
                            }
                    }
                },
                #endregion

                #region Page Name: Power Consumption
                {
                    typeof(PowerConsumptionHistoryPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"Power Consumption", "Current sense"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                                new TextColumn(){ Group = "Daily Power" ,DisplayName = "Total (kWh)", IsReadOnly = true},
                                new TextColumn(){ Group = "Daily Power" ,DisplayName = "Change (%)", IsReadOnly = true},
                                new TextColumn(){ Group = "Heaters" ,DisplayName = "Total (kWh)", IsReadOnly = true},
                                new TextColumn(){ Group = "Heaters" ,DisplayName = "Change (%)", IsReadOnly = true},
                                new TextColumn(){ Group = "Fans" ,DisplayName = "Total (kWh)", IsReadOnly = true},
                                new TextColumn(){ Group = "Fans" ,DisplayName = "Change (%)", IsReadOnly = true},
                                new TextColumn(){ Group = "Light" ,DisplayName = "Total (kWh)", IsReadOnly = true},
                                new TextColumn(){ Group = "Light" ,DisplayName = "Change (%)", IsReadOnly = true},
                                new TextColumn(){ Group = "Others" ,DisplayName = "Total (kWh)", IsReadOnly = true},
                                new TextColumn(){ Group = "Others" ,DisplayName = "Change (%)", IsReadOnly = true},
                            }
                    }
                },
                #endregion

                #region Page Name: History View
                {
                    typeof(HistoryViewPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() {"History View"},
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Time", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Target Temp", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "House Temp Min", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "House Temp Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "House Temp Max", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Temp 1 Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Temp 2 Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Temp 3 Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Temp 4 Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Temp 5 Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Temp 6 Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Attic Min", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Attic Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Attic Max", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Outside Min", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Outside Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Outside Max", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Humidity In 1 Min", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Humidity In 1 Avg", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Humidity In 1 Max", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Water Con", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Feed Con", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Level", IsReadOnly = true},
                            },
                            SettingsPageTitles = new List<string>(){ "History View - Settings" },
                    }
                },

                #endregion

                #endregion

                #region Testig And Calibration

                #region Page Name: Analog Sensors
                {
                    typeof(AnalogSensorsPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Analog Sensors Testing & Calibration" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Input No.", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Sonsor", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Sensor No.", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "A/D", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Value", IsReadOnly = true},
                            },
                    }
                },
                #endregion

                #region Page Name: Digital Sensors
                {
                    typeof(DigitalSensorsPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Digital Sensors Testing & Calibration" },
                    }
                },
                #endregion 

                #region Page Name: Static Pressure
                {
                    typeof(StaticPressureCalibrationPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Static Pressure Testing & Calibration" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "", IsReadOnly = true},
                            },
                    }
                },
                #endregion 
            
                #region Page Name: Water And Feed Calibration
                {
                    typeof(WaterAndFeedCalibrationPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Water & Feed Calibration" },
                    }
                },
                {
                    typeof(WaterTabPage), new ControllerPageSetup()
                    {
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Sensor", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Sensor No.", IsReadOnly = true},
                                new ComboBoxColumn(){ DisplayName = "Method", IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Factor", InputMethod = null, IsReadOnly = false},
                            },
                    }
                },
                #endregion 

                #region Page Name: Scales
                {
                    typeof(ScalesPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Scales Testing & Calibration" },
                    }
                },
                #endregion 

                #region Page Name: Hardware Checklist
                {
                    typeof(HardwareChecklistPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Hardware Checklist" },
                        SettingsPageTitles = new List<string>(){ "Hardware Checklist - Settings" },
                        RegionsCollection = new List<string>(){"Analog Input", "Digital Input", "Analog Output" , "Scale", "Static Pressure", "Alarm", "Relays"}
                    }
                },
                #endregion 

                #region Page Name: Wind Direction Calibration
                {
                    typeof(WindDirectionCalibrationPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Wind Direction Calibration" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Direction", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ DisplayName = "Factor", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            },
                    }
                },
                #endregion 

                #endregion

                #region SYSTEM Pages

                #region PAGE name: General Setup 
                {
                    typeof(GeneralSetupPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() { "General Setup" },
                    }
                }, 
                #endregion

                #region PAGE name: Time & Date 
                {
                    typeof(TimeAndDatePage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>() { "Time & Date" },
                    }
                }, 
                #endregion

                #region Page Name: Levels Of Ventilation
                {
                    typeof(LevelsOfVentilationPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Levels Of Ventilation" },
                        SettingsPageTitles = new List<string>(){ "Ventilation Levels - Settings" }
                    }
                },
                {
                    typeof(ExhaustAndTunnelFansTabPage), new ControllerPageSetup()
                    {
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Level", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "CFM", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Chill Range", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Diff.", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Tunnel Level", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Exh 1", InputMethod = null, IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Tun 1", InputMethod = null, IsReadOnly = false}
                            },
                    }
                },
                {
                    typeof(VentAndCurtainTabPage), new ControllerPageSetup()
                    {
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Level", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Tunnel Level", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Vent (%)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ Group="Tunnel (%)", DisplayName = "1", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ Group="Tunnel (%)", DisplayName = "2", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                                new TextColumn(){ Group="Curtain (%)", DisplayName = "1", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group="Curtain (%)", DisplayName = "2", InputMethod = null, IsReadOnly = false},
                            },
                    }
                },
                {
                    typeof(StirAndVariableStirFansTabFansPage), new ControllerPageSetup()
                    {
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Level", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "Tunnel Level", IsReadOnly = true},
                                new TextColumn(){ Group="Stir Fan No.", DisplayName = "1", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group="Stir Fan No.", DisplayName = "2", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group="Stir Fan No.", DisplayName = "3", InputMethod = null, IsReadOnly = false},
                            },
                    }
                },
                #endregion

                #region Page Name: Stir Fan Program
                {
                    typeof(StirFanProgramPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Stir Fan Program" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Fan No.", IsReadOnly = true},
                                new TextColumn(){ Group = "Program", DisplayName = "A", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group = "Program", DisplayName = "B", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group = "Program", DisplayName = "C", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group = "Program", DisplayName = "D", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group = "Program", DisplayName = "E", InputMethod = null, IsReadOnly = false},
                            },
                         SettingsPageTitles = new List<string>(){ "Stir Fan Program - Settings" }
                    }
                },
                #endregion

                #region Page Name: Relay Layout
                {
                    typeof(RelayLayoutPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Relay Layout" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Relay No.", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Device", InputMethod = new TouchComboBox(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "No.", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "N.C.", InputMethod = new TouchCheckBox(), IsReadOnly = false },//Normally Close
                            },
                        RegionsCollection = new List<string>()
                        {
                            {"Card 1 ,Main, Slot 1"},
                            {"Card 2 ,Main, Slot 2"},
                            {"Card 3 ,Main, Slot 3"},
                            {"Card 4 ,Main, Slot 4"},
                            {"Card 5 ,Main, Slot 5"},
                        }
                    }
                },
                #endregion

                #region Page Name: Sensors Installation
                {
                    typeof(SensorsInstallationPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Sensors" },
                    }
                }, 
                {
                    typeof(AnalogTabPage), new ControllerPageSetup()
                    {
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Input", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Function", IsReadOnly = false, InputMethod = new TouchComboBox()},
                                new TextColumn(){ DisplayName = "Sensor No.", IsReadOnly = false, InputMethod = new NumericUpDownKeyPad()},
                            },
                        RegionsCollection = new List<string>(){"Card 1 ,Main, Slot 2"}
                    }
                },  
                {
                    typeof(DigitalTabPage), new ControllerPageSetup()
                    {
                       TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Input", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Function", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Sensor No.", IsReadOnly = true },
                            },
                       RegionsCollection = new List<string>(){"Card 1 ,Main, Slot 1"}
                    }
                },
                #endregion

                #region Page Name: Analog Outputs Installation
                {
                    typeof(AnalogOutputsInstallationSettingsPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Analog Outputs Installation" },
                        SettingsPageTitles = new List<string>(){ "Analog Output - Settings" },
                        RegionsCollection = new List<string>(){"Card 1 ,Main, Slot 3"}
                    }
                },
                #endregion

                #region Page Name: Temperature Definition
                {
                    typeof(TemperatureCurveSettingsPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Temperature Definition" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Function", IsReadOnly = true},
                                new TextColumn(){ Group = "Sensors", DisplayName = "1", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group = "Sensors", DisplayName = "2", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group = "Sensors", DisplayName = "3", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group = "Sensors", DisplayName = "4", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group = "Sensors", DisplayName = "5", InputMethod = null, IsReadOnly = false},
                                new TextColumn(){ Group = "Sensors", DisplayName = "6", InputMethod = null, IsReadOnly = false},
                            },
                    }
                },
                #endregion

                #region Page Name: Air Inlets Setup
                {
                    typeof(AirInletsSetupPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Air Inlets Setup" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "", IsReadOnly = true},
                                new TextColumn(){ DisplayName = "", InputMethod = new TouchToggleButton(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "Potemntiometer", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "Open (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "Close (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "Wind Dir", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                            },
                    }
                },
                #endregion

                #region Page Name: House Dimention
                {
                    typeof(HouseDimensionsPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "House Dimention" },
                    }
                },
                #endregion

                #region Page Name: Fan Air Capacity
                {
                    typeof(FanAirCapacityPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Fan Air Capacity" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Fan", IsReadOnly = true }, 
                                new TextColumn(){ DisplayName = "CFM or  M3/h", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false }, 
                            },
                    }
                },
                #endregion

                #region Page Name: Bird Curve
                {
                    typeof(BirdCurvePage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Bird Curve" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false }, 
                                new TextColumn(){ DisplayName = "Female Weight", InputMethod = new PointNumericKeyPad(), IsReadOnly = false }, 
                                new TextColumn(){ DisplayName = "Male Weight", InputMethod = new PointNumericKeyPad(), IsReadOnly = false }, 
                            },
                    }
                },
                #endregion

                #region Page Name: Scale Settings
                {
                    typeof(ScaleSettingsPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Scale Settings" },
                        SettingsPageTitles = new List<string>(){ "Ventilation Levels - Settings" }
                    }
                },
                #endregion

                #region Page Name: Silo/Auger Layout
                {
                    typeof(SiloAugerLayoutPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Silo/Auger Layout", "House 1" },
                        TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Silo", IsReadOnly = true }, 
                                new TextColumn(){ DisplayName = "Auger", InputMethod = new TouchToggleButton(), IsReadOnly = false }, 
                                new TextColumn(){ DisplayName = "Device No.", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false }, 
                            },
                    }
                },
                #endregion

                #region Page Name: Communication
                {
                    typeof(CommunicationPage), new ControllerPageSetup()
                    {
                        PageTitles = new List<string>(){ "Communication" },
                    }
                },
                #endregion

                #endregion
            };
        }
    }
}
