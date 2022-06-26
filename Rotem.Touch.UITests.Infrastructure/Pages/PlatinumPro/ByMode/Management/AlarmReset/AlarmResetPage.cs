using System;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AlarmReset
{
    public class AlarmResetPage : SimpleTabsPage, IMetadataDependentPageObject
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<AlarmResetPage>()); }
        }
        private Uri _pageUri;
        public Metadata Metadata { get; set; }
        public override string Name
        {
            get { return "Alarm Reset"; }
        }
        public override string MenuName
        {
            get { return "Alarm Reset"; }
        }
        public override string SubMenu { get { return "Management"; } }
        public AlarmResetTabPage AlarmResetTabPage
        {
            get { return _alarmResetTabPage ?? (_alarmResetTabPage = PagesFactory.GetPage<AlarmResetTabPage>()); }
            set { _alarmResetTabPage = value; }
        }
        private AlarmResetTabPage _alarmResetTabPage;
    }
}
