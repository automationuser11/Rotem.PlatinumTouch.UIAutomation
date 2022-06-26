using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface ITablePageExpectedView
    {
        int GetExpectedColumnsCount();
        TableHeader GetExpectedTableHeader();
        ISystemInputMethod GetExpectedInputMethod(ITableColumn column);
    }
}