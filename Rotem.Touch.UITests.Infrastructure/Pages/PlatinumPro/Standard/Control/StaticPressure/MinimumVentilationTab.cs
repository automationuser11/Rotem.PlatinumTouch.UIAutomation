using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.Standard.Control.StaticPressure
{
    public class MinimumVentilationTab : SimpleSettingsPage, IApplicationPageTab, IErrorMessagePage
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

        #region Fields defenition

        public KeyPadSettingsField FirstLowSPressure
        {
            get { return _firstLowSPressure ?? (_firstLowSPressure = new KeyPadSettingsField() { Name = "First Low S.Pressure", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _firstLowSPressure;

        public KeyPadSettingsField FirstHighSPressure
        {
            get { return _firstHighSPressure ?? (_firstHighSPressure = new KeyPadSettingsField() { Name = "First High S.Pressure", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _firstHighSPressure;

        public KeyPadSettingsField SecondLowSPressure
        {
            get { return _secondLowSPressure ?? (_secondLowSPressure = new KeyPadSettingsField() { Name = "Second Low S.Pressure", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _secondLowSPressure;

        public KeyPadSettingsField SecondHighSPressure
        {
            get { return _secondHighSPressure ?? (_secondHighSPressure = new KeyPadSettingsField() { Name = "Second High S.Pressure", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _secondHighSPressure;

        public KeyPadSettingsField LowSPressureAlarm
        {
            get { return _lowSPressureAlarm ?? (_lowSPressureAlarm = new KeyPadSettingsField() { Name = "Second Low S.Pressure", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _lowSPressureAlarm;

        public KeyPadSettingsField HighSPressureAlarm
        {
            get { return _highSPressureAlarm ?? (_highSPressureAlarm = new KeyPadSettingsField() { Name = "Second High S.Pressure", InputMethod = new PointNumericKeyPad() }); }
        }
        private KeyPadSettingsField _highSPressureAlarm;

        #endregion
    }
}
