using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard
{
    public partial class DashboardPage
    {
        public class SensorsPanel
        {
            #region Elements Map

            protected IWebElement SensorsPanelElement
            {
                get
                {
                    return DriverManager.Driver.FindElement(By.Id("sensors"));
                }
            }

            #endregion

            public string GetSensorValue(string name)
            {
                bool isValid = false;
                string value = null;
                while (!isValid)
                {
                    try
                    {
                        var sensor = SensorsPanelElement.FindElement(By.XPath(string.Format("//span[contains(text(), '{0}')]/..", name)));
                        value = sensor.FindElement(By.Id("numeric-value-sensors")).Text;
                        isValid = true;
                    }
                    catch (StaleElementReferenceException)
                    {
                        // 
                    }
                }

                return value;
            }
        }
    }
}