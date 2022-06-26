using System;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ControlMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel
{
    public class MinMaxLevelByWeightPage : SimpleMinMaxLevelPage<MinMaxLevelByWeightPage>, ISettingsModalViewProvider<SimpleSettingsModal>
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<MinMaxLevelByWeightPage>()); }
        }
        private Uri _pageUri;

        public SimpleSettingsModal SettingsView
        {
            get { return _minMaxLevelSettingsPage ?? (_minMaxLevelSettingsPage = new MinMaxWeightSettingsPage()); }
        }
        private SimpleSettingsModal _minMaxLevelSettingsPage;

        public static void SetByWeightControlMode()
        {
            Navigator.NavigateTo<ControlModePage>();
            var controlModePage = PagesFactory.GetPage<ControlModePage>();
            controlModePage.MinMaxLevelControl.SetValue("By Weight");
            controlModePage.SaveChanges();
        }
    }
}
 