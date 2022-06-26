using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface IEditableTablePage : ITablePage
    {
        void EditCellContent(string content, int row, string column, string group);
        void EditCellContent(string content, int row, ITableColumn column);
        void SelectRandomCellAndEditItsContent(string content, string column, string group);
        void SelectRandomCellAndEditItsContent(string content, ITableColumn column);
        bool IsEditingEnable(string content, ITableColumn column);
        void ExitEditingMode();
        void SaveChanges();
        void CancelChanges();
        ISystemInputMethod LastInputMethodTypeWasActivated { get; }
        InputRange GetColumnRange(ITableColumn coulmn);
        RangeUnderTest RangeValidation(string colName);
    }
}
