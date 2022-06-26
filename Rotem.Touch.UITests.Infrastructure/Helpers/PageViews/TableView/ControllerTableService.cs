using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.RNBL;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView
{
    public class GridTableService : IControllerTable
    {
        public GridTableService(Metadata metadata)
        {
            var rnbl = new RNBLAccessor(ConfigurationsManager.ActiveConfiguration.RnblArgs);
            //Gutman added
            if (rnbl == null){   
                return;
            }
            var mtTable = rnbl.GetMetadataTableUsingMenuId(metadata.MenuId);
            // sefi added
            if (mtTable == null)
            {
                return;
            }
            var dataTable = metadata.ContainerId != null
                ? (mtTable.Rows.Cast<DataRow>()).Where(row => row["ContainerID"].ToString() == metadata.ContainerId)
                : mtTable.Rows.Cast<DataRow>();
            TableMetadata = (dataTable.Select(ColumnsFactory.InitilaizeColumn)).ToList();
        }
        public GridTableService(DataTable dataTable)
        {
            TableMetadata = ((dataTable.Rows.Cast<DataRow>()).Select(ColumnsFactory.InitilaizeColumn)).ToList();
        }
      
        //public virtual IWebElement UITable
        //{
        //    get
        //    {
        //        DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
        //        return DriverManager.Driver.WaitForFieldToBeLoaded(By.CssSelector("div[class='table-container data-grid data-grid-header']"), Timeouts.Small);
        //    }
        //}
        public virtual IWebElement UITable
        {
            get
            {

                //WebDriverExtension.HighlightElementByLocator("gridTablesContainer");

                DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
                //return DriverManager.Driver.WaitForFieldToBeLoaded(By.XPath("//div[@id='gridTablesContainer']/div[contains(@class, 'data-grid')]/div[contains(@class, 'k-grid-content')]/table"), Timeouts.Huge);
                //.FindElement(By.XPath("//div[contains(@class, 'data-grid')]/div[contains(@class, 'k-grid-content')]/table"));
                //return DriverManager.Driver.WaitForFieldToBeLoaded(By.Id("gridTablesContainer"), Timeouts.Big);
                return DriverManager.Driver.WaitForFieldToBeLoaded(By.XPath("//div[@id='gridTablesContainer']/div[contains(@class, 'data-grid')]"), Timeouts.Big);

            }
        }
        public IEnumerable<IWebElement> UIGroups
        {
            get
            {
                var allColumns = UITable.FindElements(By.TagName("th")).ToList();
                return allColumns.Where(item => item.GetAttribute("data-field") == string.Empty).ToList();
            }
        }
        public IEnumerable<IWebElement> UIColumns
        {
            get
            {
                DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
                DriverManager.Driver.WaitForAjax();
                DriverManager.Driver.WaitForDomReady();

                // Find all columns and scroll to them
                var js = (IJavaScriptExecutor)DriverManager.Driver;
                var allColumns = UITable.WaitForFieldsToBeLoaded(By.CssSelector("thead th[data-field]"));

                if (this is AccordionTableService)
                    return allColumns.Where(th => th.Displayed).Select(th => th).ToList();

                var columns = allColumns.Where(item =>
                {
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", item);
                    DriverManager.Driver.WaitForAjax();

                    return (item.Text != string.Empty);
                }).ToList();
                return columns;
            }
        }
        public virtual IEnumerable<IWebElement> UIRows
        {
            get
            {
                var tableContent = DriverManager.Driver.WaitForFieldToBeLoaded(By.CssSelector("div[class='k-grid-content k-auto-scrollable']"), Timeouts.Small);
                return tableContent.FindElements(By.TagName("tr")).ToList();
            }
        }
        public IEnumerable<string> UIColumnsNames
        {
            get
            {
                return UIColumns.Select(item => item.Text).ToList();
            }
        }
        public IEnumerable<string> UIGroupsNames
        {
            get
            {
                return UIGroups.Select(item => item.Text).ToList();
            }
        }
        public TableHeader UITableHeader
        {
            get
            {
                return new TableHeader(UITable);
            }
        }
        public IEnumerable<ITableColumn> TableMetadata { get; private set; }
        public ISystemInputMethod GetColumnInputMethod(int columnId)
        {
            try { 
                return TableMetadata.Single(col => col.Id == columnId).InputMethod;
            }
            catch (InvalidOperationException)
            {
                return TableMetadata.Last(col => col.Id == columnId).InputMethod;
            }
        }
    }
    public class AccordionTableService : GridTableService
    {
        public AccordionTableService(Metadata metadata) : base(metadata)
        {
        }
        public AccordionTableService(DataTable table) : base(table)
        {
        }
        public override IWebElement UITable
        {
            get
            {
                return DriverManager.Driver.WaitForFieldToBeLoaded(By.XPath("//div[@id='gridTablesContainer']/div[contains(@id, 'grid')]"), Timeouts.Small);
            }
        }
        public override IEnumerable<IWebElement> UIRows
        {
            get
            {
                var tableContent = DriverManager.Driver.WaitForFieldToBeLoaded(By.CssSelector("div[class='k-grid-content k-auto-scrollable']"), Timeouts.Small);
                //var tableContent = DriverManager.Driver.WaitForFieldToBeLoaded(By.CssSelector(".k-grid-content.k-auto-scrollable"), Timeouts.Small);
                return tableContent.FindElements(By.CssSelector("tr:not(.k-grouping-row)")).ToList();
            }
        }
        public IEnumerable<IWebElement> UIRegions
        {
            get
            {
                DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
                var timeout = new TimeSpan(0, 0, Timeouts.Small);
                var sw = Stopwatch.StartNew();
                IEnumerable<IWebElement> regions = null;

                while (sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
                {
                    regions = DriverManager.Driver.FindElements(By.CssSelector("tr[class='k-grouping-row']"));
                    if (regions.Any()) 
                        break;
                }

                return regions;
            }
        }
    }
}
