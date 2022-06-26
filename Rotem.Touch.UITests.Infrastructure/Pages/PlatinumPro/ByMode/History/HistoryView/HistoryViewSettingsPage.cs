using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.HistoryView
{
    public class HistoryViewSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "History View - Settings"; }
        }
        public override void Navigate()
        {
            SettingsPageSerivce.Navigate();
        }
    }
}
