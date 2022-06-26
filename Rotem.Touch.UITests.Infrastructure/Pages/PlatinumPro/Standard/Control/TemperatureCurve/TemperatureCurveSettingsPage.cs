using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.TemperatureCurve
{
    public class TemperatureCurveSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Temperature Curve - Settings"; }
        }
        public KeyPadSettingsField TemperatureCurveOffset
        {
            get { return _temperatureCurveOffset ?? (_temperatureCurveOffset = new KeyPadSettingsField() { Name = "Temperature Curve Offset", InputMethod = new MinusPointNumericKeyPad()  }); }
            set { _temperatureCurveOffset = value; }
        }
        private KeyPadSettingsField _temperatureCurveOffset;

        public KeyPadSettingsField SetTemperatureChangeReminderDiff
        {
            get { return _setTemperatureChangeReminderDiff ?? (_setTemperatureChangeReminderDiff = new KeyPadSettingsField { Name = "Set Temperature Change Reminder Diff", InputMethod = new PointNumericKeyPad() }); }
            set { _setTemperatureChangeReminderDiff = value; }
        }
        private KeyPadSettingsField _setTemperatureChangeReminderDiff;
    }
}

