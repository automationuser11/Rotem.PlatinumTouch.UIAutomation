using System;
using System.Collections.Generic;
using System.Linq;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AlarmSettings
{
    public class AlarmSettingsPage : SimpleSettingsPage, IApplicationPage, ISettingsModalViewProvider<AlarmSettingsSettingsPage>, IMetadataDependentPageObject
    {
        private dynamic[] _advancedSettingsFields;
        public AlarmSettingsPage()
        {
            _advancedSettingsFields = new dynamic[]
            {
                HighLowPressureDiffPsi, ShutdownPresureDiffPsi, AllowFeedAlarmsFromhhmm, AllowFeedAlarmsTohhmm,
                Silo1LowFeedAlarmLimit, Silo2LowFeedAlarmLimit, Silo3LowFeedAlarmLimit, Silo4LowFeedAlarmLimit,
                OverflowAccordingLightTable, FirstDayCurveForOverflow, OverflowAtFirstDayPerMin, LastDayCurveForOverflow,
                OverflowAtLastDayPerMin, OverflowAtDarkPerMin, OverflowAlarmDelayminutes, ExtraDelayAtLightStartmin,
                FoggerWaterOverflowPermin, AllowWaterShortageAlarmFrom, AllowWaterShortageAlarmTo, ShortageDuringLightsOff,
                QuantityForShortagePermin, ShortageAlarmDelayminutes, AllowBirdScaleAlarmFrom, AllowBirdScaleAlarmTo,
                RelatedRelayForAuxAlarm1, RelatedRelayForAuxAlarm2, RelatedRelayForAuxAlarm3, RelatedRelayForAuxAlarm4,
                AuxAlarmDelayseconds, TempForCircuitBreakerAlarm, Co2HighLevel, HumidityHighLevel
            };
        }
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<AlarmSettingsPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Alarm Settings"; }
        }
        public string MenuName
        {
            get { return "Alarm Settings"; }
        }
        public string SubMenu { get { return "Management"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }
        public AlarmSettingsSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new AlarmSettingsSettingsPage()); }
        }
        private AlarmSettingsSettingsPage _settingsView;
        public bool ValidateAdvancedSettingsFieldsDisplayed()
        {
            return _advancedSettingsFields.All(settingField => settingField.IsFieldExist());
        }
        public bool ValidateAdvancedSettingsFieldsDoNotDisplayed()
        {
            return _advancedSettingsFields.All(settingField => !settingField.IsFieldExist());
        }

        #region Group Name:

        public KeyPadSettingsField GlobalAlarmDelaysec
        {
            get { return _globalAlarmDelaysec ?? (_globalAlarmDelaysec = new KeyPadSettingsField() { Name = "Global Alarm Delay (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _globalAlarmDelaysec = value; }
        }
        private KeyPadSettingsField _globalAlarmDelaysec;

        public KeyPadSettingsField AlarmRemindermin
        {
            get { return _alarmRemindermin ?? (_alarmRemindermin = new KeyPadSettingsField() { Name = @"""Alarm Reminder (Minutes, 0-Disable)""", InputMethod = new BaseNumericKeyPad() }); }
            set { _alarmRemindermin = value; }
        }
        private KeyPadSettingsField _alarmRemindermin;

        #endregion

        #region Group Name: Sensor Alarm


        public KeyPadSettingsField SensorLowTempRange
        {
            get { return _sensorLowTempRange ?? (_sensorLowTempRange = new KeyPadSettingsField() { Name = "Sensor Low Temperature Range", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _sensorLowTempRange = value; }
        }
        private KeyPadSettingsField _sensorLowTempRange;

        public KeyPadSettingsField SensorAlarmDiffFromLowAlarm
        {
            get { return _sensorAlarmDiffFromLowAlarm ?? (_sensorAlarmDiffFromLowAlarm = new KeyPadSettingsField() { Name = "Sensor Alarm-Differential From Low Alarm", InputMethod = new PointNumericKeyPad() }); }
            set { _sensorAlarmDiffFromLowAlarm = value; }
        }
        private KeyPadSettingsField _sensorAlarmDiffFromLowAlarm;

        public KeyPadSettingsField SensorHighTempRange
        {
            get { return _sensorHighTempRange ?? (_sensorHighTempRange = new KeyPadSettingsField() { Name = "Sensor High Temperature Range", InputMethod = new PointNumericKeyPad() }); }
            set { _sensorHighTempRange = value; }
        }
        private KeyPadSettingsField _sensorHighTempRange;

        public KeyPadSettingsField SensorAlarmDiffFromHighAlarm
        {
            get { return _sensorAlarmDiffFromHighAlarm ?? (_sensorAlarmDiffFromHighAlarm = new KeyPadSettingsField() { Name = "Sensor Alarm-Differential From High Alarm", InputMethod = new PointNumericKeyPad() }); }
            set { _sensorAlarmDiffFromHighAlarm = value; }
        }
        private KeyPadSettingsField _sensorAlarmDiffFromHighAlarm;

        #endregion

        #region Group Name: Alarm

        public KeyPadSettingsField AlarmTestAtTime
        {
            get { return _alarmTestAtTime ?? (_alarmTestAtTime = new KeyPadSettingsField() { Name = "Alarm Test At Time: (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _alarmTestAtTime = value; }
        }
        private KeyPadSettingsField _alarmTestAtTime;

        public KeyPadSettingsField AlarmTestDurationsec
        {
            get { return _alarmTestDurationsec ?? (_alarmTestDurationsec = new KeyPadSettingsField() { Name = "Alarm Test Duration (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _alarmTestDurationsec = value; }
        }
        private KeyPadSettingsField _alarmTestDurationsec;
        public ComboboxSettingsField DayOfAlarmTest
        {
            get { return _dayOfAlarmTest ?? (_dayOfAlarmTest = new ComboboxSettingsField("Day Of Alarm Test")); }
            set { _dayOfAlarmTest = value; }
        }
        private ComboboxSettingsField _dayOfAlarmTest;

        #endregion

        #region Group Name: Auger Overtime Alarm

        public KeyPadSettingsField AugerOvertimeAlarmDelaymin
        {
            get { return _augerOvertimeAlarmDelaymin ?? (_augerOvertimeAlarmDelaymin = new KeyPadSettingsField() { Name = "Auger Overtime Delay (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _augerOvertimeAlarmDelaymin = value; }
        }
        private KeyPadSettingsField _augerOvertimeAlarmDelaymin;
        public ComboboxSettingsField FeederOffDuringOvertime
        {
            get { return _feederOffDuringOvertime ?? (_feederOffDuringOvertime = new ComboboxSettingsField("Auger Off During Overtime")); }
            set { _feederOffDuringOvertime = value; }
        }
        private ComboboxSettingsField _feederOffDuringOvertime;

        #endregion

        #region Group Name: Feeder Overtime Alarm

        public KeyPadSettingsField FeederOvertimeAlarmDelaymin
        {
            get { return _feederOvertimeAlarmDelaymin ?? (_feederOvertimeAlarmDelaymin = new KeyPadSettingsField() { Name = "Feeder Overtime Delay (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _feederOvertimeAlarmDelaymin = value; }
        }
        private KeyPadSettingsField _feederOvertimeAlarmDelaymin;
        public ComboboxSettingsField FFeederOffDuringOvertime
        {
            get { return _ffeederOffDuringOvertime ?? (_ffeederOffDuringOvertime = new ComboboxSettingsField("Feeder Off During Overtime")); }
            set { _ffeederOffDuringOvertime = value; }
        }
        private ComboboxSettingsField _ffeederOffDuringOvertime;

        #endregion

        #region Group Name: Auger Empty Alarm

        public KeyPadSettingsField ConditionDetectionDelaysec
        {
            get { return _conditionDetectionDelaysec ?? (_conditionDetectionDelaysec = new KeyPadSettingsField() { Name = "Condition Detection Delay (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _conditionDetectionDelaysec = value; }
        }
        private KeyPadSettingsField _conditionDetectionDelaysec;

        public KeyPadSettingsField BelowNominalCurrent
        {
            get { return _belowNominalCurrent ?? (_belowNominalCurrent = new KeyPadSettingsField() { Name = "Below Nominal Current (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _belowNominalCurrent = value; }
        }
        private KeyPadSettingsField _belowNominalCurrent;

        #endregion

        #region Group Name: Feed Alarms

        public KeyPadSettingsField AllowFeedAlarmsFromhhmm
        {
            get { return _allowFeedAlarmsFromhhmm ?? (_allowFeedAlarmsFromhhmm = new KeyPadSettingsField() { Name = "Allow Feed Alarms From: (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _allowFeedAlarmsFromhhmm = value; }
        }
        private KeyPadSettingsField _allowFeedAlarmsFromhhmm;

        public KeyPadSettingsField Silo1LowFeedAlarmLimit
        {
            get { return _silo1LowFeedAlarmLimit ?? (_silo1LowFeedAlarmLimit = new KeyPadSettingsField() { Name = "Silo 1 Low Feed Alarm Limit", InputMethod = new BaseNumericKeyPad() }); }
            set { _silo1LowFeedAlarmLimit = value; }
        }
        private KeyPadSettingsField _silo1LowFeedAlarmLimit;

        public KeyPadSettingsField Silo3LowFeedAlarmLimit
        {
            get { return _silo3LowFeedAlarmLimit ?? (_silo3LowFeedAlarmLimit = new KeyPadSettingsField() { Name = "Silo 3 Low Feed Alarm Limit", InputMethod = new BaseNumericKeyPad() }); }
            set { _silo3LowFeedAlarmLimit = value; }
        }
        private KeyPadSettingsField _silo3LowFeedAlarmLimit;

        public KeyPadSettingsField AllowFeedAlarmsTohhmm
        {
            get { return _allowFeedAlarmsTohhmm ?? (_allowFeedAlarmsTohhmm = new KeyPadSettingsField() { Name = "Allow Feed Alarms To: (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _allowFeedAlarmsTohhmm = value; }
        }
        private KeyPadSettingsField _allowFeedAlarmsTohhmm;

        public KeyPadSettingsField Silo2LowFeedAlarmLimit
        {
            get { return _silo2LowFeedAlarmLimit ?? (_silo2LowFeedAlarmLimit = new KeyPadSettingsField() { Name = "Silo 2 Low Feed Alarm Limit", InputMethod = new BaseNumericKeyPad() }); }
            set { _silo2LowFeedAlarmLimit = value; }
        }
        private KeyPadSettingsField _silo2LowFeedAlarmLimit;

        public KeyPadSettingsField Silo4LowFeedAlarmLimit
        {
            get { return _silo4LowFeedAlarmLimit ?? (_silo4LowFeedAlarmLimit = new KeyPadSettingsField() { Name = "Silo 4 Low Feed Alarm Limit", InputMethod = new BaseNumericKeyPad() }); }
            set { _silo4LowFeedAlarmLimit = value; }
        }
        private KeyPadSettingsField _silo4LowFeedAlarmLimit;

        public KeyPadSettingsField Silo5LowFeedAlarmLimit
        {
            get { return _silo5LowFeedAlarmLimit ?? (_silo5LowFeedAlarmLimit = new KeyPadSettingsField() { Name = "Silo 5 Low Feed Alarm Limit", InputMethod = new BaseNumericKeyPad() }); }
            set { _silo5LowFeedAlarmLimit = value; }
        }
        private KeyPadSettingsField _silo5LowFeedAlarmLimit;

        public KeyPadSettingsField Silo6LowFeedAlarmLimit
        {
            get { return _silo6LowFeedAlarmLimit ?? (_silo6LowFeedAlarmLimit = new KeyPadSettingsField() { Name = "Silo 6 Low Feed Alarm Limit", InputMethod = new BaseNumericKeyPad() }); }
            set { _silo6LowFeedAlarmLimit = value; }
        }
        private KeyPadSettingsField _silo6LowFeedAlarmLimit;

        public KeyPadSettingsField Silo7LowFeedAlarmLimit
        {
            get { return _silo7LowFeedAlarmLimit ?? (_silo7LowFeedAlarmLimit = new KeyPadSettingsField() { Name = "Silo 7 Low Feed Alarm Limit", InputMethod = new BaseNumericKeyPad() }); }
            set { _silo7LowFeedAlarmLimit = value; }
        }
        private KeyPadSettingsField _silo7LowFeedAlarmLimit;

        public KeyPadSettingsField Silo8LowFeedAlarmLimit
        {
            get { return _silo8LowFeedAlarmLimit ?? (_silo8LowFeedAlarmLimit = new KeyPadSettingsField() { Name = "Silo 8 Low Feed Alarm Limit", InputMethod = new BaseNumericKeyPad() }); }
            set { _silo8LowFeedAlarmLimit = value; }
        }
        private KeyPadSettingsField _silo8LowFeedAlarmLimit;

        public KeyPadSettingsField FeedAlarmLimitPerHour
        {
            get { return _feedAlarmLimitPerHour ?? (_feedAlarmLimitPerHour = new KeyPadSettingsField() { Name = "Feed Alarm Limit (Per Hour)", InputMethod = new BaseNumericKeyPad() }); }
            set { _feedAlarmLimitPerHour = value; }
        }
        private KeyPadSettingsField _feedAlarmLimitPerHour;

        #endregion

        #region Group Name: Water Overflow Alarm

        public ToggleButtonSettingsField OverflowAccordingLightTable
        {
            get { return _overflowAccordingLightTable ?? (_overflowAccordingLightTable = new ToggleButtonSettingsField("Overflow According Light Table")); }
            set { _overflowAccordingLightTable = value; }
        }
        private ToggleButtonSettingsField _overflowAccordingLightTable;

        public KeyPadSettingsField OverflowAtFirstDayPerMin
        {
            get { return _overflowAtFirstDayPerMin ?? (_overflowAtFirstDayPerMin = new KeyPadSettingsField() { Name = "Overflow At First Day (Per Min.)", InputMethod = new PointNumericKeyPad() }); }
                                                                                                                       
            set { _overflowAtFirstDayPerMin = value; }
        }
        private KeyPadSettingsField _overflowAtFirstDayPerMin;

        public KeyPadSettingsField OverflowAtLastDayPerMin
        {
            get { return _overflowAtLastDayPerMin ?? (_overflowAtLastDayPerMin = new KeyPadSettingsField() { Name = "Overflow At Last Day (Per Min.)", InputMethod = new PointNumericKeyPad() }); }
            set { _overflowAtLastDayPerMin = value; }
        }
        private KeyPadSettingsField _overflowAtLastDayPerMin;

        public KeyPadSettingsField OverflowAlarmDelayminutes
        {
            get { return _overflowAlarmDelayminutes ?? (_overflowAlarmDelayminutes = new KeyPadSettingsField() { Name = "Overflow Alarm Delay (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _overflowAlarmDelayminutes = value; }
        }
        private KeyPadSettingsField _overflowAlarmDelayminutes;

        public KeyPadSettingsField FoggerWaterOverflowPermin
        {
            get { return _foggerWaterOverflowPermin ?? (_foggerWaterOverflowPermin = new KeyPadSettingsField() { Name = "Fogger Water Overflow (Per Min.)", InputMethod = new PointNumericKeyPad() }); }
            set { _foggerWaterOverflowPermin = value; }
        }
        private KeyPadSettingsField _foggerWaterOverflowPermin;

        public KeyPadSettingsField FirstDayCurveForOverflow
        {
            get { return _firstDayCurveForOverflow ?? (_firstDayCurveForOverflow = new KeyPadSettingsField() { Name = "First Day Curve For Overflow", InputMethod = new BaseNumericKeyPad() }); }
            set { _firstDayCurveForOverflow = value; }
        }
        private KeyPadSettingsField _firstDayCurveForOverflow;

        public KeyPadSettingsField LastDayCurveForOverflow
        {
            get { return _lastDayCurveForOverflow ?? (_lastDayCurveForOverflow = new KeyPadSettingsField() { Name = "Last Day Curve For Overflow", InputMethod = new BaseNumericKeyPad() }); }
            set { _lastDayCurveForOverflow = value; }
        }
        private KeyPadSettingsField _lastDayCurveForOverflow;

        public KeyPadSettingsField OverflowAtDarkPerMin
        {
            get { return _overflowAtDarkPerMin ?? (_overflowAtDarkPerMin = new KeyPadSettingsField() { Name = "Overflow At Dark (Per Min.)", InputMethod = new PointNumericKeyPad() }); }
            set { _overflowAtDarkPerMin = value; }
        }
        private KeyPadSettingsField _overflowAtDarkPerMin;

        public KeyPadSettingsField ExtraDelayAtLightStartmin
        {
            get { return _extraDelayAtLightStartmin ?? (_extraDelayAtLightStartmin = new KeyPadSettingsField() { Name = "Extra Delay At Light Start (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _extraDelayAtLightStartmin = value; }
        }
        private KeyPadSettingsField _extraDelayAtLightStartmin;

        #endregion

        #region Group Name: Water Shortage Alarm

        public KeyPadSettingsField AllowWaterShortageAlarmFrom
        {
            get { return _allowWaterShortageAlarmFrom ?? (_allowWaterShortageAlarmFrom = new KeyPadSettingsField() { Name = "Allow Water Shortage Alarm From", InputMethod = new TimeKeyPad() }); }
            set { _allowWaterShortageAlarmFrom = value; }
        }
        private KeyPadSettingsField _allowWaterShortageAlarmFrom;

        public ToggleButtonSettingsField ShortageDuringLightsOff
        {
            get { return _shortageDuringLightsOff ?? (_shortageDuringLightsOff = new ToggleButtonSettingsField("Shortage During Lights Off")); }
            set { _shortageDuringLightsOff = value; }
        }
        private ToggleButtonSettingsField _shortageDuringLightsOff;

        public KeyPadSettingsField ShortageAlarmDelayminutes
        {
            get { return _shortageAlarmDelayminutes ?? (_shortageAlarmDelayminutes = new KeyPadSettingsField() { Name = "Shortage Alarm Delay (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _shortageAlarmDelayminutes = value; }
        }
        private KeyPadSettingsField _shortageAlarmDelayminutes;

        public KeyPadSettingsField AllowWaterShortageAlarmTo
        {
            get { return _allowWaterShortageAlarmTo ?? (_allowWaterShortageAlarmTo = new KeyPadSettingsField() { Name = "Allow Water Shortage Alarm To", InputMethod = new TimeKeyPad() }); }
            set { _allowWaterShortageAlarmTo = value; }
        }
        private KeyPadSettingsField _allowWaterShortageAlarmTo;

        public KeyPadSettingsField QuantityForShortagePermin
        {
            get { return _quantityForShortagePermin ?? (_quantityForShortagePermin = new KeyPadSettingsField() { Name = "Quantity For Shortage", InputMethod = new PointNumericKeyPad() }); }
            set { _quantityForShortagePermin = value; }
        }
        private KeyPadSettingsField _quantityForShortagePermin;

        public ComboboxSettingsField ShortageTestingPeriod
        {
            get { return _shortageTestingPeriod ?? (_shortageTestingPeriod = new ComboboxSettingsField("Shortage Testing Period")); }
            set { _shortageTestingPeriod = value; }
        }
        private ComboboxSettingsField _shortageTestingPeriod;

        public KeyPadSettingsField ShortageStartDay
        {
            get { return _shortageStartDay ?? (_shortageStartDay = new KeyPadSettingsField() { Name = "Shortage Start Day", InputMethod = new BaseNumericKeyPad() }); }
            set { _shortageStartDay = value; }
        }
        private KeyPadSettingsField _shortageStartDay;
        #endregion

        #region Group Name: Bird Scales Alarm

        public KeyPadSettingsField AllowBirdScaleAlarmFrom
        {
            get { return _allowBirdScaleAlarmFrom ?? (_allowBirdScaleAlarmFrom = new KeyPadSettingsField() { Name = "Allow Bird Scale Alarm From", InputMethod = new TimeKeyPad() }); }
            set { _allowBirdScaleAlarmFrom = value; }
        }
        private KeyPadSettingsField _allowBirdScaleAlarmFrom;

        public KeyPadSettingsField AllowBirdScaleAlarmTo
        {
            get { return _allowBirdScaleAlarmTo ?? (_allowBirdScaleAlarmTo = new KeyPadSettingsField() { Name = "Allow Bird Scale Alarm To", InputMethod = new TimeKeyPad() }); }
            set { _allowBirdScaleAlarmTo = value; }
        }
        private KeyPadSettingsField _allowBirdScaleAlarmTo;

        #endregion

        #region Group Name: AUX. Alarms

        public KeyPadSettingsField RelatedRelayForAuxAlarm1
        {
            get { return _relatedRelayForAuxAlarm1 ?? (_relatedRelayForAuxAlarm1 = new KeyPadSettingsField() { Name = "Related Relay For Auxiliary Alarm 1", InputMethod = new BaseNumericKeyPad() }); }
            set { _relatedRelayForAuxAlarm1 = value; }
        }
        private KeyPadSettingsField _relatedRelayForAuxAlarm1;

        public KeyPadSettingsField RelatedRelayForAuxAlarm3
        {
            get { return _relatedRelayForAuxAlarm3 ?? (_relatedRelayForAuxAlarm3 = new KeyPadSettingsField() { Name = "Related Relay For Auxiliary Alarm 3", InputMethod = new BaseNumericKeyPad() }); }
            set { _relatedRelayForAuxAlarm3 = value; }
        }
        private KeyPadSettingsField _relatedRelayForAuxAlarm3;

        public KeyPadSettingsField AuxAlarmDelayseconds
        {
            get { return _aUxAlarmDelayseconds ?? (_aUxAlarmDelayseconds = new KeyPadSettingsField() { Name = "Auxiliary Alarm delay (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _aUxAlarmDelayseconds = value; }
        }
        private KeyPadSettingsField _aUxAlarmDelayseconds;

        public KeyPadSettingsField RelatedRelayForAuxAlarm2
        {
            get { return _relatedRelayForAuxAlarm2 ?? (_relatedRelayForAuxAlarm2 = new KeyPadSettingsField() { Name = "Related Relay For Auxiliary Alarm 2", InputMethod = new BaseNumericKeyPad() }); }
            set { _relatedRelayForAuxAlarm2 = value; }
        }
        private KeyPadSettingsField _relatedRelayForAuxAlarm2;

        public KeyPadSettingsField RelatedRelayForAuxAlarm4
        {
            get { return _relatedRelayForAuxAlarm4 ?? (_relatedRelayForAuxAlarm4 = new KeyPadSettingsField() { Name = "Related Relay For Auxiliary Alarm 4", InputMethod = new BaseNumericKeyPad() }); }
            set { _relatedRelayForAuxAlarm4 = value; }
        }
        private KeyPadSettingsField _relatedRelayForAuxAlarm4;

        #endregion

        #region Group Name: Circuit Breaker Alarm

        public KeyPadSettingsField TempForCircuitBreakerAlarm
        {
            get { return _tempForCircuitBreakerAlarm ?? (_tempForCircuitBreakerAlarm = new KeyPadSettingsField() { Name = "Temperature For Circuit Breaker Alarm", InputMethod = new PointNumericKeyPad() }); }
            set { _tempForCircuitBreakerAlarm = value; }
        }
        private KeyPadSettingsField _tempForCircuitBreakerAlarm;

        #endregion

        #region Group Name: CO2 Sensor Alarm

        public KeyPadSettingsField Co2HighLevel
        {
            get { return _co2HighLevel ?? (_co2HighLevel = new KeyPadSettingsField() { Name = "CO2 High Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _co2HighLevel = value; }
        }
        private KeyPadSettingsField _co2HighLevel;

        #endregion

        #region Group Name: Humidity Sensor Alarm

        public KeyPadSettingsField HumidityHighLevel
        {
            get { return _humidityHighLevel ?? (_humidityHighLevel = new KeyPadSettingsField() { Name = "Humidity High Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidityHighLevel = value; }
        }
        private KeyPadSettingsField _humidityHighLevel;

        public ToggleButtonSettingsField HumidityAlarmEnable
        {
            get { return _humidityAlarmEnable ?? (_humidityAlarmEnable = new ToggleButtonSettingsField("Humidity Alarm Enable")); }
            set { _humidityAlarmEnable = value; }
        }
        private ToggleButtonSettingsField _humidityAlarmEnable;

        #endregion

        #region Group Name: Water On Demeand Alarms

        public KeyPadSettingsField HighLowPressureDiffPsi
        {
            get { return _highLowPressureDiffPsi ?? (_highLowPressureDiffPsi = new KeyPadSettingsField() { Name = "High/Low S.Pressure Diff", InputMethod = new PointNumericKeyPad() }); }
            set { _highLowPressureDiffPsi = value; }
        }
        private KeyPadSettingsField _highLowPressureDiffPsi;

        public KeyPadSettingsField ShutdownPresureDiffPsi
        {
            get { return _shutdownPresureDiffPsi ?? (_shutdownPresureDiffPsi = new KeyPadSettingsField() { Name = "Shutdown S.Pressure Diff.", InputMethod = new PointNumericKeyPad() }); }

            set { _shutdownPresureDiffPsi = value; }
        }
        private KeyPadSettingsField _shutdownPresureDiffPsi;

        #endregion

        #region Group Name: Ammonia Alarm

        public KeyPadSettingsField AmmoniaHighLevel
        {
            get { return _ammoniaHighLevel ?? (_ammoniaHighLevel = new KeyPadSettingsField() { Name = "Ammonia High Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _ammoniaHighLevel = value; }
        }
        private KeyPadSettingsField _ammoniaHighLevel;

        #endregion

        #region Group Name: Seconday Alarms

        public ToggleButtonSettingsField EnableSecondayAlarms
        {
            get { return _enableSecondayAlarms ?? (_enableSecondayAlarms = new ToggleButtonSettingsField("Enable Secondary Alarms")); }
            set { _enableSecondayAlarms = value; }
        }
        private ToggleButtonSettingsField _enableSecondayAlarms;

        #endregion

        #region Group Name: Potentiometer Alarm

        public KeyPadSettingsField AllowPotentiometerAlarmsFrom
        {
            get { return _allowPotentiometerAlarmsFrom ?? (_allowPotentiometerAlarmsFrom = new KeyPadSettingsField() { Name = "Allow Potentiometer Alarms From (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _allowPotentiometerAlarmsFrom = value; }
        }
        private KeyPadSettingsField _allowPotentiometerAlarmsFrom;

        public KeyPadSettingsField AllowPotentiometerAlarmsTo
        {
            get { return _allowPotentiometerAlarmsTo ?? (_allowPotentiometerAlarmsTo = new KeyPadSettingsField() { Name = "Allow Potentiometer Alarms To (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _allowPotentiometerAlarmsTo = value; }
        }
        private KeyPadSettingsField _allowPotentiometerAlarmsTo;
        #endregion

        #region Group Name: Egg Counter Alarm
        public KeyPadSettingsField AlarmActiveFrom
        {
            get { return _alarmActiveFrom ?? (_alarmActiveFrom = new KeyPadSettingsField() { Name = "Alarm Active From", InputMethod = new TimeKeyPad() }); }
            set { _alarmActiveFrom = value; }
        }
        private KeyPadSettingsField _alarmActiveFrom;

        public KeyPadSettingsField AlarmActiveUntill
        {
            get { return _alarmActiveUntill ?? (_alarmActiveUntill = new KeyPadSettingsField() { Name = "Alarm Active Untill", InputMethod = new TimeKeyPad() }); }
            set { _alarmActiveUntill = value; }
        }
        private KeyPadSettingsField _alarmActiveUntill;

        public KeyPadSettingsField LowEggHouseCount
        {
            get { return _lowEggHouseCount ?? (_lowEggHouseCount = new KeyPadSettingsField() { Name = "Low Egg House Count Eggs/minute", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowEggHouseCount = value; }
        }
        private KeyPadSettingsField _lowEggHouseCount;

        public KeyPadSettingsField LowCountAlarmDelayMin
        {
            get { return _lowCountAlarmDelayMin ?? (_lowCountAlarmDelayMin = new KeyPadSettingsField() { Name = "Low Count Alarm Delay (min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowCountAlarmDelayMin = value; }
        }
        private KeyPadSettingsField _lowCountAlarmDelayMin;
        #endregion
    }
}
