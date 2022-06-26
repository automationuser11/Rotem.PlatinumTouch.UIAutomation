using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode
{
    public class ReadonlyGridTablePage : TablePageService, IReadonlyTablePage 
    {
        public ReadonlyGridTablePage() { }
        public ReadonlyGridTablePage(DataTable metadata)
        {
            ControllerTable =  new GridTableService(metadata);
        }
        public ReadonlyGridTablePage(Metadata metadata)
        {
            ControllerTable = new GridTableService(metadata);
        }

        public bool IsHeadersAlreadyRead { get; set; }
        public bool IsEditingEnable(string content, ITableColumn column)
        {
            if (!IsHeadersAlreadyRead)
            {
                Rows = ControllerTable.UIRows;
                Headers = ControllerTable.UITableHeader;
                IsHeadersAlreadyRead = true;
            }

            if (column.IsReadOnly) return false;

            var inputMethod =  GetActualInputMethod(column);
            return inputMethod != null;
        }
        public virtual bool IsTableEmpty()
        {
            for (int i = 0; i < RowsCount; i++)
            {
                if (TableHeader.FlatHeaderStructure.Select(header => GetCellCurrentValue(header.Name, i))
                               .Any(currentCellValue => (currentCellValue != "0") && (currentCellValue != "N/A")))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsDataChanged(List<string> row, int rowIndex)
        {
            var columnIndex = 0;

            foreach (var tableHeader in TableHeader.HeaderStructure)
            {
                var originalValue = row[columnIndex++];
                if (tableHeader.SubColumns == null)
                {
                    var currentValue = GetCellCurrentValue(tableHeader.Name, rowIndex);
                    if (originalValue != currentValue)
                    {
                        return false;
                    }
                }
                else
                {
                    foreach (var subColumn in tableHeader.SubColumns)
                    {
                        var currentValue = GetCellCurrentValue(string.Format("{0}_{1}", tableHeader.Name, subColumn.Name), rowIndex);
                        if (originalValue != currentValue)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public virtual string GetLastRowCellCurrentValue(string columnName)
        {
            var js = (IJavaScriptExecutor)DriverManager.Driver;
            js.ExecuteScript("$('#grid0 .k-scrollbar').scrollTop($('#grid0 .k-scrollbar div').height());", null);

            return GetCellCurrentValue(columnName, ControllerTable.UIRows.Count() - 1);
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

            return cell.Text;
        }
        public void ExitEditMode()
        {
            var keypadFloatContainer = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            if (keypadFloatContainer.GetAttribute("class") == "ng-hide") return;

            var okBtn = keypadFloatContainer.FindElements(By.CssSelector("button[data-key-value='ok']")).First(btn => btn.Displayed);
            okBtn.JavaClickAndWait();
        }
        public override ITablePageExpectedView ExpectedView
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class ReadonlyGridTablePage<T> : ReadonlyGridTablePage where T : class, IMetadataDependentPageObject, new()
    {
        public ReadonlyGridTablePage()
        {
            if (ControllerTable != null) return;

            var metadata = MetadataFactory.GetMetadata<T>();
            ControllerTable = new GridTableService(metadata);
        }
    }
}
