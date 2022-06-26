using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class PlcDataField : ISystemInputMethod
    {
        private readonly string fieldName;
        public PlcDataField(string name)
        {
            fieldName = name;
        }
        public string InputMethodType
        {
            get { return GetType().Name; }
        }

        public string CurrentValue
        {
            get
            {
                var fieldRow = DriverManager.Driver.FindElements(By.XPath(string.Format("//*[contains(text(), '{0}')]", fieldName))).Last().GoUp(2);
                var fieldValue = fieldRow.FindElements(By.TagName("td"));
                return fieldValue[1].FindElement(By.TagName("label")).Text;
            }
        }

        public void SetValue(string value)
        {
            var fieldLable = DriverManager.Driver.FindElements(By.XPath(string.Format("//*[contains(text(), '{0}')]/..", fieldName))).Last();
            fieldLable.GoUp().FindElement(By.TagName("input")).Click();

            var timeout = new TimeSpan(0, 0, Timeouts.Small);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
                if (DriverManager.Driver.FindElement(By.CssSelector("div[id='divOpEdit']")).GetAttribute("style").Contains("visibility: visible"))
                { 
                    Thread.Sleep(1000);
                    break;
                }

            var textbox = DriverManager.Driver.FindElement(By.Id("txtEdit"));
            textbox.Clear();
            textbox.SendKeys(value);

            var okButton = DriverManager.Driver.FindElement(By.CssSelector("input[id='OkButton']"));
            okButton.Click();

            Thread.Sleep(500);
        }

        public bool IsInputMethodEnabled()
        {
            return true;
        }

        public InputRange GetRange()
        {
            throw new System.NotImplementedException();
        }

        public RangeUnderTest GetTestingRange(InputRange range)
        {
            throw new System.NotImplementedException();
        }


        public void SetValue(object value, ISearchContext context)
        {
            throw new NotImplementedException();
        }
    }
}