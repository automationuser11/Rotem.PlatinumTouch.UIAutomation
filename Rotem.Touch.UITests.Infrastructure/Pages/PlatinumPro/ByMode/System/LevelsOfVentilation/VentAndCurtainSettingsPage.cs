using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.LevelsOfVentilation
{
    public class VentAndCurtainSettingsPage : SimpleSettingsModal
    {
        #region Group Name: Curtains
        public string Name
        {
            get
            {
                return "Vent & Curtain Levels - Settings";
            }
        }
        public string SubMenu { get { return "System"; } }

        public KeyPadSettingsField FirstDayFor2NdVentToOperate
        {
            get { return _firstDayFor2NdVentToOperate ?? (_firstDayFor2NdVentToOperate = new KeyPadSettingsField() { Name = "1st Day For 2nd Vent To Operate", InputMethod = new PointNumericKeyPad() }); }
            set { _firstDayFor2NdVentToOperate = value; }
        }
        private KeyPadSettingsField _firstDayFor2NdVentToOperate;

        public KeyPadSettingsField FirstLevelFor2NdVentToOperate
        {
            get { return _firstLevelFor2NdVentToOperate ?? (_firstLevelFor2NdVentToOperate = new KeyPadSettingsField() { Name = "1st Level For 2nd Vent To Operate", InputMethod = new PointNumericKeyPad() }); }
            set { _firstLevelFor2NdVentToOperate = value; }
        }
        private KeyPadSettingsField _firstLevelFor2NdVentToOperate;

        public KeyPadSettingsField SecondVentOperateFromDay
        {
            get { return _secondVentOperateFromDay ?? (_secondVentOperateFromDay = new KeyPadSettingsField() { Name = "2nd Vent Operate From Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _secondVentOperateFromDay = value; }
        }
        private KeyPadSettingsField _secondVentOperateFromDay;

        public KeyPadSettingsField SecondVentOperateFromLevel
        {
            get { return _secondVentOperateFromLevel ?? (_secondVentOperateFromLevel = new KeyPadSettingsField() { Name = "2nd Vent Operate From Level", InputMethod = new MinusNumericKeyPad() }); }
            set { _secondVentOperateFromLevel = value; }
        }
        private KeyPadSettingsField _secondVentOperateFromLevel;

        public KeyPadSettingsField ThirdVentOperateFromDay
        {
            get { return _thirdVentOperateFromDay ?? (_thirdVentOperateFromDay = new KeyPadSettingsField() { Name = "3rd Vent Operate From Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _thirdVentOperateFromDay = value; }
        }
        private KeyPadSettingsField _thirdVentOperateFromDay;

        public KeyPadSettingsField ThirdVentOperateFromLevel
        {
            get { return _thirdVentOperateFromLevel ?? (_thirdVentOperateFromLevel = new KeyPadSettingsField() { Name = "3rd Vent Operate From Level", InputMethod = new MinusNumericKeyPad() }); }
            set { _thirdVentOperateFromLevel = value; }
        }
        private KeyPadSettingsField _thirdVentOperateFromLevel;

        public KeyPadSettingsField FourthVentOperateFromDay
        {
            get { return _fourthVentOperateFromDay ?? (_fourthVentOperateFromDay = new KeyPadSettingsField() { Name = "4th Vent Operate From Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _fourthVentOperateFromDay = value; }
        }
        private KeyPadSettingsField _fourthVentOperateFromDay;

        public KeyPadSettingsField FourthVentOperateFromLevel
        {
            get { return _fourthVentOperateFromLevel ?? (_fourthVentOperateFromLevel = new KeyPadSettingsField() { Name = "4th Vent Operate From Level", InputMethod = new MinusNumericKeyPad() }); }
            set { _fourthVentOperateFromLevel = value; }
        }
        private KeyPadSettingsField _fourthVentOperateFromLevel;

        #endregion

        #region Group Name: Attic

        public KeyPadSettingsField MinimumAtticTempToOperate
        {
            get { return _minimumAtticTempToOperate ?? (_minimumAtticTempToOperate = new KeyPadSettingsField() { Name = "Min Attic Temperature To Operate", InputMethod = new PointNumericKeyPad() }); }
            set { _minimumAtticTempToOperate = value; }
        }
        private KeyPadSettingsField _minimumAtticTempToOperate;

        public KeyPadSettingsField OperateFromTime
        {
            get { return _operateFromTime ?? (_operateFromTime = new KeyPadSettingsField() { Name = "Operate From Time", InputMethod = new TimeKeyPad() }); }
            set { _operateFromTime = value; }
        }
        private KeyPadSettingsField _operateFromTime;

        public KeyPadSettingsField MaxTemperatureToDisableAttic
        {
            get { return _maxTemperatureToDisableAttic ?? (_maxTemperatureToDisableAttic = new KeyPadSettingsField() { Name = "Max Temperature To Disable Attic", InputMethod = new PointNumericKeyPad() }); }
            set { _maxTemperatureToDisableAttic = value; }
        }
        private KeyPadSettingsField _maxTemperatureToDisableAttic;

        public KeyPadSettingsField AtticOperateUntilLevel
        {
            get { return _atticOperateUntilLevel ?? (_atticOperateUntilLevel = new KeyPadSettingsField() { Name = "Attic Operate Until Level", InputMethod = new BaseNumericKeyPad() }); }
            set { _atticOperateUntilLevel = value; }
        }
        private KeyPadSettingsField _atticOperateUntilLevel;

        public KeyPadSettingsField OperateToTime
        {
            get { return _operateToTime ?? (_operateToTime = new KeyPadSettingsField() { Name = "Operate To Time", InputMethod = new TimeKeyPad() }); }
            set { _operateToTime = value; }
        }
        private KeyPadSettingsField _operateToTime;

        #endregion 
    }
}
