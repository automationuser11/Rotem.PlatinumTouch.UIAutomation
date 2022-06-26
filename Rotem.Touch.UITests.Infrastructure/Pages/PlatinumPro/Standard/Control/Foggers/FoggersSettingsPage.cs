using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.Foggers
{
    public class FoggersSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Foggers - Settings"; }
        }
        public KeyPadSettingsField HumidityBand
        {
            get { return _humidityBand ?? (_humidityBand = new KeyPadSettingsField() { Name = "Humidity Band (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _humidityBand = value; }
        }
        private KeyPadSettingsField _humidityBand;
    }
}
