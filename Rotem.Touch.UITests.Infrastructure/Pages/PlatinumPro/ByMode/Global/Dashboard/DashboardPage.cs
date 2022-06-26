using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Co2Treatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.HumidityTreatment;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.StaticPressure;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.TemperatureCurve;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.BirdWeightHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.FeedConsumptionHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.FeedConversionHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.PowerConsumptionHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.History.WaterHistory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.BirdInventory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedInventory;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.LevelsOfVentilation;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Global.Dashboard
{
    public partial class DashboardPage : IApplicationPage
    {
        public Uri PageUrl
        {
            get { return UrlFactory.GetUrl<DashboardPage>(); }
        }
        public string Name { get { return "Main Dashboard"; } }
        public string SubMenu { get { return "Dashboard"; } }
        public string MenuName { get { return ""; } }
        IEnumerable<string> IApplicationPage.Titles
        {
            get { return new List<string>(); }
        }
        public SensorsPanel Sensors { get { return new SensorsPanel(); }}
        public DevicesTablePage DevicesTable { get { return new DevicesTablePage(); } }

        #region Elements Mapping

        internal IWebElement AverageTemperatureTitle
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div[ng-click='navigateToPage(C_MenuID_AverageTemperature)']"));
            }
        }

        internal IWebElement VentLevelTitle
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector(@"span.noWrap.ng-binding"));
            }
        }

        internal IWebElement LivabilityTitle
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector(@"#livability > div.row > div.col-xs-8 > span.title > span.ng-binding"));
            }
        }

        internal IWebElement Last24TemperatureTitle
        {
            get
            {
                return DriverManager.Driver.FindElement(By.XPath(@"//div[@id='last24HoursTemperatureModule']/div/div"));
            }
        }

        internal IWebElement AvgBirdWeightTitle
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div[ng-click='navigateToPage(C_MenuID_HistoryBirdsWeight)']"));
            }
        }

        internal IWebElement DevicesTableElement
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div[class='module-flat dashboardGrid'] ul[class='device-list']"));
            }
        }

        internal IWebElement HumidityTitle
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("span[class='regular-small ng-binding']"));
            }
        }

        internal IWebElement PressureTitle
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div[ng-click='navigateToPage(C_MenuID_Pressure)']"));
            }
        }

        internal IWebElement Co2Title
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div[ng-click='navigateToPage(C_MenuID_CO2)']"));
            }
        }

        internal IWebElement AnalogDevicesTable
        {
            get
            {
                return DriverManager.Driver.FindElement(By.Id(@"analogDevices"));
            }
        }

        internal IWebElement SensorPanel
        {
            get { return DriverManager.Driver.FindElement(By.Id("sensors")); }
        }

        internal IWebElement DailyConsumptionPanel
        {
            get
            {
                return DriverManager.Driver.FindElement(By.Id(@"dailyConsumption"));
            }
        }

        internal IWebElement FeedInventoryTile
        {
            get { return DriverManager.Driver.FindElement(By.Id("feedInventory")); }
        }

        internal IWebElement WaterConsumption
        {
            get { return DriverManager.Driver.FindElement(By.CssSelector("div[ng-click='navigateToPage(C_MenuID_HistoryWater)']")); }
        }

        internal IWebElement FeedConsumption
        {
            get { return DriverManager.Driver.FindElement(By.CssSelector("div[ng-click='navigateToPage(C_MenuID_HistoryFeed)']")); }
        }

        internal IWebElement FCR
        {
            get { return DriverManager.Driver.FindElement(By.CssSelector("div[ng-click='navigateToPage(C_MenuID_FeedConsumptionRate)']")); }
        }

        #endregion

        #region Building Blocks Validation

        public bool IsAverageTemperaturePanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => AverageTemperatureTitle);
        }

        public bool IsVentLevelPanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => VentLevelTitle);
        }

        public bool IsVentLivabilityPanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => LivabilityTitle);
        }

        public bool IsLast24HoursTempPanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => Last24TemperatureTitle);
        }

        public bool IsAvgBirdWeightPanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => AvgBirdWeightTitle);
        }

        public bool IsDevicesTableExists()
        {
            return DriverManager.Driver.IsElementExists(() => DevicesTableElement);
        }

        public bool IsHumidityPanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => HumidityTitle);
        }

        public bool IsPressurePanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => PressureTitle);
        }

        public bool IsCo2PanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => Co2Title);
        }


        public bool IsAnalogDevicesPanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => AnalogDevicesTable);
        }

        public bool IsSensorsPanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => SensorPanel);
        }

        public bool IsDailyConsumptionPanelExists()
        {
            return DriverManager.Driver.IsElementExists(() => DailyConsumptionPanel);
        }

        #endregion

        #region Public Methods

        private void SwitchToDefaultFrame()
        {
            if (ConfigurationManagerHelper.IsFarmMode)
            {
                DriverManager.Driver.SwitchTo().DefaultContent();
            }
        }
        public TemperatureCurvePage ClickAverageTemperatureTile()
        {
            AverageTemperatureTitle.TryToClick();
            SwitchToDefaultFrame();
            return new TemperatureCurvePage();
        }

        public HumidityTreatmentPage ClickHumidityTile()
        {
            HumidityTitle.TryToClick();
            SwitchToDefaultFrame();
            return new HumidityTreatmentPage();
        }

        public StaticPressurePage ClickPressureTile()
        {
            PressureTitle.TryToClick();
            SwitchToDefaultFrame();
            return new StaticPressurePage();
        }

        public Co2TreatmentPage ClickCo2Tile()
        {
            Co2Title.TryToClick();
            SwitchToDefaultFrame();
            return new Co2TreatmentPage();
        }

        public LevelsOfVentilationPage ClickVentLevelTile()
        {
            VentLevelTitle.TryToClick();
            SwitchToDefaultFrame();
            return new LevelsOfVentilationPage();
        }

        public BirdInventoryPage ClickLivabilityTile()
        {
            LivabilityTitle.TryToClick();
            SwitchToDefaultFrame();
            return new BirdInventoryPage();
        }

        public BirdWeightHistoryPage ClickAvgBirdsWeight()
        {
            AvgBirdWeightTitle.TryToClick();
            SwitchToDefaultFrame();
            return new BirdWeightHistoryPage();
        }

        public FeedInventoryPage ClickFeedInventoryTile()
        {
            FeedInventoryTile.TryToClick();
            SwitchToDefaultFrame();
            return new FeedInventoryPage();
        }

        public WaterHistoryPage WaterConsumptuinHistory()
        {
            WaterConsumption.TryToClick();
            SwitchToDefaultFrame();
            return new WaterHistoryPage();
        }

        public FeedConsumptionHistoryPage FeedConsumptuinHistory()
        {
            FeedConsumption.TryToClick();
            SwitchToDefaultFrame();
            return new FeedConsumptionHistoryPage();
        }

        public FeedConversionHistoryPage FeedConversionHistory()
        {
            FCR.TryToClick();
            SwitchToDefaultFrame();
            return new FeedConversionHistoryPage();
        }

        #endregion
    }
}
