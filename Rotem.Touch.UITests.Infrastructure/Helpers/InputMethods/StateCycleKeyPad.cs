using System;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class StateCycleKeyPad : BaseNumericKeyPad
    {
        public override KeyPad Type
        {
            get { return KeyPad.StateCycleKeyPad; }
        }
        public override InputRange GetRange()
        {
            var keypad = DriverManager.Driver.FindElement(By.CssSelector("div[class*='keypad-state-cycle']"));
            var keypadValuesItems = keypad.FindElements(By.CssSelector("ul[class='keypad-list'] li"));
            var keypadValuesList = keypadValuesItems.Select(item => item.Text).ToList();

            return new InputRange() { RangeList = keypadValuesList };
        }
        public override RangeUnderTest GetTestingRange(InputRange range)
        {
            var testingRange = KeyPadHelper.GetTestingRange(range);
            testingRange.TestRandomStateCycle(testingRange);
            return testingRange;
        }
        public override string CurrentValue
        {
            get
            {
                var keypad = KeyPadHelper.GetActiveKeyPadElement();
                var selectedOption = DriverManager.Driver.FindElement(By.CssSelector("li[class*='selected-icon']"));
                var selectedOptionName = selectedOption.FindElement(By.CssSelector("span[class='icon-description ng-binding']"));
                var currentValue = selectedOptionName.Text;
                try { ClickOkButton(); }
                catch (Exception ex) { };
                return currentValue;
            }
        }
        public override void SetValue(string value)
        {
            var keypad = KeyPadHelper.GetActiveKeyPadElement();
            var options = DriverManager.Driver.FindElements(By.CssSelector("span[class='icon-description ng-binding']"));
            var option = options.Single(opt => opt.Text.Equals(value));

            option.Click();
            ClickOkButton();
        }
        public override void ClearAll()
        {
            throw new NotSupportedException("NumericUpDownKeyPad does not support in ClearAll method.");
        }
    }

    public enum StateCycle
    {
        [StringValue("None")] None,
        [StringValue("Continuous")] Continuous,
        [StringValue("Cycle")] Cycle,
        [StringValue("Rotate")] Rotate,
    }
}
