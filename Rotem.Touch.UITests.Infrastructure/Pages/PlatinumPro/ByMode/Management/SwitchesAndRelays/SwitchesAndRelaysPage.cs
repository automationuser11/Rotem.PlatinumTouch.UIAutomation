using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EventsLogHistory;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.SwitchesAndRelays
{
    public class SwitchesAndRelaysPage : IApplicationPage, IMetadataDependentPageObject
    {
        public static INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<SwitchesAndRelaysPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Switches & Relays"; }
        }
        public string MenuName
        {
            get { return "Switches & Relays"; }
        }
        public string SubMenu { get { return "Management"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public bool IsSwitchesAndRelaysExtensionsExists()
        {
            try
            {
                DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
                Waits.Wait(3);
                DriverManager.Driver.FindElement(By.CssSelector("div[class*='switches-relays']"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
