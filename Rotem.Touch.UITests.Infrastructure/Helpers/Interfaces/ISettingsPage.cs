namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface ISettingsPage
    {
        void SaveChanges();
        void CancelChanges();
        void ExitEditingMode();
    }

    public interface ISettingsModal : ISettingsPage, INavigatalePageView
    {
        void Open();
        void Close();
    }
}
