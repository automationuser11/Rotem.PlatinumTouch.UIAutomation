using System;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public class PageErrorMessageService
    {
        public static bool IsErrorMessageDisplayed()
        {
            try
            {
                Waits.Wait(3);
                var messageControls = DriverManager.Driver.FindElements(By.CssSelector("div[class*='message-control ng-scope']"));
                //var messageControl = messageControls.Single(msgCtrl => !msgCtrl.GetAttribute("class").Contains("ng-hide"));
                //messageControl.FindElement(By.CssSelector("div[class*='message-text']"));

                return true;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }
        public static string GetDisplayedErrorMessage()
        {
            try
            {
                Waits.Wait(3);
                var messageControls = DriverManager.Driver.FindElements(By.CssSelector("div[class*='message-control ng-scope']"));
                var messageControl = messageControls.Single(msgCtrl => !msgCtrl.GetAttribute("class").Contains("ng-hide"));
                var message = messageControl.FindElement(By.CssSelector("div[class*='message-text']"));

                return message.Text;
            }
            catch (InvalidOperationException)
            {
                throw new Exception("The error message is not displayed.");
            }
        }
        public static void ApproveErrorMessage()
        {
            try
            {
                var msgControls = DriverManager.Driver.FindElements(By.CssSelector("div[class='message-control ng-scope']"));
                var displayedMsgControl = msgControls.Single(element => !element.GetAttribute("class").Contains("ng-hide"));
                var messageControlBtns = displayedMsgControl.FindElement(By.CssSelector("div[class*='message-control-buttons']"));
                var okBtn = messageControlBtns.FindElement(By.TagName("button"));
                okBtn.JavaClickAndWait();
            }
            catch (InvalidOperationException)
            {
                throw new Exception("The error message is not displayed.");
            }
        }
    }
}
