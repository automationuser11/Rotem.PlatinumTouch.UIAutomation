using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.MyAccount
{
    public class FarmsPage : IRotemWebPage
    {
        public Uri PageUrl
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { return "My Account"; }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }

        public IEnumerable<string> Titles
        {
            get { throw new NotImplementedException(); }
        }

        internal ReadOnlyCollection<IWebElement> Farms
        {
            get { return DriverManager.Driver.FindElements(By.CssSelector("div[ng-controller='farmsController'] ul[class='user-farms'] li")); }
        }          
        public void SelectFarm(string farmName)
        {
            if (!IsDisplayed()) return;

            var requiredFarm = Farms.Single(farm => farm.FindElement(By.TagName("div")).Text == farmName);
            requiredFarm.ClickAndWait();
        }

        private bool IsDisplayed()
        {
            try
            {
                var navBar = DriverManager.Driver.FindElement(By.CssSelector("ul[class*='navbar-nav']"));
                var title = navBar.FindElement(By.CssSelector("li[class*='gate-name']")).Text;
                return title == Name;
            }
            catch
            {
                return false;
            }
        }
    }
}
