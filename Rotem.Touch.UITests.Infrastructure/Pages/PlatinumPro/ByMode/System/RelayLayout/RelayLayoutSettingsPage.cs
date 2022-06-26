using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.RelayLayout
{
    public class RelayLayoutSettingsPage : SimpleSettingsModal
    {
        public CheckBoxSettingsField RelayOperationMode
        {
            get { return _relayOperationMode ?? (_relayOperationMode = new CheckBoxSettingsField("Relay Operation Mode")); }
            set { _relayOperationMode = value; }
        }
        private CheckBoxSettingsField _relayOperationMode;
    }
}
