using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode
{
    public class TempReminderPage
    {
        #region Elemnents Mapping

        private IWebElement AlarmTitle
        {
            get { return AlarmBox.FindElement(By.CssSelector("div[class='title']")); }
        }

        private IWebElement AlarmBox
        {
            get { return DriverManager.Driver.FindElement(By.CssSelector("div[class*='confirm-save-modal']")); }
        }

        private string AlarmMessage
        {
            get { return AlarmBox.FindElement(By.CssSelector("div[class*='confirm-save-message']")).Text; }
        }

        public IWebElement ConfirmButton
        {
            get{return AlarmBox.FindElement(By.LinkText("Confirm"));}
        }

        #endregion

        public bool IsReminderDisplayed(string message)
        {
            if (AlarmBox.GetAttribute("class").Contains("hide"))
                return false;
            if (AlarmMessage != message)
                return false;
            return true;
        }

        public void ClickConfirmButton()
        {
            try
            {
                ConfirmButton.Click();
            }
            catch
            {
            }
        }

        public void ClickOKButton()
        {
            try
            {
                ConfirmButton.Click();
            }
            catch
            {
            }
        }
    }
}
