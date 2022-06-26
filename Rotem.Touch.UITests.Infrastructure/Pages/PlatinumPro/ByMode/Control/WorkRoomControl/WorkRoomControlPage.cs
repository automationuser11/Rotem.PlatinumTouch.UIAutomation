using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.WorkRoomControl
{
    public class WorkRoomControlPage : IApplicationPage, ITableViewProvider<GridTablePage<WorkRoomControlPage>>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<WorkRoomControlPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Work Room Control"; }
        }
        public string MenuName
        {
            get { return "Work Room Control"; }
        }
        public string SubMenu { get { return "Control"; } }
        public IEnumerable<string> Titles
        {
            get
            {
                return ApplicationPageService.Titles;
                
            }
        }
        public Metadata Metadata { get; set; }
        public GridTablePage<WorkRoomControlPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<WorkRoomControlPage>()); }
        }
        private GridTablePage<WorkRoomControlPage> _tableView;
    }
}
