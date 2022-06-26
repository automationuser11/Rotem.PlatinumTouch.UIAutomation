using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.StirFanProgram
{
    public class StirFanProgramSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Stir Fan Program - Settings"; }
        }

        #region Group Name: Program A (for Heaters)

        public KeyPadSettingsField DiffBelowTargetToOperate
        {
            get { return _diffBelowTargetToOperate ?? (_diffBelowTargetToOperate = new KeyPadSettingsField() { Name = "Program A (For Heaters)_Diff. Below Target To Operate", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _diffBelowTargetToOperate = value; }
        }
        private KeyPadSettingsField _diffBelowTargetToOperate;

        public KeyPadSettingsField ProgramACycleOffTimesec
        {
            get { return _programACycleOffTimesec ?? (_programACycleOffTimesec = new KeyPadSettingsField() { Name = "Program A (For Heaters)_Cycle Off Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _programACycleOffTimesec = value; }
        }
        private KeyPadSettingsField _programACycleOffTimesec;

        public KeyPadSettingsField ProgramAToLevel
        {
            get { return _programAToLevel ?? (_programAToLevel = new KeyPadSettingsField() { Name = "Program A (For Heaters)_To Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _programAToLevel = value; }
        }
        private KeyPadSettingsField _programAToLevel;

        public KeyPadSettingsField ProgramAToTimehhmm
        {
            get { return _programAToTimehhmm ?? (_programAToTimehhmm = new KeyPadSettingsField() { Name = "Program A (For Heaters)_To Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _programAToTimehhmm = value; }
        }
        private KeyPadSettingsField _programAToTimehhmm;

        public KeyPadSettingsField ProgramACycleOnTimesec
        {
            get { return _programACycleOnTimesec ?? (_programACycleOnTimesec = new KeyPadSettingsField() { Name = "Program A (For Heaters)_Cycle On Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _programACycleOnTimesec = value; }
        }
        private KeyPadSettingsField _programACycleOnTimesec;

        public KeyPadSettingsField ProgramAFromLevel
        {
            get { return _programAFromLevel ?? (_programAFromLevel = new KeyPadSettingsField() { Name = "Program A (For Heaters)_From Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _programAFromLevel = value; }
        }
        private KeyPadSettingsField _programAFromLevel;

        public KeyPadSettingsField ProgramAFromTimehhmm
        {
            get { return _programAFromTimehhmm ?? (_programAFromTimehhmm = new KeyPadSettingsField() { Name = "Program A (For Heaters)_From Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _programAFromTimehhmm = value; }
        }
        private KeyPadSettingsField _programAFromTimehhmm;

        public ToggleButtonSettingsField ProgramAStopDuringFanOperation
        {
            get { return _programAStopDuringFanOperation ?? (_programAStopDuringFanOperation = new ToggleButtonSettingsField("Program A (For Heaters)_Stop During Fan Operation")); }
            set { _programAStopDuringFanOperation = value; }
        }
        private ToggleButtonSettingsField _programAStopDuringFanOperation;

        #endregion

        #region Group Name: Program B (for Min Vent)

        public ToggleButtonSettingsField OperateAfterEndOfCycle
        {
            get { return _operateAfterEndOfCycle ?? (_operateAfterEndOfCycle = new ToggleButtonSettingsField("Program B (For Min Ventilation)_Operate After End Of Cycle")); }
                                                                                                                                                  
            set { _operateAfterEndOfCycle = value; }
        }
        private ToggleButtonSettingsField _operateAfterEndOfCycle;

        public KeyPadSettingsField TimeForOperationsec
        {
            get { return _timeForOperationsec ?? (_timeForOperationsec = new KeyPadSettingsField() { Name = "Program B (For Min Ventilation)_Time For Operation (Sec.)", InputMethod = new MinusNumericKeyPad() }); }
            set { _timeForOperationsec = value; }
        }
        private KeyPadSettingsField _timeForOperationsec;

        public KeyPadSettingsField ProgramBToLevel
        {
            get { return _programBToLevel ?? (_programBToLevel = new KeyPadSettingsField() { Name = "Program B (For Min Ventilation)_To Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _programBToLevel = value; }
        }
        private KeyPadSettingsField _programBToLevel;

        public KeyPadSettingsField ProgramBToTimehhmm
        {
            get { return _programBToTimehhmm ?? (_programBToTimehhmm = new KeyPadSettingsField() { Name = "Program B (For Min Ventilation)_To Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _programBToTimehhmm = value; }
        }
        private KeyPadSettingsField _programBToTimehhmm;

        public KeyPadSettingsField DelayForOperationsec
        {
            get { return _delayForOperationsec ?? (_delayForOperationsec = new KeyPadSettingsField() { Name = "Program B (For Min Ventilation)_Delay For Operation (Sec.) (+/-)", InputMethod = new MinusNumericKeyPad() }); }
            set { _delayForOperationsec = value; }
        }
        private KeyPadSettingsField _delayForOperationsec;

        public KeyPadSettingsField ProgramBFromLevel
        {
            get { return _programBFromLevel ?? (_programBFromLevel = new KeyPadSettingsField() { Name = "Program B (For Min Ventilation)_From Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _programBFromLevel = value; }
        }
        private KeyPadSettingsField _programBFromLevel;

        public KeyPadSettingsField ProgramBFromTimehhmm
        {
            get { return _programBFromTimehhmm ?? (_programBFromTimehhmm = new KeyPadSettingsField() { Name = "Program B (For Min Ventilation)_From Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _programBFromTimehhmm = value; }
        }
        private KeyPadSettingsField _programBFromTimehhmm;

        #endregion

        #region Group Name: Program C (Sensors Diff Temp)


        public KeyPadSettingsField ProgramCTempDiffToOperate
        {
            get { return _programCTempDiffToOperate ?? (_programCTempDiffToOperate = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_Temperature Diff. To Operate", InputMethod = new PointNumericKeyPad()}); }
            set { _programCTempDiffToOperate = value; }
        }
        private KeyPadSettingsField _programCTempDiffToOperate;

        public KeyPadSettingsField ProgramCDiffBetweenSensorNumber
        {
            get { return _programCDiffBetweenSensorNumber ?? (_programCDiffBetweenSensorNumber = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_Diff. Between Sensor Number", InputMethod = new BaseNumericKeyPad() }); }
            set { _programCDiffBetweenSensorNumber = value; }
        }
        private KeyPadSettingsField _programCDiffBetweenSensorNumber;

        public KeyPadSettingsField ProgramCCycleOffTimesec
        {
            get { return _programCCycleOffTimesec ?? (_programCCycleOffTimesec = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_Cycle Off Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _programCCycleOffTimesec = value; }
        }
        private KeyPadSettingsField _programCCycleOffTimesec;

        public KeyPadSettingsField ProgramCToLevel
        {
            get { return _programCToLevel ?? (_programCToLevel = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_To Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _programCToLevel = value; }
        }
        private KeyPadSettingsField _programCToLevel;

        public KeyPadSettingsField ProgramCToTimehhmm
        {
            get { return _programCToTimehhmm ?? (_programCToTimehhmm = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_To Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _programCToTimehhmm = value; }
        }
        private KeyPadSettingsField _programCToTimehhmm;


        public KeyPadSettingsField ProgramCMaximumVariableStirFanSpeed
        {
            get { return _programCMaximumVariableStirFanSpeed ?? (_programCMaximumVariableStirFanSpeed = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_Maximum Variable Stir Fan Speed", InputMethod = new BaseNumericKeyPad() }); }
            set { _programCMaximumVariableStirFanSpeed = value; }
        }
        private KeyPadSettingsField _programCMaximumVariableStirFanSpeed;

        public KeyPadSettingsField ProgramCRightDiffBetweenSensorNumber
        {
            get { return _programCRightDiffBetweenSensorNumber ?? (_programCRightDiffBetweenSensorNumber = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_Diff. Between Sensor Number", InputMethod = new BaseNumericKeyPad() }); }
            set { _programCRightDiffBetweenSensorNumber = value; }
        }
        private KeyPadSettingsField _programCRightDiffBetweenSensorNumber;

        public KeyPadSettingsField ProgramCCycleOnTimesec
        {
            get { return _programCCycleOnTimesec ?? (_programCCycleOnTimesec = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_Cycle On Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _programCCycleOnTimesec = value; }
        }
        private KeyPadSettingsField _programCCycleOnTimesec;

        public KeyPadSettingsField ProgramCFromLevel
        {
            get { return _programCFromLevel ?? (_programCFromLevel = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_From Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _programCFromLevel = value; }
        }
        private KeyPadSettingsField _programCFromLevel;

        public KeyPadSettingsField ProgramCFromTimehhmm
        {
            get { return _programCFromTimehhmm ?? (_programCFromTimehhmm = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_From Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _programCFromTimehhmm = value; }
        }
        private KeyPadSettingsField _programCFromTimehhmm;

        public ToggleButtonSettingsField ProgramCStopDuringFanOperation
        {
            get { return _programCStopDuringFanOperation ?? (_programCStopDuringFanOperation = new ToggleButtonSettingsField("Program C (Sensors Diff. Temp.)_Stop During Fan Operation")); }
            set { _programCStopDuringFanOperation = value; }
        }
        private ToggleButtonSettingsField _programCStopDuringFanOperation;

        public KeyPadSettingsField ProgramCMinimumVariableStirFanSpeed
        {
            get { return _programCMinimumVariableStirFanSpeed ?? (_programCMinimumVariableStirFanSpeed = new KeyPadSettingsField() { Name = "Program C (Sensors Diff. Temp.)_Minimum Variable Stir Fan Speed", InputMethod = new BaseNumericKeyPad() }); }
            set { _programCMinimumVariableStirFanSpeed = value; }
        }
        private KeyPadSettingsField _programCMinimumVariableStirFanSpeed;

        #endregion

        #region Group Name: Program D (Sensor Diff Temp)

        public KeyPadSettingsField ProgramDTempDiffToOperate
        {
            get { return _programDTempDiffToOperate ?? (_programDTempDiffToOperate = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_Temperature Diff. To Operate", InputMethod = new PointNumericKeyPad() }); }
            set { _programDTempDiffToOperate = value; }
        }
        private KeyPadSettingsField _programDTempDiffToOperate;

        public KeyPadSettingsField ProgramDDiffBetweenSensorNumber
        {
            get { return _programDDiffBetweenSensorNumber ?? (_programDDiffBetweenSensorNumber = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_Diff. Between Sensor Number", InputMethod = new BaseNumericKeyPad() }); }
            set { _programDDiffBetweenSensorNumber = value; }
        }
        private KeyPadSettingsField _programDDiffBetweenSensorNumber;

        public KeyPadSettingsField ProgramDCycleOffTimesec
        {
            get { return _programDCycleOffTimesec ?? (_programDCycleOffTimesec = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_Cycle Off Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _programDCycleOffTimesec = value; }
        }
        private KeyPadSettingsField _programDCycleOffTimesec;

        public KeyPadSettingsField ProgramDToLevel
        {
            get { return _programDToLevel ?? (_programDToLevel = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_To Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _programDToLevel = value; }
        }
        private KeyPadSettingsField _programDToLevel;

        public KeyPadSettingsField ProgramDToTimehhmm
        {
            get { return _programDToTimehhmm ?? (_programDToTimehhmm = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_To Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _programDToTimehhmm = value; }
        }
        private KeyPadSettingsField _programDToTimehhmm;

        public KeyPadSettingsField ProgramDMinimumVariableStirFanSpeed
        {
            get { return _programDMinimumVariableStirFanSpeed ?? (_programDMinimumVariableStirFanSpeed = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_Minimum Variable Stir Fan Speed", InputMethod = new BaseNumericKeyPad() }); }
            set { _programDMinimumVariableStirFanSpeed = value; }
        }
        private KeyPadSettingsField _programDMinimumVariableStirFanSpeed;

        public KeyPadSettingsField ProgramDRightDiffBetweenSensorNumber
        {
            get { return _programDRightDiffBetweenSensorNumber ?? (_programDRightDiffBetweenSensorNumber = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_Diff. Between Sensor Number", InputMethod = new BaseNumericKeyPad() }); }
            set { _programDRightDiffBetweenSensorNumber = value; }
        }
        private KeyPadSettingsField _programDRightDiffBetweenSensorNumber;

        private ComboboxSettingsField _programDVariableStirFan;
        public KeyPadSettingsField ProgramDCycleOnTimesec
        {
            get { return _programDCycleOnTimesec ?? (_programDCycleOnTimesec = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_Cycle On Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _programDCycleOnTimesec = value; }
        }
        private KeyPadSettingsField _programDCycleOnTimesec;
        public KeyPadSettingsField ProgramDFromLevel
        {
            get { return _programDFromLevel ?? (_programDFromLevel = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_From Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _programDFromLevel = value; }
        }
        private KeyPadSettingsField _programDFromLevel;

        public KeyPadSettingsField ProgramDFromTimehhmm
        {
            get { return _programDFromTimehhmm ?? (_programDFromTimehhmm = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_From Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _programDFromTimehhmm = value; }
        }
        private KeyPadSettingsField _programDFromTimehhmm;
        public ToggleButtonSettingsField ProgramDStopDuringFanOperation
        {
            get { return _programDStopDuringFanOperation ?? (_programDStopDuringFanOperation = new ToggleButtonSettingsField("Program D (Sensors Diff. Temp.)_Stop During Fan Operation")); }
            set { _programDStopDuringFanOperation = value; }
        }
        private ToggleButtonSettingsField _programDStopDuringFanOperation;
        
        public KeyPadSettingsField ProgramDMaximumVariableStirFanSpeed
        {
            get { return _programDMaximumVariableStirFanSpeed ?? (_programDMaximumVariableStirFanSpeed = new KeyPadSettingsField() { Name = "Program D (Sensors Diff. Temp.)_Maximum Variable Stir Fan Speed", InputMethod = new BaseNumericKeyPad() }); }
            set { _programDMaximumVariableStirFanSpeed = value; }
        }
        private KeyPadSettingsField _programDMaximumVariableStirFanSpeed;

     /*   public ComboboxSettingsField ProgramDVariableStirFan
        {
            get { return _programDVariableStirFan ?? (_programDVariableStirFan = new ComboboxSettingsField("Program D (Sensor Diff Temperature)_Variable Stir Fan:")); }
            set { _programDVariableStirFan = value; }
        }
        */

        #endregion

        #region Group Name: Program E (Sensor Diff Temp)

        public KeyPadSettingsField TempDiffToOperate
        {
            get { return _tempDiffToOperate ?? (_tempDiffToOperate = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_Temperature Diff. To Operate", InputMethod = new PointNumericKeyPad() }); }
            set { _tempDiffToOperate = value; }
        }
        private KeyPadSettingsField _tempDiffToOperate;

        public KeyPadSettingsField ProgramEDiffBetweenSensorNumber
        {
            get { return _programEDiffBetweenSensorNumber ?? (_programEDiffBetweenSensorNumber = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_Diff. Between Sensor Number", InputMethod = new BaseNumericKeyPad() }); }
            set { _programEDiffBetweenSensorNumber = value; }
        }
        private KeyPadSettingsField _programEDiffBetweenSensorNumber;

        public KeyPadSettingsField CycleOffTimesec
        {
            get { return _cycleOffTimesec ?? (_cycleOffTimesec = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_Cycle Off Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _cycleOffTimesec = value; }
        }
        private KeyPadSettingsField _cycleOffTimesec;

        public KeyPadSettingsField ToLevel
        {
            get { return _toLevel ?? (_toLevel = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_To Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _toLevel = value; }
        }
        private KeyPadSettingsField _toLevel;

        public KeyPadSettingsField ToTimehhmm
        {
            get { return _toTimehhmm ?? (_toTimehhmm = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_To Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _toTimehhmm = value; }
        }
        private KeyPadSettingsField _toTimehhmm;

        public KeyPadSettingsField MaximumVariableStirFanSpeed
        {
            get { return _maximumVariableStirFanSpeed ?? (_maximumVariableStirFanSpeed = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_Maximum Variable Stir Fan Speed", InputMethod = new BaseNumericKeyPad() }); }
            set { _maximumVariableStirFanSpeed = value; }
        }
        private KeyPadSettingsField _maximumVariableStirFanSpeed;

        public KeyPadSettingsField DiffBetweenSensorNumber
        {
            get { return _diffBetweenSensorNumber ?? (_diffBetweenSensorNumber = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_Diff. Between Sensor Number", InputMethod = new BaseNumericKeyPad() }); }
            set { _diffBetweenSensorNumber = value; }
        }
        private KeyPadSettingsField _diffBetweenSensorNumber;

        public KeyPadSettingsField CycleOnTimesec
        {
            get { return _cycleOnTimesec ?? (_cycleOnTimesec = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_Cycle On Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _cycleOnTimesec = value; }
        }
        private KeyPadSettingsField _cycleOnTimesec;

        public KeyPadSettingsField FromLevel
        {
            get { return _fromLevel ?? (_fromLevel = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_From Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _fromLevel = value; }
        }
        private KeyPadSettingsField _fromLevel;

        public KeyPadSettingsField FromTimehhmm
        {
            get { return _fromTimehhmm ?? (_fromTimehhmm = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_From Time (hh:mm)", InputMethod = new TimeKeyPad() }); }
            set { _fromTimehhmm = value; }
        }
        private KeyPadSettingsField _fromTimehhmm;

        public ToggleButtonSettingsField StopDuringFanOperation
        {
            get { return _stopDuringFanOperation ?? (_stopDuringFanOperation = new ToggleButtonSettingsField("Program E (Sensors Diff. Temp.)_Stop During Fan Operation")); }
            set { _stopDuringFanOperation = value; }
        }
        private ToggleButtonSettingsField _stopDuringFanOperation;

        public KeyPadSettingsField MinimumVariableStirFanSpeed
        {
            get { return _minimumVariableStirFanSpeed ?? (_minimumVariableStirFanSpeed = new KeyPadSettingsField() { Name = "Program E (Sensors Diff. Temp.)_Minimum Variable Stir Fan Speed", InputMethod = new BaseNumericKeyPad() }); }
            set { _minimumVariableStirFanSpeed = value; }
        }
        private KeyPadSettingsField _minimumVariableStirFanSpeed;

        #endregion 
    }
}
