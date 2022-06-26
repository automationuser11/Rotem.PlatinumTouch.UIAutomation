using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface ITabsPage : IApplicationPage
    {
        IApplicationPageTab this[string tab] { get; }
        List<IApplicationPageTab> Tabs { get; }
        List<string> TabsNames { get; }
        TabsPageExpectedView ExpectedView { get; }
    }

    public interface IApplicationPageTab : INavigatalePageView 
    {
        string Name { get; }
        ITabsPage OwnerPage { get; }
        bool IsTabButtonExists();
    }
}

