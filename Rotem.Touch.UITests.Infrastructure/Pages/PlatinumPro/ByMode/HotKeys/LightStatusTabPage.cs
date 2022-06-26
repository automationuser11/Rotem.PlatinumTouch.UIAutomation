using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class LightStatusTabPage : ReadonlyGridTablePage<LightStatusTabPage>, IApplicationPageTab, IMetadataDependentPageObject, IErrorMessagePage
    {
        public string Name
        {
            get { return "Light Status"; }
        }
        public string MenuName
        {
            get { return "Light Status"; }
        }
        public string SubMenu { get { return "Hot Key"; } }
        public ITabsPage OwnerPage
        {
            get { return PagesFactory.GetPage<LightStatusPage>(); }
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
