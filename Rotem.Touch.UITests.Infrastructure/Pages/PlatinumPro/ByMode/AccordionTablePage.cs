using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode
{
    public class AccordionTablePage : GridTablePage
    {
        private const string RowClassName = "accordion_col ng-scope";

        #region Private Methods 

        private bool IsRegionExpanded(string region)
        {
            var uiRegion = GetRegionElement(region);
            return IsRegionExpanded(uiRegion);
        }
        private bool IsRegionExpanded(IWebElement uiRegion)
        {
            var icon = uiRegion.FindElement(By.TagName("a"));
            var isExpand = icon.GetAttribute("class").Contains("k-i-collapse");

            return isExpand;
        }
        private IWebElement GetRegionElement(string region)
        {
            var uiRegion = AccordionTable.UIRegions.Single(rgn => rgn.FindElement(By.TagName("td")).Text == region);
            return uiRegion;
        }
        private List<IWebElement> GetRegionRowsByRegionName(string region)
        {
            var uiRegion = GetRegionElement(region);
            var rows = new List<IWebElement>();
            var nextRow = uiRegion.FindElement(By.XPath("following-sibling::tr"));

            while (nextRow.GetAttribute("class") == RowClassName)
            {
                rows.Add(nextRow);
                try
                {
                    nextRow = nextRow.FindElement(By.XPath("following-sibling::tr"));
                }
                catch (NoSuchElementException)
                {
                    break;
                }
            }

            return rows;
        }

        #endregion

        public AccordionTablePage(){}
        protected AccordionTablePage(DataTable metadata)
        {
            ControllerTable =  new AccordionTableService(metadata);
        }
        protected AccordionTableService AccordionTable
        {
            get { return ControllerTable as AccordionTableService; }
        }

        public List<string> RegionsNames
        {
            get
            {
                var regionsNames = AccordionTable.UIRegions.Select(uiRegion => uiRegion.FindElement(By.TagName("td")).Text).ToList();
                return regionsNames;
            }
        }

        public void ExpandAll()
        {
            foreach (var region in AccordionTable.UIRegions)
            {
                var isExpand = IsRegionExpanded(region);
                if(!isExpand)
                    region.JavaClickAndWait();
            }
        }
        public void CollapseAll()
        {
            foreach (var region in AccordionTable.UIRegions)
            {
                var isExpand = IsRegionExpanded(region);
                if (isExpand)
                    region.JavaClickAndWait();
            }
        }
        public void ExpandRegionByName(string region)
        {
            var uiRegion = GetRegionElement(region);
            var isExpand = IsRegionExpanded(region);

            if(!isExpand)
                uiRegion.Click();
        }
        public void CollapsedRegionByName(string region)
        {
            var uiRegion = GetRegionElement(region);
            var isExpand = IsRegionExpanded(region);

            if (isExpand)
                uiRegion.Click();
        }
        public bool IsEmptyRegion(string region)
        {
            ExpandRegionByName(region);
            var uiRegion = GetRegionElement(region);

            var nextRow = uiRegion.FindElement(By.XPath("following-sibling::tr"));
            var itHasRows = nextRow.GetAttribute("class") == RowClassName;

            return itHasRows;
        }
        public void EditRandomCellContent(string content, string region, string column)
        {
            CollapseAll();
            ExpandRegionByName(region);

            var rows = GetRegionRowsByRegionName(region);
            var rnd = new Random();
            var rndIdx = rows.Count() > 10 ? rnd.Next(1, 10) : rnd.Next(1, rows.Count());

            int columnId = column.GetHashCode() + "0".GetHashCode();
            EditCellContent(content, rndIdx, columnId);
        }
        public void EditRandomCellContent(string content, ITableColumn column)
        {
            CollapseAll();
            var firstRegion = AccordionTable.UIRegions.First().FindElement(By.TagName("td")).Text;
            ExpandRegionByName(firstRegion);

            var rows = GetRegionRowsByRegionName(firstRegion);
            var rnd = new Random();
            var rndIdx = rows.Count() > 10 ? rnd.Next(1, 10) : rnd.Next(1, rows.Count());

            EditCellContent(content, rndIdx, column.Id);
        }
        public override bool IsEditingEnable(string content, ITableColumn column)
        {
            try
            {
                EditRandomCellContent(content, column);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }

    public class AccordionTablePage<T> : AccordionTablePage where T : class, IMetadataDependentPageObject, new()
    {
        public AccordionTablePage()
        {
            if (ControllerTable != null) return;
            
            var metadata = MetadataFactory.GetMetadata<T>();
            ControllerTable = new AccordionTableService(metadata);
        }
        
        public virtual int GetExpectedColumnsCount()
        {
            return ConfigurationsManager.GetTabColumnsCount<T>();
        }

        public virtual TableHeader GetExpectedTableHeader()
        {
            return ConfigurationsManager.GetTabTableHeader<T>();
        }

        public virtual ISystemInputMethod GetExpectedInputMethod(ITableColumn column)
        {
            return ConfigurationsManager.GetTabInputMethod<T>(column);
        }
    }

    public class AccordionTableExpectedView<T> : GridTableExpectedView<T> where T : class, IMetadataDependentPageObject
    {
        public IEnumerable<string> GetExpectedRegions()
        {
            return ConfigurationsManager.GetRegionsCollection(PageObject as IApplicationPage);
        }
    }
}
