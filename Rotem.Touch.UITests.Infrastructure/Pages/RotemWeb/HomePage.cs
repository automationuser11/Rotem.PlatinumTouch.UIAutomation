using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Overview;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using System.Collections.ObjectModel;

namespace Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb
{
    public class HomePage : IRotemWebPage
    {
        public Uri PageUrl
        {
            get { return UrlFactory.GetUrl<OverviewPage>(); }
        }
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles
        {
            get { throw new NotImplementedException(); }
        }

        #region Elements Mapping

        internal IEnumerable<IWebElement> Houses
        {
            get
            {
                List<IWebElement> houses;
                if (ConfigurationManagerHelper.IsCellularMode)
                {
                    DriverManager.Driver.FindElement(By.CssSelector("button[class*='navbar-toggle pull-left side-menu-button']")).ClickAndWait();
                    houses = DriverManager.Driver.FindElements(By.CssSelector("span[class='number ng-binding']")).ToList();
                    return houses;
                }
               
                var housesList = DriverManager.Driver.FindElements(By.CssSelector(@"div#mainBody div[class*='house-list-sidebar'] li"));
                houses = housesList.Select(item => item.FindElement(By.CssSelector(@"span[class='name ng-binding']"))).ToList();
                return houses;
            }
        }

        #endregion

        internal void SelectHouse(int houseId)
        {
            var house = Houses.Single(h => h.Text.Contains(houseId.ToString()));
            house.ClickAndWait();
        }
    }
}