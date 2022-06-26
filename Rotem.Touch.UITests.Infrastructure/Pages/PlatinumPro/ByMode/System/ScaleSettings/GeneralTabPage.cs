using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleSettings
{
    public class GeneralTabPage : SimpleSettingsPage, ISettingsModalViewProvider<GeneralTabSettingsPage>, IApplicationPageTab
    {
        public string Name { get { return "General"; } }
        public string SubMenu { get { return "System"; } }
        public ITabsPage OwnerPage
        {
            get
            {
                return PagesFactory.GetPage<ScaleSettingsPage>();
            }
        }
        public bool IsTabButtonExists()
        {
            return DriverManager.Driver.IsElementExists(() => TabPageService.GetTabButton(Name));
        }
        public void Navigate()
        {
            TabPageService.Navigate(Name);
        }
        public GeneralTabSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new GeneralTabSettingsPage()); }
        }
        private GeneralTabSettingsPage _settingsPage;

        #region Settings Fields
        public ComboboxSettingsField BirdScaleMode
        {
            get { return _birdScaleMode ?? (_birdScaleMode = new ComboboxSettingsField("Bird Scale Mode")); }
            set { _birdScaleMode = value; }
        }
        private ComboboxSettingsField _birdScaleMode;
        public ComboboxSettingsField CurveSelectorForMixed
        {
            get { return _curveSelectorForMixed ?? (_curveSelectorForMixed = new ComboboxSettingsField("Curve Selector (For Mixed)")); }
            set { _curveSelectorForMixed = value; }
        }
        private ComboboxSettingsField _curveSelectorForMixed;

        public KeyPadSettingsField UniformityRange530
        {
            get { return _uniformityRange530 ?? (_uniformityRange530 = new KeyPadSettingsField() { Name = "Uniformity Range (5-30%)", InputMethod = new BaseNumericKeyPad() }); }
            set { _uniformityRange530 = value; }
        }
        private KeyPadSettingsField _uniformityRange530;

        #endregion 
    }
}
