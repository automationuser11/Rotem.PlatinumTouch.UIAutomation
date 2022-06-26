using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.StaticPressure
{
    public class StaticPressurePage : SimpleTabsPage, ISettingsModalViewProvider<StaticPressureSettingsPage>, IMetadataDependentPageObject
    {
        public override string Name
        {
            get {  return _name; }
        }
        private string _name = "Static Pressure";

        public override string MenuName
        {
            get { return "Static Pressure"; }
        }
        public override string SubMenu { get { return "Control"; } }

        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<StaticPressurePage>()); }
        }
        private Uri _pageUri;

        public StaticPressureSettingsPage SettingsView
        {
            get { return _settingView ?? (_settingView = new StaticPressureSettingsPage()); }
        }
        private StaticPressureSettingsPage _settingView;

        public Metadata Metadata { get; set; }

        #region Tabs definotios
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
        #endregion
    }
}
