using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView
{
    public class TableHeader
    {
        private readonly IWebElement _uiTable;
        public TableHeader(IWebElement table)
        {
            try
            {
                DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
                DriverManager.Driver.WaitForAjax();
                DriverManager.Driver.WaitForDomReady();
                _uiTable = table.TagName == "table" ? table : table.WaitForFieldToBeLoaded(By.TagName("table"));
            }
            catch (NoSuchElementException e)
            {
                throw new NoSuchElementException(e.Message + "UI element is not of type Html table");
            }

            InitializeHeaderStructure();
        }
        public TableHeader(IEnumerable<ITableColumn> table)
        {
            InitializeHeaderStructure(table);
        }
        private void InitializeHeaderStructure(IEnumerable<ITableColumn> table)
        {
            HeaderStructure = new List<TableHeaderColumn>();

            var tableColumns = table as IList<ITableColumn> ?? table.ToList();
            var groups = tableColumns.GroupBy(item => item.Group ?? item.DisplayName);

            int index = 0;
            foreach (var group in groups)
            {
                TableHeaderColumn column;

                if (group.Count() == 1) // Handle the cases of column with no group, and a group with only one column.
                {
                    if(group.Single().Group == null)
                        column = new TableHeaderColumn(group.Single()) { Index = index++ };
                    else
                    {
                        column = new TableHeaderColumn(group.Single()) { Name = group.Key.Trim(), Index = -1, IsGroupColumn = true, SubColumns = new List<TableHeaderColumn>(1) };
                        var subColumn = new TableHeaderColumn(group.Single()) { Index = index++, GroupName = group.Key.Trim(), IsGroupColumn = false };
                        column.SubColumns.Add(subColumn);
                    }
                }
                else
                {
                    column = new TableHeaderColumn(group.First());
                    column.Name = group.Key.Trim();
                    column.Index = -1;
                    column.IsGroupColumn = true;
                    column.SubColumns = new List<TableHeaderColumn>(1); 
                    foreach (ITableColumn colGroup in group)
                    {
                        var subColumn = new TableHeaderColumn(colGroup) { Index = index++, GroupName = group.Key.Trim(), IsGroupColumn = false };
                        column.SubColumns.Add(subColumn);
                    }
                }

                HeaderStructure.Add(column);
            }
        }
        private void InitializeHeaderStructure()
        {
            var headerElement = _uiTable.FindElement(By.TagName("thead"));
            var uiColumns = headerElement.FindElements(By.CssSelector("th[data-title]"));
            var currentIdx = 0;
            var js = (IJavaScriptExecutor)DriverManager.Driver;
            HeaderStructure = new List<TableHeaderColumn>();
            foreach (var uiColumn in uiColumns)
            {
                js.ExecuteScript("arguments[0].scrollIntoView(true);", uiColumn);
                if (uiColumn.Text != string.Empty)
                    HeaderStructure.Add(new TableHeaderColumn(uiColumn));
                else {
                    currentIdx = 1;
                }
            }

            // Now we have all Columns object in the correct order as a flat list, lets creates the header hierarchy
            //var currentIdx = 0;
            for (var i = 0; i < HeaderStructure.Count; i++)
            {
                if (HeaderStructure[i].Index == -1) // -1 means that current column is a group column.
                {
                    for (var j = 0; j < HeaderStructure[i].SubColumns.Capacity; j++)
                    {
                        try
                        {
                            var column = HeaderStructure.Single(col => col.Index == currentIdx + j);
                            HeaderStructure.Remove(column);
                            column.GroupName = HeaderStructure[i].Name.Trim();
                            HeaderStructure[i].SubColumns.Add(column);
                        }
                        catch (InvalidOperationException ex)
                        {
                            throw new InvalidOperationException(string.Format("{0} for HeaderStructure[{1}] column index {2}.", ex.Message, i, currentIdx + j));
                        }
                    }
                }

                currentIdx = HeaderStructure[i].SubColumns != null ? HeaderStructure[i].SubColumns.Last().Index + 1 : currentIdx + 1;
            }

            // In case of accordion header 
            if (HeaderStructure.TrueForAll(column => column.Index == 0))
            {
                for (var i = 0; i < HeaderStructure.Count; i++)
                {
                    HeaderStructure[i].Index = i;
                }
            }
        }
        public List<TableHeaderColumn> HeaderStructure { get; set; }

        public List<TableHeaderColumn> FlatHeaderStructure
        {
            get
            {
                if(HeaderStructure == null) 
                    InitializeHeaderStructure();

                var flatHeader = new List<TableHeaderColumn>();
                foreach (var column in HeaderStructure)
                {
                    if (!column.IsGroupColumn)
                        flatHeader.Add(column);
                    else
                    {
                        flatHeader.AddRange(column.SubColumns);
                    }
                }

                return flatHeader;
            }
        }

        public int GetColumnIndexByColumnId(int columnId)
        {
            try {
                return (FlatHeaderStructure.Single(column => column.Id == columnId)).Index;
            }
            catch (InvalidOperationException)
            {
                //the if statement is a patch for wrong generated id of "Value" column at "Bird Weight" table
                if (columnId == -2119751731)
                    return FlatHeaderStructure.SingleOrDefault(c => c.Name == "Value").Index;
                return (FlatHeaderStructure.Last(column => column.Id == columnId)).Index;
            }
            throw new ArgumentException(string.Format("Column ID: {0} was not found.", columnId));
        }
        protected bool Equals(TableHeader other)
        {
            if (HeaderStructure.Count != other.HeaderStructure.Count)
                return false;

            for (int i = 0; i < HeaderStructure.Count; i++)
            {
                if (!HeaderStructure[i].Equals(other.HeaderStructure[i]))
                    return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((TableHeader)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return ((_uiTable != null ? _uiTable.GetHashCode() : 0) * 397) ^ (HeaderStructure != null ? HeaderStructure.GetHashCode() : 0);
            }
        }
        public override string ToString()
        {
            var msg = string.Empty;
            foreach (var column in HeaderStructure)
            {
                msg += column.ToString();
                msg += Environment.NewLine;
            }

            return msg;
        }
        public class TableHeaderColumn
        {
            public string Name { get; internal set; }
            public bool IsGroupColumn { get; internal set; }
            public int Index { get; internal set; }
            public List<TableHeaderColumn> SubColumns { get; internal set; }
            public string GroupName { get; internal set; }
            public int Id
            {
                get
                {
                    var id = GroupName == null ? "0".GetHashCode() : GroupName.GetHashCode();
                    id += Name == null ? string.Empty.GetHashCode() : Name.GetHashCode();

                    return id;
                }
            }
            public TableHeaderColumn(IWebElement column)
            {
                if (column.TagName != "th")
                    throw new ArgumentException("UI element is not of type 'th'");

                Name = column.Text.Trim();

                // Accordion table does not support group column, therefore retrun if that the case...
                // Read this comment if accordion tests fails. It does not seem a condition to differentiate between accordion
                // table and not accordion tables.
                //if ((column.GetAttribute("class") != "k-header ng-scope") && (column.GetAttribute("class") != "k-header ng-scope k-first")) return; 
                try
                {
                    IsGroupColumn = column.GetAttribute("data-index") == null;
                }
                catch (Exception e)
                {
                    Thread.Sleep(3000);
                    IsGroupColumn = column.GetAttribute("data-index") == null;
                }
                Index = IsGroupColumn ? -1 : int.Parse(column.GetAttribute("data-index"));

                if (IsGroupColumn)
                {
                    int subColumnCount;
                    int.TryParse(column.GetAttribute("colspan"), out subColumnCount);
                    SubColumns = subColumnCount == 0 ?  new List<TableHeaderColumn>(1) : new List<TableHeaderColumn>(subColumnCount);
                }
            }
            public TableHeaderColumn(ITableColumn column)
            {
                Name = column.DisplayName.Trim();
                IsGroupColumn = column.Group != null;
            }
            protected bool Equals(TableHeaderColumn other)
            {
                var isEqual = string.Equals(Name, other.Name) && IsGroupColumn.Equals(other.IsGroupColumn) && Index == other.Index && string.Equals(GroupName, other.GroupName);

                if (other.IsGroupColumn)
                {
                    if (SubColumns == null && other.SubColumns != null) return false;
                    if (SubColumns != null && other.SubColumns == null) return false;
                    if (SubColumns.Count != other.SubColumns.Count) return false;
                    if (SubColumns != null && other.SubColumns != null)
                    {
                        for (int i = 0; i < SubColumns.Count; i++)
                        {
                            if (!SubColumns[i].Equals(other.SubColumns[i]))
                                return false;
                        }
                    }    
                }

                return isEqual;
            }
            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != GetType()) return false;
                return Equals((TableHeaderColumn)obj);
            }
            public override int GetHashCode()
            {
                unchecked
                {
                    int hashCode = (Name != null ? Name.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ IsGroupColumn.GetHashCode();
                    hashCode = (hashCode * 397) ^ Index;
                    hashCode = (hashCode * 397) ^ (SubColumns != null ? SubColumns.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (GroupName != null ? GroupName.GetHashCode() : 0);
                    return hashCode;
                }
            }
            public override string ToString()
            {
                if (!IsGroupColumn) return Name;

                string msg = string.Empty;
                var subCol = SubColumns.Select(item => item.Name);
                var groupName = SubColumns.First().GroupName;

                var header = subCol.Aggregate(msg, (current, columnName) => current + (groupName + ": " + columnName + ","));
                return header.TrimEnd(',');
            }
        }
    }
}
