using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.ControlMode;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.Communication;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.RelayLayout;
using Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Login;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations
{

    public class Configuration
    {
        public static string ByWeight { get { return "By Weight"; } }
    }

    public static class ColdStartConfiguration
    {
        public static INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : new Navigator();
            }
        }
          
        #region Properties

        public static bool IsConfigurationsAlreadyDefined;

        public static ControlModePage ControlModePage
        {
            get { return _controlModePage ?? (_controlModePage = new ControlModePage()); }
            set { _controlModePage = value; }
        }
        private static ControlModePage _controlModePage;

        public static CommunicationPage CommunicationPage
        {
            get { return _communicationPage ?? (_communicationPage = new CommunicationPage()); }
            set { _communicationPage = value; }
        }
        private static CommunicationPage _communicationPage;

        public static RelayLayoutPage RelayLayoutPage
        {
            get { return _relayLayoutPage ?? (_relayLayoutPage = new RelayLayoutPage()); }
            set { _relayLayoutPage = value; }
        }
        private static RelayLayoutPage _relayLayoutPage;

        #endregion

        public static void SetBroeilerConfiguration()
        {
            if (IsConfigurationsAlreadyDefined) return;

            var controlModePage = PagesFactory.GetPage<ControlModePage>();
            Navigator.NavigateTo(controlModePage);
            controlModePage.MinMaxLevelControl.SetValue(Configuration.ByWeight);
            controlModePage.SaveChanges();

            Navigator.NavigateTo<RelayLayoutPage>();
            RelayLayoutPage.TableView.ExpandAll();
            RelayLayoutPage.TableView.EditCellContent("Light", "Device", 0);
            RelayLayoutPage.TableView.EditCellContent("Light", "Device", 1);
            RelayLayoutPage.TableView.EditCellContent("Light", "Device", 2);
            RelayLayoutPage.TableView.EditCellContent("Light", "Device", 3);
            RelayLayoutPage.TableView.EditCellContent("Water", "Device", 4);
            RelayLayoutPage.TableView.EditCellContent("Feeder", "Device", 5);
            RelayLayoutPage.TableView.EditCellContent("Auger", "Device", 6);
            RelayLayoutPage.TableView.EditCellContent("Feed Line Up", "Device", 7);
            RelayLayoutPage.TableView.EditCellContent("Feed Line Down", "Device", 8);
            RelayLayoutPage.TableView.EditCellContent("Water Main", "Device", 9);
            RelayLayoutPage.TableView.EditCellContent("Water Bypass", "Device", 10);
            RelayLayoutPage.TableView.EditCellContent("Water Line", "Device", 11);
            RelayLayoutPage.TableView.EditCellContent("Feeder Window Open", "Device", 12);
            RelayLayoutPage.TableView.EditCellContent("Feeder Window Close", "Device", 13);
            RelayLayoutPage.TableView.EditCellContent("Drink Line Up", "Device", 14);
            RelayLayoutPage.TableView.EditCellContent("Drink Line Down", "Device", 15);
            RelayLayoutPage.TableView.EditCellContent("Water On Demand", "Device", 16);
            RelayLayoutPage.TableView.EditCellContent("Tunnel Fan", "Device", 17);
            RelayLayoutPage.TableView.EditCellContent("Tunnel Fan", "Device", 18);
            RelayLayoutPage.TableView.EditCellContent("Tunnel Fan", "Device", 19);
            RelayLayoutPage.TableView.EditCellContent("Tunnel Fan", "Device", 20);
            RelayLayoutPage.TableView.EditCellContent("Tunnel Close", "Device", 21);
            RelayLayoutPage.TableView.EditCellContent("Tunnel Close", "Device", 22);
            RelayLayoutPage.TableView.EditCellContent("Tunnel Open", "Device", 23);
            RelayLayoutPage.TableView.EditCellContent("Tunnel Open", "Device", 24);
            RelayLayoutPage.TableView.EditCellContent("Exhaust Fan", "Device", 25);
            RelayLayoutPage.TableView.EditCellContent("Exhaust Fan", "Device", 26);
            RelayLayoutPage.TableView.EditCellContent("Exhaust Fan", "Device", 27);
            RelayLayoutPage.TableView.EditCellContent("Exhaust Fan", "Device", 28);
            RelayLayoutPage.TableView.EditCellContent("Curtain Open", "Device", 29);
            RelayLayoutPage.TableView.EditCellContent("Curtain Open", "Device", 30);
            RelayLayoutPage.TableView.EditCellContent("Curtain Close", "Device", 31);
            RelayLayoutPage.TableView.EditCellContent("Curtain Close", "Device", 32);
            RelayLayoutPage.TableView.EditCellContent("Vent Open", "Device", 33);
            RelayLayoutPage.TableView.EditCellContent("Vent Close", "Device", 34);
            RelayLayoutPage.TableView.EditCellContent("Stir Fan", "Device", 35);
            RelayLayoutPage.TableView.EditCellContent("Stir Fan", "Device", 36);
            RelayLayoutPage.TableView.EditCellContent("Stir Fan", "Device", 37);
            RelayLayoutPage.TableView.EditCellContent("Cool Pad", "Device", 38);
            RelayLayoutPage.TableView.EditCellContent("Fogger", "Device", 39);
            RelayLayoutPage.TableView.SaveChanges();

            Navigator.NavigateTo<CommunicationPage>();
            CommunicationPage.Channela.SetValue("Light Dimmer 1");
            CommunicationPage.Channelb.SetValue("Light Dimmer 2");
            CommunicationPage.SaveChanges();

            IsConfigurationsAlreadyDefined = true;
        }
    }
}