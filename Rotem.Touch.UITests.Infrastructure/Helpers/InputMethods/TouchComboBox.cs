using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class TouchComboBox : ISystemInputMethod
    {
        private readonly string _labelText;
        private IWebElement _webElement;
        private SelectElement _selectElement;
        public TouchComboBox(){}
        public TouchComboBox(IWebElement uiElement)
        {
            _webElement = uiElement;
            _selectElement = new SelectElement(uiElement);
        }
        public TouchComboBox(IWebElement uiElement, string labelText)
        {
            _webElement = uiElement;
            _labelText = labelText;
            _selectElement = new SelectElement(uiElement);
        }
        public void InitUiElement(IWebElement uiElement)
        {
            _webElement = uiElement;
            _selectElement = new SelectElement(uiElement); 
        }
        public string InputMethodType
        {
            get { return GetType().ToString(); }
        }
        public string CurrentValue
        {
            get
            {
                try
                {
                    return _selectElement.SelectedOption.Text;
                }
                catch (StaleElementReferenceException)
                {
                    var comboLabel = DriverManager.Driver.FindElements(By.CssSelector("div[class*=setting-label]"))
                                                         .Single(item => item.Text == _labelText).GoUp();
                    _selectElement = new SelectElement(comboLabel.FindElement(By.TagName("select")));
                    return _selectElement.SelectedOption.Text;
                }
            }
        }
        public void SetValue(string value)
        {
            if (CurrentValue != value)
            {
                _selectElement.SelectByText(value);
                Thread.Sleep(500);
            }
        }
        public bool IsInputMethodEnabled()
        {
            throw new NotImplementedException();
        }
        public InputRange GetRange()
        {
                _webElement.SendKeys("");
                new Actions(DriverManager.Driver).MoveToElement(_webElement).Perform();
                return new InputRange() { RangeList = _selectElement.Options.Select(item => item.Text).ToList() };
        }
        public RangeUnderTest GetTestingRange(InputRange range)
        {
            return KeyPadHelper.GetTestingRange(range);
        }
        public void SetValue(object value, ISearchContext context)
        {
            var comboCell = context.FindElement(By.TagName("select"));
            comboCell.SendKeys("");
            new Actions(DriverManager.Driver).MoveToElement(comboCell).Perform();
            var inputMethod = new TouchComboBox(comboCell);
            inputMethod.SetValue(value.ToString());
        }
    }
}
