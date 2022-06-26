using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.LightControl
{
    public class LightControlPage : SimpleTabsPage, ISettingsModalViewProvider<LightControlSettingsPage>, IMetadataDependentPageObject
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<LightControlPage>()); }
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

        public Metadata Metadata { get; set; }

        public LightControlSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new LightControlSettingsPage()); }
            set { _settingsPage = value; }
        }
        private LightControlSettingsPage _settingsPage;

        public LightFeedTabPage LightFeedTab
        {
            get { return _lightFeedTab ?? (_lightFeedTab = new LightFeedTabPage()); }
            set { _lightFeedTab = value; }
        }
        private LightFeedTabPage _lightFeedTab;

        public LightNoFeedTabPage LightNoFeedTab
        {
            get { return _lightNoFeedTab ?? (_lightNoFeedTab = new LightNoFeedTabPage()); }
            set { _lightNoFeedTab = value; }
        }
        private LightNoFeedTabPage _lightNoFeedTab;    
    }
}
