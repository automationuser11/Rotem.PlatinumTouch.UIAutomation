using System;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class NumericUpDownKeyPad : BaseNumericKeyPad
    {
        public IWebElement MinusButton
        {
            get
            {
                var keypad = KeyPadHelper.GetActiveKeyPadElement();
                var minusButton = keypad.FindElement(By.CssSelector("li div[ng-click='decreaseNumber()']"));

                return minusButton;
            }
        }
        public IWebElement PlusButotn
        {
            get
            {
                var keypad = KeyPadHelper.GetActiveKeyPadElement();
                var minusButton = keypad.FindElement(By.CssSelector("li div[ng-click='increaseNumber()']"));

                return minusButton;
            }
        }
        public override KeyPad Type
        {
            get { return KeyPad.NumericUpDownKeyPad; }
        }
        public override InputRange GetRange()
        {
            var keypad = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            var rangeRow = keypad
                                 .FindElements(By.ClassName("keypad-range-row"))
                                 .SingleOrDefault(element => !element.GetAttribute("class").Contains("ng-hide"));

            if(rangeRow == null) throw new NullReferenceException("Can not find range values in NumericUpDownKeyPad");

            var min = rangeRow.FindElement(By.CssSelector("span[class='keypad-min-value ng-binding']")).Text;
            var max = rangeRow.FindElement(By.CssSelector("span[class='keypad-nax-value ng-binding']")).Text;

            return new InputRange() { Minimum = min, Maximum = max };
        }
        public override string CurrentValue
        {
            get
            {
                var keypad = KeyPadHelper.GetActiveKeyPadElement();
                var currentValue = keypad.FindElement(By.CssSelector("li span[class='rounded-display-text ng-binding']"));   

                return currentValue.Text;
            }
        }
        public override void SetValue(string value)
        {
            var currentValue = int.Parse(CurrentValue);
            var newValue = int.Parse(value);

            if(currentValue == newValue) return;
            var delta = currentValue - newValue;
            if (delta > 0)
            {
                for (int i = 0; i < delta; i++)
                {
                    MinusButton.JavaClickAndWait();
                }
            }
            else
            {
                for (int i = 0; i < Math.Abs(delta); i++)
                {
                    PlusButotn.JavaClickAndWait();
                }        
            }

            ClickOkButton();
        }
        public override void ClearAll()
        {
            throw new NotSupportedException("NumericUpDownKeyPad does not support in ClearAll method.");
        }
    }
}
