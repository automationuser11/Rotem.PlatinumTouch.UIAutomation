using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AlarmSettings
{
    public class AlarmSettingsSettingsPage : SimpleSettingsModal
    {
        public string Name
        {
            get { return "Alarms - Settings"; }
        }
        public ToggleButtonSettingsField AdvancedAlarm
        {
            get { return _advancedAlarm ?? (_advancedAlarm = new ToggleButtonSettingsField("Advanced Alarms")); }
            set { _advancedAlarm = value; }
        }
        private ToggleButtonSettingsField _advancedAlarm;
        
        public static bool IsAdvancedAlarmSettingsOn { get; set; }
        public void TurnOnAdvancedAlarmSettings()
        {
            if (IsAdvancedAlarmSettingsOn) return;
            SetAdvancedAlarmSettings("Yes");
            IsAdvancedAlarmSettingsOn = true;
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            Waits.Wait(2);
        }   
        public void TurnAdvancedAlarmSettingsToDefaultValue()
        {
            SetAdvancedAlarmSettings("No");
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            IsAdvancedAlarmSettingsOn = false;
            Waits.Wait(2);
        }
        private void SetAdvancedAlarmSettings(string advancedAlarmSettingsValue)
        {
            Open();
            var currentValue = AdvancedAlarm.InputMethod.CurrentValue;
            if (currentValue == advancedAlarmSettingsValue)
            {
                
                Close();
            }
            else
            {
                AdvancedAlarm.InputMethod.SetValue(advancedAlarmSettingsValue);
                
                SaveChanges();
            }
        }
    }
}
