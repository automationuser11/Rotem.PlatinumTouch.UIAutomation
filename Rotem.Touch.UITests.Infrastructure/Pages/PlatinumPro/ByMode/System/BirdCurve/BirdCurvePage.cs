using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.BirdCurve
{
    public class BirdCurvePage : IApplicationPage, ITableViewProvider<BirdCurveTable>, ISettingsModalViewProvider<BirdCurveSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<BirdCurvePage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Bird Curve"; }
        }
        public string MenuName
        {
            get { return "Bird Curve"; }
        }
        public string SubMenu { get { return "System"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }

        public BirdCurveSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new BirdCurveSettingsPage()); }
        }
        private BirdCurveSettingsPage _settingsPage;

        public BirdCurveTable TableView
        {
            get { return _tableView ?? (_tableView = new BirdCurveTable()); }
        }
        private BirdCurveTable _tableView;
    }
}
