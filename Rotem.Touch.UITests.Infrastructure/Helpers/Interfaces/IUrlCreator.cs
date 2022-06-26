using System;
namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface IUrlCreator
    {
        string UrlFormat { get; }
        string DashboardUrlFormat { get; }
        string HouseDimensionUrlFormat { get; }
        Uri GetUrl<T>() where T : class, IApplicationPage, new();
        string GetDashboardUrl();
    }
}
