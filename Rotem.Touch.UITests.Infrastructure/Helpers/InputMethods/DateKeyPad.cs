using System;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class DateKeyPad : ISystemKeyPad
    {
        private readonly IWebElement _element;
        public DateKeyPad() { }
        public DateKeyPad(IWebElement element)
        {
            _element = element;
        }
        public KeyPad Type
        {
            get
            {
                return KeyPad.DateKeyPad;
            }
        }

        public void ClickOkButton()
        {
            var keypad = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            var buttons = DriverManager.Driver.FindElements(By.TagName("button"));
            var okBtn = buttons.Single(btn => btn.Text == "OK");

            okBtn.JavaClickAndWait();
        }
        public void ClickCancelButton()
        {
            var keypad = DriverManager.Driver.FindElement(By.Id("page-float-ext"));
            var buttons = keypad.FindElements(By.TagName("button"));
            var cancelBtn = buttons.Single(btn => btn.Text == "Cancel");

            cancelBtn.JavaClickAndWait();
        }
        public bool IsKeyPadActive()
        {
            return DriverManager.Driver.FindElements(By.CssSelector("div[class='keypad numkey-pad']")).Any();
        }

        public string InputMethodType {get; private set;}

            //Ben added, same as TimeKeyPad implemention, has to be fixed.
        //public string CurrentValue { get { return _element.FindElement(By.CssSelector("div[class='setting-value ng-binding']")).Text; } }
        public string CurrentValue
        {
            get
            {
                var hours = DriverManager.Driver.FindElement(By.CssSelector("div[class='timer timer-hour']")).FindElement(By.CssSelector("div[class='digits ng-binding']")).Text;
                var minutes = DriverManager.Driver.FindElement(By.CssSelector("div[class='timer timer-min']")).FindElement(By.CssSelector("div[class='digits ng-binding']")).Text;
                return string.Format("{0}:{1}", hours, minutes);
            }
        }

        //Ben added, same as TimeKeyPad implemention, has to be fixed.
        //public void SetValue(string value)
        //{
        //    // Need to implement
        //}

        public void SetValue(string value)
        {
            var currentTime = CurrentValue;
            var time = value.Split(':');
            var currentTimeHour = currentTime.Split(':');

            int numberOfHoursToEdit;
            int numberOfMinutesToEdit;
            try
            {
                var hour = int.Parse(time[0]);
                var minutes = int.Parse(time[1]);
                var currentHour = int.Parse(currentTimeHour[0]);
                var currentMinutes = int.Parse(currentTimeHour[1]);
                numberOfHoursToEdit = hour - currentHour;
                numberOfMinutesToEdit = minutes - currentMinutes;
            }
            catch (Exception)
            {
                ClickCancelButton();
                throw new Exception("Wrong KeyPad time!");
            }

            #region Edit Hours

            if (numberOfHoursToEdit > 0)
            {
                while (numberOfHoursToEdit > 0)
                {
                    DriverManager.Driver.FindElement(By.CssSelector("div[class='timer timer-hour']")).FindElement(By.CssSelector("div[class='keypad-keys keypad-keys-top']")).JavaClickAndWait();
                    numberOfHoursToEdit--;
                }
            }
            else
            {
                while (numberOfHoursToEdit < 0)
                {
                    DriverManager.Driver.FindElement(By.CssSelector("div[class='timer timer-hour']")).FindElement(By.CssSelector("div[class='keypad-keys keypad-keys-bottom']")).JavaClickAndWait();
                    numberOfHoursToEdit++;
                }
            }

            #endregion

            #region Edit Minutes

            if (numberOfMinutesToEdit > 0)
            {
                while (numberOfMinutesToEdit > 0)
                {
                    DriverManager.Driver.FindElement(By.CssSelector("div[class='timer timer-min']")).FindElement(By.CssSelector("div[class='keypad-keys keypad-keys-top']")).JavaClickAndWait();
                    numberOfMinutesToEdit--;
                }
            }
            else
            {
                while (numberOfMinutesToEdit < 0)
                {
                    DriverManager.Driver.FindElement(By.CssSelector("div[class='timer timer-min']")).FindElement(By.CssSelector("div[class='keypad-keys keypad-keys-bottom']")).JavaClickAndWait();
                    numberOfMinutesToEdit++;
                }
            }

            #endregion

            ClickOkButton();
        }

        public bool IsInputMethodEnabled()
        {
            throw new NotImplementedException();
        }
        //public InputRange GetRange()
        //{
        //    //TODO: Need to implement
        //    return new InputRange();
        //}

            //Ben added, same as TimeKeyPad implemention, has to be fixed.
        public InputRange GetRange()
        {
            var staticValues = new InputRange { MinimumMinutes = "00", MaximumMinutes = "59", MinimumHours = "00", MaximumHours = "23" };
            staticValues.Minimum = string.Format("{0}:{1}", staticValues.MinimumHours, staticValues.MinimumMinutes);
            staticValues.Maximum = string.Format("{0}:{1}", staticValues.MaximumHours, staticValues.MaximumMinutes);

            return staticValues;
        }

        protected bool Equals(DateKeyPad other)
        {
            return true; // for now it's sufficient
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((DateKeyPad)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return ((InputMethodType != null ? InputMethodType.GetHashCode() : 0)*397) ^ (CurrentValue != null ? CurrentValue.GetHashCode() : 0);
            }
        }
        //public RangeUnderTest GetTestingRange(InputRange range)
        //{
        //    return KeyPadHelper.GetTestingRange(range);
        //}
            //Ben added, same as TimeKeyPad implemention, has to be fixed.
        public RangeUnderTest GetTestingRange(InputRange range)
        {
            var testingRange = KeyPadHelper.GetTestingRange(range);

            testingRange.TestTimeInsideRange();
            return testingRange;
        }

        public void SetValue(object value, ISearchContext context)
        {
            throw new NotImplementedException();
        }
    }
}
