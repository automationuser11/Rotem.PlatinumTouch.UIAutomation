namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface IReadonlyTablePage : ITablePage
    {
        bool IsEditingEnable(string content, ITableColumn column);
    }
}
