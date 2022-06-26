using System;
using System.Collections.Generic;
using System.Linq;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.Mortality
{
    public class MortalityHistoryPage : IApplicationPage, ITableViewProvider<ReadonlyGridTablePage<MortalityHistoryPage>>, IGraphViewProvider<SimpleGraphPage>, IMetadataDependentPageObject
    {
        private List<List<string>> _rows;
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<MortalityHistoryPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Mortality History"; }
        }
        public string MenuName
        {
            get { return "Mortality"; }
        }
        public string SubMenu { get { return "History"; } }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public Metadata Metadata { get; set; }
        public ReadonlyGridTablePage<MortalityHistoryPage> TableView
        {
            get { return _tableView ?? (_tableView = new ReadonlyGridTablePage<MortalityHistoryPage>()); }
        }
        private ReadonlyGridTablePage<MortalityHistoryPage> _tableView;
        public SimpleGraphPage GraphView
        {
            get { return _graphPage ?? (_graphPage = new SimpleGraphPage()); }
        }
        private SimpleGraphPage _graphPage;
        public void SaveState()
        {
            _rows = _rows ?? new List<List<string>>();
            _rows.Clear();

            var rowsCount = TableView.RowsCount;
            for (int i = 0; i < rowsCount; i++)
            {
                var row = new List<string>();
                foreach (var tableHeader in TableView.TableHeader.HeaderStructure)
                {
                    if (tableHeader.SubColumns == null)
                    {
                        row.Add(TableView.GetCellCurrentValue(tableHeader.Name, i));
                    }
                    else
                    {
                        row.AddRange(tableHeader.SubColumns.Select(subColumn => TableView.GetCellCurrentValue(string.Format("{0}_{1}", tableHeader.Name, subColumn.Name), i)));
                    }                 
                }

                _rows.Add(row);
            }
        }
        public bool IsTableEmpty()
        {
            if (TableView.RowsCount != 1) return false;

            var header = TableView.TableHeader.FlatHeaderStructure;
            var columnsCount = TableView.TableHeader.FlatHeaderStructure.Count - 3;

            if (TableView.GetCellCurrentValue(header[0].Name) != "1") return false;

            for (int i = 1; i < columnsCount; i++)
            {
                var currentValue = TableView.GetCellCurrentValue(header[i].Name, i);
                if (currentValue != "0") return false;
            }

            return true;
        }
        public bool IsDataChanged(string deadFemales, string deadMales)
        {
            if (TableView.RowsCount != _rows.Count + 1) return false;

            for (int i = 0; i < _rows.Count(); i++)
            {
                if(TableView.IsDataChanged(_rows.ElementAt(i), i))
                {
                    return false;
                }
            }

            var lastRowIndex = TableView.RowsCount - 1;
            var currenDeadMales = TableView.GetCellCurrentValue("Dead Birds_Male", lastRowIndex);
            var currenDeadFemales = TableView.GetCellCurrentValue("Dead Birds_Female", lastRowIndex);
            
            if ((deadFemales != currenDeadFemales) || (deadMales != currenDeadMales))
                return false;

            return true;
        }
    }
}
