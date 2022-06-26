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

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.GrowthDayAndGroup
{
    public class GrowthDayAndGroupPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
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
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<GrowthDayAndGroupPage>()); }
        }
        private Uri _pageUri;
        public string SubMenu { get { return "Management"; } }
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
            get { return "Growth Day & Group"; }
        }
        public string MenuName
        {
            get { return "Growth Day & Group"; }
        }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public KeyPadSettingsField GroupNo
        {
            get { return _groupNo ?? (_groupNo = new KeyPadSettingsField() { Name = "Group Number", InputMethod = new BaseNumericKeyPad() }); }
            set { _groupNo = value; }
        }
        private KeyPadSettingsField _groupNo;
        public ComboboxSettingsField NewGroup
        {
            get { return _newGroup ?? (_newGroup = new ComboboxSettingsField("New Group")); }
            set { _newGroup = value; }
        }
        private ComboboxSettingsField _newGroup;
        public KeyPadSettingsField CurrentGrowthDay
        {
            get { return _currentGrowthDay ?? (_currentGrowthDay = new KeyPadSettingsField() { Name = "Current Growth Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _currentGrowthDay = value; }
        }
        private KeyPadSettingsField _currentGrowthDay;

        public override void SaveChanges()
        {
            base.SaveChanges();
            if (ConfirmSaveModal.GetAttribute("class").Contains("ng-hide")) return;

            AllertMessage = ConfirmSaveMessage.Text;
            ModalSaveChangesButton.JavaClickAndWait();
        }
        public override void CancelChanges()
        {
            base.SaveChanges();
            if (ConfirmSaveModal.GetAttribute("class").Contains("ng-hide")) return;

            AllertMessage = ConfirmSaveMessage.Text;
            ModalCancelChangesButton.JavaClickAndWait();
        }
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
