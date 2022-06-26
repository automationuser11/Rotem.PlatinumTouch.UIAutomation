using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators
{
    internal abstract class BaseUrlCreator : IUrlCreator
    {
        public abstract string UrlFormat { get; }
        public abstract string DashboardUrlFormat { get; }

        public abstract string HouseDimensionUrlFormat { get; }
        
        public abstract string GetDashboardUrl();
        public Uri GetUrl<T>() where T : class, IApplicationPage, new()
        {
            var resultPage = PagesFactory.GetPage<T>();
            var page = Cast(resultPage, resultPage.GetType());

            return GetUrl(page);
        }
        protected abstract Uri GetUrl(IApplicationPage page);
        protected static dynamic Cast(dynamic obj, Type castTo)
        {
            return Convert.ChangeType(obj, castTo);
        }
    }
}
