using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.WaterAndFeedControl
{
    public class WaterAndFeedSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Water & Feed - Settings"; }
        }
        public ComboboxSettingsField FeedByCycle
        {
            get { return _feedByCycle ?? (_feedByCycle = new ComboboxSettingsField("Feed Day Cycle")); }
            set { _feedByCycle = value; }
        }
        private ComboboxSettingsField _feedByCycle;
        public ToggleButtonSettingsField Quantity
        {
            get { return _quantity ?? (_quantity = new ToggleButtonSettingsField("Quantity")); }
            set { _quantity = value; }
        }
        private ToggleButtonSettingsField _quantity;
    }
}
