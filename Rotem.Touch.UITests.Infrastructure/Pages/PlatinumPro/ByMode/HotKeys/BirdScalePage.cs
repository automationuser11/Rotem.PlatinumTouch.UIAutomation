using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.HotKeys
{
    public class BirdScalePage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<BirdScalePage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Bird Scale"; }
        }
        public string MenuName
        {
            get { return "Bird Scale"; }
        }
        public string SubMenu { get { return "Hot Key"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        //public ReadonlyGridTablePage<BirdScalePage> TableView
        //{
        //    get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<BirdScalePage>()); }
        //}
        //private ReadonlyGridTablePage<BirdScalePage> _tableView;
        public Metadata Metadata { get; set; }        
    }
}


