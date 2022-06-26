using System;
using System.Collections.Generic;
using System.IO;
using ControllersLayoutParser;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.LightControl;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.LightDimmers;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.WaterAndFeedControl;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.FeedScaleProgram;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HeatersHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.RadiantHeatersHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedInventory;
using Rotem.Touch.UITests.Infrastructure.RNBL;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Co2Treatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.AmmoniaTreatment;
using CoolPadPrecision = Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.CoolPad;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ExtraSystems;
using FoggersPrecision = Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Foggers;
using HumidityPrecision = Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.HumidityTreatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.NaturalVentilation;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.SystemParameters;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.EggRoomControl;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.WorkRoomControl;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Nests;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.AlarmsHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.BirdWeightHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.Co2History;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EventsLogHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.FeedConsumptionHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.FeedConversionHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HistoryView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HumidityHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.Mortality;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.PowerConsumptionHistory;
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
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FailSafeSetting;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedersAndDrinkers;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.GrowthDayAndFlock;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.NippleFlushing;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.Password;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.WaterOnDemand;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.CurrentSense;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.SwitchesAndRelays;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedLinesCalibration;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.VentCurtSetup;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.AnalogOutputsInstallation;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.BirdCurve;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.BirdWeight;
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

using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.AnalogSensors;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.DigitalSensors;

using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.Scales;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.StaticPressureCalibration;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WaterAndFeedCalibration;
using Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WindDirectionCalibration;
using TemperatureCurvePrecision = Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.TemperatureCurve;
using StaticPressurePrecision = Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.StaticPressure;
using ControlModePrecision = Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ControlMode;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations
{
    public class BreederPrecisionBasicFeedingConfiguration : IControllerConfiguration
    {
        #region Configuration's Expected Views

        #region Control

        #region Min Max Level By Day
        private Dictionary<Type, ControllerPageSetup> _pagesSetupDictionary = new Dictionary<Type, ControllerPageSetup>()
        {
            {
                typeof(MinMaxLevelByDaysPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {@"Min / Max Vent Level", @"By Day"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Min Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Max Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false}
                        },
                }
            },

            {
	#endregion                
                
 #region Min Max Level By Curve
		typeof(MinMaxLevelByDaysCurvePage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {@"Min / Max Vent Level", @"By Day With Curve"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Min Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Max Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false}
                        },
                }
            },
            { 
	#endregion

#region Min Max Level By Time
		
                typeof(MinMaxLevelByTimePage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {@"Min / Max Vent Level", @"By Time"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "From", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Min Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Max Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false}
                        },
                }
            },
            { 
	#endregion

#region Min Max Level By Soft Min
		
                typeof(MinMaxLevelBySoftMinPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {@"Min / Max Vent Level", @"Soft Min / Max"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Min Soft", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Min Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Max Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false}
                        },
                    SettingsPageTitles = new List<string>(){"Min Max Level - Settings"},
                }
            },
            { 
	#endregion

#region Min Max Level By Weight
		                typeof(MinMaxLevelByWeightPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {@"Min / Max Vent Level", @"By Weight"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Min Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group= "Air Per Kg/Lb" ,DisplayName = "Cold Air Per", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group= "Air Per Kg/Lb" ,DisplayName = "Warm Air Per", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Max Level", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false}
                        },
                    SettingsPageTitles = new List<string>(){"Min Max Level - Settings"},
                }
            },
	#endregion

#region Water & Feed
            {
                typeof(WaterAndFeedPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {@"Water & Feed Control"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "From Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "To Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Water", DisplayName = "1", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Feeder", DisplayName = "1", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Auger", DisplayName = "1", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                        },
                    SettingsPageTitles = new List<string>(){"Water & Feed - Settings"},
                }

            },
            	#endregion

#region Light
		       
            {
                typeof(LightControlPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){"Light Control"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new MinusNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "From Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light", DisplayName = "1", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            //new OnOffButtonColumn(){ Group ="Light", DisplayName = "2", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            //new OnOffButtonColumn(){ Group ="Light", DisplayName = "3", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                           // new OnOffButtonColumn(){ Group ="Light", DisplayName = "3", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light Dimmer", DisplayName = "1", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light Dimmer", DisplayName = "2", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},

                        },
                    SettingsPageTitles = new List<string>(){"Light - Settings"},
                }
            },  
	#endregion

    #region Ammonia Treatment
    {
        typeof(AmmoniaTreatmentPage), new ControllerPageSetup()
        {
            PageTitles = new List<string>(){ "Ammonia Treatment" },
            TableColumns = new List<ITableColumn>()
                {
                    new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                    new TextColumn(){ DisplayName = "Start Value", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                    new TextColumn(){ DisplayName = "Stop Value", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                    new TextColumn(){ DisplayName = "Delay (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                    new TextColumn(){ DisplayName = "Duration (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                },
                SettingsPageTitles = new List<string>(){ "Ammonia Treatment - Settings" }
        }
    },
    #endregion

#region Light Feed TAB
            {
                typeof(LightFeedTabPage), new ControllerPageSetup()
                {
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new MinusNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light", DisplayName = "1", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light", DisplayName = "2", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light", DisplayName = "3", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light", DisplayName = "4", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            //new TextColumn(){ Group ="Light Dimmer", DisplayName = "1", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            //new TextColumn(){ Group ="Light Dimmer", DisplayName = "2", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        },
                }
            }, 
	#endregion

#region Light No Feed TAB
		            {
                typeof(LightNoFeedTabPage), new ControllerPageSetup()
                {
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new MinusNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light", DisplayName = "1", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light", DisplayName = "2", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light", DisplayName = "3", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                            new OnOffButtonColumn(){ Group ="Light", DisplayName = "4", InputMethod = new TouchToggleButton(), IsReadOnly = false},
                           // new TextColumn(){ Group ="Light Dimmer", DisplayName = "1", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            //new TextColumn(){ Group ="Light Dimmer", DisplayName = "2", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        },
                }
            }, 
	#endregion

#region Feed Inventory
		            {
                typeof(FeedInventoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Feed Inventory"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new DateColumn(){ DisplayName = "Date", InputMethod = new DateKeyPad(), IsReadOnly = true},
                            new TextColumn(){ Group ="Silo", DisplayName = "1", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group ="Silo", DisplayName = "2", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group ="Silo", DisplayName = "3", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group ="Silo", DisplayName = "4", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        },
                    SettingsPageTitles = new List<string>(){"Feed Inventory - Settings"},
                }
            }, 
	#endregion

#region Feed Scale Program
		            {
                typeof(FeedScaleProgramPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Feed Scale Program"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new DateKeyPad(), IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Feed Per Bird", InputMethod = new DateKeyPad(), IsReadOnly = true},
                            new TextColumn(){ Group ="Silo", DisplayName = "1", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group ="Silo", DisplayName = "2", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group ="Silo", DisplayName = "3", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group ="Silo", DisplayName = "4", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        },
                    SettingsPageTitles = new List<string>(){"Feed Inventory - Settings"},
                }
            }, 
	#endregion
 
	#endregion

#region History
		
#region Heaters History
		            {
                typeof(HeatersHistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Heaters History", "(Hours)"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 1", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 2", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 3", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 4", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 5", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 6", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 7", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 8", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 9", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 10", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 11", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 12", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 13", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 14", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 15", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heater 16", IsReadOnly = true},
                        }
                }
            }, 
	#endregion

#region RadiantHeatersHistory
		
            {
                typeof(RadiantHeatersHistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Radiant Heaters History"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn() { DisplayName = "Day", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 1", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 1", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 2", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 2", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 3", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 3", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 4", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 4", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 5", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 5", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 6", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 6", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 7", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 7", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 8", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 8", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 9", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 9", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 10", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 10", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 11", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 11", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 12", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 12", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 13", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 13", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 14", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 14", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 15", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 15", DisplayName = "High", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 16", DisplayName = "Low", IsReadOnly = true },
                            new TimeColumn() { Group ="Heater 16", DisplayName = "High", IsReadOnly = true }
                        }
                }
            }
        };

        #endregion

        #endregion

        #endregion

        private Dictionary<Type, ControllerPageSetup> _fixedPagesSetupDictionary = new Dictionary<Type, ControllerPageSetup>()
        {
            #region CONTROL Pages

            #region Page Name: Temperature Curve
		   {
                typeof(TemperatureCurvePrecision.TemperatureCurvePage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Temperature Curve" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new MinusNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Target", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Heat Off", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Tunnel", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group = "Alarm", DisplayName = "Low", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group = "Alarm", DisplayName = "High", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group = "Alarm", DisplayName = "Tunnel High", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                        },
                        SettingsPageTitles = new List<string>(){ "Temperature Curve - Settings" }
                }
            },
            #endregion

            #region Page Name: Humidity Treatment
            {
                typeof(HumidityPrecision.HumidityTreatmentPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Humidity Treatment" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Humidity", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Delay (Min.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Duration (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
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
                            new TextColumn(){ Group = "PPM", DisplayName = "Start Value", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group = "PPM", DisplayName = "Stop Value", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Delay (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Duration (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        },
                     SettingsPageTitles = new List<string>(){ "CO2 Treatment - Settings" }
                }
            },
            #endregion

            #region Page Name: Ammonia Treatment
            {
                typeof(AmmoniaTreatmentPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Ammonia Treatment" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Start Value", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Stop Value", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Delay (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Duration (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        },
                     SettingsPageTitles = new List<string>(){ "Ammonia Treatment - Settings" }
                }
            },
            #endregion

            #region Page Name: Natural Ventilation
            {
                typeof(NaturalVentilationPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Natural Ventilation" },
                    SettingsPageTitles = new List<string>(){ "Natural Ventilation - Settings" }
                }
            },
            #endregion

            #region Page Name: Static Pressure
            {
                typeof(StaticPressurePrecision.StaticPressurePage), new ControllerPageSetup ()
                {
                    PageTitles = new List<string>(){ "Static Pressure" },
                    SettingsPageTitles = new List<string>(){ "Static Pressure - Settings" }
                }
            },
            #endregion

            #region Page Name: Cool Pad
            {
                typeof(CoolPadPrecision.CoolPadPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Cool Pad" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "Start Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "End Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Tunnel Diff", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "To Humidity", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "On (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Off (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        },
                     SettingsPageTitles = new List<string>(){ "Cool Pad - Settings" }
                }
            },
            #endregion

            #region Page Name: Foggers
            {
                typeof(FoggersPrecision.FoggersPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Foggers" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "Start Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "End Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Target Diff", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "To Humidity", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "On (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Off (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},

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
                        new TextColumn(){ Group= "Temperature" ,DisplayName = "From", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                        new TextColumn(){ Group= "Temperature" ,DisplayName = "To", InputMethod = new MinusPointNumericKeyPad(), IsReadOnly = false},
                        new TextColumn(){ Group = "Humidity" ,DisplayName = "From", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        new TextColumn(){ Group = "Humidity" ,DisplayName = "To", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        new TextColumn(){ DisplayName = "On (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        new TextColumn(){ DisplayName = "Off (Sec.)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false}
                    }
                }
            }, 
            #endregion

            #region Page Name: Control Mode
            {
                typeof(ControlModePrecision.ControlModePage), new ControllerPageSetup()
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

            #region Light Dimmers
            {
                typeof(LightDimmersPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Light Dimmers" },
                    TableColumns = new List<ITableColumn>
                    {
                        new TextColumn {DisplayName = "Address", IsReadOnly = true},
                        new TextColumn {DisplayName = "Device", InputMethod = new TouchComboBox(), IsReadOnly = false},
                    },
                }
            },
            #endregion

            #region Page Name: Egg Room Control
            {
                typeof(EggRoomControlPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Egg Room Control" },
                    SettingsPageTitles = new List<string>(){ "Egg Room - Settings" }
                }
            },
            #endregion

            #region Page Name: Work Room Control
            {
                typeof(WorkRoomControlPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Work Room Control" },
                    TableColumns = new List<ITableColumn>()
                    {
                        new TextColumn(){ DisplayName = "Function", IsReadOnly = true},
                        new TimeColumn(){ DisplayName = "On", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        new TextColumn(){ DisplayName = "Off", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                    }
                }
            }, 
            #endregion

            #region PAGE name: Nests
            {
                typeof(NestsPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Nests" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Number", IsReadOnly = true },
                            new TextColumn(){ Group = "Open", DisplayName = "Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group = "Open", DisplayName = "Duration (sec)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ Group = "Close", DisplayName = "Time", InputMethod = new TimeKeyPad(), IsReadOnly = false },
                            new TextColumn(){ Group = "Close", DisplayName = "Duration (sec)",  InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                        }
                }
            }, 
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
                            new TextColumn(){ Group = "Dead Birds", DisplayName = "Update", InputMethod = new MinusNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ Group = "Dead Birds", DisplayName = "Total", IsReadOnly = true },
                            new TextColumn(){ Group = "Culled Birds", DisplayName = "Update", InputMethod = new MinusNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ Group = "Culled Birds", DisplayName = "Total", IsReadOnly = true },
                            new TextColumn(){ Group = "Birds Moved", DisplayName = "Update", InputMethod = new MinusNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ Group = "Birds Moved", DisplayName = "Total", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Bird Count", IsReadOnly = true },
                        }
                }
            }, 
            #endregion

            #region PAGE name: Growth Day & Flock
            {
                typeof(GrowthDayAndFlockPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Growth Day & Flock" },
                }
            }, 
            #endregion

            #region PAGE name: Alarm Settings
            {
                typeof(AlarmSettingsPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Alarm Settings" },
                    SettingsPageTitles = new List<string>(){ "Alarms - Settings" },
                }
            }, 
            #endregion

            #region PAGE name: Alarm Reset
            {
                typeof(AlarmResetPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Alarm Reset" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "No.", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Message",IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Time", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "State", IsReadOnly = true },
                        }
                }
            }, 
            #endregion

            #region PAGE name: Fail Safe Setting
            {
                typeof(FailSafeSettingPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Fail Safe Settings" },
                }
            }, 
            #endregion

            #region PAGE name: Password
            {
                typeof(PasswordPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Password" },
                }
            }, 
            #endregion
                
            #region PAGE name: Feeders And Drinkers
            {
                typeof(FeedersAndDrinkersPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Feeders & Drinkers" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Window Pos (%)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Feeder-Line Lift (inch)", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Drinker-Line Lift (inch)", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                        },
                        SettingsPageTitles = new List<string>(){ "Feeders & Drinkers - Settings" },
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
                    PageTitles = new List<string>(){ "Water On Demand" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "Time", InputMethod = new TimeKeyPad(), IsReadOnly = false},
                            new TextColumn(){ Group = "Relays", DisplayName = "1", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                        },
                    SettingsPageTitles = new List<string>(){ "Water On Demand - Settings" }
                }
            }, 
            #endregion

            #region PAGE name: Current Sense
            {
                typeof(CurrentSensePage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Current Sense Installation" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Relay", IsReadOnly = true },
                            new TimeColumn(){ DisplayName = "Function", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Function", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Min", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Nominal", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Maximum", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Volt", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Alarm", InputMethod = new TouchComboBox(), IsReadOnly = false},
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

            #region PAGE name: Switches And Relays
            {
                typeof(SwitchesAndRelaysPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Switches & Relays" }
                }
            }, 
            #endregion

            #region Page Name: Feed Lines Calibration
            {
                typeof(FeedLinesCalibrationPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Feed Lines Calibration" },
                    TableColumns = new List<ITableColumn>()
                    {
                        new TextColumn(){ DisplayName = "Function", IsReadOnly = true},
                        new TimeColumn(){ DisplayName = "Run Time (sec)", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                    }
                }
            }, 
            #endregion

            #endregion

            #region HISTORY Pages
            
            #region Page Name: Temperature History
            {

                typeof(TemperatureHistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Temperature History"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Min", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Avg", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Max", IsReadOnly = true },
                        }
                }
            }, 
            #endregion

            #region Page Name: Humidity History
                    {
                typeof(HumidityHistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Humidity History"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Min (%)", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Avg (%)", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Max (%)", IsReadOnly = true },
                        }
                }
            }, 
            #endregion

            #region Page Name: CO2 History
                    {
                typeof(Co2HistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"CO2 History"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Min (PPM)", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Avg (PPM)", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Max (PPM)", IsReadOnly = true },
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
                            new TextColumn(){ Group = "Common", DisplayName = "Weight", IsReadOnly = true },
                            new TextColumn(){ Group = "Common", DisplayName = "Daily Gain", IsReadOnly = true },
                            new TextColumn(){ Group = "Common", DisplayName = "No. Of Weights", IsReadOnly = true },
                            new TextColumn(){ Group = "Common", DisplayName = "Std. Dev.", IsReadOnly = true },
                            new TextColumn(){ Group = "Common", DisplayName = "Uniformity", IsReadOnly = true },
                            new TextColumn(){ Group = "Common", DisplayName = "C.V.", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-1", DisplayName = "Weight", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-1", DisplayName = "Daily Gain", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-1", DisplayName = "No. Of Weights", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-1", DisplayName = "Std. Dev.", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-1", DisplayName = "Uniformity", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-1", DisplayName = "C.V.", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-2", DisplayName = "Weight", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-2", DisplayName = "Daily Gain", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-2", DisplayName = "No. Of Weights", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-2", DisplayName = "Std. Dev.", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-2", DisplayName = "Uniformity", IsReadOnly = true },
                            new TextColumn(){ Group = "Scale-2", DisplayName = "C.V.", IsReadOnly = true },
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
                            new TextColumn(){ DisplayName = "Bird Weight", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Daily Feed", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Feed Conversion", IsReadOnly = true },
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
                            new TextColumn(){ Group = "Total Daily Water" ,DisplayName = "Total", IsReadOnly = true },
                            new TextColumn(){ Group = "Total Daily Water" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Water Per Bird", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-1" ,DisplayName = "Water-1", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-1" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-2" ,DisplayName = "Water-2", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-2" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-3" ,DisplayName = "Water-3", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-3" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-4" ,DisplayName = "Water-4", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-4" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-5" ,DisplayName = "Water-5", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-5" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-6" ,DisplayName = "Water-6", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-6" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-7" ,DisplayName = "Water-7", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-7" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-8" ,DisplayName = "Water-8", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-8" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-9" ,DisplayName = "Water-9", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-9" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-10" ,DisplayName = "Water-10", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-10" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-11" ,DisplayName = "Water-11", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-11" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-12" ,DisplayName = "Water-12", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-12" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-13" ,DisplayName = "Water-13", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-13" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-14" ,DisplayName = "Water-14", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-14" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-15" ,DisplayName = "Water-15", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-15" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-16" ,DisplayName = "Water-16", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-16" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-17" ,DisplayName = "Water-17", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-17" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-18" ,DisplayName = "Water-18", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-18" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-19" ,DisplayName = "Water-19", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-19" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-20" ,DisplayName = "Water-20", IsReadOnly = true },
                            new TextColumn(){ Group = "Water-20" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Total Water", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Cool Pad", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Fogger", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Flushed Water", IsReadOnly = true },
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
                            new TextColumn(){ Group = "Daily Feed" ,DisplayName = "Total", IsReadOnly = true },
                            new TextColumn(){ Group = "Daily Feed" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Feed Per Bird", IsReadOnly = true },
                            new TextColumn(){ Group = "Feed-1 Daily" ,DisplayName = "Feed 1", IsReadOnly = true },
                            new TextColumn(){ Group = "Feed-1 Daily" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Feed-2 Daily" ,DisplayName = "Feed 2", IsReadOnly = true },
                            new TextColumn(){ Group = "Feed-2 Daily" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Feed-3 Daily" ,DisplayName = "Feed 3", IsReadOnly = true },
                            new TextColumn(){ Group = "Feed-3 Daily" ,DisplayName = "Change (%)", IsReadOnly = true },
                            new TextColumn(){ Group = "Feed-4 Daily" ,DisplayName = "Feed 4", IsReadOnly = true },
                            new TextColumn(){ Group = "Feed-4 Daily" ,DisplayName = "Change (%)", IsReadOnly = true },
                        }
                }
            }, 
            #endregion

            #region Page Name: Mortality
            {
                typeof(MortalityHistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Mortality History"},
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
                            //new TextColumn(){ DisplayName = "Active", IsReadOnly = true},//gutman removed
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
                    PageTitles = new List<string>() {"Power Consumption", "Current Sense"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Heaters", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Fans", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Lights", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Others", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Total", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Change (%)", IsReadOnly = true},
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

            #region Page Name: Ammonia History
                    {
                typeof(AmmoniaHistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Ammonia History"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Min (%)", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Avg (%)", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Max (%)", IsReadOnly = true },
                        }
                }
            }, 
            #endregion

            #region Page Name: Egg Room History
            {
                typeof(EggRoomhistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Egg Room"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                            new TextColumn(){ Group = "Temperature" ,DisplayName = "Min", IsReadOnly = true },
                            new TextColumn(){ Group = "Temperature" ,DisplayName = "Avg", IsReadOnly = true },
                            new TextColumn(){ Group = "Temperature" ,DisplayName = "Max", IsReadOnly = true },
                            new TextColumn(){ Group = "Humidity" ,DisplayName = "Min", IsReadOnly = true },
                            new TextColumn(){ Group = "Humidity" ,DisplayName = "Avg", IsReadOnly = true },
                            new TextColumn(){ Group = "Humidity" ,DisplayName = "Max", IsReadOnly = true },
                        }
                }
            },
            #endregion

            #region Page Name: Egg Belt History
            {
                typeof(EggBelthistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Egg Belt Run Time"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "1", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "2", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "3", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "4", IsReadOnly = true },

                        }
                }
            },
            #endregion

            #region Page Name: Eggs History
            {
                typeof(EggshistoryPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() {"Eggs History"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Day", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "1", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "2", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "3", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "4", IsReadOnly = true },

                        }
                }
            },
            #endregion

            #endregion

            #region Testing And Calibration

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

            #region PAGE name: Setup 
            {
                typeof(GeneralSetupPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Setup" },
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
                    SettingsPageTitles = new List<string>(){ @"Vent & Curtain Levels - Settings", @"Vent Levels - Settings"},
                    TabsCollection = new List<string>(){ @"Exhaust & Tunnel Fans", @"Vent & Curtain", "Variable Speed Fans", @"Stir & Variable Stir Fans"}
                }
            },
            {
                typeof(ExhaustAndTunnelFansTabPage), new ControllerPageSetup()
                {
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Level", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "On (Sec.)", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Air Capacity", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Diff.", InputMethod = new PointNumericKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Tunnel Level", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Exhaust: E1", InputMethod = new StateCycleKeyPad(), IsReadOnly = false},
                            new TextColumn(){ DisplayName = "Tunnel: T1", InputMethod = new StateCycleKeyPad(), IsReadOnly = false}
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
                            new TextColumn(){ DisplayName = "Vent", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                        },
                }
            },
            { //TODO: EDIT PROPERTIES
                typeof(VariableSpeedFansTabPage), new ControllerPageSetup()
                {
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Level", IsReadOnly = true},
                            new TextColumn(){ DisplayName = "Tunnel Level", IsReadOnly = true},
                            new TextColumn(){ Group="Exhaust", DisplayName = "1", IsReadOnly = true},
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
                            new TextColumn(){ Group="Stir Fan", DisplayName = "V1", InputMethod = new StateCycleKeyPad(), IsReadOnly = false},
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
                            new TextColumn(){ Group = "Program", DisplayName = "A", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ Group = "Program", DisplayName = "B", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ Group = "Program", DisplayName = "C", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ Group = "Program", DisplayName = "D", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ Group = "Program", DisplayName = "E", InputMethod = new TouchCheckBox(), IsReadOnly = false},
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
                                new TextColumn(){ DisplayName = "No.", InputMethod = new NumericUpDownKeyPad(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "N.C.", InputMethod = new TouchCheckBox(), IsReadOnly = false },
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
                            new TextColumn(){ DisplayName = "Function", InputMethod = new TouchComboBox(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Sensor No.", InputMethod = new NumericUpDownKeyPad(), IsReadOnly = false },
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
                            new TextColumn(){ DisplayName = "Function", InputMethod = new TouchComboBox(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Sensor No.", InputMethod = new NumericUpDownKeyPad(), IsReadOnly = false },
                        },
                   RegionsCollection = new List<string>(){"Card 1 ,Main, Slot 1"}
                }
            },
            #endregion

            #region Page Name: Analog Outputs Installation
            {
                typeof(AnalogOutputsInstallationPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Analog Outputs Installation" },
                    SettingsPageTitles = new List<string>(){ "Analog Output - Settings" },
                    RegionsCollection = new List<string>(){"Card 1 ,Main, Slot 3"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Output No.", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Function", InputMethod = new TouchComboBox(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Output Function", InputMethod = new NumericUpDownKeyPad(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Min V.Out", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Max V.Out", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                        },
                }
            },
            #endregion

            #region Page Name: Temperature Definition
            {
                typeof(TemperatureDefinitionPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Temperature Definition" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Function", IsReadOnly = true},
                            new TextColumn(){ Group = "Sensors", DisplayName = "1", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ Group = "Sensors", DisplayName = "2", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ Group = "Sensors", DisplayName = "3", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ Group = "Sensors", DisplayName = "4", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ Group = "Sensors", DisplayName = "5", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                            new TextColumn(){ Group = "Sensors", DisplayName = "6", InputMethod = new TouchCheckBox(), IsReadOnly = false},
                        },
                }
            },
            #endregion


            #region Vent/Curt Setup 
            {
                typeof(VentCurtSetupPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Vent/Curt Setup" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Curtain", IsReadOnly = true},
                            new TimeColumn(){ DisplayName = "Pot.",InputMethod = new TouchToggleButton() ,IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "Potentiometer", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){DisplayName = "Open", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){DisplayName = "Close", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "Wind Direction", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false},
                            new TimeColumn(){ DisplayName = "Stop Fans", InputMethod = new TouchComboBox(), IsReadOnly = false},
                       },
                       SettingsPageTitles = new List<string>() { "Vent/Curt Calibration" }
                }
            },
            #endregion 

            #region Page Name: House Dimention
            {
                typeof(HouseDimensionsPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "House Dimensions" },
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
                            new TextColumn(){ DisplayName = "M3/h", InputMethod = new BaseNumericKeyPad(), IsReadOnly = false },
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
                            new TextColumn(){ DisplayName = "Female", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Male", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                        },
                    SettingsPageTitles = new List<string>(){ "Bird Curve" }
                }
            },
            #endregion

            #region Page Name: Bird Weight
            {
                typeof(BirdWeightPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Bird Weight" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Description", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Value", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                        },
                    SettingsPageTitles = new List<string>(){ "Bird Weight" }
                }
            },
            #endregion

            #region Page Name: Scale Settings
            {
                typeof(ScaleSettingsPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Scale Settings" },
                    SettingsPageTitles = new List<string>(){ "General Scale - Settings" }
                }
            },
            #endregion

            #region Page Name: Silo/Auger Layout
            {
                typeof(SiloAugerLayoutPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Silo/Auger Layout"},
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

            #region Page Name: Version
            {

                typeof(VersionPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Version"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Name", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Version", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Date", IsReadOnly = true },
                        }
                }
            }, 
            #endregion

            #region Page Name: Scale Testing
            {

                typeof(ScaleTestingPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Scale Testing"},
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Type", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Weight", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "A/D", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Status", IsReadOnly = true },
                        }
                }
            }, 
            #endregion

            #region Page Name: Scale Layout
            {
                typeof(ScaleLayoutPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Scale Layout" },
                    TableColumns = new List<ITableColumn>()
                            {
                                new TextColumn(){ DisplayName = "Channel.", IsReadOnly = true },
                                new TextColumn(){ DisplayName = "Function", InputMethod = new TouchComboBox(), IsReadOnly = false },
                                new TextColumn(){ DisplayName = "No.", InputMethod = new NumericUpDownKeyPad(), IsReadOnly = false },
                            },
                        RegionsCollection = new List<string>()
                        {
                            {"Card 1 ,Main, Slot 1"},
                        }
                }
            },
            #endregion

            #region Page Name: Munters Drive
            {
                typeof(MuntersDrivePage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>(){ "Munters Drive" },
                    TableColumns = new List<ITableColumn>()
                        {
                            new TextColumn(){ DisplayName = "Fan ID", IsReadOnly = true },
                            new TextColumn(){ DisplayName = "Exh/Tun", InputMethod = new TouchComboBox(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Fan No.", InputMethod = new PointNumericKeyPad(), IsReadOnly = false },
                            new TextColumn(){ DisplayName = "Type", InputMethod = new TouchComboBox(), IsReadOnly = false },
                        },
                }
            },
            #endregion

            #endregion

            #region Hot Keys Pages

              #region PAGE name: Curve Status
            {
                typeof(CurvePage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Curve Status" },
                }
            }, 
            #endregion

              #region PAGE name: Light Status 
            {
                typeof(LightStatusPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Light Status" },
                }
            }, 
            #endregion
              #region PAGE name: Temperature & Humidity Status 
            {
                typeof(TemperatureandHumidityPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Temperature & Humidity Status" },
                }
            }, 
            #endregion

              #region PAGE name: Natural Ventilation Hot Key 
            {
                typeof(NaturalVentilationPageHotkey), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Natural Ventilation" },
                }
            }, 
            #endregion

              #region PAGE name: Analog Output Status 
            {
                typeof(AnalogOutputStatusPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Analog Output Status" },
                }
            }, 
            #endregion
              #region PAGE name: Feed Scale Status 
            {
                typeof(FeedScaleStatusPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Feed Scale Status" },
                }
            }, 
            #endregion

              #region PAGE name: Water Meters 
            {
                typeof(WaterMetersPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Water Meters" },
                }
            }, 
            #endregion

            #region PAGE name: Egg Counter State
            {
                typeof(EggCounterStatePage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Egg Counter State" },
                }
            }, 
            #endregion

            #region PAGE name: Egg Room Status
            {
                typeof(EggRoomStatusPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Egg Room Status" },
                }
            }, 
            #endregion

            #region PAGE name: Bird Scale 
            {
                typeof(BirdScalePage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Bird Scale" },
                }
            }, 
            #endregion

            #region PAGE name: Silo
            {
                typeof(SiloPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Silo" },
                }
            }, 
            #endregion

            #region PAGE name: Curtain Position
            {
                typeof(CurtainPositionPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Curtain Position" },
                }
            }, 
            #endregion
             #region PAGE name: Air Status
            {
                typeof(AirStatusPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Air Status" },
                }
            }, 
            #endregion
            #region PAGE name: Water And Feed Status
            {
                typeof(WaterAndFeedStatusPage), new ControllerPageSetup()
                {
                    PageTitles = new List<string>() { "Water & Feed Status" },
                }
            }, 
            #endregion
#endregion

#endregion
        };

        public BreederPrecisionBasicFeedingConfiguration()
        {
            Name = "BreederPrecisionBasicFeeding";
            WaterDevices = 4;
            FeedDevices = 4;
            AugerDevices = 4;
            LightDevices = 1;
            LightDimmerDevices = 4;
            SiloDevices = 4;
            HeatersDevices = 1;
            LowRadiantHeatersDevices = 5;
            HighRadiantHeatersDevices = 5;
            FamilyType = null;
            TemperatureUnit = TemperatureUnit.None;
            WeightUnit = WeightUnit.None;

            RnblArgs = new RnblArgs()
            {
                ControllerType = ControllerType.PLATINUM_PLUS_BREEDER_PRECISION,
                MemoryVersion = 8,
                ControllerMajorVersion = 5,
                LevelControl = LevelControl.CM_SoftMin,

                /* Online path:*/
                MetadataDirectoryInfo = new DirectoryInfo(Path.GetFullPath("../../../Rotem.Touch.UITests.Infrastructure/ExternalDependencies//PLATINUM_PLUS_BREEDER_PRECISION_METADATA/"))

                /* Offline path:*/
                //MetadataDirectoryInfo = new DirectoryInfo(Path.GetFullPath(@"C:\Work\Customers\Rotem\Workspaces\Rotem.UIAutomation.NewArchitecture\Rotem.Touch.UITests.Infrastructure\ExternalDependencies\PLATINUM_PLUS_BROILER_PRECISION_METADATA"))
            };
            LevelControl = RnblArgs.LevelControl;
        }
        public string Name { get; set; }
        public string FamilyType { get; set; }
        public TemperatureUnit TemperatureUnit { get; set; }
        public WeightUnit WeightUnit { get; set; }
        public int WaterDevices { get; set; }
        public int FeedDevices { get; set; }
        public int AugerDevices { get; set; }
        public int LightDevices { get; set; }
        public int LightDimmerDevices { get; set; }
        public int SiloDevices { get; set; }
        public RnblArgs RnblArgs { get; set; }
        public int HeatersDevices { get; set; }
        public int LowRadiantHeatersDevices { get; set; }
        public int HighRadiantHeatersDevices { get; set; }
        public LevelControl LevelControl { get; set; }

        Dictionary<Type, ControllerPageSetup> IControllerConfiguration.PagesSetupDictionary
        {
            get
            {
                return _pagesSetupDictionary;
            }
        }

        public Dictionary<Type, ControllerPageSetup> FixedPagesSetupDictionary
        {
            get
            {
                return _fixedPagesSetupDictionary;
            }
        }
    }
}
