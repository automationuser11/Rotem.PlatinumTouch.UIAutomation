using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.SensorsInstallation
{
    public class AnalogTabPage : DeviceInstallationPage<AnalogTabPage>, IApplicationPageTab, IMetadataDependentPageObject
    {
        public AnalogTabPage() {}

        public AnalogTabPage(string dataFieldName) : base(dataFieldName) { }
        public string Name
        {
            get
            {
                return "Analog";
            }
        }
        public string SubMenu { get { return "System"; } }
        public ITabsPage OwnerPage
        {
            get
            {
                return PagesFactory.GetPage<SensorsInstallationPage>();
            }
        }
        public bool IsTabButtonExists()
        {
            return DriverManager.Driver.IsElementExists(() => TabPageService.GetTabButton(Name));
        }
        public new void Navigate()
        {
            TabPageService.Navigate(Name);
        }
        public Metadata Metadata { get; set; }


        public DeviceInstallationPage<AnalogTabPage> TableView
        {
            get { return _tableView ?? (_tableView = new DeviceInstallationPage<AnalogTabPage>()); }
            set { _tableView = value; }
        }
        private DeviceInstallationPage<AnalogTabPage> _tableView;
    }
}
