using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;
using System.Threading;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.LevelsOfVentilation;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.ScaleSettings;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView
{
    public static class SettingsFieldFactory
    {
        public static ISettingsField<ISystemInputMethod> GetSettingsField(IWebElement element)
        {
            ISettingsField<ISystemInputMethod> settingsField = null;

            if (!element.Displayed)
                ((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript("arguments[0].scrollIntoView();", element);

            var name = GetFieldName(element);
            var type = GetSettingsFieldType(element);
            string group;
            try
            {
                group = SettingsFieldFactory.GetSettingsGroup(element);
                if (group != null && group != string.Empty)
                    name = group + "_" + name;
            }
            catch (Exception)
            { return null; }

            if (type is KeyPadSettingsField)
            {
                try
                {
                    ISystemKeyPad keypadType = GetKeypadType(element);
                    if (keypadType.Type == KeyPad.DateKeyPad)
                        return null;
                    settingsField = new KeyPadSettingsField() { Name = name, InputMethod = keypadType };
                }
                catch (Exception) { return null; }
            }
            else if (type is ButtonsGroupSettingsField)
            {
                settingsField = new ButtonsGroupSettingsField(name);
            }
            else if (type is ComboboxSettingsField)
            {
                settingsField = new ComboboxSettingsField(name);
            }
            else if (type is ToggleButtonSettingsField)
            {
                settingsField = new ToggleButtonSettingsField(name);
            }
            else if (type is ReadonlyTextSettingsField)
            {
                settingsField = new ReadonlyTextSettingsField(name);
            }

            return settingsField;
        }

        public static string GetSettingsGroup(IWebElement element)
        {
            var row = element.FindElement(By.XPath(".."));
            row = row.FindElement(By.XPath(".."));
            row = row.FindElement(By.XPath(".."));
            var div = row.FindElements(By.TagName("div"))[0];
            var header = div.FindElement(By.TagName("header"));
            var group = header.Text;

            return group;
        }
        public static string GetFieldName(IWebElement element)
        {
            var xsDiv = element.FindElement(By.TagName("div"));
            return xsDiv.FindElements(By.TagName("div"))[0].Text;
        }
        private static ISystemKeyPad GetKeypadType(IWebElement settingsField)
        {
            var xsDiv = settingsField.FindElement(By.TagName("div"));
            var editArea = xsDiv.FindElements(By.TagName("div"))[1];
            var editBtn = editArea.FindElement(By.CssSelector("div[class='setting-editable']"));

            editBtn.Click();
            Waits.Wait(3);
            var keypadType = KeyPadFactory.GetActiveKeyPadType();

            if (keypadType != null)
                KeyPadHelper.ExitEditMode();
            return keypadType;
        }
        private static ISettingsField<ISystemInputMethod> GetSettingsFieldType(IWebElement element)
        {
            var xsDiv = element.FindElement(By.TagName("div"));
            var settingsInput = xsDiv.FindElements(By.TagName("div"))[1];

            var isKeyPadInput = settingsInput.GetAttribute("class").Equals("setting-view-edit-container pull-right ng-scope");
            if (isKeyPadInput)
                return new KeyPadSettingsField();

            var isButotnGroup = settingsInput.FindElements(By.CssSelector("div[class='btn-group settings-btn-group ng-scope']")).Any();
            if (isButotnGroup)
                return new ButtonsGroupSettingsField("");

            var isComboBox = settingsInput.FindElements(By.TagName("select")).Any();
            if (isComboBox)
                return new ComboboxSettingsField("");

            var isToggleButton = element.FindElements(By.TagName("label")).Any();
            if (isToggleButton)
                return new ToggleButtonSettingsField("");

            var isReadonlyText = settingsInput.FindElements(By.CssSelector("div[class='setting-editable makeIconInvisible']")).Any();
            if (isReadonlyText)
                return new ReadonlyTextSettingsField("");

            return null;
        }
        public static string RemoveNonAlphanumeric(string text)
        {
            StringBuilder sb = new StringBuilder(text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= '0' && c <= '9')
                    sb.Append(text[i]);
            }

            return sb.ToString();
        }

        public static ReadOnlyCollection<IWebElement> GetSettingsFieldCollection(this IApplicationPage settingsPage, bool isSettings)
        {
            var settingsFieldList = new List<IWebElement>();
            if (isSettings)
            {
                if(settingsPage is LevelsOfVentilationPage || settingsPage is ScaleSettingsPage)
                {
                    var LolSettingsContainer = DriverManager.Driver.FindElements(By.Id("help-row"))[1];
                    return LolSettingsContainer.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                }
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                //for (int i = 0; i < settingsContainer.Count; i++)
                //{
                //    settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                //    var settingsFields = settingsContainer[i].FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                //    settingsFieldList.AddRange(settingsFields);
                //}
                foreach (var container in settingsContainer)
                {
                    var settingsFields = container.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                    settingsFieldList.AddRange(settingsFields);
                }

                return settingsFieldList.AsReadOnly();
            }
            if (settingsPage is ISettingsModalViewProvider<ISettingsModal>)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("help-row"))[1];
                if (settingsContainer.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']")).Count == 0)
                    (settingsPage as ISettingsModalViewProvider<ISettingsModal>).SettingsView.Navigate();
                //Waits.Wait(3);
                return settingsContainer.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
            }
            if (settingsPage is ITabsPage)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                foreach (var container in settingsContainer)
                {
                    if (container.Text != string.Empty)
                    {
                        var settingsFields = container.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                        settingsFieldList.AddRange(settingsFields);
                    }
                }
                return settingsFieldList.AsReadOnly();
            }
            
            return null;
        }
        public static ReadOnlyCollection<IWebElement> GetSettingsFieldCollection(this IApplicationPage settingsPage)
        {
            var settingsFieldList = new List<IWebElement>();
            if (settingsPage is ISettingsModalViewProvider<ISettingsModal>)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("help-row"))[1];
                if (settingsContainer.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']")).Count == 0)
                    (settingsPage as ISettingsModalViewProvider<ISettingsModal>).SettingsView.Navigate();
                //Waits.Wait(3);
                return settingsContainer.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
            }
            if (settingsPage is ITabsPage)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                foreach (var container in settingsContainer)
                {
                    if (container.Text != string.Empty)
                    {
                        var settingsFields = container.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                        settingsFieldList.AddRange(settingsFields);
                    }
                }
                return settingsFieldList.AsReadOnly();
            }
            if (settingsPage is ISettingsPage)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                //for (int i = 0; i < settingsContainer.Count; i++)
                //{
                //    settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                //    var settingsFields = settingsContainer[i].FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                //    settingsFieldList.AddRange(settingsFields);
                //}
                foreach (var container in settingsContainer)
                {
                    var settingsFields = container.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                    settingsFieldList.AddRange(settingsFields);
                }

                return settingsFieldList.AsReadOnly();
            }
            return null;
        }
        public static ReadOnlyCollection<IWebElement> GetTableFieldCollection(this IApplicationPage settingsPage, bool isSettings)
        {
            var settingsFieldList = new List<IWebElement>();

            if (isSettings)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("help-row"))[1];
                if (settingsContainer.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']")).Count == 0)
                    (settingsPage as ISettingsModalViewProvider<ISettingsModal>).SettingsView.Navigate();
                Waits.Wait(3);
                return settingsContainer.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
            }
            if (settingsPage is ISettingsPage)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                for (int i = 0; i < settingsContainer.Count; i++)
                {
                    settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                    var settingsFields = settingsContainer[i].FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                    settingsFieldList.AddRange(settingsFields);
                }
                //foreach (var container in settingsContainer)
                //{
                //    var settingsFields = container.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                //    settingsFieldList.AddRange(settingsFields);
                //}

                return settingsFieldList.AsReadOnly();
            }
        
            if (settingsPage is ITabsPage)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                foreach (var container in settingsContainer)
                {
                    if (container.Text != string.Empty)
                    {
                        var settingsFields = container.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                        settingsFieldList.AddRange(settingsFields);
                    }
                }
                return settingsFieldList.AsReadOnly();
            }

            

            return null;
        }

        public static ReadOnlyCollection<IWebElement> GetTableFieldCollection(this IApplicationPage settingsPage)
        {
            var settingsFieldList = new List<IWebElement>();
            if (settingsPage is ISettingsPage)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                for (int i = 0; i < settingsContainer.Count; i++)
                {
                    settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                    var settingsFields = settingsContainer[i].FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                    settingsFieldList.AddRange(settingsFields);
                }
                //foreach (var container in settingsContainer)
                //{
                //    var settingsFields = container.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                //    settingsFieldList.AddRange(settingsFields);
                //}

                return settingsFieldList.AsReadOnly();
            }
            
            if (settingsPage is ISettingsModalViewProvider<ISettingsModal>)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("help-row"))[1];
                if (settingsContainer.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']")).Count == 0)
                    (settingsPage as ISettingsModalViewProvider<ISettingsModal>).SettingsView.Navigate();
                Waits.Wait(3);
                return settingsContainer.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
            }
            if (settingsPage is ITabsPage)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                foreach (var container in settingsContainer)
                {
                    if (container.Text != string.Empty)
                    {
                        var settingsFields = container.FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                        settingsFieldList.AddRange(settingsFields);
                    }
                }
                return settingsFieldList.AsReadOnly();
            }
            return null;
        }

        public static ReadOnlyCollection<IWebElement> GetAlarmSettingsSpecificCollection(this IApplicationPage settingsPage)
        {
            var settingsFieldList = new List<IWebElement>();
            if (settingsPage is ISettingsPage)
            {
                var settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                for (int i = 0; i < settingsContainer.Count; i++)
                {
                    settingsContainer = DriverManager.Driver.FindElements(By.Id("setting-container"));
                    var settingsFields = settingsContainer[i].FindElements(By.CssSelector("div[class='row setting-control-row ng-scope']"));
                    settingsFieldList.AddRange(settingsFields);
                }
                return settingsFieldList.AsReadOnly();
            }
            return null;
        }
    }

    public interface ISettingsField<out T> where T : ISystemInputMethod
    {
        T InputMethod { get; }
        string Name { get; set; }
        string Group { get; set; }
        string CurrentValue { get; }
        InputRange GetFieldRange();
        void SetValue(string value);
        void Reset();
        RangeUnderTest RangeValidation();
        string SetValueThatDifferentThan(string valueToCompare);
        string SetValueGreaterThan(string currentValue);
        string SetValueLowerThan(string currentValue);
        string SetRandomValue();

        event EventHandler ValueChanged;
    }

    public class SettingsField<T> : ISettingsField<T> where T : ISystemInputMethod
    {
        public event EventHandler ValueChanged;
        public string Name { get; set; }
        public string Group { get; set; }
        public virtual T InputMethod { get; set; }
        public virtual string CurrentValue { get { return InputMethod.CurrentValue; } }
        public virtual InputRange GetFieldRange()
        {
            if (InputMethod is ReadonlyText)
            {
                return new InputRange();
            }
            if (InputMethod is TouchCheckBox)
            {
                (InputMethod as TouchCheckBox).FieldName = KeyPadHelper.FindFieldContainer(Name).FindElement(By.TagName("input")).GetAttribute("name");
                return InputMethod.GetRange();
            }
            KeyPadHelper.OpenSettingsFieldKeyPad(Name);
            var fieldRange = InputMethod.GetRange();
            KeyPadHelper.ExitEditMode();
            return fieldRange;
        }
        public virtual void SetValue(string value)
        {
            //OnValueChanged(new SettingsFieldChangedEventArgs() { OldValue = CurrentValue });

            //Ben added this condition
            if (InputMethod.CurrentValue == value) return;
            InputMethod.SetValue(value);
            Thread.Sleep(2000);
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            DriverManager.Driver.WaitForDomReady();
        }
        public virtual void Reset()
        {
            throw new NotImplementedException();
        }
        protected virtual IWebElement FindInputMethodContainer()
        {
            var fieldContainer = DriverManager.Driver.WaitForFieldsToBeLoaded(By.CssSelector("div[class*='setting-label']"), Name, Timeouts.Small);
            return fieldContainer.FindElement(By.XPath(".."));
        }
        protected virtual void OnValueChanged(SettingsFieldChangedEventArgs args)
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, args);
            }
        }
        public RangeUnderTest RangeValidation()
        {
            var actualRange = GetFieldRange();
            var testingRange = InputMethod.GetTestingRange(actualRange);

            if (!(InputMethod is BaseNumericKeyPad)) return testingRange;

            if (testingRange.Below != null)
            {
                SetValue(testingRange.Below);
                testingRange.IsBelowTestPassed = KeyPadHelper.IsWarnningIconAppears;
                KeyPadHelper.ExitEditMode();
            }

            SetValue(testingRange.MinValue);
            testingRange.IsMinValueTestPassed = !KeyPadHelper.IsWarnningIconAppears;
            if (testingRange.IsMinValueTestPassed)
                if (GetCurrentValue() != testingRange.MinValue)
                    testingRange.IsMinValueTestPassed = false;
            KeyPadHelper.ExitEditMode();

            SetValue(testingRange.Inside);
            testingRange.IsInsideTestPassed = !KeyPadHelper.IsWarnningIconAppears;
            if (testingRange.IsInsideTestPassed)
                // if (GetCurrentValue() != testingRange.Inside)
            if (double.Parse(GetCurrentValue()) < double.Parse(testingRange.MinValue) &&  double.Parse(GetCurrentValue()) > double.Parse(testingRange.MaxValue))
                   testingRange.IsInsideTestPassed = false;
          

            KeyPadHelper.ExitEditMode();

            SetValue(testingRange.MaxValue);
            testingRange.IsMaxValueTestPassed = !KeyPadHelper.IsWarnningIconAppears;
            if (testingRange.IsMaxValueTestPassed)
                if (GetCurrentValue() != testingRange.MaxValue)
                    testingRange.IsMaxValueTestPassed = false;
            KeyPadHelper.ExitEditMode();

            SetValue(testingRange.Above);
            testingRange.IsAboveTestPassed = KeyPadHelper.IsWarnningIconAppears;
            KeyPadHelper.ExitEditMode();

            return testingRange;
        }
        public string SetValueThatDifferentThan(string valueToCompare)
        {
            KeyPadHelper.OpenSettingsFieldKeyPad(Name);
            var actualRange = InputMethod.GetRange();
            var valueInsideTheRange = InputMethod.GetTestingRange(actualRange).Inside;
            if (valueToCompare == valueInsideTheRange)
                valueInsideTheRange = double.Parse(valueInsideTheRange) + 1 <= double.Parse(actualRange.Maximum) ? (double.Parse(valueInsideTheRange) + 1).ToString() : (double.Parse(valueInsideTheRange) - 1).ToString();
            else if (actualRange.Minimum == actualRange.Maximum)
                valueInsideTheRange = actualRange.DefaultValue;
            InputMethod.SetValue(valueInsideTheRange);

            return valueInsideTheRange;
        }
        public string SetValueGreaterThan(string currentValue)
        {
            KeyPadHelper.OpenSettingsFieldKeyPad(Name);
            var actualRange = InputMethod.GetRange();
            actualRange.Minimum = currentValue;
            var valueInsideTheRange = InputMethod.GetTestingRange(actualRange).Inside;
            InputMethod.SetValue(valueInsideTheRange);

            return valueInsideTheRange;
        }
        public string SetValueLowerThan(string currentValue)
        {
            KeyPadHelper.OpenSettingsFieldKeyPad(Name);
            var actualRange = InputMethod.GetRange();
            actualRange.Maximum = currentValue;
            var valueInsideTheRange = InputMethod.GetTestingRange(actualRange).Inside;
            InputMethod.SetValue(valueInsideTheRange);

            return valueInsideTheRange;
        }


        public string SetRandomValue()
        {
            KeyPadHelper.OpenSettingsFieldKeyPad(Name);
            var actualRange = InputMethod.GetRange();
            var valueInsideTheRange = InputMethod.GetTestingRange(actualRange).Inside;
            InputMethod.SetValue(valueInsideTheRange);

            return valueInsideTheRange;
        }

        public string GetCurrentValue()
        {
            var rgx = new Regex("[,]");
            var currentValue = FindInputMethodContainer().FindElement(By.CssSelector("div[class='setting-value ng-binding']")).Text;
            return rgx.Replace(currentValue, "");
        }
    }

    public class SettingsFieldChangedEventArgs : EventArgs
    {
        public string OldValue { get; set; }
    }
    public class KeyPadSettingsField : SettingsField<ISystemKeyPad>
    {
        public override string CurrentValue
        {
            get
            {
                var fieldContainer = KeyPadHelper.FindFieldContainer(Name);

                return fieldContainer.FindElement(By.CssSelector("div[class='setting-value ng-binding']")).Text;
            }
        }
        public override void SetValue(string value)
        {
            KeyPadHelper.OpenSettingsFieldKeyPad(Name);
            InputMethod.SetValue(value);
        }
        public void ExitEditingMode()
        {
            InputMethod.ClickCancelButton();
        }
    }
    public class ButtonsGroupSettingsField : SettingsField<ButtonsGroup>
    {
        public ButtonsGroupSettingsField(string name)
        {
            Name = name;
        }
        public override ButtonsGroup InputMethod
        {
            get
            {
                if (_inputMethod != null) return _inputMethod;

                var uiElement = FindInputMethodContainer();
                _inputMethod = new ButtonsGroup(uiElement);

                return _inputMethod;
            }
            set { _inputMethod = value; }
        }
        private ButtonsGroup _inputMethod;
        protected override IWebElement FindInputMethodContainer()
        {
            var filedContainer = KeyPadHelper.FindFieldContainer(Name);
            return filedContainer.FindElement(By.CssSelector("div[class = 'btn-group settings-btn-group ng-scope']"));
        }
        public override string CurrentValue
        {
            get
            {
                var buttonsGroup = FindInputMethodContainer();

                var isExist = DriverManager.Driver.TryFindElement(By.CssSelector("label[class='btn button-label ng-binding ng-scope active']"), buttonsGroup);
                if (isExist == null) return string.Empty;

                var activeButton = buttonsGroup.FindElement(By.CssSelector("label[class='btn button-label ng-binding ng-scope active']"));
                return activeButton.Text.Trim();
            }
        }
        public override InputRange GetFieldRange()
        {
            var buttonsGroup = FindInputMethodContainer();
            var buttons = buttonsGroup.FindElements(By.TagName("label"));
            var buttonsNames = from item in buttons select item.Text;

            return new InputRange() { RangeList = buttonsNames.ToList() };
        }
    }
    public class ComboboxSettingsField : SettingsField<TouchComboBox>
    {
        public ComboboxSettingsField(string name)
        {
            Name = name;
        }
        public override TouchComboBox InputMethod
        {
            get
            {
                if (_inputMethod != null) return _inputMethod;

                var uiElement = FindInputMethodContainer();
                _inputMethod = new TouchComboBox(uiElement, Name);

                return _inputMethod;
            }
            set { _inputMethod = value; }
        }
        private TouchComboBox _inputMethod;
        protected override IWebElement FindInputMethodContainer()
        {
            var filedContainer = KeyPadHelper.FindFieldContainer(Name);
            return filedContainer.FindElement(By.TagName("select"));
        }
        public override string CurrentValue
        {
            get
            {
                var comboBox = FindInputMethodContainer();
                var selectedItem = comboBox.FindElement(By.CssSelector("option[selected='selected']"));

                return selectedItem.Text.Trim();
            }
        }
        public override InputRange GetFieldRange()
        {
            var comboBox = FindInputMethodContainer();
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            var options = comboBox.FindElements(By.TagName("option")).Where(item => item.Text != string.Empty).Select(item => item.Text).ToList();

            return new InputRange() { RangeList = options };
        }
    }
    public class ToggleButtonSettingsField : SettingsField<TouchToggleButton>
    {
        public ToggleButtonSettingsField(string name)
        {
            Name = name;
        }
        public override TouchToggleButton InputMethod
        {
            get
            {
                var uiElement = FindInputMethodContainer();
                _inputMethod = new TouchToggleButton(uiElement);

                return _inputMethod;
            }
            set { _inputMethod = value; }
        }
        private TouchToggleButton _inputMethod;
        protected override IWebElement FindInputMethodContainer()
        {
            var filedContainer = KeyPadHelper.FindFieldContainer(Name);
            return filedContainer.FindElement(By.TagName("label"));
        }
        public override InputRange GetFieldRange()
        {
            var currentValue = InputMethod.CurrentValue;
            FindInputMethodContainer().JavaClickAndWait();
            var secondOption = InputMethod.CurrentValue;
            //Comment this to solve Locator not found error in Bounderies_Co2_2 test
            //SettingsPageSerivce.CancelChanges();

            return new InputRange() { RangeList = { currentValue, secondOption } };
        }
    }
    public class ReadonlyTextSettingsField : SettingsField<ReadonlyText>
    {
        public ReadonlyTextSettingsField(string name)
        {
            Name = name;
        }
        public override ReadonlyText InputMethod
        {
            get
            {
                var uiElement = FindInputMethodContainer();
                _inputMethod = new ReadonlyText(uiElement);

                return _inputMethod;
            }
            set { _inputMethod = value; }
        }
        private ReadonlyText _inputMethod;
        protected sealed override IWebElement FindInputMethodContainer()
        {
            var filedContainer = KeyPadHelper.FindFieldContainer(Name);
            return filedContainer.FindElement(By.CssSelector("div[class='setting-value ng-binding']"));
        }
        public override void SetValue(string value)
        {
            throw new NotSupportedException();
        }
        public override void Reset()
        {
            throw new NotSupportedException();
        }
    }
    public class CheckBoxSettingsField : SettingsField<TouchCheckBox>
    {
        public CheckBoxSettingsField(string name)
        {
            Name = name;
        }
        public override TouchCheckBox InputMethod
        {
            get
            {
                if (_inputMethod != null) return _inputMethod;

                var uiElement = FindInputMethodContainer();
                _inputMethod = new TouchCheckBox(uiElement);

                return _inputMethod;
            }
            set { _inputMethod = value; }
        }
        private TouchCheckBox _inputMethod;
        protected override sealed IWebElement FindInputMethodContainer()
        {
            var filedContainer = KeyPadHelper.FindFieldContainer(Name);
            return filedContainer.FindElement(By.TagName("input"));
        }
        public override void SetValue(string value)
        {
            throw new NotSupportedException();
        }
        public override void Reset()
        {
            throw new NotSupportedException();
        }
    }
    public class DateKeyPadSettingsField : SettingsField<DateKeyPad>
    {
        public DateKeyPadSettingsField(string name)
        {
            Name = name;
        }
        public override DateKeyPad InputMethod
        {
            get
            {
                if (_inputMethod != null) return _inputMethod;

                var uiElement = FindInputMethodContainer();
                _inputMethod = new DateKeyPad(uiElement);

                return _inputMethod;
            }
            set { _inputMethod = value; }
        }
        private DateKeyPad _inputMethod;
    }
}
