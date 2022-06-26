using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.SensorsInstallation
{
    public class DigitalTabPage : AccordionTablePage<DigitalTabPage>, IApplicationPageTab, IMetadataDependentPageObject
    {
        public string Name
        {
            get
            {
                return "Digital";
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
    }
}
