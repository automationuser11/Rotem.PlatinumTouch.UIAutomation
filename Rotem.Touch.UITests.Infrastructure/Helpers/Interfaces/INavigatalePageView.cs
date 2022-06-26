namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface INavigatalePageView : IPageObject
    {
        // Sometimes it will be a button in the screen and other times it will be a menu item...
        void Navigate(); 
    }
}
