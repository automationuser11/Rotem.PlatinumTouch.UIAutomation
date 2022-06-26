using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AlarmReset
{
    public class AlarmResetTable : GridTablePage<AlarmResetTabPage>
    {
        public AlarmResetTable()
        {
            var metadata = MetadataFactory.GetMetadata<AlarmResetTabPage>();
            //metadata.ContainerId = "Total";

            Total = new ReadonlyGridTablePage(metadata);
        }

        public ReadonlyGridTablePage Total { get; private set; }

        public ComboboxSettingsField AlarmReset
        {
            get { return _alarmReset ?? (_alarmReset = new ComboboxSettingsField("Alarm Reset")); }
            set { _alarmReset = value; }
        }
        private ComboboxSettingsField _alarmReset;

    }
}
