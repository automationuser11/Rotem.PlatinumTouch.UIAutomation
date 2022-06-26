using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode
{
    public class GridTablePage : TablePageService, IEditableTablePage
    {
        #region Private Methods
        //protected virtual void EditCellContent(object content, int row, int columnId)
        //{
        //    Rows = ControllerTable.UIRows;
        //    Headers = ControllerTable.UITableHeader;

        //    int colIdx = Headers.GetColumnIndexByColumnId(columnId);

        //    if (colIdx == -1)
        //        throw new ArgumentException(string.Format("Column ID: {0} not found.", columnId));

        //    var inputMethod = ControllerTable.GetColumnInputMethod(columnId);
        //    if (inputMethod == null) return;

        //    // Enter to editing mode.
        //    var uiRow = Rows.ToList()[row];
        //    var cell = uiRow.FindElements(By.CssSelector("td[role='gridcell']"))[colIdx];

        //    if (inputMethod is ISystemKeyPad)
        //    {
        //        //cell.DoubleClick(); 
        //        cell.JavaDoubleClickAndWait();
        //        inputMethod.SetValue(content.ToString());
        //    }
        //    else
        //    {
        //        cell.JavaClickAndWait();
        //        cell.Click();
        //        //Waits.Wait(1);//sefi add - need to test it 
        //        inputMethod.SetValue(content, cell);
        //        //Waits.Wait(1);//sefi add - need to test it 
        //        cell.JavaClickAndWait();
        //        //cell.Click();
        //    }

        //    DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
        //    DriverManager.Driver.WaitForAjax();
        //    LastInputMethodTypeWasActivated = inputMethod;
        //}

        protected virtual void EditCellContent(object content, int row, int columnId)
        {
            Rows = ControllerTable.UIRows;
            Headers = ControllerTable.UITableHeader;

            int colIdx = Headers.GetColumnIndexByColumnId(columnId);

            if (colIdx == -1)
                throw new ArgumentException(string.Format("Column ID: {0} not found.", columnId));

            var inputMethod = ControllerTable.GetColumnInputMethod(columnId);
            if (inputMethod == null) return;

            var uiRow = Rows.ToList()[row];
            var cell = uiRow.FindElements(By.CssSelector("td[role='gridcell']"))[colIdx];

            if (inputMethod is ISystemKeyPad)
            {
                cell.JavaDoubleClickAndWait();
                inputMethod.SetValue(content.ToString());
            }
            else if (inputMethod.InputMethodType.Contains("Toggle"))
            {
                if (content.ToString() != cell.Text)
                    cell.Click();
            }
            else
            {
                cell.JavaClickAndWait();
                cell.Click();
                inputMethod.SetValue(content, cell);
                cell.JavaClickAndWait();
            }

            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            LastInputMethodTypeWasActivated = inputMethod;
            return;
                
        }

        protected virtual void EditCellContentByRowName(object content, string rowName, int columnId)
        {
            Rows = ControllerTable.UIRows;
            Headers = ControllerTable.UITableHeader;

            int colIdx = Headers.GetColumnIndexByColumnId(columnId);

            if (colIdx == -1)
                throw new ArgumentException(string.Format("Column ID: {0} not found.", columnId));

            var inputMethod = ControllerTable.GetColumnInputMethod(columnId);
            if (inputMethod == null) return;

            // Enter to editing mode.
            var uiRow = Rows.Where(row => row.Text == rowName).First();
            var cell = uiRow.FindElements(By.TagName("td"))[colIdx];

            if (inputMethod is ISystemKeyPad)
            {
                cell.JavaDoubleClickAndWait();
                inputMethod.SetValue(content.ToString());
            }
            else
            {
                inputMethod.SetValue(content, cell);
            }

            LastInputMethodTypeWasActivated = inputMethod;
        }

        public List<string> saveDataIgnoreList = new List<string> { "Feeder-Line Lift ", "Drinker-Line Lift " };

        private void SelectRandomCellAndEditItsContent(string content, int columnId)
        {
            var rnd = new Random();
            var rndIdx = ControllerTable.UIRows.Count() > 10 ? rnd.Next(1, 10) : rnd.Next(1, ControllerTable.UIRows.Count());

            EditCellContent(content, rndIdx, columnId);
        }
        public List<List<string>> EditAndGetSpecificRowContentOldAndNewValues(List<ITableColumn> ColumnsList, int row = 0)
        {
            List<string> cellValues = new List<string>();
            List<string> oldCellValues = new List<string>();
            List<List<string>> OldAndNewValues = new List<List<string>>();

            foreach (var columnName in ColumnsList)
            {
                if (!columnName.DisplayName.Contains("Date") && !saveDataIgnoreList.Contains(columnName.DisplayName))
                {
                    string currentColumn = (columnName.Group.ToString() + "_" + columnName.DisplayName);
                    oldCellValues.Add(GetCellCurrentValue(currentColumn, row));
                    cellValues.Add(EditCellContentInsideBoundaries(currentColumn, null, null, row));
                }
            }
            OldAndNewValues.Add(oldCellValues);
            OldAndNewValues.Add(cellValues);

            return OldAndNewValues;
        }
        public List<string> EditSpecificRowContent(List<ITableColumn> ColumnsList, int row = 0)
        {
            List<string> cellValues = new List<string>();

            foreach (var columnName in ColumnsList)
            {
                if (!columnName.DisplayName.Contains("Date") && !saveDataIgnoreList.Contains(columnName.DisplayName))
                {
                    string currentColumn = (columnName.Group.ToString() + "_" + columnName.DisplayName);
                    cellValues.Add(EditCellContentInsideBoundaries(currentColumn, null, null, row));
                }
            }
            return cellValues;
        }

        public void EditSpecificRowContent(List<ITableColumn> ColumnsList, List<string> CellValues, int row = 0)
        {
            var i = 0;
            foreach (var columnName in ColumnsList)
            {
                
                if (!columnName.DisplayName.Contains("Date") && !saveDataIgnoreList.Contains(columnName.DisplayName))
                {
                    string currentColumn = (columnName.Group.ToString() + "_" + columnName.DisplayName);
                    EditCellContent(CellValues[i], currentColumn);
                    try
                    {
                        if (KeyPadHelper.IsWarnningIconAppears)
                            KeyPadHelper.ExitEditMode();
                    }
                    catch {
                        KeyPadHelper.ExitEditMode();
                        continue;
                    }
                    i++;
                }
                
            }
        }

        public List<string> EditSpecificRowContentTempAndTimer(List<ITableColumn> ColumnsList, int row = 0)
        {
            List<string> cellValues = new List<string>();

            foreach (var columnName in ColumnsList)
            {
                if (columnName.DisplayName != "On")
                {
                    string currentColumn = (columnName.Group.ToString() + "_" + columnName.DisplayName);
                    cellValues.Add(EditCellContentInsideBoundaries(currentColumn, null, null, row));
                }
            }
            return cellValues;
        }

        public List<string> GetSpecificRowContentTempAndTimer(List<ITableColumn> ColumnsList, int row = 0)
        {
            List<string> cellValues = new List<string>();

            foreach (var columnName in ColumnsList)
            {
                if (columnName.DisplayName != "On")
                {
                    string currentColumn = (columnName.Group.ToString() + "_" + columnName.DisplayName);
                    cellValues.Add(GetCellCurrentValue(currentColumn, row));
                }
            }
            return cellValues;
        }

        public List<string> GetSpecificRowContent(List<ITableColumn> ColumnsList, int row = 0)
        {
            List<string> cellValues = new List<string>();

            foreach (var columnName in ColumnsList)
            {
                if (!columnName.DisplayName.Contains("Date") && !saveDataIgnoreList.Contains(columnName.DisplayName))
                {
                    string currentColumn = (columnName.Group.ToString() + "_" + columnName.DisplayName);
                    cellValues.Add(GetCellCurrentValue(currentColumn, row));
                }
            }
            return cellValues;
        }


        public List<string> GetBirdInventoryContent(List<ITableColumn> ColumnList, List<string> readOnlyFieldsBeforeEdit, int row = 0)
        {
            List<string> cellValues = new List<string>();

            for (int i = 0; i < ColumnList.Count; i++)
            {
                string currentColumn = (ColumnList[i].Group.ToString() + "_" + ColumnList[i].DisplayName);
                int currentValue = Convert.ToInt32(GetCellCurrentValue(currentColumn, row).Replace(",", string.Empty));
                int calculatedDiff = currentValue - Convert.ToInt32(readOnlyFieldsBeforeEdit[i].Replace(",", string.Empty));
                cellValues.Add(calculatedDiff.ToString());
            }
            return cellValues;
        }

        #endregion

        protected GridTablePage() { }
        public GridTablePage(Metadata metadata)
        {
            ControllerTable = new GridTableService(metadata);
        }
        public ISystemInputMethod LastInputMethodTypeWasActivated { get; private set; }

        public virtual InputRange GetColumnRange(ITableColumn column)
        {
            InputRange range = new InputRange();
            try
            {
                Rows = ControllerTable.UIRows;
                Headers = ControllerTable.UITableHeader;

                int colIdx = Headers.GetColumnIndexByColumnId(column.Id);

                if (colIdx == -1)
                    throw new ArgumentException(string.Format("Column ID: {0} not found.", column.Id));

                var inputMethod = ControllerTable.GetColumnInputMethod(column.Id);

                if ((inputMethod == null) && (column.IsReadOnly)) return new InputRange();

                // add new
                if (inputMethod is ISystemKeyPad)
                    KeyPadHelper.ExitEditMode();

                var uiRow = Rows.ToList().First();
                var cell = uiRow.FindElements(By.CssSelector("td[role='gridcell']"))[colIdx];
                //for default vlaue -
                //var currentValue = cell.Text;
                if (inputMethod is ISystemKeyPad)
                {
                    cell.JavaDoubleClickAndWait();
                }
                
                else
                {
                    cell.DoubleClick();
                }

                DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
                DriverManager.Driver.WaitForAjax();

                if (column is ButtonsGroupColumn)
                {
                    (inputMethod as ButtonsGroup).InitUiElement(cell);
                }
                else if (column is CheckBoxColumn)
                {
                    (inputMethod as TouchCheckBox).InitUiElement(cell);
                }
                else if (column is ComboBoxColumn)
                {
                    var comboBox = cell.FindElement(By.TagName("select"));
                    (inputMethod as TouchComboBox).InitUiElement(comboBox);
                }
                else if (column is OnOffButtonColumn)
                {
                    (inputMethod as TouchToggleButton).InitUiElement(cell);
                }

                range = inputMethod.GetRange();
                //for default value -
                //range.DefaultValue = currentValue;
                if (inputMethod is ISystemKeyPad)
                    KeyPadHelper.ExitEditMode();

                return range;
            }
            catch { return null; }
        }

        public decimal CalculateTotalArea()
        {
            var Height = Decimal.Parse(GetCellForHouseDimensions("Height").Text);
            var Width = Decimal.Parse(GetCellForHouseDimensions("Width").Text);
            var WallHeight = Decimal.Parse(GetCellForHouseDimensions("WallHeight").Text);
            return WallHeight * Width + (Height - WallHeight) * Width / 2; 
        }

        public IWebElement GetCellForHouseDimensions(string cellToCheck)
        {
            switch (cellToCheck)
            {
                case "Height":
                    return DriverManager.Driver.FindElement(By.XPath("//*[@id='ngViewContainer']/div/div/div/div[2]/div/div[1]/div/div[1]/div[1]/span"));
                case "Width":
                    return DriverManager.Driver.FindElement(By.XPath("//*[@id='ngViewContainer']/div/div/div/div[2]/div/div[1]/div/div[1]/div[2]/span"));
                case "WallHeight":
                    return DriverManager.Driver.FindElement(By.XPath("//*[@id='ngViewContainer']/div/div/div/div[2]/div/div[1]/div/div[1]/div[3]/span"));
                default:
                    return DriverManager.Driver.FindElement(By.XPath("//*[@id='ngViewContainer']/div/div/div/div[2]/div/div[1]/div/div[3]/p[2]/span"));
            }
        }

        public InputRange GetHouseDimensionsCellRange(IWebElement cell)
        {
            cell.JavaDoubleClickAndWait();
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            var inputMethod = KeyPadFactory.GetActiveKeyPadType();
            var range = inputMethod.GetRange();

            if (inputMethod is ISystemKeyPad)
                KeyPadHelper.ExitEditMode();

            return range;
        }

        public string SetRandomValueHouseDimensionsCell(IWebElement cell)
        {
            cell.JavaDoubleClickAndWait();
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            var inputMethod = KeyPadFactory.GetActiveKeyPadType();
            var range = inputMethod.GetRange();
            Random rnd = new Random();
            var valueToSet = rnd.Next((int)Convert.ToDouble(range.Minimum), (int)Convert.ToDouble(range.Maximum)).ToString();
            inputMethod.SetValue(valueToSet);
            return valueToSet;
        }

        public string GetCurrentValueHouseDimensionsCell(IWebElement cell)
        {
            cell.JavaDoubleClickAndWait();
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            var inputMethod = KeyPadFactory.GetActiveKeyPadType();
            var range = inputMethod.GetRange();
            if (inputMethod is ISystemKeyPad)
                KeyPadHelper.ExitEditMode();
            return inputMethod.CurrentValue;
        }

        public virtual InputRange GetColumnRange(string colName)
        {
            var column = GetTableColumnByColumnName(colName);
            return GetColumnRange(column);
        }

        public virtual InputRange GetColumnRangeForHouseDimensions(string cellName)
        {
            var cell = GetCellForHouseDimensions(cellName);
            return GetHouseDimensionsCellRange(cell);
        }
        
        public string SetRandomValueForHouseDimensions(string cellName)
        {
            var cell = GetCellForHouseDimensions(cellName);
            return SetRandomValueHouseDimensionsCell(cell);
        }

        public string GetCurrentValueForHouseDimensions(string cellName)
        {
            var cell = GetCellForHouseDimensions(cellName);
            return cell.Text;
        }
        public virtual string GetCellCurrentValue(string colName, int rowNumber = 0)
        {
            var inputMethod = GetActualInputMethod(colName, rowNumber);
            var column = GetTableColumnByColumnName(colName);
            var colIdx = ControllerTable.UITableHeader.GetColumnIndexByColumnId(column.Id);
            var uiRow = ControllerTable.UIRows.ToList()[rowNumber];
            var cell = uiRow.FindElements(By.CssSelector("td[role=\"gridcell\"]"))[colIdx];

            if (inputMethod is StateCycleKeyPad)
            {
                return inputMethod.CurrentValue;
            }
            if (inputMethod is ButtonsGroup)
            {
                inputMethod = new ButtonsGroup(cell);
                return inputMethod.CurrentValue;
            }
            if (inputMethod is TouchCheckBox)
            {
                inputMethod = new TouchCheckBox(cell);
                return inputMethod.CurrentValue;
            }
            if (inputMethod is TouchComboBox)
            {
                var comboCell = cell.FindElement(By.TagName("select"));
                inputMethod = new TouchComboBox(comboCell);
                return inputMethod.CurrentValue;
            }
            if (inputMethod is TouchToggleButton)
            {
                var toggle = cell.FindElement(By.TagName("label"));
                inputMethod = new TouchToggleButton(toggle);
                return inputMethod.CurrentValue;
            }
            if (inputMethod is ISystemKeyPad)
            {
                KeyPadHelper.ExitEditMode();
            }

            return cell.Text;
        }
        public virtual bool IsTableElementAsExpected(string elementThatShouldBeFound, string colName, int rowNumber = 0)
        {
            var column = GetTableColumnByColumnName(colName);
            var colIdx = ControllerTable.UITableHeader.GetColumnIndexByColumnId(column.Id);
            var uiRow = ControllerTable.UIRows.ToList()[rowNumber];
            var cell = uiRow.FindElements(By.TagName("td"))[colIdx];

            if (cell.Text == elementThatShouldBeFound)
                return true;

            return false;
        }
        public List<ITableColumn> EditableColumns
        {
            get
            {
                return ControllerTable.TableMetadata.Where(column => !column.IsReadOnly && column.DisplayName != "").ToList();
            }
        }
        public List<ITableColumn> EditableColumnsAlarmReset
        {
            get
            {
                return ControllerTable.TableMetadata.Where(column => !column.IsReadOnly && column.DisplayName == "").ToList();
            }
        }
        public List<ITableColumn> ReadonlyColumns
        {
            get
            {
                return ControllerTable.TableMetadata.Where(column => column.IsReadOnly && column.DisplayName != "").ToList();
            }
        }
        public virtual void EditCellContent(string content, int row, string column, string @group = "")
        {
            int columnId = group.GetHashCode() + column.GetHashCode();
            EditCellContent(content, row, columnId);
        }
        public virtual void EditCellContent(string content, int row, ITableColumn column)
        {
            EditCellContent(content, row, column.Id);
        }
        public virtual void EditCellContent(object content, string columnName, int row = 0)
        {
            var column = GetTableColumnByColumnName(columnName);
            EditCellContent(content, row, column.Id);
        }
        public virtual void EditCellContent(object content, string columnName, string rowName)
        {
            var column = GetTableColumnByColumnName(columnName);
            EditCellContentByRowName(content, rowName, column.Id);
        }
        public virtual string EditCellContent(string columnName, int row = 0)
        {
            var column = GetTableColumnByColumnName(columnName);
            var actualRange = GetColumnRange(column);
            var valueInsideTheRange = column.InputMethod.GetTestingRange(actualRange).Inside;
            EditCellContent(valueInsideTheRange, columnName, row);

            return valueInsideTheRange;
        }
        public virtual string EditCellContentInsideBoundaries(string columnName, string fixedUpperBoundary = null, string fixedLowerBoundary = null, int row = 0)
        {
            var column = GetTableColumnByColumnName(columnName);
            var actualRange = GetColumnRange(columnName);
            string valueInsideTheRange;
            if (fixedUpperBoundary != null) actualRange.Maximum = fixedUpperBoundary;
            if (fixedLowerBoundary != null) actualRange.Minimum = fixedLowerBoundary;
            valueInsideTheRange = columnName.Contains("Day") ? "6" : column.InputMethod.GetTestingRange(actualRange).Inside;
            EditCellContent(valueInsideTheRange, columnName, row);

            return valueInsideTheRange;
        }
        public virtual string EditCellContentThatLowerBoundary(string columnName, string fixedLowerBoundary, int row = 0)
        {
            var column = GetTableColumnByColumnName(columnName);
            var actualRange = GetColumnRange(columnName);
            actualRange.Minimum = fixedLowerBoundary;
            var time = fixedLowerBoundary.Split(':');
            if (time.Count() > 1)
            {
                actualRange.MinimumHours = time[0];
                actualRange.MinimumMinutes = time[1];
            }
            var valueInsideTheRange = column.InputMethod.GetTestingRange(actualRange).Inside;
            EditCellContent(valueInsideTheRange, columnName, row);

            return valueInsideTheRange;
        }
        public virtual string EditCellContentThatUpperBoundary(string columnName, string fixedUpperBoundary, int row = 0)
        {
            var column = GetTableColumnByColumnName(columnName);
            var actualRange = GetColumnRange(columnName);
            actualRange.Maximum = fixedUpperBoundary;
            var time = fixedUpperBoundary.Split(':');
            if (time.Count() > 1)
            {
                actualRange.MaximumHours = time[0];
                actualRange.MaximumMinutes = time[1];
            }
            var valueInsideTheRange = column.InputMethod.GetTestingRange(actualRange).Inside;
            EditCellContent(valueInsideTheRange, columnName, row);

            return valueInsideTheRange;
        }
        public virtual string EditRandomCellContent(string columnName, int row = 0)
        {
            var column = GetTableColumnByColumnName(columnName);
            var actualRange = GetColumnRange(columnName);
            var valueInsideTheRange = column.InputMethod.GetTestingRange(actualRange).Inside;
            SelectRandomCellAndEditItsContent(valueInsideTheRange, column.Id);

            return valueInsideTheRange;
        }
        public virtual void SelectRandomCellAndEditItsContent(string content, string column, string @group = "")
        {
            int columnId = column.GetHashCode() + group.GetHashCode();
            SelectRandomCellAndEditItsContent(content, columnId);
        }
        public virtual void SelectRandomCellAndEditItsContent(string content, ITableColumn column)
        {
            SelectRandomCellAndEditItsContent(content, column.Id);
        }
        public virtual bool IsEditingEnable(string content, ITableColumn column)
        {
            Rows = ControllerTable.UIRows;
            Headers = ControllerTable.UITableHeader;

            if (!column.IsReadOnly) return true;

            int colIdx = Headers.GetColumnIndexByColumnId(column.Id);

            if (colIdx == -1)
                throw new ArgumentException(string.Format("Column ID: {0} not found.", colIdx));

            ExitEditingMode();

            var rnd = new Random();
            var rndIdx = Rows.Count() > 10 ? rnd.Next(1, 10) : rnd.Next(0, Rows.Count());
            var uiRow = Rows.ToList()[rndIdx];
            var cell = uiRow.FindElements(By.CssSelector("td[role]"))[colIdx];

            cell.JavaDoubleClickAndWait();

            try
            {
                var keypadFloatContainer = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
                return (keypadFloatContainer.GetAttribute("class") != "ng-hide");
            }
            catch
            {
                return false;
            }
        }
        public virtual int GetRowNumberThatContainSpecificContent(string content, string colName)
        {
            Rows = ControllerTable.UIRows;
            Headers = ControllerTable.UITableHeader;
            var column = GetTableColumnByColumnName(colName);
            var colIdx = Headers.GetColumnIndexByColumnId(column.Id);
            var rowNumberToReturn = 0;

            foreach (var row in Rows.ToList())
            {
                if (row.FindElements(By.TagName("td"))[colIdx].Text == content) break;
                rowNumberToReturn++;

                if (Rows.ToList().Count == rowNumberToReturn) rowNumberToReturn = -1;
            }

            return rowNumberToReturn;
        }
        public void ExitEditingMode()
        {
            CancelChanges();
        }
        public void SaveChanges()
        {
            Waits.Wait(3);
            var saveModal = DriverManager.Driver.TryFindElement(By.CssSelector("div[class='confirm-save-modal']"));
            
            if (saveModal == null)
            {
                var btnsPlaceHolder = DriverManager.Driver.FindElement(By.Id("saveAndCancelPlaceholder"));
                if (!btnsPlaceHolder.GetAttribute("class").Contains("ng-hide"))
                {
                    //DriverManager.Driver.FindElement(By.CssSelector("button[ng-click='saveEdit()']")).TryToClick();
                    DriverManager.Driver.FindElement(By.CssSelector("button[ng-click='saveEdit()']")).Click();
                }
            }
            else
            {
                saveModal.FindElement(By.CssSelector("div[class='saveAndCancel'] button[ng-click='confirmDialog.okCallback()']")).TryToClick();
            }
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            DriverManager.Driver.WaitForDomReady();
            //while (!DriverManager.Driver.FindElement(By.Id("saveAndCancelPlaceholder")).GetAttribute("class").Contains("ng-hide"))
            //    Waits.Wait(1);
            Waits.Wait(10);
        }
        public void CancelChanges()
        {
            var saveModal = DriverManager.Driver.TryFindElement(By.CssSelector("div[class='confirm-save-modal']"));

            if (saveModal == null)
            {
                var btnsPlaceHolder = DriverManager.Driver.FindElement(By.Id("saveAndCancelPlaceholder"));
                if (!btnsPlaceHolder.GetAttribute("class").Contains("ng-hide"))
                {
                    DriverManager.Driver.FindElement(By.CssSelector("button[ng-click='cancelEdit()']")).JavaClickAndWait();
                }
            }
            else
            {
                saveModal.FindElement(By.CssSelector("div[class='saveAndCancel'] button[class*='btn btn-cancel']")).JavaClickAndWait();
            }

            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
        }
        public RangeUnderTest RangeValidation(string colName)
        {
            Headers = ControllerTable.UITableHeader;

            var column = GetTableColumnByColumnName(colName);
            var range = GetColumnRange(column);
            var colIdx = Headers.GetColumnIndexByColumnId(column.Id);

            if (colIdx == -1)
                throw new ArgumentException(string.Format("Column ID: {0} not found.", column.Id));

            var inputMethod = ControllerTable.GetColumnInputMethod(column.Id);
            if ((inputMethod == null) && (column.IsReadOnly))
            {
                return new RangeUnderTest(range)
                {
                    IsAboveTestPassed = true,
                    IsBelowTestPassed = true,
                    IsInsideTestPassed = true,
                    IsMaxValueTestPassed = true,
                    IsMinValueTestPassed = true
                };
            }

            if (inputMethod == null)
                throw new NullReferenceException(string.Format("The column {0} input method is null.", colName));

            var testingRange = inputMethod.GetTestingRange(range);

            if (inputMethod is StateCycleKeyPad) return testingRange;
            if (!(inputMethod is BaseNumericKeyPad)) return testingRange;

            if (testingRange.Below != null)
            {
                EditCellContent(testingRange.Below, colName);
                testingRange.IsBelowTestPassed = KeyPadHelper.IsWarnningIconAppears;
                KeyPadHelper.ExitEditMode();
            }
            EditCellContent(testingRange.MinValue, colName);
            testingRange.IsMinValueTestPassed = !KeyPadHelper.IsWarnningIconAppears;

            EditCellContent(testingRange.Inside, colName);
            testingRange.IsInsideTestPassed = !KeyPadHelper.IsWarnningIconAppears;

            EditCellContent(testingRange.MaxValue, colName);
            testingRange.IsMaxValueTestPassed = !KeyPadHelper.IsWarnningIconAppears;

            EditCellContent(testingRange.Above, colName);
            testingRange.IsAboveTestPassed = KeyPadHelper.IsWarnningIconAppears;
            KeyPadHelper.ExitEditMode();

            return testingRange;
        }
        public override ITablePageExpectedView ExpectedView { get { return ExpectedView; } }
    }

    public class GridTablePage<T> : GridTablePage where T : class, IMetadataDependentPageObject
    {
        public GridTablePage()
        {
            if (ControllerTable != null) return;

            var metadata = MetadataFactory.GetMetadata<T>();
            ControllerTable = new GridTableService(metadata);
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
        }
        public override ITablePageExpectedView ExpectedView
        {
            get { return new GridTableExpectedView<T>(); }
        }
        public string GetDefaultValue(string colName)
        {
            var column = GetTableColumnByColumnName(colName);
            var colIdx = ControllerTable.UITableHeader.GetColumnIndexByColumnId(column.Id);

            var uiRow = ControllerTable.UIRows.ToList().First();
            var cell = uiRow.FindElements(By.TagName("td"))[colIdx];
            var checkbox = cell.FindElements(By.CssSelector("input[type=\"checkbox\"]"));

            return checkbox.Count == 0 ? cell.Text : checkbox[0].Selected.ToString();
        }
        public bool IsTableSorted(string colName)
        {
            var column = GetTableColumnByColumnName(colName);
            var colIdx = ControllerTable.UITableHeader.GetColumnIndexByColumnId(column.Id);
            var columnRange = GetColumnRange(colName);

            var uiRows = ControllerTable.UIRows.ToList().Select(row => double.Parse(row.FindElements(By.TagName("td"))[colIdx].Text));
            var relevantCells = uiRows.Where(row => row >= double.Parse(columnRange.Minimum) && row <= double.Parse(columnRange.Maximum)).ToList();
            List<double> sortedCells = new List<double>();
            var dayBasedComparer = new DayBasedComparer();

            sortedCells.AddRange(relevantCells);
            sortedCells.Sort(dayBasedComparer);
            sortedCells.Sort(dayBasedComparer);
            if (sortedCells.SequenceEqual(relevantCells))
                return true;
            return false;
        }
        public bool IsTableSorted(string colName, string firstcolumnValue, string secondColumnValue)
        {
            var columnRange = GetColumnRange(colName);

            var column = GetTableColumnByColumnName(colName);
            var colIdx = ControllerTable.UITableHeader.GetColumnIndexByColumnId(column.Id);

            var uiRows = ControllerTable.UIRows.ToList().Select(row => double.Parse(row.FindElements(By.TagName("td"))[colIdx].Text));
            var relevantCells = uiRows.Where(row => row >= double.Parse(columnRange.Minimum) && row <= double.Parse(columnRange.Maximum)).ToList();

            //Return true if rows sorted otherwise false
            return ((Convert.ToDouble(firstcolumnValue) == relevantCells[1]) &&
                    (Convert.ToDouble(secondColumnValue) == relevantCells[0]));
        }
        public bool IsTimeRowsSorted(string timeColumn, string editedDayColumnVariable)
        {
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            Rows = ControllerTable.UIRows;
            Headers = ControllerTable.UITableHeader;

            var timeCol = GetTableColumnByColumnName(timeColumn);
            var timeIdx = Headers.GetColumnIndexByColumnId(timeCol.Id);

            var dayCol = GetTableColumnByColumnName("Day");
            var dayIdx = Headers.GetColumnIndexByColumnId(dayCol.Id);

            var hour = 0;
            var minutes = 0;
            var firstIndx = 0;
            foreach (var row in Rows.ToList())
            {
                if (row.FindElements(By.TagName("td"))[dayIdx].Text == editedDayColumnVariable) break;
                firstIndx++;
            }

            if (firstIndx == Rows.Count())
                throw new Exception(string.Format("The requested day {0} does not exist in the table.", editedDayColumnVariable));

            var timeRows = Rows.ToList().Select(row => row.FindElements(By.TagName("td"))[timeIdx].Text).ToList();
            var filteredRows = new List<string>() { timeRows[firstIndx], timeRows[firstIndx + 1] };

            foreach (var row in filteredRows)
            {
                var time = row.ToString().Split(':');
                if (int.Parse(time[0]) < hour)
                {
                    return false;
                }
                if (int.Parse(time[0]) == hour)
                {
                    if (int.Parse(time[1]) < minutes)
                    {
                        return false;
                    }
                }
                hour = int.Parse(time[0]);
                minutes = int.Parse(time[1]);
            }
            return true;
        }
    }

    public class GridTableExpectedView<T> : ITablePageExpectedView where T : class, IMetadataDependentPageObject
    {
        public GridTableExpectedView()
        {
            Metadata = MetadataFactory.GetMetadata<T>();
            PageObject = MetadataFactory.GetOwnerPage(Metadata);
        }
        public IPageObject PageObject { get; set; }
        public Metadata Metadata { get; set; }
        public virtual int GetExpectedColumnsCount()
        {
            if ((PageObject as IApplicationPageTab) != null)
                return ConfigurationsManager.GetTabColumnsCount<T>();

            return ConfigurationsManager.GetColumnsCount(PageObject as IApplicationPage);
        }
        public virtual TableHeader GetExpectedTableHeader()
        {
            if ((PageObject as IApplicationPageTab) != null)
                return ConfigurationsManager.GetTabTableHeader<T>();

            return ConfigurationsManager.GetTableHeader(PageObject as IApplicationPage);
        }
        public virtual ISystemInputMethod GetExpectedInputMethod(ITableColumn column)
        {
            if ((PageObject as IApplicationPageTab) != null)
                return ConfigurationsManager.GetTabInputMethod<T>(column);

            return ConfigurationsManager.GetInputMethod(PageObject as IApplicationPage, column);
        }
    }
}
