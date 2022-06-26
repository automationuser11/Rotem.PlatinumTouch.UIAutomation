using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.WaterOnDemand
{
    public class WaterOnDemandSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Water On Demand - Settings"; }
        }
        public override void Navigate()
        {
            SettingsPageSerivce.Navigate();
        }

        public KeyPadSettingsField WaterPressDuringFlush
        {
            get { return _waterPressDuringFlush ?? (_waterPressDuringFlush = new KeyPadSettingsField() { Name = "Water Press. During Flush:", InputMethod = new PointNumericKeyPad() }); }
            set { _waterPressDuringFlush = value; }
        }
        private KeyPadSettingsField _waterPressDuringFlush;

        public ComboboxSettingsField RelayActiveDuringFlush
        {
            get { return _relayActiveDuringFlush ?? (_relayActiveDuringFlush = new ComboboxSettingsField("Relay Active During Flush:")); }
            set { _relayActiveDuringFlush = value; }
        }
        private ComboboxSettingsField _relayActiveDuringFlush;
    }
}
