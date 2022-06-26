using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators
{
    public class UrlFactory
    {
        public static Uri GetUrl<T>() where T : class, IApplicationPage, new()
        {
            BaseUrlCreator urlCreator;
            if (ConfigurationManagerHelper.IsFarmMode)
            {
                urlCreator = new RotemWebUrlCreator();
            }
            else
            {
                urlCreator = new TouchUrlCreator();
            }

            return urlCreator.GetUrl<T>();
        }
        public static string GetDashboardUrl()
        {
            BaseUrlCreator urlCreator;
            if (ConfigurationManagerHelper.IsFarmMode)
            {
                urlCreator = new RotemWebUrlCreator();
            }
            else
            {
                urlCreator = new TouchUrlCreator();
            }

            return urlCreator.GetDashboardUrl();
        }
    }
}
