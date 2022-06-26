using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.LightControl
{
    public class StandardLightControlPage : SimpleTabsPage, ISettingsModalViewProvider<LightControlSettingsPage>, IMetadataDependentPageObject
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<StandardLightControlPage>()); }
        }
        private Uri _pageUri;
        public override string Name
        {
            get { return "Light Control"; }
        }
        public override string MenuName
        {
            get { return "Light"; }
        }
        public override string SubMenu { get { return "Control"; } }

        public LightControlSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new LightControlSettingsPage()); }
        }
        private LightControlSettingsPage _settingsPage;

        public LightFeedTabPage LightFeedTab
        {
            get { return _lightFeedTab ?? (_lightFeedTab = new LightFeedTabPage()); }
        }
        private LightFeedTabPage _lightFeedTab;

        public LightNoFeedTabPage LightNoFeedTab
        {
            get { return _lightNoFeedTab ?? (_lightNoFeedTab = new LightNoFeedTabPage()); }
        }
        private LightNoFeedTabPage _lightNoFeedTab;

        public Metadata Metadata { get; set; }
    }
}
