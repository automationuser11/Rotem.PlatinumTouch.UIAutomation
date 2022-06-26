using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.NippleFlushing
{
    public class OrderTabPage : GridTablePage<OrderTabPage>, IApplicationPageTab, IMetadataDependentPageObject
    {
        public string Name 
        {
            get { return "Order"; }
        }
        public string SubMenu { get { return "Management"; } }
        public ITabsPage OwnerPage
        {
            get
            {
                return PagesFactory.GetPage<NippleFlushingPage>();
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
        public global::System.Uri PageUrl
        {
            get { throw new global::System.NotImplementedException(); }
        }
        public global::System.Collections.Generic.IEnumerable<string> Titles
        {
            get { throw new global::System.NotImplementedException(); }
        }
    }
}
