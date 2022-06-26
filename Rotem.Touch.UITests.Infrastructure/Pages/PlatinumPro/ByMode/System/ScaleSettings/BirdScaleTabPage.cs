using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleSettings
{
    public class BirdScaleTabPage : SimpleSettingsPage, ISettingsModalViewProvider<BirdScaleTabSettingsPage>, IApplicationPageTab
    {
        public string Name { get { return "Bird Scale"; } }
        public ITabsPage OwnerPage
        {
            get
            {
                return PagesFactory.GetPage<ScaleSettingsPage>();
            }
        }
        public string SubMenu { get { return "System"; } }
        public bool IsTabButtonExists()
        {
            return DriverManager.Driver.IsElementExists(() => TabPageService.GetTabButton(Name));
        }
        public void Navigate()
        {
            TabPageService.Navigate(Name);
        }

        public BirdScaleTabSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new BirdScaleTabSettingsPage()); }
        }
        private BirdScaleTabSettingsPage _settingsPage;

        public ComboboxSettingsField WeightingMethod
        {
            get { return _weightingMethod ?? (_weightingMethod = new ComboboxSettingsField("Weighting Method")); }
            set { _weightingMethod = value; }
        }
        private ComboboxSettingsField _weightingMethod;

        //
        public ComboboxSettingsField WeightMethod
        {
            get { return _weightMethod ?? (_weightMethod = new ComboboxSettingsField("Weight Method")); }
            set { _weightMethod = value; }
        }
        private ComboboxSettingsField _weightMethod;

        public ComboboxSettingsField Scale1
        {
            get { return _scale1 ?? (_scale1 = new ComboboxSettingsField("Scale 1")); }
            set { _scale1 = value; }
        }
        private ComboboxSettingsField _scale1;

        public ComboboxSettingsField Scale2
        {
            get { return _scale2 ?? (_scale2 = new ComboboxSettingsField("Scale 2")); }
            set { _scale2 = value; }
        }
        private ComboboxSettingsField _scale2;
        public ComboboxSettingsField Scale3
        {
            get { return _scale3 ?? (_scale3 = new ComboboxSettingsField("Scale 3")); }
            set { _scale3 = value; }
        }
        private ComboboxSettingsField _scale3;
        public ComboboxSettingsField Scale4
        {
            get { return _scale4 ?? (_scale4 = new ComboboxSettingsField("Scale 4")); }
            set { _scale4 = value; }
        }
        private ComboboxSettingsField _scale4;


        //
        #region Settings Fields

        public KeyPadSettingsField StartTime
        {
            get { return _startTime ?? (_startTime = new KeyPadSettingsField() { Name = "Start Time", InputMethod = new TimeKeyPad() }); }
            set { _startTime = value; }
        }
        private KeyPadSettingsField _startTime;

        public KeyPadSettingsField UpperRange
        {
            get { return _upperRange ?? (_upperRange = new KeyPadSettingsField() { Name = "Upper Range - (Above reference %)", InputMethod = new BaseNumericKeyPad() }); }
            set { _upperRange = value; }
        }
        private KeyPadSettingsField _upperRange;

        public KeyPadSettingsField ReferenceWeigh1
        {
            get { return _referenceWeigh1 ?? (_referenceWeigh1 = new KeyPadSettingsField() { Name = "Reference Weight 1", InputMethod = new PointNumericKeyPad() }); }
            set { _referenceWeigh1 = value; }
        }
        private KeyPadSettingsField _referenceWeigh1;

        public KeyPadSettingsField EndTime
        {
            get { return _endTime ?? (_endTime = new KeyPadSettingsField() { Name = "End Time", InputMethod = new TimeKeyPad() }); }
            set { _endTime = value; }
        }
        private KeyPadSettingsField _endTime;

        public KeyPadSettingsField LowerRange
        {
            get { return _lowerRange ?? (_lowerRange = new KeyPadSettingsField() { Name = "Lower Range - (Below Reference %)", InputMethod = new BaseNumericKeyPad() }); }
            set { _lowerRange = value; }
        }
        private KeyPadSettingsField _lowerRange;

        public KeyPadSettingsField ReferenceWeigh2
        {
            get { return _referenceWeigh2 ?? (_referenceWeigh2 = new KeyPadSettingsField() { Name = "Reference Weight 2", InputMethod = new PointNumericKeyPad() }); }
            set { _referenceWeigh2 = value; }
        }
        private KeyPadSettingsField _referenceWeigh2;

        #endregion 
    }
}
