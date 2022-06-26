using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.StaticPressure
{
    public class TunnelVentilationTab : SimpleSettingsPage, IApplicationPageTab, IErrorMessagePage
    {
        public string Name
        {
            get { return _name; }
        }
        private string _name = "Min Ventilation";


        public ITabsPage OwnerPage
        {
            get { return PagesFactory.GetPage<StaticPressurePage>(); }
        }

        public bool IsTabButtonExists()
        {
            return DriverManager.Driver.IsElementExists(() => TabPageService.GetTabButton(Name));
        }

        public void Navigate()
        {
            TabPageService.Navigate(Name);
        }

        public string ErrorMessage
        {
            get { return PageErrorMessageService.GetDisplayedErrorMessage(); }
        }

        public void ApproveErrorMessage()
        {
            PageErrorMessageService.ApproveErrorMessage();
        }

        #region Fields definitions
        public KeyPadSettingsField LowSPressure
        {
            get { return _lowSPressure ?? (_lowSPressure = new KeyPadSettingsField() { Name = "Low  S.Pressure", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _lowSPressure;

        public KeyPadSettingsField HighSPressure
        {
            get { return _highSPressure ?? (_highSPressure = new KeyPadSettingsField() { Name = "High  S.Pressure", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _highSPressure;

        public KeyPadSettingsField LowSPressureAlarm
        {
            get { return _lowSPressureAlarm ?? (_lowSPressureAlarm = new KeyPadSettingsField() { Name = "Low  S.Pressure Alarm", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _lowSPressureAlarm;

        public KeyPadSettingsField HighSPressureAlarm
        {
            get { return _highSPressureAlarm ?? (_highSPressureAlarm = new KeyPadSettingsField() { Name = "High  S.Pressure Alarm", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _highSPressureAlarm;
        #endregion

    }
}
