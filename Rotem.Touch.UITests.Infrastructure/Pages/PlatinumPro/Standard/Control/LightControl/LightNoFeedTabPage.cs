using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.LightControl
{
    public class LightNoFeedTabPage : GridTablePage<LightNoFeedTabPage>, IApplicationPageTab, IMetadataDependentPageObject, IErrorMessagePage
    {
        public string Name
        {
            get
            {
                return "Light No Feed";
            }
        }
        public ITabsPage OwnerPage
        {
            get
            {
                return PagesFactory.GetPage<StandardLightControlPage>();
            }
        }
        public bool IsTabButtonExists()
    {
            return DriverManager.Driver.IsElementExists(() => TabPageService.GetTabButton(Name));
        }
        public new void Navigate()
        {
            if (TabPageService.IsTabAlreadyPressed(Name)) return;
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
