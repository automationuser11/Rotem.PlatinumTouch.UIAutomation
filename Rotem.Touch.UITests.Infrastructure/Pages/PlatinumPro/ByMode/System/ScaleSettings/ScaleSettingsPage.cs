using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleSettings
{
    public class ScaleSettingsPage : SimpleTabsPage, IMetadataDependentPageObject
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<ScaleSettingsPage>()); }
        }
        private Uri _pageUri;
        public override string Name
        {
            get { return "Scale Settings"; }
        }
        public override string MenuName
        {
            get { return "Scale Settings"; }
        }
        public override string SubMenu { get { return "System"; } }
        public Metadata Metadata { get; set; }
        public GeneralTabPage GeneralTab
        {
            get { return _generalTabPage  ?? (_generalTabPage = new GeneralTabPage()); }
            set { _generalTabPage  = value; }
        }
        private GeneralTabPage _generalTabPage;

        public BirdScaleTabPage BirdScaleTab
        {
            get { return _birdScaleTabPage  ?? (_birdScaleTabPage = new BirdScaleTabPage()); }
            set { _birdScaleTabPage  = value; }
        }
        private BirdScaleTabPage _birdScaleTabPage;

        public SiloTabPage SiloTab
        {
            get { return _siloTabPage  ?? (_siloTabPage = new SiloTabPage()); }
            set { _siloTabPage  = value; }
        }
        private SiloTabPage _siloTabPage;
    }
}
