using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView
{
    public abstract class SimpleSettingsPage : ISettingsPage
    {
        public List<string> EditSpecificRowContent(IApplicationPage page)
        {
            var SettingsFeildList = page.GetTableFieldCollection();
            string valueInsideRange;
            List<string> cellValues = new List<string>();

            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                if (SettingsFeildList.Count > 50)
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                SettingsFeildList = page.GetTableFieldCollection();
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                if (inputMethod != null)
                {
                    if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                    {
                        var range = inputMethod.GetFieldRange();

                        valueInsideRange = inputMethod.CurrentValue;
                    }
                    else
                    {
                        valueInsideRange = inputMethod.SetRandomValue();
                    }
                    cellValues.Add(valueInsideRange);
                }  
            }
            return cellValues;
        }

        public List<string> EditSpecificRowContent(IApplicationPage page, bool isSettings = false)
        {
            var SettingsFeildList = page.GetTableFieldCollection(isSettings);
            string valueInsideRange;
            List<string> cellValues = new List<string>();

            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                if (SettingsFeildList.Count > 50)
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                SettingsFeildList = page.GetTableFieldCollection(isSettings);
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                if (inputMethod != null)
                {
                    if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                    {
                        var range = inputMethod.GetFieldRange();

                        valueInsideRange = inputMethod.CurrentValue;
                    }
                    else
                    {
                        valueInsideRange = inputMethod.SetRandomValue();
                    }
                    cellValues.Add(valueInsideRange);
                }
            }
            return cellValues;
        }
        public void EditSpecificRowContent(IApplicationPage page, List<string> CellValues)
        {
            var SettingsFeildList = page.GetTableFieldCollection();

            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                if (SettingsFeildList.Count > 50)
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                SettingsFeildList = page.GetTableFieldCollection();
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                {
                    var toggleElement = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var firstOption = toggleElement.Text;
                    toggleElement.JavaClickAndWait();
                }
                else
                {
                    try
                    {
                        inputMethod.SetValue(CellValues[i]);
                        if (KeyPadHelper.IsWarnningIconAppears)
                            KeyPadHelper.ExitEditMode();
                    }
                    catch
                    {
                        KeyPadHelper.ExitEditMode();
                        continue;
                    }
                }
            }
        }
        public void EditSpecificRowContent(IApplicationPage page, List<string> CellValues, bool isSetting=false)
        {
            var SettingsFeildList = page.GetTableFieldCollection(isSetting);

            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                SettingsFeildList = page.GetTableFieldCollection(isSetting);
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                {
                    var toggleElement = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var firstOption = toggleElement.Text;
                    toggleElement.JavaClickAndWait();
                }
                else
                {
                    try
                    {
                        inputMethod.SetValue(CellValues[i]);
                        if (KeyPadHelper.IsWarnningIconAppears)
                            KeyPadHelper.ExitEditMode();
                    }
                    catch
                    {
                        KeyPadHelper.ExitEditMode();
                        continue;
                    }
                }
            }
        }
        public List<List<string>> EditSpecificRowContentAndGetValuesBeforeEdit(IApplicationPage page)
        {
            var SettingsFeildList = page.GetTableFieldCollection();
            string valueInsideRange;
            List<string> cellValuesBefore = new List<string>();
            List<string> cellValues = new List<string>();
            var ReturnedList = new List<List<string>>();
            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                if (SettingsFeildList.Count > 50)
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                SettingsFeildList = page.GetTableFieldCollection();
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);


                if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                {
                    cellValuesBefore.Add(inputMethod.CurrentValue);
                    var toggleElement = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var firstOption = toggleElement.Text;
                    toggleElement.JavaClickAndWait();
                    SettingsFeildList = page.GetTableFieldCollection();
                    var toggleElement1 = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var secondOption = toggleElement1.Text;
                    valueInsideRange = secondOption;
                }
                else
                {
                    cellValuesBefore.Add(inputMethod.CurrentValue);
                    valueInsideRange = inputMethod.SetRandomValue();
                }
                cellValues.Add(valueInsideRange);
            }
            ReturnedList.Add(cellValuesBefore);
            ReturnedList.Add(cellValues);

            return ReturnedList;
        }

        public List<string> EditSpecificRowContentForAlarmSettings(IApplicationPage page)
        {
            var SettingsFeildList = page.GetTableFieldCollection();
            string valueInsideRange;
            List<string> cellValues = new List<string>();
            List<IWebElement> RelevantFieldsList = new List<IWebElement>();
            RelevantFieldsList.Add(SettingsFeildList[2]);
            RelevantFieldsList.Add(SettingsFeildList[6]);
            RelevantFieldsList.Add(SettingsFeildList[4]);
            for (int i = 0; i < RelevantFieldsList.Count; i++)
            {
                SettingsFeildList = page.GetTableFieldCollection();
                List<IWebElement> RelevantFieldsListUpdated = new List<IWebElement>();
                RelevantFieldsListUpdated.Add(SettingsFeildList[2]);
                RelevantFieldsListUpdated.Add(SettingsFeildList[6]);
                RelevantFieldsListUpdated.Add(SettingsFeildList[4]);
                var inputMethod = SettingsFieldFactory.GetSettingsField(RelevantFieldsListUpdated[i]);
                valueInsideRange = inputMethod.SetRandomValue();

                cellValues.Add(valueInsideRange);
            }
            return cellValues;
        }

        public string GetSpecificAlarmSettingsValues(IApplicationPage page)
        {
            var SettingsFeildList = page.GetTableFieldCollection();
            List<string> cellValues = new List<string>();
            var RelevantElement = SettingsFeildList[4];
            var inputMethod = SettingsFieldFactory.GetSettingsField(RelevantElement);
            return inputMethod.CurrentValue;
        }

        public List<string> EditSettingsSpecificRowContent(IApplicationPage page)
        {
            var SettingsFeildList = page.GetSettingsFieldCollection();
            string valueInsideRange;
            List<string> cellValues = new List<string>();

            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                if (SettingsFeildList.Count > 100)
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                SettingsFeildList = page.GetSettingsFieldCollection();
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                {
                    var range = inputMethod.GetFieldRange();

                    valueInsideRange = inputMethod.CurrentValue;
                }
                else
                {
                    valueInsideRange = inputMethod.SetRandomValue();
                }
                cellValues.Add(valueInsideRange);
            }
            return cellValues;
        }

        public List<string> GetSpecificRowContent(IApplicationPage page)
        {
            var SettingsFieldList = page.GetTableFieldCollection();
            List<string> cellValues = new List<string>();

            foreach (var field in SettingsFieldList)
            {
                var inputMethod = SettingsFieldFactory.GetSettingsField(field);
                if(inputMethod != null)
                    cellValues.Add(inputMethod.CurrentValue);
            }
            return cellValues;
        }

        public List<string> GetSpecificRowContent(IApplicationPage page, bool isSettings = false)
        {
            var SettingsFieldList = page.GetTableFieldCollection(isSettings);
            List<string> cellValues = new List<string>();

            foreach (var field in SettingsFieldList)
            {
                var inputMethod = SettingsFieldFactory.GetSettingsField(field);
                if (inputMethod != null)
                    cellValues.Add(inputMethod.CurrentValue);
            }
            return cellValues;
        }

        public List<string> GetSpecificFieldsContent(IApplicationPage page, List<string> fieldsNames)
        {
            var SettingsFieldList = page.GetSettingsFieldCollection();
            List<string> cellValues = new List<string>();

            foreach (var field in SettingsFieldList)
            {
                var inputMethod = SettingsFieldFactory.GetSettingsField(field);
                cellValues.Add(inputMethod.CurrentValue);
            }
            return cellValues;
        }

        public List<string> GetSettingsSpecificRowContent(IApplicationPage page)
        {
            ReadOnlyCollection<IWebElement> SettingsFieldList;
            SettingsFieldList = page.GetSettingsFieldCollection();
            List<string> cellValues = new List<string>();

            foreach (var field in SettingsFieldList)
            {
                var inputMethod = SettingsFieldFactory.GetSettingsField(field);
                cellValues.Add(inputMethod.CurrentValue);
            }
            return cellValues;
        }

        public List<string> GetSettingsSpecificRowContent(IApplicationPage page, bool isSettings)
        {
            ReadOnlyCollection<IWebElement> SettingsFieldList;
            SettingsFieldList = page.GetSettingsFieldCollection(isSettings);
            List<string> cellValues = new List<string>();

            foreach (var field in SettingsFieldList)
            {
                var inputMethod = SettingsFieldFactory.GetSettingsField(field);
                cellValues.Add(inputMethod.CurrentValue);
            }
            return cellValues;
        }

        public bool IsOpen { get; set; }

        public virtual void SaveChanges()
        {
            SettingsPageSerivce.SaveChanges();
            IsOpen = false;
        }
        public virtual void CancelChanges()
        {
            SettingsPageSerivce.CancelChanges();
            IsOpen = false;
        }
        public virtual void ExitEditingMode()
        {
            SettingsPageSerivce.ExitEditingMode();
        }
        public virtual void RestoreInitialSetup()
        {
        }
        public virtual ISettingsField<ISystemInputMethod> this[string field]
        {
            get
            {
                var properties = GetType().GetProperties();
                var settingsFields = properties.Where(p => p.PropertyType.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(ISettingsField<>) && p.SetMethod != null));//p.SetMethod != null
                foreach (PropertyInfo settingsField in settingsFields)
                {
                    object fieldProp = settingsField.GetValue(this, null);
                    PropertyInfo name = fieldProp.GetType().GetProperty("Name");
                    if (name.GetValue(fieldProp, null).ToString() == field)
                    {
                        var settingsFieldProp = fieldProp as ISettingsField<ISystemInputMethod>;
                        return settingsFieldProp;
                    }
                }
                throw new NullReferenceException(string.Format("The field {0} does not exist.", field));
            }
        }

        public bool IsSettingContainerExistsStaticPresure()
        {
            try
            {
                DriverManager.Driver.FindElement(By.XPath("//div[contains(@class, 'setting-control-column')]"));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
        public bool IsSettingContainerExists()
        {
            try
            {
                DriverManager.Driver.WaitForFieldToBeLoaded(By.Id("setting-container"), 30);
                //DriverManager.Driver.FindElements(By.Id("setting-container"));
                //Waits.Wait(10);
                WebDriverExtension.HighlightElementByLocator("setting-container");
                if (DriverManager.Driver.FindElement(By.Id("setting-container")).GetAttribute("class").Contains("ng-hide"))
                    return false;
                //Waits.Wait(10);
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            //var settingContainers = DriverManager.Driver.FindElements(By.Id("setting-container"));
            //var settingContainer = settingContainers.FirstOrDefault(container => !container.GetAttribute("class").Contains("ng-hide"));
            //return settingContainer == null ? false : true;
        }

    }
    public abstract class SimpleSettingsModal : SimpleSettingsPage, ISettingsModal
    {
        public string Title
        {
            get
            {
                var settingsPage = DriverManager.Driver.FindElement(By.CssSelector("div[class*='settings-modal']"));
                return settingsPage.FindElement(By.TagName("span")).Text;
            }
        }
        public virtual void Navigate()
        {
            SettingsPageSerivce.Navigate();
        }
        public virtual void Open()
        {
            if (IsSettingsScreenOpen()) return;

            Waits.Wait(2);
            var settingsBtn = DriverManager.Driver.WaitForSettingsBtnToLoaded(Timeouts.Small);
            settingsBtn.TryToClick(Timeouts.Small);
            IsOpen = true;

            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
        }
        public virtual void Close()
        {
            if (IsSettingsScreenOpen())
            {
                var closeSettingsBtn = DriverManager.Driver.FindElements(By.CssSelector("span[class='icon-cross_rounded']")).Last();
                closeSettingsBtn.TryToClick();
            }
            IsOpen = false;

            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
        }
        public bool IsSettingsButtonExists()
        {
            try
            {
                return DriverManager.Driver.IsElementExists(() => SettingsPageSerivce.SettingsButton);
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
        public bool IsSettingsViewInFocus()
        {
            return IsOpen;
        }
        public bool IsSettingsScreenOpen()
        {
            try
            {
                return !DriverManager.Driver.TryFindElement
                    (By.CssSelector("div[class*='settings-modal']")).GetAttribute("class").Contains("ng-hide");
            }
            catch
            {
                return false;
            }

        }

        public bool IsSettingTableExists()
        {
            try
            {
                DriverManager.Driver.FindElement(By.XPath("//div[contains(@class, 'setting-control')]"));
                //DriverManager.Driver.TryFindElement(By.CssSelector("div[class*='row setting-point-body settings-content']"));
            }
            catch {
                return false;
            }
            return true;

        }

        //public virtual ISettingsField<ISystemInputMethod> EditableColumns(IApplicationPage Page)
        //{
        //        return Page.GetSettingsFieldCollection() as ISettingsField<ISystemInputMethod>;
        //}


        public List<string> EditSpecificRowContent(IApplicationPage page)
        {
            var SettingsFeildList = page.GetTableFieldCollection();
            string valueInsideRange;
            List<string> cellValues = new List<string>();

            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                SettingsFeildList = page.GetTableFieldCollection();
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                if(inputMethod.GetType().Name == "ToggleButtonSettingsField")
                {
                    var range = inputMethod.GetFieldRange();

                    valueInsideRange = inputMethod.CurrentValue;
                }
                else
                {
                    valueInsideRange = inputMethod.SetRandomValue();
                }
                cellValues.Add(valueInsideRange);
            }
            return cellValues;
        }

        public void EditSpecificRowContent(IApplicationPage page , List<string> CellValues)
        {
            var SettingsFeildList = page.GetSettingsFieldCollection();

            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                SettingsFeildList = page.GetSettingsFieldCollection();
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                //if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                //{
                //    var toggleElement = SettingsFeildList[i].FindElement(By.TagName("label"));
                //    toggleElement.JavaClickAndWait();
                //}
                //else
                inputMethod.SetValue(CellValues[i]);
                if (KeyPadHelper.IsWarnningIconAppears)
                    KeyPadHelper.ExitEditMode();
            }
        }

        public List<List<string>> EditSettingsSpecificRowContentAndGetValuesBeforeEdit(IApplicationPage page, bool isSettings = false)
        {
            var SettingsFeildList = page.GetSettingsFieldCollection(isSettings);
            string valueInsideRange;
            List<string> cellValuesBefore = new List<string>();
            List<string> cellValues = new List<string>();
            var ReturnedList = new List<List<string>>();
            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                SettingsFeildList = page.GetSettingsFieldCollection(isSettings);
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                {
                    cellValuesBefore.Add(inputMethod.CurrentValue);
                    var toggleElement = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var firstOption = toggleElement.Text;
                    toggleElement.JavaClickAndWait();
                    SettingsFeildList = page.GetSettingsFieldCollection(isSettings);
                    var toggleElement1 = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var secondOption = toggleElement1.Text;
                    valueInsideRange = secondOption;
                }
                else
                {
                    cellValuesBefore.Add(inputMethod.CurrentValue);
                    valueInsideRange = inputMethod.SetRandomValue();
                    
                }
                cellValues.Add(valueInsideRange);
            }
            ReturnedList.Add(cellValuesBefore);
            ReturnedList.Add(cellValues);

            return ReturnedList;
        }

        public List<string> EditSettingsSpecificRowContent(IApplicationPage page,bool isSettings = false)
        {
            var SettingsFeildList = page.GetSettingsFieldCollection(isSettings);
            string valueInsideRange;
            List<string> cellValues = new List<string>();

            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                SettingsFeildList = page.GetSettingsFieldCollection(isSettings);
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                {
                    var toggleElement = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var firstOption = toggleElement.Text;
                    toggleElement.JavaClickAndWait();
                    SettingsFeildList = page.GetSettingsFieldCollection(isSettings);
                    var toggleElement1 = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var secondOption = toggleElement1.Text;
                    valueInsideRange = secondOption;
                }
                else
                {
                    valueInsideRange = inputMethod.SetRandomValue();
                }
                cellValues.Add(valueInsideRange);
            }
            return cellValues;
        }

        public List<string> EditSettingsSpecificRowContent(IApplicationPage page)
        {
            var SettingsFeildList = page.GetSettingsFieldCollection();
            string valueInsideRange;
            List<string> cellValues = new List<string>();

            for (int i = 0; i < SettingsFeildList.Count; i++)
            {
                SettingsFeildList = page.GetSettingsFieldCollection();
                var inputMethod = SettingsFieldFactory.GetSettingsField(SettingsFeildList[i]);
                if (inputMethod.GetType().Name == "ToggleButtonSettingsField")
                {
                    var toggleElement = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var firstOption = toggleElement.Text;
                    toggleElement.JavaClickAndWait();
                    SettingsFeildList = page.GetSettingsFieldCollection();
                    var toggleElement1 = SettingsFeildList[i].FindElement(By.TagName("label"));
                    var secondOption = toggleElement1.Text;
                    valueInsideRange = secondOption;
                }
                else
                {
                    valueInsideRange = inputMethod.SetRandomValue();
                }
                cellValues.Add(valueInsideRange);
            }
            return cellValues;
        }

        public List<string> GetSpecificRowContent(IApplicationPage page)
        {
            var SettingsFieldList = page.GetTableFieldCollection();
            List<string> cellValues = new List<string>();

            foreach (var field in SettingsFieldList)
            {
                var inputMethod = SettingsFieldFactory.GetSettingsField(field);
                cellValues.Add(inputMethod.CurrentValue);
            }
            return cellValues;
        }

        public List<string> GetAllFields(IApplicationPage page)
        {
            List<string> propList = new List<string>();

            foreach (var item in page.GetType().GetProperties())
            {
                if (item.PropertyType == typeof(KeyPadSettingsField))
                    propList.Add(item.GetType().GetProperty("Name").GetValue(item).ToString());
            }
            return propList;
        }

        public void SetRandomValueInAllFields()
        {
            
        }
    }

    public class SettingsPageSerivce
    {
        #region Elements Mapping

        internal static IWebElement SettingsButton
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div[class='buttonsContainer custom-button pull-right ng-scope']"));
            }
        }

        #endregion

        public static void ExitEditingMode()
        {
            KeyPadHelper.ExitEditMode();
        }
        public static void SaveChanges()
        {
            Waits.Wait(3);
            var saveModal = DriverManager.Driver.TryFindElement(By.CssSelector("div[class*='settings-modal']"));

            if ((saveModal != null) && !saveModal.GetAttribute("class").Contains("ng-hide"))
            {
                var saveBtn = saveModal.FindElement(By.CssSelector("button[ng-click='saveEditSetPoint()']"));
                saveBtn.TryToClick();
            }
            else
            {
                var btnsContainer = DriverManager.Driver.FindElement(By.Id("saveAndCancelPlaceholder"));

                if (!btnsContainer.GetAttribute("class").Contains("ng-hide"))
                {
                    var saveBtn = DriverManager.Driver.FindElement(By.CssSelector("button[ng-click='saveEdit()']"));
                    saveBtn.TryToClick();
                }
            }

            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            Waits.Wait(10);
        }
        public static void CancelChanges()
        {
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();

            var saveModal = DriverManager.Driver.TryFindElement(By.CssSelector("div[class='confirm-save-modal']"));
            var cancelBtn = saveModal != null
                ? saveModal.FindElement(By.CssSelector("button[ng-click='confirmCancelEdit()']"))
                : DriverManager.Driver.FindElement(By.CssSelector("button[ng-click='cancelEditSetPoint()']"));

            if (cancelBtn.Text == "")
                cancelBtn = DriverManager.Driver.FindElement(By.CssSelector("button[ng-click='cancelEdit()']"));

            try
            {
                if (!String.IsNullOrEmpty(cancelBtn.Text))
                    cancelBtn.TryToClick();
            }
            catch (Exception)
            {
                return;
            }

            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
            DriverManager.Driver.WaitForDomReady();
        }
        public static void RestoreInitialSetup()
        {
        }
        public static void Navigate()
        {
            SettingsButton.TryToClick();
        }
        public ISettingsField<ISystemInputMethod> GetSettingsField<T>(string field) where T : ISettingsModal
        {
            var properties = GetType().GetProperties();
            var settingsFields = properties.Where(p => p.PropertyType.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(ISettingsField<>)));

            foreach (PropertyInfo settingsField in settingsFields)
            {
                object filedProp = settingsField.GetValue(this, null);
                PropertyInfo name = filedProp.GetType().GetProperty("Name");
                if (name.GetValue(filedProp, null).ToString() == field)
                {
                    var prop = filedProp as ISettingsField<ISystemInputMethod>;
                    return prop;
                }
            }
            return null;
        }
    }
}
