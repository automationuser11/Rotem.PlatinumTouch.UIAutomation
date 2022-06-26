using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.StaticPressure
{
    public class StaticPressurePage : SimpleTabsPage, ISettingsModalViewProvider<StaticPressureSettingsPage>, IMetadataDependentPageObject
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<StaticPressurePage>()); }
        }
        private Uri _pageUri;

        public override string Name
        {
            get { return "Static Pressure"; }
        }
        public override string MenuName
        {
            get { return "Static Pressure"; }
        }
        public override string SubMenu { get { return "Control"; } }
        public Metadata Metadata { get; set; }

        public StaticPressureSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new StaticPressureSettingsPage()); }
            set { _settingsPage = value; }
        }
        private StaticPressureSettingsPage _settingsPage;
        public AtticVentilationTab AtticVentilationTab
        {
            get { return _atticVentilationTab ?? (_atticVentilationTab = new AtticVentilationTab()); }
            set { _atticVentilationTab = value; }
        }
        private AtticVentilationTab _atticVentilationTab;
        public MinimumVentilationTab MinimumVentilationTab
        {
            get { return _minimumVentilationTab ?? (_minimumVentilationTab = new MinimumVentilationTab()); }
            set { _minimumVentilationTab = value; }
        }
        private MinimumVentilationTab _minimumVentilationTab;
        public TunnelVentilationTab TunnelVentilationTab
        {
            get { return _tunnelVentilationTab ?? (_tunnelVentilationTab = new TunnelVentilationTab()); }
            set { _tunnelVentilationTab = value; }
        }
        private TunnelVentilationTab _tunnelVentilationTab;
    }
}
