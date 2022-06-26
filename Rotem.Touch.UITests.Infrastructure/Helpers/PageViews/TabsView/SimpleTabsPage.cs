using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TabsView
{
    public abstract class SimpleTabsPage : ITabsPage
    {
        public abstract string Name { get; }
        public abstract string SubMenu { get; }
        public abstract string MenuName { get; }
        public abstract Uri PageUrl { get; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }
        public IApplicationPageTab this[string tab]
        {
            get
            {
                var properties = GetType().GetProperties();
                var tabs = properties.Where(p => p.PropertyType.GetInterfaces().Any(x => x == typeof(IApplicationPageTab)));

                foreach (PropertyInfo tabProp in tabs)
                {
                    object filedProp = tabProp.GetValue(this, null);
                    PropertyInfo name = filedProp.GetType().GetProperty("Name");
                    if (name.GetValue(filedProp, null).ToString() == tab)
                    {
                        var tabProperty = filedProp as IApplicationPageTab;
                        return tabProperty;
                    }
                }

                throw new ArgumentException("The given tab name is not part of the tabs collection belongs to the page, please check for misspelling...");
            }
        }
        public TabsPageExpectedView ExpectedView
        {
            get { return new TabsPageExpectedView(this);}
        }
        public List<IApplicationPageTab> Tabs
        {
            get
            {
                var properties = this.GetType().GetProperties();
                var tabsProperties = properties.Where(p => p.PropertyType.GetInterfaces().Any(x => x == typeof(IApplicationPageTab)));

                return tabsProperties.Select(tabProp => (IApplicationPageTab) tabProp.GetValue(this, null)).ToList();
            }
        }
        public List<string> TabsNames
        {
            get { return TabPageService.GetTabsNames(); }
        }
    }
    public class TabPageService
    {
        public static IWebElement GetTabButton(string tabName)
        {
            var btnGroup = DriverManager.Driver.WaitForFieldToBeLoaded(By.CssSelector("div[class='btn-group tabs-btn-group']"), Timeouts.Big);
            var buttons = btnGroup.FindElements(By.TagName("label"));
            DriverManager.Driver.WaitForPageContainerToLoaded(30);
            var tabBtn = (buttons.Where(item => item.Text == tabName)).Single();

            return tabBtn;   
        }
        public static void Navigate(string tabName)
        {
            if (IsTabAlreadyPressed(tabName)) return;
            var button = GetTabButton(tabName);
            
            button.TryToClick();
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            DriverManager.Driver.WaitForAjax();
        }
        public static bool IsTabAlreadyPressed(string tabName)
        {
            var button = GetTabButton(tabName);
            //button.Click();removed guy
            return button.WaitForAttributeToContain("class", "active");
        }
        public static List<string> GetTabsNames()
        {
            var btnGroup = DriverManager.Driver.FindElement(By.CssSelector("div[class='btn-group tabs-btn-group']"));
            var buttons = btnGroup.FindElements(By.TagName("label"));
            var names = buttons.Select(button => button.Text).ToList();

            return names;
        }
    }

    public class TabsPageExpectedView
    {
        private readonly ITabsPage tabsPage;

        public TabsPageExpectedView(ITabsPage page)
        {
            tabsPage = page;
        }

        public List<string> GetExpectedTabsNames()
        {
            return ConfigurationsManager.GetTabsNames(tabsPage).ToList();
        }
    }
}
