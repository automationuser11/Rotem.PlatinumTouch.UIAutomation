using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.HouseDimensions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators
{
    internal class TouchUrlCreator : BaseUrlCreator
    {
        public override string UrlFormat
        {
            get { return @"http://{0}:8080/Main.html#/template01Page?houseNumber=-1&pageID={1}"; }
        }

        public override string DashboardUrlFormat
        {
            get { return @"http://{0}:8080/Main.html#/dashboard?houseNumber={1}"; }
        }

        public override string HouseDimensionUrlFormat
        {
            get { return @"http://{0}:8080/Main.html#/HouseDimention?houseNumber=-1&pageID={1}"; }
            
        }


        public override string GetDashboardUrl()
        {
            return string.Format(DashboardUrlFormat, ConfigurationManagerHelper.ControllerAddress, "-1");
        }

        protected override Uri GetUrl(Helpers.Interfaces.IApplicationPage page)
        {
            if (page is DashboardPage)
                return new Uri(string.Format(DashboardUrlFormat, ConfigurationManagerHelper.ControllerAddress, "-1"));

            if (page is HouseDimensionsPage)
                return new Uri(string.Format(HouseDimensionUrlFormat, ConfigurationManagerHelper.ControllerAddress, "-1"));

            var menuId = MetadataFactory.GetMetadata(page as IMetadataDependentPageObject).MenuId;

            return new Uri(string.Format(UrlFormat, ConfigurationManagerHelper.ControllerAddress, menuId));
        }
    }
}
