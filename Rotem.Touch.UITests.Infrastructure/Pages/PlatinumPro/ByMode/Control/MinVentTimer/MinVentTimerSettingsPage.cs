using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinVentTimer
{
    public class MinVentTimerSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Min Vent Timer - Settings"; }
        }
        public ToggleButtonSettingsField RampingEnable
        {
            get { return _rampingEnable ?? (_rampingEnable = new ToggleButtonSettingsField("Ramping Enable")); }
            set { _rampingEnable = value; }
        }
        private ToggleButtonSettingsField _rampingEnable;

        public KeyPadSettingsField IncreaseDecreasTimeSec 
        {
            get { return _increaseDecreasTimeSec ?? (_increaseDecreasTimeSec = new KeyPadSettingsField() { Name = "Increase Decrease Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _increaseDecreasTimeSec = value; }
        }
        private KeyPadSettingsField _increaseDecreasTimeSec;

        public KeyPadSettingsField VentilationChange
        {
            get { return _ventilationChange ?? (_ventilationChange = new KeyPadSettingsField() { Name = "Ventilation Change (%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _ventilationChange = value; }
        }
        private KeyPadSettingsField _ventilationChange;

        public KeyPadSettingsField MinOffTimeSec
        {
            get { return _minOffTimeSec ?? (_minOffTimeSec = new KeyPadSettingsField() { Name = "Min Off Time (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _minOffTimeSec = value; }
        }
        private KeyPadSettingsField _minOffTimeSec;

        public KeyPadSettingsField DiffAboveSetToStartRamping
        {
            get { return _diffAboveSetToStartRamping ?? (_diffAboveSetToStartRamping = new KeyPadSettingsField() { Name = "Diff. Above SET To Start Ramping", InputMethod = new PointNumericKeyPad() }); }
            set { _diffAboveSetToStartRamping = value; }
        }
        private KeyPadSettingsField _diffAboveSetToStartRamping;

        
        
    }
}
