using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using System.Threading;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.HouseDimensions
{
    public class HouseDimensionsPage : GridTablePage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<HouseDimensionsPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "House Dimensions"; }
        }
        public string MenuName
        {
            get { return "House Dimensions"; }
        }
        public string SubMenu { get { return "System"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }
        public bool IsSchemaHouseDimensionsExists()
        {
            try
            { DriverManager.Driver.FindElement(By.CssSelector("div[class*='house-div']")); return true; }
            catch (NoSuchElementException)
            { return false; }
        }

        public void HDSaveChanges()
        {
            DriverManager.Driver.FindElement(By.XPath("//button[contains(@class, 'button-save-house-dimention')]")).Click();
            Thread.Sleep(1500);
        }

        public void HDCancelChanges()
        {
            DriverManager.Driver.FindElements(By.XPath("//button[contains(@class, 'button-save-house-dimention')]"))[1].Click();
            var x = 10;
            Thread.Sleep(1500);
        }
    }
}
