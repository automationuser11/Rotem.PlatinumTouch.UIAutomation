using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface ITablePage : INavigatalePageView
    {
        int ColumnsCount { get; }
        IEnumerable<string> ColumnsNames { get; }
        int GroupsCount { get; }
        IEnumerable<string> GroupsNames { get; }
        TableHeader TableHeader { get; }
        ITablePageExpectedView ExpectedView { get; }
        ISystemInputMethod GetActualInputMethod(ITableColumn column, int row);
    }
}
