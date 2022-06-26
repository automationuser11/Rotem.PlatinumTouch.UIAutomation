using System.Drawing;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.GraphView
{
    public class SimpleGraphPage : IGraphPage
    {
        #region Elements Mapping

        internal IWebElement GraphButton
        {
            get { return DriverManager.Driver.FindElement(By.CssSelector("div.icon.icon-graph")); }
        }

        //public IWebElement TableButton { get; private set; }
        internal IWebElement TableButton
        {
            //Gutman
            get { return DriverManager.Driver.FindElement(By.CssSelector("div.icon.icon-grid")); }
        }


        #endregion

        public void Navigate()
        {
            DriverManager.Driver.WaitForFieldToBeLoaded(By.CssSelector("div[class='icon icon-graph'"), Timeouts.Small).TryToClick();

            var togglesBtns = DriverManager.Driver.FindElement(By.Id("toggles-buttons"));
            var activeView = togglesBtns.FindElement(By.CssSelector("div[class='single-toggle active']")).GetAttribute("data-type");

            if (activeView == "G")  // G = graph view is active.
            {
                DriverManager.Driver.ConditionalWait(() => togglesBtns.Size != Size.Empty);
                return;
            }

            // In case that table view is active
            var isExist = DriverManager.Driver.IsElementExists(() => GraphButton);
            if (isExist)
            {
                GraphButton.Click();
                DriverManager.Driver.WaitForDomReady();
                return;
            }

            // In case that settings view is active
            Browser.Reload();
            DriverManager.Driver.WaitForDomReady();

            isExist = DriverManager.Driver.IsElementExists(() => GraphButton);
            if (!isExist) return;
            GraphButton.Click();
            DriverManager.Driver.WaitForDomReady();
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
        }

        public bool IsGraphButtonExists()
        {
            return DriverManager.Driver.IsElementExists(() => GraphButton);
        }

        public bool IsTableButtonExists()
        {
            //Gutman add
            return DriverManager.Driver.IsElementExists(() => TableButton);
        }

        public bool IsGraphViewExists()
        {
            //PagesFactory.GetPage<TopMenuBarPage>().ClickUnLockButton();
            var chart = DriverManager.Driver.FindElement(By.Id("page-Chart"));

            return chart.FindElements(By.CssSelector("div[class='highcharts-container']")).SingleOrDefault() != null;
        }
    }
}
