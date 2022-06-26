using System;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class TimeKeyPad : ISystemKeyPad
    {
        public KeyPad Type
        {
            get
            {
                return KeyPad.TimeKeyPad;
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
        public InputRange GetRange()
        {
            var staticValues = new InputRange { MinimumMinutes = "00", MaximumMinutes = "59", MinimumHours = "00", MaximumHours = "23" };
            staticValues.Minimum = string.Format("{0}:{1}", staticValues.MinimumHours, staticValues.MinimumMinutes);
            staticValues.Maximum = string.Format("{0}:{1}", staticValues.MaximumHours, staticValues.MaximumMinutes);

            return staticValues;
        }
        public string InputMethodType
        {
            get { return Type.ToString(); }
        }
        public string CurrentValue
        {
            get
            {
                var hours = DriverManager.Driver.FindElement(By.CssSelector("div[class='timer timer-hour']")).FindElement(By.CssSelector("div[class='digits ng-binding']")).Text;
                var minutes = DriverManager.Driver.FindElement(By.CssSelector("div[class='timer timer-min']")).FindElement(By.CssSelector("div[class='digits ng-binding']")).Text;
                return string.Format("{0}:{1}", hours, minutes);
            }
        }
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
            return IsKeyPadActive();
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
        public static bool operator ==(TimeKeyPad x, TimeKeyPad y)
        {
            return x != null && x.Equals(y);
        }
        public static bool operator !=(TimeKeyPad x, TimeKeyPad y)
        {
            return !(x == y);
        }
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
