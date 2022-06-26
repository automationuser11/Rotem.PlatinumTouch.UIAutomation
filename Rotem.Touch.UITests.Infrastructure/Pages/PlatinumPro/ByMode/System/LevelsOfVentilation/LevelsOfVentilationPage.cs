using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.LevelsOfVentilation
{
    public class LevelsOfVentilationPage : SimpleTabsPage, IMetadataDependentPageObject
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<LevelsOfVentilationPage>()); }
        }
        private Uri _pageUri;
        public override string Name
        {
            get { return "Levels Of Ventilation"; }
        }
        public override string MenuName
        {
            get { return "Levels Of Ventilation"; }
        }
        public override string SubMenu { get { return "System"; } }
        public Metadata Metadata { get; set; }
        public ExhaustAndTunnelFansTabPage ExhaustAndTunnelFansTab
        {
            get { return _exhaustAndTunnelFansTabPage  ?? (_exhaustAndTunnelFansTabPage = new ExhaustAndTunnelFansTabPage()); }
            set { _exhaustAndTunnelFansTabPage  = value; }
        }
        private ExhaustAndTunnelFansTabPage _exhaustAndTunnelFansTabPage;

        public VentAndCurtainTabPage VentAndCurtainTab
        {
            get { return _ventAndCurtainTabPage  ?? (_ventAndCurtainTabPage = new VentAndCurtainTabPage()); }
            set { _ventAndCurtainTabPage  = value; }
        }
        private VentAndCurtainTabPage _ventAndCurtainTabPage;

        public VariableSpeedFansTabPage VariableSpeedFansTab
        {
            get { return _variableSpeedFansTabPage  ?? (_variableSpeedFansTabPage = new VariableSpeedFansTabPage()); }
            set { _variableSpeedFansTabPage  = value; }
        }
        private VariableSpeedFansTabPage _variableSpeedFansTabPage;

        public StirAndVariableStirFansTabFansPage StirAndVariableStirFansTab
        {
            get { return _stirAndVariableStirFansTabFansPage ?? (_stirAndVariableStirFansTabFansPage = new StirAndVariableStirFansTabFansPage()); }
            set { _stirAndVariableStirFansTabFansPage = value; }
        }
        private StirAndVariableStirFansTabFansPage _stirAndVariableStirFansTabFansPage;
    }
}
