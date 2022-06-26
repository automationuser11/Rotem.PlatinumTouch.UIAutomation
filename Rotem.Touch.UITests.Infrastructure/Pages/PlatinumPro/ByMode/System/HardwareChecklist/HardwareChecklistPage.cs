using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.HardwareChecklist
{
    public class HardwareChecklistPage : IApplicationPage, ITableViewProvider<AccordionTablePage<HardwareChecklistPage>>, ISettingsModalViewProvider<HardwareChecklistSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<HardwareChecklistPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Hardware Checklist"; }
        }
        public string MenuName
        {
            get { return "Hardware Checklist"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public AccordionTablePage<HardwareChecklistPage> TableView
        {
            get { return _tableView  ?? (_tableView = new AccordionTablePage<HardwareChecklistPage>()); }
            set { _tableView  = value; }
        }
        private AccordionTablePage<HardwareChecklistPage> _tableView;

        public HardwareChecklistSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new HardwareChecklistSettingsPage()); }
        }
        private HardwareChecklistSettingsPage _settingsView;
    }
}
