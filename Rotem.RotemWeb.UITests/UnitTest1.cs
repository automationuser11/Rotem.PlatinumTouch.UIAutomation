using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.HumidityTreatment;
using Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Login;

namespace Rotem.RotemWeb.UITests
{
    [TestClass]
    public class UnitTest1
    {
        public INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }

        public LoginPage LoginPage
        {
            get { return _loginPage  ?? (_loginPage = PagesFactory.GetPage<LoginPage>()); }
            set { _loginPage  = value; }
        }
        private LoginPage _loginPage;

        public HumidityTreatmentPage HumidityTreatmentPage
        {
            get { return _humidityTreatmentPage  ?? (_humidityTreatmentPage = PagesFactory.GetPage<HumidityTreatmentPage>()); }
            set { _humidityTreatmentPage  = value; }
        }
        private HumidityTreatmentPage _humidityTreatmentPage;

        [TestMethod]
        public void TestMethod1()
        {
            Navigator.NavigateTo<LoginPage>();
            LoginPage.Login(new LoginArgs(){ UserName = "admin", Password = "admin", FarmName = "rotemsiteil"});

            Navigator.NavigateTo<HumidityTreatmentPage>();

            HumidityTreatmentPage.TableView.EditCellContent("12", "Humidity");
        }
    }
}
