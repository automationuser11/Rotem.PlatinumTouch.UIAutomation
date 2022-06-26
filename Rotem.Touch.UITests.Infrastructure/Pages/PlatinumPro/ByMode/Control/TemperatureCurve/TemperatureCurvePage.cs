using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.TemperatureCurve
{
    public class TemperatureCurvePage : IApplicationPage , IGraphViewProvider<SimpleGraphPage>, ITableViewProvider<GridTablePage<TemperatureCurvePage>>,ISettingsModalViewProvider<TemperatureCurveSettingsPage>, IMetadataDependentPageObject
    {
       private List<string> TableTitleArray = new List<string>(new string[]
        {
                    "Day",
                    "Target",
                    "Heat Off",
                    "Tunnel",
                    "Low",
                    "High",
                    "Tunnel High"
        });

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
        public string MenuName
        {
            get { return "Temperature Curve"; }
        }
        public string SubMenu { get { return "Control"; } }
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
            set { _tableView  = value; }
        }
        private GridTablePage<TemperatureCurvePage> _tableView;

        public TemperatureCurveSettingsPage SettingsView
        {
            get { return _temperatureCurveSettingsPage  ?? (_temperatureCurveSettingsPage = new TemperatureCurveSettingsPage()); }
            set { _temperatureCurveSettingsPage  = value; }
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


        public bool IsTableTitlesOK()//Gutman
        {
            bool isTitleFound = true;

            string Title = Titles.ToString();
            TableView.Navigate();

            if(TableTitleArray.Count != TableView.ColumnsCount) //need to make sure that there are 6 column
            {
                Console.WriteLine("Number of titles must be equal to " + TableTitleArray.Count);
                return false;
            }

            foreach (var column in TableView.EditableColumns)
            {
                if (isTitleFound == false)
                {
                    return isTitleFound;
                }

                Title = column.DisplayName;
                foreach (string TitleName in TableTitleArray)
                {
                    if(Title == TitleName)
                    {
                        isTitleFound = true;
                        break;
                    }
                    else
                    {
                        if(isTitleFound)
                            isTitleFound = false;
                    }
                }
            }
            
            return isTitleFound;
        }
    }
}
