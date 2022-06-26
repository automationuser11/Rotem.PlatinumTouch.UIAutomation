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
    public class AtticVentilationTab : SimpleSettingsPage, IApplicationPageTab, IErrorMessagePage
    {
        public string Name
        {
            get { return _name; }
        }
        private string _name = "Attic Ventilation";

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

        #region Fileds Definitions
        public KeyPadSettingsField LowSPressureSetting
        {
            get
            {
                return _lowSPressureSetting ?? (_lowSPressureSetting = new KeyPadSettingsField() { Name = "Low S.Pressure Setting", InputMethod = new PointNumericKeyPad() });
            }
        }
        private KeyPadSettingsField _lowSPressureSetting;

        public KeyPadSettingsField HighSPressureSetting
        {
            get
            {
                return _highSPressureSetting ?? (_highSPressureSetting = new KeyPadSettingsField() { Name = "High S.Pressure Setting", InputMethod = new PointNumericKeyPad() });
            }
        }
        private KeyPadSettingsField _highSPressureSetting;
        #endregion

    }
}
