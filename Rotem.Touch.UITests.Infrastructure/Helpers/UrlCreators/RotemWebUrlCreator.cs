using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard;
using Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Comparison;
using Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Overview;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators
{
    internal class RotemWebUrlCreator : BaseUrlCreator
    {
        private const string RotemWebShellDashboardUrlFormat = @"https://{0}/Latest/rotemWebApp/Main.html#/dashboard?token={1}";
        private const string RotemWebShellComparisonUrlFormat = @"https://{0}/Latset/rotemWebApp/Main.html#/Comparison?token={1}";

        public override string UrlFormat
        {
            get { return @"https://{0}/Latest/rotemWebApp/Main.html#/houseDetails?token={1}&houseNumber={2}&farm={3}&pageID={4}"; }
        }
        public override string DashboardUrlFormat
        {
            get { return @"https://{0}/Latest/rotemWebApp/Main.html#/houseDetails?token={1}&houseNumber={2}"; }
        }
        public override string HouseDimensionUrlFormat
        {
            get { return @"https://{0}/Latest/rotemWebApp/Main.html#/HouseDimention?token={1}&houseNumber={2}"; }
        }
        public override string GetDashboardUrl()
        {
            return string.Format(DashboardUrlFormat, ConfigurationManagerHelper.FarmAddress, RotemWebNavigator.UserToken,
                RotemWebNavigator.ActiveHouseId);
        }
        protected override Uri GetUrl(IApplicationPage page)
        {
            if (page is DashboardPage)
                return new Uri(string.Format(DashboardUrlFormat, ConfigurationManagerHelper.FarmAddress,
                        RotemWebNavigator.UserToken, RotemWebNavigator.ActiveHouseId));

            var menuId = MetadataFactory.GetMetadata(page as IMetadataDependentPageObject).MenuId;

            return new Uri(string.Format(UrlFormat, ConfigurationManagerHelper.FarmAddress, RotemWebNavigator.UserToken, RotemWebNavigator.ActiveHouseId, RotemWebNavigator.FarmId, menuId));
        }
        protected Uri GetUrl(IRotemWebPage page)
        {
            var host = ConfigurationManagerHelper.FarmAddress;
            var token = RotemWebNavigator.UserToken;

            if (page is OverviewPage)
                return new Uri(string.Format(RotemWebShellDashboardUrlFormat, host, token));

            if (page is ComparisonPage)
                return new Uri(string.Format(RotemWebShellComparisonUrlFormat, host, token));

            return null;
        }
    }
}
