using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleSettings
{
    public class GeneralTabSettingsPage : SimpleSettingsModal
    {
        #region Group Name: General Scale Settings

        public string Name
        {
            get { return "General Scale Settings"; }
        }
        public ToggleButtonSettingsField FactoryDefaultCurve
        {
            get { return _factoryDefaultCurve ?? (_factoryDefaultCurve = new ToggleButtonSettingsField("Factory Default Curve")); }
            set { _factoryDefaultCurve = value; }
        }
        private ToggleButtonSettingsField _factoryDefaultCurve;

        #endregion 
    }
}
