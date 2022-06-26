using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.EventsLogHistory;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.GrowthDayAndFlock
{
    public class GrowthDayAndFlockPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public static INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }
        public string SubMenu { get { return "Management"; } }
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<GrowthDayAndFlockPage>()); }
        }
        private Uri _pageUri;

        internal IWebElement ConfirmSaveModal
        {
            get { return DriverManager.Driver.FindElement(By.CssSelector("div[class*='confirm-save-modal']")); }
        }
        internal IWebElement ConfirmSaveMessage
        {
            get { return ConfirmSaveModal.FindElement(By.CssSelector("div[class*='confirm-save-message']")); }
        }
        internal IWebElement ModalButtonsContainer
        {
            get { return ConfirmSaveModal.FindElement(By.CssSelector("div[class='saveAndCancel']")); }
        }
        internal IWebElement ModalSaveChangesButton
        {
            get
            {
                return
                    ModalButtonsContainer.FindElement(By.CssSelector("button[ng-click='confirmDialog.okCallback()']"));
            }
        }
        internal IWebElement ModalCancelChangesButton
        {
            get
            {
                return
                    ModalButtonsContainer.FindElement(By.CssSelector("button[ng-click='confirmDialog.cancelCallback()']"));
            }
        }
        public string AllertMessage { get; private set; }
        public string Name
        {
            get { return "Growth Day & Flock"; }
        }
        public string MenuName
        {
            get { return "Growth Day & Flock"; }
        }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public KeyPadSettingsField FlockNo
        {
            get { return _flockNo ?? (_flockNo = new KeyPadSettingsField() { Name = "Flock Number", InputMethod = new BaseNumericKeyPad() }); }
            set { _flockNo = value; }
        }
        private KeyPadSettingsField _flockNo;
        public ComboboxSettingsField StartNewFlock
        {
            get { return _startNewFlock ?? (_startNewFlock = new ComboboxSettingsField("New Flock")); }
            set { _startNewFlock = value; }
        }
        private ComboboxSettingsField _startNewFlock;
        public KeyPadSettingsField CurrentGrowthDay
        {
            get { return _currentGrowthDay ?? (_currentGrowthDay = new KeyPadSettingsField() { Name = "Current Growth Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _currentGrowthDay = value; }
        }
        private KeyPadSettingsField _currentGrowthDay;

        public override void SaveChanges()
        {
            base.SaveChanges();
            try
            {
                if (ConfirmSaveModal.GetAttribute("class").Contains("ng-hide")) return;
            }
            catch
            {
                return;
            }
            AllertMessage = ConfirmSaveMessage.Text;
            ModalSaveChangesButton.JavaClickAndWait();
        }

        public void SaveChangesClearHistory()
        {
            SaveChanges();
            if (ConfirmSaveModal.GetAttribute("class").Contains("ng-hide")) return;
            AllertMessage = ConfirmSaveMessage.Text;
            ModalSaveChangesButton.JavaClickAndWait();
        }
        //public override void CancelChanges()
        //{
        //    base.CancelChanges();
        //}
        public bool IsAlertMessageDisplayed()
        {

            try
            {
                if (ConfirmSaveModal.GetAttribute("class").Contains("ng-hide")) return false;
                return true;
            }
            catch { return false; }
        }
        public bool ValidateConfirmSaveMessageVisibility()
        {
            base.SaveChanges();

            var dialogButtons = ModalButtonsContainer.FindElements(By.TagName("button"));
            
            if (dialogButtons.Count != 2)
                return false;
            if (dialogButtons[0].Text != "Yes")
                return false;
            if (dialogButtons[1].Text != "No")
                return false;
            return true;
        }
        public void ApproveAlertMessage()
        {
            base.SaveChanges();
            ModalSaveChangesButton.JavaClickAndWait();
        }
        public bool ValidateHistoryErased()
        {
            var historyPages = PagesFactory.GetHistoryPages();
            if(historyPages.Count != 14)
                throw new Exception("There is problem with history pages. Validate all pages exists.");

            foreach (var historyPage in historyPages)
            {
                if (historyPage.GetType() == typeof (EventsLogHistoryPage)) continue;

                Navigator.NavigateTo(historyPage);
                dynamic page = Convert.ChangeType(historyPage, historyPage.GetType());
                if (!page.TableView.IsTableEmpty())
                    return false;
            }
            return true;
        }
    }
}
