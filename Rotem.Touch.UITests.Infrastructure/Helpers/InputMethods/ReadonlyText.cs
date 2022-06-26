using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class ReadonlyText : ISystemInputMethod
    {
        private readonly IWebElement _uiElement;
        public ReadonlyText(IWebElement uiElement)
        {
            _uiElement = uiElement;
        }
        public string InputMethodType { get { return GetType().ToString(); } }
        public string CurrentValue { get { return _uiElement.Text; } }
        public void SetValue(string value)
        {
            throw new NotSupportedException();
        }
        public bool IsInputMethodEnabled()
        {
            return false;
        }
        public InputRange GetRange()
        {
            return new InputRange() {RangeList = new List<string>() {_uiElement.Text}};
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
