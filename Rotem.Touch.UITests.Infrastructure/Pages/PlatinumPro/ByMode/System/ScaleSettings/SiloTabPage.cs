using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleSettings
{
    public class SiloTabPage : SimpleSettingsPage, IApplicationPageTab
    {
        public string Name { get { return "Silo"; } }
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

        #region Settings Fields

        public KeyPadSettingsField MinFillingWeight
        {
            get { return _minFillingWeight ?? (_minFillingWeight = new KeyPadSettingsField() { Name = "Min Filling Weight", InputMethod = new BaseNumericKeyPad() }); }
            set { _minFillingWeight = value; }
        }
        private KeyPadSettingsField _minFillingWeight;

        public KeyPadSettingsField ResumeTimeMin
        {
            get { return _resumeTimeMin ?? (_resumeTimeMin = new KeyPadSettingsField() { Name = "Resume Time (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _resumeTimeMin = value; }
        }
        private KeyPadSettingsField _resumeTimeMin;

        public KeyPadSettingsField FillingDetectionWeight
        {
            get { return _fillingDetectionWeight ?? (_fillingDetectionWeight = new KeyPadSettingsField() { Name = "Filling Detection Weight", InputMethod = new BaseNumericKeyPad() }); }
            set { _fillingDetectionWeight = value; }
        }
        private KeyPadSettingsField _fillingDetectionWeight;

        #endregion 
    }
}
