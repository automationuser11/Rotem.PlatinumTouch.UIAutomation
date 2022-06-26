namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface INavigator
    {
        void NavigateTo(IApplicationPage page);
        void SwitchTab();
        string BaseUrl { get; }
        string CurrentPageUrl { get; }
        void NavigateToDashboard();
        void NavigateTo<T>(NavigationOption option) where T : class, IApplicationPage, new();
        void NavigateTo<T>() where T : class, IApplicationPage, new();
    }
}
