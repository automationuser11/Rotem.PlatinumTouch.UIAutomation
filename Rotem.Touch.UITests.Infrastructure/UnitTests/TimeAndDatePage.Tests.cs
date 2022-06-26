using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TimeAndDate;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class TimeAndDatePageTests
    {
        public INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }

        public TimeAndDatePage TimeAndDatePage
        {
            get { return _timeAndDatePage  ?? (_timeAndDatePage = new TimeAndDatePage()); }
            set { _timeAndDatePage  = value; }
        }
        private TimeAndDatePage _timeAndDatePage;

        [TestMethod]
        public void TimeAndDatePage_CallToMoveToNextdayMethod_ShouldMoveTheSystemToTheNextDay()
        {
            Navigator.NavigateTo<TimeAndDatePage>();
            TimeAndDatePage.MoveToNextDay();
        }
    }
}
