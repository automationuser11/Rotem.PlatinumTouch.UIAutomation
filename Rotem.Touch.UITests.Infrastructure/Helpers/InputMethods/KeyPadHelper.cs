using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public static class KeyPadHelper
    {
        public static void OpenSettingsFieldKeyPad(string fieldName)
        {
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            var fieldContainer = FindFieldContainer(fieldName);
            IWebElement editBtn;
            try { editBtn = fieldContainer.FindElement(By.CssSelector("div[class='setting-view-edit-container pull-right ng-scope']")); }
            catch { return; }
            var btn = editBtn.FindElement(By.CssSelector("div[class='setting-editable']"));
            var js = (IJavaScriptExecutor)DriverManager.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", btn);
            //DriverManager.Driver.WaitForSaveAndCancelButtonToBeLoaded();//removed by Gutman -this button appears only when changing made
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();

            btn.JavaClickAndWait();
            WaitForKeyPadToShowUp();
        }
        public static IWebElement FindFieldContainer(string fieldName)
        {
            var splitToSettingsHeaderAndFieldName = fieldName.Split('_');

            var fieldString = splitToSettingsHeaderAndFieldName.Length > 1 ? splitToSettingsHeaderAndFieldName[1] : splitToSettingsHeaderAndFieldName[0];
            var settingsHeader = splitToSettingsHeaderAndFieldName.Length > 1 ? splitToSettingsHeaderAndFieldName[0] : string.Empty;

            if (settingsHeader == string.Empty)
            {
                var fieldContainer = DriverManager.Driver.WaitForFieldsToBeLoaded(By.CssSelector("div[class*='setting-label']"), fieldString, Timeouts.Big);
                return fieldContainer.FindElement(By.XPath(".."));
            }
            var header = DriverManager.Driver.WaitForFieldToBeLoaded(By.XPath(string.Format("//*[text()='{0}']/../../..", settingsHeader)), Timeouts.Small);
            var fieldChildContainer = header.FindElements(By.CssSelector("div[class*='setting-label']"));
            try
            {
                return fieldChildContainer.First(field => field.Text == fieldString).FindElement(By.XPath(".."));
            }
            catch
            {
                var fieldContainer = DriverManager.Driver.WaitForFieldsToBeLoaded(By.CssSelector("div[class*='setting-label']"), fieldString, Timeouts.Big);
                return fieldContainer.FindElement(By.XPath(".."));
            }
        }
        public static void ExitEditMode()
        {
            try
            {
                var keypadFloatContainer = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
                if (keypadFloatContainer.GetAttribute("class").Contains("ng-hide")) return;

                var keypdPanels =
                    keypadFloatContainer.FindElements(By.CssSelector("div[id=\"page-float-ext\"] > div[class*=\"keypad\"][style]"));

                var activeKeypadPanel = keypdPanels.SingleOrDefault(button => !(button.GetAttribute("style").Contains("display: none")));

                if (activeKeypadPanel != null)
                {
                    var cancelBtn = activeKeypadPanel.FindElement(By.CssSelector("div[class*=\"buttons-row\"] button[data-key-value=\"cancel\"]"));
                    cancelBtn.JavaClickAndWait();
                }
                else
                {
                    var okSettingsBtn =
                        keypadFloatContainer.TryFindElement(
                            By.CssSelector("ButtonsGroup[ng-click='cancelEditSetPoint()']"));
                    okSettingsBtn.JavaClickAndWait();
                }
            }
            catch (NoSuchElementException)
            {
                // No keypad panel is open.
            }
        }
        public static bool IsWarnningIconAppears
        {
            get
            {
                var keypad = GetActiveKeyPadElement();
                try
                {
                    var keypadbounderies = keypad.FindElement(By.XPath("//div[contains(@class, 'keypad-range-row')]/span[contains(@class, 'icon-warning-sign')]"));
                    if (keypadbounderies.GetAttribute("class").Contains("ng-hide"))
                        return false;
                    else
                        return true;
                    
                }
                catch
                {
                    return false;
                }
                //var keypad = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
                //var rangeRow = keypad.FindElement(By.ClassName("keypad-range-row"));
                //var spans = rangeRow.FindElements(By.TagName("span"));
                //if (spans.Count != 3)
                //    throw new NoSuchElementException("Cannot decide if warnning icon appers or not");

                //var warnningIcon = spans[2].GetAttribute("class");
                //return warnningIcon.Equals("icon-warning-sign");
            }
        }

        public static IWebElement GetActiveKeyPadElement()
        {
            var keypadContainer = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            var keypadCollection = keypadContainer.FindElements(By.CssSelector("div[class*='keypad']"));

            IWebElement activeKeypad = null;

            foreach (var webElement in keypadCollection)
            {
                var style = webElement.GetAttribute("style");
                if (style != string.Empty && (style.Contains("display: block") || !style.Contains("none")))
                {
                    activeKeypad = webElement;
                    break;
                }
            }

            return activeKeypad;
        }
        public static RangeUnderTest GetTestingRange(InputRange range)
        {
            var testingRange = new RangeUnderTest(range)
            {
                IsMaxValueTestPassed = true,
                IsMinValueTestPassed = true,
                IsAboveTestPassed = true,
                IsInsideTestPassed = true,
                IsBelowTestPassed = true
            };
            if(range.RangeList.Count != 0)
            {
                Random r = new Random();
                int index = r.Next(testingRange.Range.RangeList.Count);
                testingRange.Inside = testingRange.Range.RangeList[index];
            }
            return testingRange;
        }
        public static void WaitForKeyPadToShowUp(int timeout = Timeouts.FiveSeconds)
        {
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                if (GetActiveKeyPadElement() != null) return;
                Thread.Sleep(100);
            }
        }
    }
}