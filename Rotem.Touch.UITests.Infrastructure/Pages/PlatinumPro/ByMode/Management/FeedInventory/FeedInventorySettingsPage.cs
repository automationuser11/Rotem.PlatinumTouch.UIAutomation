using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedInventory
{
    public class FeedInventorySettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Feed Inventory - Settings"; }
        }
        public KeyPadSettingsField TotalFeedInSilo1
        {
            get
            {
                return _totalFeedInSilo1 ??
                       (_totalFeedInSilo1 =
                           new KeyPadSettingsField() { Name = "Total Feed In Silo-1", InputMethod = new BaseNumericKeyPad() });
            }
            set { _totalFeedInSilo1 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo1;

        public KeyPadSettingsField TotalFeedInSilo2
        {
            get
            {
                return _totalFeedInSilo2 ??
                       (_totalFeedInSilo2 =
                           new KeyPadSettingsField() { Name = "Total Feed In Silo-2", InputMethod = new BaseNumericKeyPad() });
            }
            set { _totalFeedInSilo2 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo2;

        public KeyPadSettingsField TotalFeedInSilo3
        {
            get
            {
                return _totalFeedInSilo3 ??
                       (_totalFeedInSilo3 =
                           new KeyPadSettingsField() { Name = "Total Feed In Silo-3", InputMethod = new BaseNumericKeyPad() });
            }
            set { _totalFeedInSilo3 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo3;

        public KeyPadSettingsField TotalFeedInSilo4
        {
            get
            {
                return _totalFeedInSilo4 ??
                       (_totalFeedInSilo4 =
                           new KeyPadSettingsField() { Name = "Total Feed In Silo-4", InputMethod = new BaseNumericKeyPad() });
            }
            set { _totalFeedInSilo4 = value; }
        }
        private KeyPadSettingsField _totalFeedInSilo4;

        public ComboboxSettingsField ActiveSilo
        {
            get { return _activeSilo ?? (_activeSilo = new ComboboxSettingsField("Active Silo")); }
            set { _activeSilo = value; }
        }
        private ComboboxSettingsField _activeSilo;
    }
}
