using System;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class ButtonsGroup : ISystemInputMethod
    {
        private IWebElement _uiElement;
        public ButtonsGroup() {}
        public ButtonsGroup(IWebElement uiElement)
        {
            _uiElement = uiElement;
        }
        public string InputMethodType { get { return GetType().ToString(); } }
        public void InitUiElement(IWebElement uiElement)
        {
            _uiElement = uiElement;
        }
        public string CurrentValue
        {
            get
            {
                var groupbutton = _uiElement.FindElement(By.XPath("//label[contains(@class, 'active')]"));
                return groupbutton.Text;
            }
        }
        public void SetValue(string value)
        {
            // find a button with the value string deliverd and click on it...
            var buttonToClick = _uiElement.FindElements(By.CssSelector("div[class*='btn-group settings-btn-group'] label")).Where(item => item.Text == value).Single();
            buttonToClick.JavaClickAndWait();
        }
        public bool IsInputMethodEnabled()
        {
            throw new NotImplementedException();
        }
        public InputRange GetRange()
        {
            //var btnGroup =
            //    DriverManager.Driver.FindElements(By.CssSelector("label[class='btn button-label active']"))
            //        .First()
            //        .GoUp();
            var range = _uiElement.FindElements(By.CssSelector("div[class*='btn-group settings-btn-group'] label"));
            var rangeNames = range.Select(item => item.Text);

            return new InputRange() {RangeList = rangeNames.ToList()};
        }
        public RangeUnderTest GetTestingRange(InputRange range)
        {
            return KeyPadHelper.GetTestingRange(range);
        }
        public void SetValue(object value, ISearchContext context)
        {
            throw new NotImplementedException();
        }
    }
}
