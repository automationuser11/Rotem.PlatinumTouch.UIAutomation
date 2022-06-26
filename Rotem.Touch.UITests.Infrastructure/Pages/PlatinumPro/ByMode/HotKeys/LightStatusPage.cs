using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class LightStatusPage : SimpleTabsPage, IMetadataDependentPageObject
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<HotKeys.LightStatusPage>()); }
        }
        private Uri _pageUri;

        public override string Name
        {
            get { return "Light Status"; }
        }
        public override string MenuName
        {
            get { return "Light Status"; }
        }
        public override string SubMenu { get { return "Hot Key"; } }
        public LightTabPage LightTab
        {
            get { return _lightTab ?? (_lightTab = new LightTabPage()); }
        }
        private LightTabPage _lightTab;

        public LightStatusTabPage LightStatusTab
        {
            get { return _lightStatusTab ?? (_lightStatusTab = new LightStatusTabPage()); }
        }
        private LightStatusTabPage _lightStatusTab;

        public Metadata Metadata { get; set; }

        public IEnumerable<string> Titles
        {
            get { return  ApplicationPageService.Titles; }
        }
    }
}
