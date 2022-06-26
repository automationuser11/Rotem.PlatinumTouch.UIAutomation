using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.SensorsInstallation
{
    public class SensorsInstallationPage : SimpleTabsPage, IMetadataDependentPageObject
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<SensorsInstallationPage>()); }
        }
        private Uri _pageUri;
        public override string Name
        {
            get { return "Sensors"; }
        }
        public override string MenuName
        {
            get { return "Sensors"; }
        }
        public override string SubMenu { get { return "System"; } }
        public Metadata Metadata { get; set; }
        public AnalogTabPage AnalogTab
        {
            get { return _analogTabPage ?? (_analogTabPage = new AnalogTabPage("AnalogSensors_Function")); }
            set { _analogTabPage  = value; }
        }
        private AnalogTabPage _analogTabPage;

        public DigitalTabPage DigitalTab
        {
            get { return _digitalTabPage  ?? (_digitalTabPage = new DigitalTabPage()); }
            set { _digitalTabPage  = value; }
        }
        private DigitalTabPage _digitalTabPage;
    }
}
