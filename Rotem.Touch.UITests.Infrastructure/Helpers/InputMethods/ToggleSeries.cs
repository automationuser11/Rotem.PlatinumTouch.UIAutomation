using System;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class ToggleSeries : ISystemInputMethod
    {
        private readonly IWebElement _element;
        public ToggleSeries(){}
        public ToggleSeries(IWebElement element)
        {
            _element = element;
        }
        public string InputMethodType
        {
            get
            {
                return GetType().ToString();
            }
        }
        public string CurrentValue
        {
            get
            {
                throw new NotImplementedException();
            }
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
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            return (obj.GetType() == this.GetType());
        }
        public override int GetHashCode()
        {
            return this.GetType().FullName.GetHashCode();
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
