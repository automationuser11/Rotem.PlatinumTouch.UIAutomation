using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel
{
    public class MinMaxLevelBySoftMinPage : SimpleMinMaxLevelPage<MinMaxLevelBySoftMinPage>, ISettingsModalViewProvider<SimpleSettingsModal>
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<MinMaxLevelBySoftMinPage>()); }
        }
        private Uri _pageUri;

        public SimpleSettingsModal SettingsView
        {
            get { return _minMaxLevelSettingsPage ?? (_minMaxLevelSettingsPage = new MinMaxSoftSettingsPage()); }
        }
        private SimpleSettingsModal _minMaxLevelSettingsPage;
    }
}
 