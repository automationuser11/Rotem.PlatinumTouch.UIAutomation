using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TimeAndDate;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class ExcelCreatorPageFields
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
        public void CreateExcel_WriteAllPageFieldsToRelatedExcelSheet_ExcelFileWithAllPages()
        {
            var page = PagesFactory.GetPage<TimeAndDatePage>();
            Navigator.NavigateTo(page);
            Waits.Wait(4);

            var settingsFields = page.GetSettingsFieldCollection();

            foreach (var settingsField in settingsFields)
            {
                var fieldName = settingsField.FindElement(By.TagName("div")).FindElement(By.CssSelector("div[class='setting-label pull-left ng-binding']")).Text;


            }
        }
    }
}
