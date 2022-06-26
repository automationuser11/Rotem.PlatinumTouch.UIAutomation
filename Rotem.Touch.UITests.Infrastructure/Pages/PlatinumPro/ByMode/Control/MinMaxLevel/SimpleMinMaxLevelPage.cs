using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel
{
    public abstract class SimpleMinMaxLevelPage<T> : IApplicationPage, IMetadataDependentPageObject, ITableViewProvider<GridTablePage<T>> where T : class, IMetadataDependentPageObject
    {
        public static INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }

        public abstract Uri PageUrl { get; }
        public string Name
        {
            get { return @"Min/Max Vent. Levels"; }//Gutman
        }

        public string MenuName {
            get { return @"Min/Max Levels"; }
        }
        public string SubMenu { get { return "Control"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }
        public GridTablePage<T> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<T>()); }
            set { _tableView = value; }
        }
        private GridTablePage<T> _tableView;
    }
}
 