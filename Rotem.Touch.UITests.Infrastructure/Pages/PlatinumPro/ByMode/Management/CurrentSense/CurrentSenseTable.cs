using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.CurrentSense
{
    public class CurrentSenseTable : SimpleSettingsModal
    {
        public CurrentSenseTable()
        {
            var metadata = MetadataFactory.GetMetadata<CurrentSensePage>();
            //metadata.ContainerId = "Total";

            Total = new ReadonlyGridTablePage(metadata);
        }

        public ReadonlyGridTablePage Total { get; private set; }
    }
}
