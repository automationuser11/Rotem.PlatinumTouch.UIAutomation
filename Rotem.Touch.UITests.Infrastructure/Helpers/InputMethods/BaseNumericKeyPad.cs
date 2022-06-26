using System;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class BaseNumericKeyPad : ISystemKeyPad
    {
        public virtual KeyPad Type
        {
            get
            {
                return KeyPad.BaseNumericKeyPad;
            }
        }
        public void ClickOkButton()
        {
            var keypad = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            var buttons = keypad.FindElements(By.TagName("button"));
            var okBtn = buttons.Single(btn => btn.Text == "OK");
            if (okBtn == null)
                return;
            okBtn.JavaClickAndWait();
        }
        public virtual void ClickCancelButton()
        {
            var keypad = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            var buttons = keypad.FindElements(By.TagName("button"));
            var cancelBtn = buttons.Single(btn => btn.Text == "Cancel");

            cancelBtn.JavaClickAndWait();
        }
        public bool IsKeyPadActive()
        {
            var keypad = DriverManager.Driver.FindElement(By.Id("page-float-ext")).GetAttribute("class");
            return keypad != "ng-hide";
        }
        public virtual InputRange GetRange()
        {
            var keypad = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            var rangeRow = keypad.FindElement(By.ClassName("keypad-range-row"));

            var min = rangeRow.FindElement(By.CssSelector("span[ng-bind*='minValueDisplay']")).Text;
            var max = rangeRow.FindElement(By.CssSelector("span[ng-bind*='maxValueDisplay']")).Text;
            

            return new InputRange() { Minimum = min, Maximum = max};
        }
        public string InputMethodType
        {
            get { return Type.ToString(); }
        }
        public virtual string CurrentValue
        {
            get { throw new NotSupportedException("BaseNumericKeyPad does not hold the current value of the cell its belongs."); }
        }
        public virtual void SetValue(string value)
        {
            var length = value.Length;
            for (int i = 0; i < length; i++)
            {
                var button = GetKeyPadButton(value[i]);
                button.JavaClickAndWait();
            }

            ClickOkButton();
        }
        public virtual void ClearAll()
        {
           // Currently there is no simple way to clear the text in the target cell without breaking the architecture. 
           // Although this implementation is very weak... unless the current value is above 20 characters (unlikely) it should work fine.
           
            var delButton = GetKeyPadButton("del");
            for (int i = 0; i < 8; i++)
            {
                delButton.JavaClickAndWait();
            }
        }
        private IWebElement GetKeyPadButton(string key)
        {
            var keypad = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            var keysContainer = keypad.FindElement(By.ClassName("keypad-keys-container"));
            var keysTable = keysContainer.FindElement(By.TagName("table"));
            var buttons = keysTable.FindElements(By.TagName("td")).Where(item => !item.GetAttribute("class").Contains("keypad-btn ng-hide")).ToList();

            IWebElement bottunToPress;
            try
            {
                bottunToPress = buttons.Single(keyItem => keyItem.GetAttribute("data-key-value") == key);
            }
            catch (Exception)
            {
                KeyPadHelper.ExitEditMode();
                throw new Exception(String.Format("The key: {0} isn't valid!", key));
            }
            return bottunToPress;
        }
        private IWebElement GetKeyPadButton(char key)
        {
            return GetKeyPadButton(key.ToString());
        }
        public bool IsInputMethodEnabled()
        {
            return IsKeyPadActive();
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            return (obj.GetType() == GetType());
        }
        public override int GetHashCode()
        {
            return GetType().FullName.GetHashCode();
        }
        public static bool operator ==(BaseNumericKeyPad x, BaseNumericKeyPad y)
        {
            return x != null && x.Equals(y);
        }
        public static bool operator !=(BaseNumericKeyPad x, BaseNumericKeyPad y)
        {
            return !(x == y);
        }
        public virtual RangeUnderTest GetTestingRange(InputRange range)
        {
            var testingRange = new RangeUnderTest(range);

            if (double.Parse(range.Minimum) >= 1)
            {
                testingRange.Below = (double.Parse(range.Minimum) - 1).ToString();
            }
            else
            {
                testingRange.IsBelowTestPassed = true;
            }

            testingRange.Above = (double.Parse(range.Maximum) + 1).ToString();
            testingRange.TestValueInsideRange();

            return testingRange;
        }


        public void SetValue(object value, ISearchContext context)
        {
            throw new NotImplementedException();
        }
    }
}
