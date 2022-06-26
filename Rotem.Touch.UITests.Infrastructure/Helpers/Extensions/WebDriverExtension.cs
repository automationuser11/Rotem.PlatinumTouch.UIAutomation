using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Extensions
{
    public static class WebDriverExtension
    {
        public static void WaitForPageContainerToLoaded(this IWebDriver driver, int timeout)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            const string mainPageLocator = "mainContent";
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();

            DriverManager.Driver.SwitchTo().DefaultContent();
            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    driver.FindElement(By.Id(mainPageLocator));
                    if (ConfigurationManagerHelper.IsFarmMode)
                    {
                        DriverManager.Driver.SwitchTo().Frame("ifrmHouseDetails");
                    }
                    return;
                }
                catch (NoSuchElementException)
                {
                    Thread.Sleep(300);
                }
            }

            if (ConfigurationManagerHelper.IsFarmMode)
            {
                DriverManager.Driver.SwitchTo().Frame("ifrmHouseDetails");
            }
        }

        public static IWebElement WaitForSettingsBtnToLoaded(this IWebDriver driver, int timeout)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();
            
            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    var settingsHeader = DriverManager.Driver.FindElement(By.CssSelector("div[class*='single-row-header pull-right']"));
                    var buttonsContainer = settingsHeader.FindElements(By.CssSelector("div[class*='buttonsContainer custom-button']"));

                    /*The follwing rows remove by Guy Gutman
                      var buttonContainer = buttonsContainer
                        .SingleOrDefault(btnContainer => !(btnContainer.GetAttribute("class").Contains("ng-hide")));
                    if (buttonContainer != null)
                    {
                        var settingsBtn = driver.FindElement(By.CssSelector("div[class='icon-setting icon-cog']"));
                        
                        return settingsBtn;
                    }
                    */
                    //sefi add the above rows becuase of a bug in reading the setting button in levels of ventilation while switching tabs
                    if (buttonsContainer.Count > 1)
                    {
                        var buttonContainer = buttonsContainer.FirstOrDefault(btnContainer => !(btnContainer.GetAttribute("class").Contains("ng-hide")));
                        if (buttonContainer != null)
                        {
                            var settingsBtn = buttonContainer.FindElement(By.CssSelector("div[class='icon-setting icon-cog']"));

                            return settingsBtn;
                        }
                    }

                    if (buttonsContainer != null)
                    {
                        var settingsBtn = driver.FindElement(By.CssSelector("div[class='icon-setting icon-cog']"));
                        
                        return settingsBtn;

                    }
                }
               
                catch (Exception)
                {
                    Thread.Sleep(300);
                }
            }
            throw new NoSuchElementException("Can't find settings button element");
        }

        public static bool WaitForPageLoadingToComplete(this IWebDriver driver, IApplicationPage page, int timeout)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            var locator = GetManadatoryComponentLocator(page);

            if (locator == null)
            {
                return true;
            }

            var timeToWait = new TimeSpan(0, 0, timeout);
            Stopwatch sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    DriverManager.Driver.FindElement(locator);
                    return true;
                }
                catch (Exception)
                {
                    Thread.Sleep(300);
                }
            }

            throw new NoSuchElementException(locator.ToString());
        }

        public static IWebElement WaitForFieldToBeLoaded(this IWebDriver driver, By locator, int timeout)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    var container = DriverManager.Driver.FindElement(locator);
                    return container;
                }
                catch (Exception)
                {
                    Thread.Sleep(300);
                }
            }

            throw new NoSuchElementException("Couldn't find locator: " + locator);
        }

        public static IWebElement WaitForFieldsToBeLoaded(this IWebDriver driver, By locator, string fieldString, int timeout)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    var container = DriverManager.Driver.FindElements(locator);
                    return container.First(field => field.Text == fieldString);
                }
                catch (Exception)
                {
                    Thread.Sleep(300);
                }
            }
            throw new NoSuchElementException(string.Format("Couldn't find locator: {0} with value {1}.", locator, fieldString));
        }

        public static ReadOnlyCollection<IWebElement> WaitForFieldsToBeLoaded(this IWebElement driver, By locator, int timeout = Timeouts.Small)
        {
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    var items = DriverManager.Driver.FindElements(locator);
                    if (items.Count > 0)
                        return items;
                }
                catch (Exception)
                {
                    Thread.Sleep(300);
                }
            }
            throw new NoSuchElementException("Couldn't find locator: " + locator);
        }

        public static ReadOnlyCollection<IWebElement> WaitForNumberOfElementsGreaterTahnZero(this IWebElement driver, By locator, int timeout = Timeouts.Small)
        {
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    var elements = DriverManager.Driver.FindElements(locator);
                    if (elements.Count > 0)
                        return elements;
                }
                catch (Exception)
                {
                    Thread.Sleep(700);
                }
            }
            throw new NoSuchElementException("Couldn't find locator: " + locator);
        }

        public static bool IsElementExists(this IWebDriver driver, Func<IWebElement> uiElement, int timeout = Timeouts.Big)
        {
            PagesFactory.GetPage<TopMenuBarPage>().ClickUnLockButton();
            driver.WaitForLoadingSpinnerToBeLoaded();
            driver.WaitForPageContainerToLoaded(30);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            var element1 = wait.Until(d =>
            {
                try
                {
                    var element = uiElement(); // Fetching the element by calling the get accessor
                    return element;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
                catch (ElementNotVisibleException)
                {
                    return null;
                }
                catch (TargetInvocationException)
                {
                    return null;
                }
                catch (InvalidOperationException)
                {
                    return null;
                }
            });
            return element1 != null ? element1.Displayed : false;
        }

        public static bool IsElementDisplayed(this IWebDriver driver, string locator, int timeout = Timeouts.Big)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            driver.WaitForPageContainerToLoaded(30);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(By.Id(locator));
                    return elementToBeDisplayed.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
                catch (InvalidOperationException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
            return true;
        }
        
        public static bool IsTableElementExists(this IWebDriver driver, Func<IWebElement> uiElement)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            driver.WaitForPageContainerToLoaded(30);
            try
            {
                var element = uiElement();
                
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (ElementNotVisibleException)
            {
                return false;
            }
            catch (TargetInvocationException)
            {
                return false;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }

        public static IWebElement ClickOnInvisibleElement(this IWebDriver driver, By by)
        {
            var element = driver.FindElement(by);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].hidden = false;", element);
            element.Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].hidden = true;", element);
            return element;
        }

        public static IWebElement ClickOnInvisibleElement(this IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].hidden = false;", element);
            element.Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].hidden = true;", element);
            return element;
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, string errorMsg)
        {
            try
            {
                IWebElement element = driver.FindElement(by);
                return element;
            }
            catch (NoSuchElementException e)
            {
                throw new NoSuchElementException(errorMsg, e);
            }
        }

        public static IWebElement TryFindElement(this IWebDriver driver, By by, IWebElement scope = null)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            try
            {
                var element = scope != null ? scope.FindElement(@by) : driver.FindElement(@by);

                return element;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebElement TryFindElement(this IWebElement element, By by)
        {
            try
            {
                var resultElement = element.FindElement(@by);
                return resultElement;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static IWebElement WaitForFieldToBeLoaded(this IWebElement element, By locator, int timeout = Timeouts.Small)
        {
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    var container = element.FindElement(locator);
                    return container;
                }
                catch (Exception)
                {
                    Thread.Sleep(300);
                }
            }

            throw new NoSuchElementException("Couldn't find locator: " + locator);
        }
        public static bool WaitForAttributeToContain(this IWebElement element, string attributeName, string locator, int timeout = Timeouts.Small)
        {
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    var container = element.GetAttribute(attributeName).Contains(locator);
                    return container;
                }
                catch (Exception)
                {
                    Thread.Sleep(300);
                }
            }

            throw new NoSuchElementException("Couldn't find locator: " + locator);
        }

        public static ReadOnlyCollection<IWebElement> TryFindElements(this IWebElement element, By by)
        {
            try
            {
                var resultElements = element.FindElements(@by);
                return resultElements;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static By GetManadatoryComponentLocator(object page)
        {
            DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
            var properties = page.GetType().GetProperties();
            return (from propertyInfo in properties select Attribute.GetCustomAttribute(propertyInfo, typeof(MandatoryComponentAttribute)) into customAttributes where customAttributes != null select customAttributes as MandatoryComponentAttribute into mandatoryComponentAttriubue select (By)typeof(MandatoryComponentAttribute).GetProperty("Finder", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(mandatoryComponentAttriubue)).FirstOrDefault();
        }

        public static void HighlightElement(this IWebDriver driver, IWebElement element)
        {
            var jsDriver = (IJavaScriptExecutor)driver;

            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red"";";
            jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
        }

        public static void HighlightElementByLocator(string elementPathId)
        {
            var jsDriver = (IJavaScriptExecutor)DriverManager.Driver;
            var element = DriverManager.Driver.FindElement(By.Id(elementPathId));
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red"";";
            jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
        }


        public static void WaitForAjax(this IWebDriver driver)
        {
            try
            {
                var timeout = new TimeSpan(0, 0, 30);
                var jsDriver = (IJavaScriptExecutor)driver;
                Stopwatch sw = Stopwatch.StartNew();

                while (sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
                {
                    bool isAjaxFinished = (bool)((IJavaScriptExecutor)driver).ExecuteScript("return jQuery.active == 0");
                    bool isLoaderHidden = (bool)((IJavaScriptExecutor)driver).ExecuteScript("return $('.spinner').is(':visible') == false");
                    if (isAjaxFinished & isLoaderHidden) return;
                    DriverManager.Driver.Navigate().Refresh();
                    Thread.Sleep(500);
                    

                    //Object numberOfAjaxConnections = jsDriver.ExecuteScript("return jQuery.active");
                    //// return should be a number
                    //if (numberOfAjaxConnections is Int64)
                    //{
                    //    var n = (Int64)numberOfAjaxConnections;
                    //    if (n == 0L)
                    //    {
                    //        Thread.Sleep(1000);
                    //        return;
                    //    }
                    //}

                    //Thread.Sleep(1500);
                }
            }
            catch
            {
                throw new TimeoutException("Waiting for AJAX to exceeds its time limit.");
            }
            Thread.Sleep(1500);
        }

        public static void VoodooClick(this IWebDriver driver, IWebElement element)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            var id = element.GetAttribute("id");
            if (id == string.Empty)
            {
                id = Guid.NewGuid().ToString();
                ((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript("arguments[0].setAttribute('id', arguments[1])", element, id);
            }

            var elementNew = DriverManager.Driver.FindElement(By.Id(id));
            ((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript("arguments[0].click();", elementNew);
        }

        public static void WaitForDomReady(this IWebDriver driver, int timeout = Timeouts.Small)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static void WaitForSpecificFieldDomReady(this IWebDriver driver, By by, int timeout = Timeouts.Small)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeout));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(by));
        }

        public static void ConditionalWait(this IWebDriver driver, Func<bool> condition, int timeout = Timeouts.Small)
        {
            driver.WaitForLoadingSpinnerToBeLoaded();
            var timout = new TimeSpan(0, 0, timeout);
            Stopwatch sw = Stopwatch.StartNew();

            while (sw.ElapsedMilliseconds < timout.TotalMilliseconds)
            {
                try
                {
                    if (condition())
                    {
                        Thread.Sleep(2000);
                        return;
                    }
                }
                catch
                {

                }

                Thread.Sleep(2500);
            }

            throw new TimeoutException("Waiting for condition to exceeds its time limit.");
        }

        public static IWebElement GoUp(this IWebElement element, int levelsUp = 1)
        {
            for (int i = 0; i < levelsUp; i++)
            {
                element = element.FindElement(By.XPath(".."));
            }

            return element;
        }

        internal static bool TryToClick(this IWebElement element, int timeout = Timeouts.Small)
        {
            var timeToWait = new TimeSpan(0, 0, timeout);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
            {
                try
                {
                    element.JavaClickAndWait();
                    Thread.Sleep(1500);
                    DriverManager.Driver.WaitForLoadingSpinnerToBeLoaded();
                    DriverManager.Driver.WaitForAjax();
                    return true;
                }
                catch (Exception)
                {
                    Thread.Sleep(300);
                }
            }
            return false;
        }

        public static void WaitForSaveAndCancelButtonToBeLoaded(this IWebDriver driver, int timeToWait = Timeouts.Big)
        {
            var timeout = new TimeSpan(0, 0, timeToWait);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
            {
                try
                {
                    DriverManager.Driver.WaitForFieldToBeLoaded(By.CssSelector("div[class='saveAndCancel']"), Timeouts.Small);
                    return;
                }
                catch (NoSuchElementException)
                {
                    Thread.Sleep(1000);
                }
            }

            throw new TimeoutException("Waiting for spinner loading to exceeds its time limit.");
        }

        public static void WaitForLoadingSpinnerToBeLoaded(this IWebDriver driver, int timeToWait = Timeouts.Big)
        {
            var timeout = new TimeSpan(0, 0, timeToWait);
            var sw = Stopwatch.StartNew();

            DriverManager.Driver.SwitchTo().DefaultContent();
            while (sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
            {
                try
                {
                    driver.FindElement(By.CssSelector("html[class*='nprogress-busy']"));
                }
                catch (NoSuchElementException)
                {
                    try
                    {
                        //@ToDo: BAD BAD BAD implementation! Fix it NOW! 
                        if (ConfigurationManagerHelper.IsFarmMode)
                        {
                            DriverManager.Driver.SwitchTo().Frame("ifrmHouseDetails");
                        }
                        return;
                    }
                    catch (NoSuchFrameException)
                    {
                    }
                }
            }
        }

        public static void WaitForLoadingMaessageDissapear(this IWebDriver driver, int timeToWait = Timeouts.FirstLoad)
        {
            var timeout = new TimeSpan(0, 0, timeToWait);
            var sw = Stopwatch.StartNew();
            try
            {
                IWebElement loadingPage = driver.FindElement(By.CssSelector("div[class='loading-message']"));

                while (loadingPage.Displayed && timeout.TotalMilliseconds > sw.ElapsedMilliseconds)
                {
                    Thread.Sleep(1000);
                }
            }
            catch
            {
            }

        }

        public static void RefreshTable(this IWebDriver driver, bool isSettings = false)
        {       
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            IWebElement refreshButton;
            driver.WaitForLoadingSpinnerToBeLoaded();
            try
            {
                if (!isSettings)
                {
                    if (!DriverManager.Driver.FindElement(By.Id("saveAndCancelPlaceholder")).GetAttribute("class").Contains("ng-hide"))
                        Waits.Wait(1);
                    refreshButton = WaitForFieldToBeLoaded(driver, By.XPath("//div[contains(@class, 'buttonsContainer')]/div[@class='setting']/div[contains(@class, 'fa-refresh')]"), Timeouts.Big);
                }

                else
                {
                    if (!DriverManager.Driver.FindElement(By.ClassName("setting-poing-buttons-div")).GetAttribute("class").Contains("ng-hide"))
                        Waits.Wait(1);
                    refreshButton = WaitForFieldToBeLoaded(driver, By.XPath("//*[@id='ngViewContainer']/div/div/div/div[4]/div/div[1]/div[2]/div[2]/span"), Timeouts.Big);
                }
                js.ExecuteScript("arguments[0].style='color: red;'", refreshButton);
                refreshButton.Click();
                driver.WaitForLoadingSpinnerToBeLoaded();
                Waits.Wait(2);
            }
            catch (Exception) {
                Waits.Wait(1);
                return; }
        }
        
    }
}
