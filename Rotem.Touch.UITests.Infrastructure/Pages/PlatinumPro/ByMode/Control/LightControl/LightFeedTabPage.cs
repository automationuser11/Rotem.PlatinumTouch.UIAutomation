using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.LightControl
{
    public class LightFeedTabPage : GridTablePage<LightFeedTabPage>, IApplicationPageTab, IMetadataDependentPageObject, IErrorMessagePage
    {
        public string Name
        {
            get { return "Light Feed"; }
        }
        public string MenuName
        {
            get { return "Light"; }
        }
        public string SubMenu { get { return "Control"; } }
        public ITabsPage OwnerPage
        {
            get { return PagesFactory.GetPage<LightControlPage>(); }
        }
        public Metadata Metadata { get; set; }
        public new void Navigate()
        {
            TabPageService.Navigate(Name);
        }
        public bool IsTabButtonExists()
        {
            return DriverManager.Driver.IsElementExists(() => TabPageService.GetTabButton(Name));
        }
        public global::System.Uri PageUrl
        {
            get { throw new global::System.NotImplementedException(); }
        }
        public global::System.Collections.Generic.IEnumerable<string> Titles
        {
            get { throw new global::System.NotImplementedException(); }
        }
        public string ErrorMessage
        {
            get { return PageErrorMessageService.GetDisplayedErrorMessage(); }
        }
        public void ApproveErrorMessage()
        {
            PageErrorMessageService.ApproveErrorMessage();
        }
    }
}
