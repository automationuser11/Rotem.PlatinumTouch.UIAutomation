using System;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class NumericUpDown : ISystemInputMethod
    {
        private readonly IWebElement _element;
        public NumericUpDown() { }
        public NumericUpDown(IWebElement element)
        {
            _element = element;
        }
        public string InputMethodType
        {
            get { throw new NotImplementedException(); }
        }
        public string CurrentValue
        {
            get { throw new NotImplementedException(); }
        }
        public void SetValue(string value)
        {
            throw new NotImplementedException();
        }
        public bool IsInputMethodEnabled()
        {
            throw new NotImplementedException();
        }
        public InputRange GetRange()
        {
            throw new NotImplementedException();
        }
        public RangeUnderTest GetTestingRange(InputRange range)
        {
            throw new NotImplementedException();
        }
    }
}
