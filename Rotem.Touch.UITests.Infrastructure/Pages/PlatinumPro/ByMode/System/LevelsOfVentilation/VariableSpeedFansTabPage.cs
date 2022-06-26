using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.LevelsOfVentilation
{
    public class VariableSpeedFansTabPage : GridTablePage<VariableSpeedFansTabPage>, IApplicationPageTab, IMetadataDependentPageObject, IErrorMessagePage
    {
        public string Name
        {
            get
            {
                return "Variable Speed Fans";
                
            }
        }
        public string SubMenu { get { return "System"; } }
        public ITabsPage OwnerPage
        {
            get
            {
                return PagesFactory.GetPage<LevelsOfVentilationPage>();
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
