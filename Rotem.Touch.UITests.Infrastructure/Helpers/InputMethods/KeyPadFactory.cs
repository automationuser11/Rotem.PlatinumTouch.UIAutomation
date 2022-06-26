using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class KeyPadFactory
    {
        private static readonly Dictionary<KeyPad, Type> KeyPadDictionary = new Dictionary<KeyPad, Type>()
        {
            {KeyPad.BaseNumericKeyPad, typeof (BaseNumericKeyPad)},
            {KeyPad.MinusNumericKeyPad, typeof (MinusNumericKeyPad)},
            {KeyPad.MinusPointNumericKeyPad, typeof (MinusPointNumericKeyPad)},
            {KeyPad.PointNumericKeyPad, typeof (PointNumericKeyPad)},
            {KeyPad.TimeKeyPad, typeof (TimeKeyPad)},
            {KeyPad.DateKeyPad, typeof (DateKeyPad)},
            {KeyPad.NumericUpDownKeyPad, typeof (NumericUpDownKeyPad)},
            {KeyPad.StateCycleKeyPad, typeof (StateCycleKeyPad)},
        };

        public static ISystemKeyPad GetKeyPadType(KeyPad keypad)
        {
            return Activator.CreateInstance(KeyPadDictionary[keypad]) as ISystemKeyPad;
        }

        public ISystemKeyPad GetKeyPadType(string keypad)
        {
            var type = (KeyPad) Enum.Parse(typeof(KeyPad), keypad);
            return Activator.CreateInstance(KeyPadDictionary[type]) as ISystemKeyPad;
        }

        public static ISystemKeyPad GetActiveKeyPadType()
        {
            var keypadContainer = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            var keypadCollection = keypadContainer.FindElements(By.CssSelector("div[class*='keypad']")).Where(keypad => !keypad.GetAttribute("class").Contains("arrow"));

            IWebElement activeKeypad = null;

            foreach (var webElement in keypadCollection)
            {
                var style = webElement.GetAttribute("style");
                if (style != string.Empty && (style.Contains("display: block") || !style.Contains("none")))
                {
                    activeKeypad = webElement;
                    break;
                }
            }

            if (activeKeypad == null) return null;

            //var activeKeypad = keypadCollection.First(keypad => keypad.GetAttribute("style").Contains("display: block;"));

            var isDateKeypad = activeKeypad.GetAttribute("class").Equals("keypad-panel-date");
            if(isDateKeypad)
                return Activator.CreateInstance(KeyPadDictionary[KeyPad.DateKeyPad]) as ISystemKeyPad;

            var isTimeKeyPad = activeKeypad.GetAttribute("class").Equals("keypad-panel-time");
            if (isTimeKeyPad)
                return Activator.CreateInstance(KeyPadDictionary[KeyPad.TimeKeyPad]) as ISystemKeyPad;

            var isNumericUpDownKeyPad = activeKeypad.GetAttribute("class").Equals("keypad keypad-panel-numeric-updown");
            if (isNumericUpDownKeyPad)
                return Activator.CreateInstance(KeyPadDictionary[KeyPad.NumericUpDownKeyPad]) as ISystemKeyPad;

            var isStateCycleKeyPad = activeKeypad.GetAttribute("class").Equals("keypad keypad-state-cycle floater");
            if (isStateCycleKeyPad)
                return Activator.CreateInstance(KeyPadDictionary[KeyPad.StateCycleKeyPad]) as ISystemKeyPad;

            var isNumkeyKeypad = activeKeypad.GetAttribute("class").Equals("keypad numkey-pad");
            if (!isNumkeyKeypad) return null;

            var isPointBtnExist = activeKeypad.FindElements(By.CssSelector("td[data-key-value='.']:not([class='keypad-btn ng-hide'])")).Any();
            var isMinusBtnExist = activeKeypad.FindElements(By.CssSelector("td[data-key-value='-']:not([class='keypad-btn ng-hide'])")).Any();
            

            if (isPointBtnExist && isMinusBtnExist)
                return Activator.CreateInstance(KeyPadDictionary[KeyPad.MinusPointNumericKeyPad]) as ISystemKeyPad;

            if (isPointBtnExist)
                return Activator.CreateInstance(KeyPadDictionary[KeyPad.PointNumericKeyPad]) as ISystemKeyPad;

            if (isMinusBtnExist)
                return Activator.CreateInstance(KeyPadDictionary[KeyPad.MinusNumericKeyPad]) as ISystemKeyPad;

            var isPlusBtnExist = activeKeypad.FindElements(By.CssSelector("td[data-key-value='del']:not([class='keypad-btn ng-hide'])")).Any();
            if (isPlusBtnExist)
                return Activator.CreateInstance(KeyPadDictionary[KeyPad.BaseNumericKeyPad]) as ISystemKeyPad;

            throw new NoSuchElementException(string.Format("No such input method! {0}", activeKeypad.GetAttribute("class")));
        }
    }
}
