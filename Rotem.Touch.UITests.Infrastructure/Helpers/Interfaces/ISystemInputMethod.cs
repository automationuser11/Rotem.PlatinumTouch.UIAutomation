using System;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface ISystemInputMethod
    {
        string InputMethodType { get; }
        string CurrentValue { get; }

        void SetValue(string value);
        void SetValue(object value, ISearchContext context);
        bool IsInputMethodEnabled();
        InputRange GetRange();
        RangeUnderTest GetTestingRange(InputRange range);
    }
}
