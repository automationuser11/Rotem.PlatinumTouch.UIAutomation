namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface ITableColumn
    {
        int Id { get; }
        string DisplayName { get; }
        string Group { get; }
        bool IsReadOnly { get; }
        ISystemInputMethod InputMethod { get; }
    }
}
