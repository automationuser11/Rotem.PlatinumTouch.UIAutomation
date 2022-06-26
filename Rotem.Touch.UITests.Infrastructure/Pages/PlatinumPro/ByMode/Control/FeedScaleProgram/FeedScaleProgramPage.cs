using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.FeedScaleProgram
{
    public class FeedScaleProgramPage : IApplicationPage, ITableViewProvider<GridTablePage<FeedScaleProgramPage>>, ISettingsModalViewProvider<FeedScaleProgramSettingsPage>, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<FeedScaleProgramPage>()); }
        }
        private Uri _pageUri;

        public string Name
        {
            get { return "Feed Scale Program"; }
        }
        public string MenuName
        {
            get { return "Feed Scale Program"; }
        }
        public string SubMenu { get { return "Control"; } }

        public void SaveChanges()
        {
            Waits.Wait(3);
            var saveModal = DriverManager.Driver.TryFindElement(By.CssSelector("div[class='confirm-save-modal']"));

            if (saveModal == null)
            {
                var btnsPlaceHolder = DriverManager.Driver.FindElement(By.Id("saveAndCancelPlaceholder"));
                if (!btnsPlaceHolder.GetAttribute("class").Contains("ng-hide"))
                {
                    DriverManager.Driver.FindElement(By.CssSelector("button[ng-click='saveEdit()']")).Click();
                }
            }
            else
            {
                saveModal.FindElement(By.CssSelector("div[class='saveAndCancel'] button[ng-click='confirmDialog.okCallback()']")).TryToClick();
            }
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            DriverManager.Driver.WaitForDomReady();

            var approveModal = DriverManager.Driver.TryFindElement(By.CssSelector("div[class='btn btn-primary']"));
            approveModal.TryToClick();
            Waits.Wait(10);
        }

        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public GridTablePage<FeedScaleProgramPage> TableView
        {
            get { return _tableView ?? (_tableView = new GridTablePage<FeedScaleProgramPage>()); }
        }
        private GridTablePage<FeedScaleProgramPage> _tableView;

        public FeedScaleProgramSettingsPage SettingsView
        {
            get { return _settingsView ?? (_settingsView = new FeedScaleProgramSettingsPage());  }
        }
        private FeedScaleProgramSettingsPage _settingsView;
    }
}