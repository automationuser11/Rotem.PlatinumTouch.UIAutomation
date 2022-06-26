using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface IControllerTable 
    {
        IWebElement UITable { get; }
        IEnumerable<IWebElement> UIGroups { get; }
        IEnumerable<IWebElement> UIColumns { get; }
        IEnumerable<IWebElement> UIRows { get; }
        IEnumerable<string> UIColumnsNames { get; }
        IEnumerable<string> UIGroupsNames { get; }
        TableHeader UITableHeader { get; }
        IEnumerable<ITableColumn> TableMetadata { get; }
        ISystemInputMethod GetColumnInputMethod(int columnId);
    }
}
