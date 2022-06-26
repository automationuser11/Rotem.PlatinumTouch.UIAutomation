using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.TemperatureCurve
{
    public class TemperatureCurvePage : IApplicationPage, IGraphViewProvider<SimpleGraphPage>, ITableViewProvider<GridTablePage<TemperatureCurvePage>>, ISettingsModalViewProvider<TemperatureCurveSettingsPage>, IMetadataDependentPageObject
    {
        #region Elements Mapping

        internal IWebElement FullCycleButton
        {
            get
            {
                return DriverManager.Driver.FindElement(By.XPath("//div[@id='gridLegendRow']/div/div/span"));
            }
        }

        internal IWebElement Last10DaysButton
        {
            get
            {
                return DriverManager.Driver.FindElement(By.XPath("//div[@id='gridLegendRow']/div/div[2]/span"));
            }
        }

        #endregion

        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<TemperatureCurvePage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Temperature Curve"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        public SimpleGraphPage GraphView
        {
            get { return _graphView ?? (_graphView = new SimpleGraphPage()); }
            set { _graphView = value; }
        }
        private SimpleGraphPage _graphView;

        public GridTablePage<TemperatureCurvePage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<TemperatureCurvePage>()); }
            set { _tableView = value; }
        }
        private GridTablePage<TemperatureCurvePage> _tableView;

        public TemperatureCurveSettingsPage SettingsView
        {
            get { return _temperatureCurveSettingsPage ?? (_temperatureCurveSettingsPage = new TemperatureCurveSettingsPage()); }
            set { _temperatureCurveSettingsPage = value; }
        }
        private TemperatureCurveSettingsPage _temperatureCurveSettingsPage;

        public bool IsFullCycleButtonExists()
        {
            NavigateToGraphView();
            return DriverManager.Driver.IsElementExists(() => FullCycleButton);
        }
        public bool IsLast10DaysButtonExists()
        {
            NavigateToGraphView();
            return DriverManager.Driver.IsElementExists(() => Last10DaysButton);
        }

        private void NavigateToGraphView()
        {
            GraphView.Navigate();
        }
    }
}
