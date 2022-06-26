using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class TouchToggleButton : ISystemInputMethod
    {
        private IWebElement _uiElement;
        public TouchToggleButton(){}
        public TouchToggleButton(IWebElement uiElement)
        {
            _uiElement = uiElement;
        }
        public string InputMethodType
        {
            get
            {
                return GetType().ToString();
            }
        }
        public void InitUiElement(IWebElement uiElement)
        {
            _uiElement = uiElement;
        }
        public void SetValue(string value)
        {
            if (CurrentValue == value) return;
            
            var input = _uiElement.FindElement(By.TagName("input"));
            DriverManager.Driver.VoodooClick(input);
        }
        public bool IsInputMethodEnabled()
        {
            throw new NotImplementedException();
        }
        public InputRange GetRange()
        {
            var range = _uiElement.FindElements(By.TagName("span")).Where(item => item.Text != string.Empty);
            var firstOption = range.Single().Text;
            _uiElement.FindElement(By.TagName("label")).JavaClickAndWait();
            var secondOption = range.Single().Text;
            _uiElement.FindElement(By.TagName("label")).JavaClickAndWait();

            return new InputRange() { RangeList = new List<string>() { firstOption, secondOption } };
        }
        //public InputRange GetRange()
        //{

        //    var range = _uiElement.FindElements(By.TagName("span")).Where(item => item.Text != string.Empty);
        //    var firstOption = range.Single().Text;
        //    return new InputRange() {RangeList = new List<string>() { firstOption}};
        //}
        public string CurrentValue
        {
            get { return _uiElement.Text; }
        }
        public RangeUnderTest GetTestingRange(InputRange range)
        {
            return KeyPadHelper.GetTestingRange(range);
        }
        public void SetValue(object value, ISearchContext context)
        {
            //var x = context.FindElement(By.XPath(".."));
            throw new NotImplementedException();
        }
    }
}
