using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.VariableSpeedFansSetting
{
    public class VariableSpeedFansSettingSettingsPage : SimpleSettingsModal
    {
        public KeyPadSettingsField DiffToTurnFanOff
        {
            get { return _diffToTurnFanOff ?? (_diffToTurnFanOff = new KeyPadSettingsField() { Name = "Diff. To Turn Fan Off", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _diffToTurnFanOff = value; }
        }
        private KeyPadSettingsField _diffToTurnFanOff;

        public KeyPadSettingsField SetTemperatureChangeReminderDiff
        {
            get { return _setTemperatureChangeReminderDiff ?? (_setTemperatureChangeReminderDiff = new KeyPadSettingsField { Name = "Day To Disable Fan Off", InputMethod = new BaseNumericKeyPad() }); }
            set { _setTemperatureChangeReminderDiff = value; }
        }
        private KeyPadSettingsField _setTemperatureChangeReminderDiff;

        public KeyPadSettingsField DayToTurnFanOff
        {
            get { return _dayToTurnFanOff ?? (_dayToTurnFanOff = new KeyPadSettingsField() { Name = "Day To Turn Fan Off", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _dayToTurnFanOff = value; }
        }
        private KeyPadSettingsField _dayToTurnFanOff;
    }
}
