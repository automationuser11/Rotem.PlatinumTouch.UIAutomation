using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AlarmReset
{
    public class AlarmResetTabPage : ITableViewProvider<AlarmResetTable>, IApplicationPageTab, IMetadataDependentPageObject
    {
        public string Name
        {
            get { return "Alarm Reset"; }
        }
        public string SubMenu { get { return "Management"; } }
        public ITabsPage OwnerPage
        {
            get { return PagesFactory.GetPage<AlarmResetPage>(); }
        }
        public bool IsTabButtonExists()
        {
            return DriverManager.Driver.IsElementExists(() => TabPageService.GetTabButton(Name));
        }

        public Metadata Metadata { get; set; }

        public void Navigate()
        {
            TabPageService.Navigate(Name);
        }
        public Uri PageUrl
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<string> Titles
        {
            get { throw new NotImplementedException(); }
        }
        public AlarmResetTable TableView
        {
            get { return _tableView ?? (_tableView = new AlarmResetTable()); }
        }
        private AlarmResetTable _tableView;
    }
}
