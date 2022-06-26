using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TimeAndDate
{
    public class TimeAndDatePage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<TimeAndDatePage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Time & Date"; }
        }
        public string MenuName
        {
            get { return "Time & Date"; }
        }
        public string SubMenu { get { return "System"; } }

        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        #region Group Name:

        public KeyPadSettingsField CurrentTime
        {
            get { return _currentTime ?? (_currentTime = new KeyPadSettingsField() { Name = "Current Time", InputMethod = new TimeKeyPad() }); }
            set { _currentTime = value; }
        }
        private KeyPadSettingsField _currentTime;

        public ReadonlyTextSettingsField CurrentDayOfTheWeek
        {
            get { return _currentDayOfTheWeek ?? (_currentDayOfTheWeek = new ReadonlyTextSettingsField("Current Day Of The Week")); }
            set { _currentDayOfTheWeek = value; }
        }
        private ReadonlyTextSettingsField _currentDayOfTheWeek;

        public DateKeyPadSettingsField CurrentDate
        {
            get { return _currentDate ?? (_currentDate = new DateKeyPadSettingsField("Current Date")); }
            set { _currentDate  = value; }
        }
        private DateKeyPadSettingsField _currentDate;

        #endregion

        public void MoveToNextDay()
        {
            CurrentTime.SetValue("23:59");
            SaveChanges();

            var timeout = new TimeSpan(0, 0, 120); // An ugly patch for an existing bug.
            Stopwatch sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
            {
                if(CurrentTime.GetCurrentValue() == "00:00")
                    break;
                
                Thread.Sleep(5000);
                Browser.Reload();
                Thread.Sleep(5000);
            }

            Browser.Reload();
        }
        public Metadata Metadata { get; set; }

    }
}
