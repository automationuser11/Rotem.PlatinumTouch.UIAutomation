using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.CoolPad
{
    public class CoolapdSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Cool Pad - Settings"; }
        }
        public KeyPadSettingsField HumidtyBand
        {
            get { return _humidtyBand ?? (_humidtyBand = new KeyPadSettingsField { Name = "Humidty Band (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidtyBand = value; }
        }
        private KeyPadSettingsField _humidtyBand;

        public KeyPadSettingsField FlushCooldadAt
        {
            get { return _flushCooldadAt ?? (_flushCooldadAt = new KeyPadSettingsField { Name = "Flush Cool Pad At:", InputMethod = new TimeKeyPad() }); }
            set { _flushCooldadAt = value; }
        }
        private KeyPadSettingsField _flushCooldadAt;

        public KeyPadSettingsField CoolpadFlushDurationMinute
        {
            get { return _coolpadFlushDurationMinute ?? (_coolpadFlushDurationMinute = new KeyPadSettingsField { Name = "Cool Pad Flush Duration (Minute)", InputMethod = new BaseNumericKeyPad() }); }
            set { _coolpadFlushDurationMinute = value; }
        }
        private KeyPadSettingsField _coolpadFlushDurationMinute;
    }
}
