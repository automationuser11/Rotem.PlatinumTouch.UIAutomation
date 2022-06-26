using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode
{
    public abstract class TablePageService : ITablePage
    {
        #region Elements Mapping
        internal IWebElement TableButton
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div.icon.icon-grid"));
            }
        }

        #endregion

        protected IControllerTable ControllerTable { get; set; }
        public int ColumnsCount { get { return ControllerTable.UIColumns.Count(); } }
        public int RowsCount { get { return Rows.Count(); } }
        public IEnumerable<string> ColumnsNames { get { return ControllerTable.UIColumnsNames; } }
        public int GroupsCount { get { return ControllerTable.UIGroups.Count(); } }
        public IEnumerable<string> GroupsNames { get { return ControllerTable.UIGroupsNames; } }
        public TableHeader TableHeader { get { return ControllerTable.UITableHeader; } }
        public virtual IWebElement UITable { get { return ControllerTable.UITable; } }
        public virtual bool IsTableExists()
        {
            //return DriverManager.Driver.IsElementExists(() => UITable);
            return DriverManager.Driver.IsTableElementExists(() => UITable);
        }
        public bool IsTableButtonExists() { return DriverManager.Driver.IsElementExists(() => TableButton); }
        public IEnumerable<ITableColumn> TableColumns { get { return ControllerTable.TableMetadata; } }
        public virtual ITableColumn GetTableColumnByColumnName(string name)
        {
            try
            {
                var splitToDisplyNameAndGroup = name.Split('_');

                var displayName = splitToDisplyNameAndGroup.Length > 1 ? splitToDisplyNameAndGroup[1] : splitToDisplyNameAndGroup[0];
                var group = splitToDisplyNameAndGroup.Length > 1 ? splitToDisplyNameAndGroup[0] : "0";
                try
                {
                    return ControllerTable.TableMetadata.Single(col => col.DisplayName == displayName && col.Group == group);
                }
                catch (InvalidOperationException)
                {
                    if(name == "Value")
                        return ControllerTable.TableMetadata.Single(col => col.DisplayName == displayName);
                    return ControllerTable.TableMetadata.Last(col => col.DisplayName == displayName && col.Group == group);
                }
            }
            catch (InvalidOperationException)
            {
                throw new Exception(string.Format("The column {0} does not exist.", name));
            }
        }
        public void Navigate()
        {
            var togglesBtns = DriverManager.Driver.FindElement(By.Id("toggles-buttons"));
            if (!togglesBtns.Displayed) return;

            var activeView = togglesBtns.FindElement(By.CssSelector("div[class='single-toggle active']")).GetAttribute("data-type");

            if (activeView == "T")  // T = table view is active.
            {
                DriverManager.Driver.ConditionalWait(() => togglesBtns.Size != Size.Empty);
                return;
            }

            // In case that graph view is active
            var isExist = DriverManager.Driver.IsElementExists(() => TableButton);
            if (isExist)
            {
                TableButton.Click();
                DriverManager.Driver.WaitForDomReady();
                return;
            }

            // In case that settings view is active
            Browser.Reload();
            DriverManager.Driver.WaitForDomReady();

            isExist = DriverManager.Driver.IsElementExists(() => TableButton);
            if (!isExist) return;
            TableButton.Click();
            DriverManager.Driver.WaitForDomReady();
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
        }
        public bool IsTableViewInFocus()
        {
            var chart = DriverManager.Driver.FindElement(By.Id("gridTablesContainer"));
            var parent = chart.FindElement(By.XPath("ancestor::div[contains(@ng-show,  'layoutItemsObj.activeGTToggle')]"));

            return parent.GetAttribute("class") == "col-md-12";
        }
        public abstract ITablePageExpectedView ExpectedView { get; }
        public TableHeader Headers { get; set; }
        public IEnumerable<IWebElement> Rows 
        {
            get { return ControllerTable.UIRows; }
            set { _rows = value; }
        }
        private IEnumerable<IWebElement> _rows;
        public ISystemInputMethod GetActualInputMethod(ITableColumn column, int row = 0)
        {
            Rows = ControllerTable.UIRows;
            Headers = ControllerTable.UITableHeader;

            var colIdx = Headers.GetColumnIndexByColumnId(column.Id);
            if (colIdx == -1) 
                throw new ArgumentException(string.Format("Column ID: {0} not found.", column.Id));

            if (row == 0)
                row = new Random().Next(0, Rows.Count() - 1);

            var uiRow = Rows.ToList()[row];
            var cell = uiRow.FindElements(By.CssSelector("td[role]"))[colIdx];

            var isButotnGroup = cell.FindElements(By.CssSelector("div[class='btn-group settings-btn-group']")).Any();
            if (isButotnGroup)
                return new ButtonsGroup();

            var isToggleButton = cell.FindElements(By.TagName("label")).Any();
            if (isToggleButton)
                return new TouchToggleButton();

            var isCheckBox = cell.FindElements(By.TagName("input")).Any();
            if (isCheckBox)
                return new TouchCheckBox();

            cell.TryToClick();
            cell.TryToClick();
            var keypadType = KeyPadFactory.GetActiveKeyPadType();

            if (keypadType != null)
            {
                KeyPadHelper.ExitEditMode();
                return keypadType;
            }

            if (DriverManager.Driver.FindElements(By.CssSelector("span[class='keypad-input settings-rounded-input-text ng-binding ng-scope']")).Any())
            {
                KeyPadHelper.ExitEditMode();
                return new DateKeyPad();
            }

            var isComboBox = cell.FindElements(By.TagName("select")).Any();
            if (isComboBox)
                return new TouchComboBox();


            throw new NoSuchElementException(string.Format("No such input method! {0}", ControllerTable.GetColumnInputMethod(column.Id)));
        }
        public ISystemInputMethod GetActualInputMethod(string col, int row = -1)
        {
            var column = GetTableColumnByColumnName(col);
            
            Rows = ControllerTable.UIRows;
            Headers = ControllerTable.UITableHeader;
            
            var colIdx = Headers.GetColumnIndexByColumnId(column.Id);
            if (colIdx == -1)
                throw new ArgumentException(string.Format("Column ID: {0} not found.", column.Id));

            if (row == -1)
                row = new Random().Next(1, Rows.Count() - 1);

            var uiRow = Rows.ToList()[row];
            var cell = uiRow.FindElements(By.CssSelector("td[role=\"gridcell\"]"))[colIdx];

            var isButotnGroup = cell.FindElements(By.CssSelector("div[class='btn-group settings-btn-group']")).Any();
            if (isButotnGroup)
                return new ButtonsGroup();

            var isToggleButton = cell.FindElements(By.TagName("label")).Any();
            if (isToggleButton)
                return new TouchToggleButton();

            var isCheckBox = cell.FindElements(By.TagName("input")).Any();
            if (isCheckBox)
                return new TouchCheckBox();

            cell.JavaDoubleClickAndWait();
            var keypadType = KeyPadFactory.GetActiveKeyPadType();

            if (keypadType != null && keypadType.InputMethodType != "StateCycleKeyPad")
            {
                KeyPadHelper.ExitEditMode();
                return keypadType;
            }

            var isComboBox = cell.FindElements(By.TagName("select")).Any();
            if (isComboBox)
                return new TouchComboBox();

            return keypadType;
        }
    }
}

