using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PLC.TestingAndCalibration.WaterAndFeedCalibration
{
    public class FeedTabPage : GridTablePage<FeedTabPage>, IApplicationPageTab, IMetadataDependentPageObject
    {
        public string Name { get { return "Feed"; } }
        public ITabsPage OwnerPage
        {
            get
            {
                return PagesFactory.GetPage<WaterAndFeedCalibrationPage>();
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
