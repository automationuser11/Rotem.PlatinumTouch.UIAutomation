using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode
{
    public interface IGraphViewProvider<out T> where T : IGraphPage
    {
        T GraphView { get; }
    }

    public interface ITableViewProvider<out T> where T : ITablePage
    {
        T TableView { get; }
    } 

    public interface ISettingsModalViewProvider<out T> where T : ISettingsModal
    {
        T SettingsView { get; }
    }
}
