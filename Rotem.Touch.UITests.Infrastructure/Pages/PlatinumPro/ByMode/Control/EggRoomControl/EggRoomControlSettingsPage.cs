using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.EggRoomControl
{
    public class EggRoomControlSettingsPage : SimpleSettingsModal
    {
        #region Group Name: Egg Room Control

        public string Name
        {
            get { return "Egg Room - Settings"; }
        }

        public KeyPadSettingsField LowTemperature
        {
            get { return _lowTemperature ?? (_lowTemperature = new KeyPadSettingsField() { Name = "Low Temperature", InputMethod = new PointNumericKeyPad() }); }
            set { _lowTemperature = value; }
        }
        private KeyPadSettingsField _lowTemperature;

        public KeyPadSettingsField HighTemperature
        {
            get { return _highTemperature ?? (_highTemperature = new KeyPadSettingsField() { Name = "High Temperature", InputMethod = new PointNumericKeyPad() }); }
            set { _highTemperature = value; }
        }
        private KeyPadSettingsField _highTemperature;

        public KeyPadSettingsField LowHumidity
        {
            get { return _lowHumidity ?? (_lowHumidity = new KeyPadSettingsField() { Name = "Low Humidity", InputMethod = new PointNumericKeyPad() }); }
            set { _lowHumidity = value; }
        }
        private KeyPadSettingsField _lowHumidity;

        public KeyPadSettingsField HighHumidity
        {
            get { return _highHumidity ?? (_highHumidity = new KeyPadSettingsField() { Name = "High Humidity", InputMethod = new PointNumericKeyPad() }); }
            set { _highHumidity = value; }
        }
        private KeyPadSettingsField _highHumidity;

        public KeyPadSettingsField Delay
        {
            get { return _delay ?? (_delay = new KeyPadSettingsField() { Name = "Delay (Min.)", InputMethod = new PointNumericKeyPad() }); }
            set { _delay = value; }
        }
        private KeyPadSettingsField _delay;

        #endregion
    }
}
