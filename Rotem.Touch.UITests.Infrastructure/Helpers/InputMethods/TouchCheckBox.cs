using System;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class TouchCheckBox : ISystemInputMethod
    {
        private IWebElement _uiElement;
        public TouchCheckBox(){}
        public TouchCheckBox(IWebElement element)
        {
            _uiElement = element.FindElement(By.TagName("input"));
        }
        public void InitUiElement(IWebElement uiElement)
        {
            _uiElement = uiElement.FindElement(By.TagName("input")); 
        }
        public string InputMethodType
        {
            get
            {
                return GetType().ToString();
            }
        }
        public string FieldName { get; set; }
        public string CurrentValue
        {
            get
            {
                return _uiElement.Selected ? "TRUE" : "FALSE";
            }
        }
        public void SetValue(string value)
        {
            switch (value)
            {
                case "TRUE":
                    if (!_uiElement.Selected)
                        _uiElement.JavaClickAndWait();
                    break;
                case "FALSE":
                    if (_uiElement.Selected)
                        _uiElement.JavaClickAndWait();
                    break;
            }

        }
        public bool IsInputMethodEnabled()
        {
            var isCheckedLocator = string.Format(@"return $($(""[name='{0}']"")[0]).is("":checked"")", FieldName);
            return (bool)((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript(isCheckedLocator);
        }
        public InputRange GetRange()
        {
            var range = new InputRange();
            
            range.RangeList.Add(CurrentValue);
            _uiElement.JavaClickAndWait();
            range.RangeList.Add(CurrentValue);
            _uiElement.JavaClickAndWait();

            return range;
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
            //bool isValid = value is Boolean;
            //if (!isValid)
            //    throw new ArgumentException();
            //var realValue = (bool)value;
            var valueToSet = Boolean.Parse(value.ToString());
            var checkbox = context.FindElement(By.TagName("input"));
            var status = (bool)((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript(@" return $(arguments[0]).is("":checked"")", checkbox);

            if (status == valueToSet)
                return;

            checkbox.Click();
        }
    }
}
