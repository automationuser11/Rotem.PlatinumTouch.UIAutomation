using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.Password;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class SettingsPageTests
    {
        public INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }

        [TestMethod]
        [InfrastructureTest]
        public void SettingsFiledTypes_CastingToISettingsFieldIterface_Passed()
        {
            var buttonGroup = new ButtonsGroupSettingsField("Bla");

            SettingsField<ButtonsGroup> baseClass = (SettingsField<ButtonsGroup>)buttonGroup;
            ISettingsField<ISystemInputMethod> genericClass = (ISettingsField<ISystemInputMethod>) baseClass;

            Assert.IsNotNull(genericClass);
        }

        [TestMethod]
        [InfrastructureTest]
        public void T4_SettingsFieldTest()
        {
            PagesFactory.RefreshFactory();
            var page = PagesFactory.GetPage<PasswordPage>();
            Navigator.NavigateTo(page);
            Waits.Wait(4);

            List<IWebElement> errors = new List<IWebElement>();
            var settingsFields = page.GetSettingsFieldCollection();

            foreach (var settingsField in settingsFields)
            {
                var group = SettingsFieldFactory.GetSettingsGroup(settingsField);

                var settings = SettingsFieldFactory.GetSettingsField(settingsField);
                if (settings == null)
                {
                    errors.Add(settingsField);
                    continue;
                }
                var propertyType = settings.GetType().Name;
                var propertyName = SettingsFieldFactory.RemoveNonAlphanumeric(settings.Name);
                var privateMember = "_" + propertyName[0].ToString().ToLower() + propertyName.Remove(0, 1);
            }
        }
    }
}
