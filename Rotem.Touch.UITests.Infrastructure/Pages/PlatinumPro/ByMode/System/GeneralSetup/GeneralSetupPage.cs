using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.GeneralSetup
{
    public class GeneralSetupPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {

        public INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }

        #region Elements Mapping
        public IWebElement PageTitle
        {
            get
            {
                return DriverManager.Driver.FindElement(By.Id("data-page-main-heading"));
            }
        }

        #endregion

        public GeneralSetupPage()
        {
            VentilationMode.ValueChanged += SettingsField_ValueChanged;
            StaticPressureUnit.ValueChanged += SettingsField_ValueChanged;
            TemperatureUnit.ValueChanged += SettingsField_ValueChanged;
            GrowingZones.ValueChanged += SettingsField_ValueChanged;
            MinimumVentilation.ValueChanged += SettingsField_ValueChanged;
            NaturalVentilation.ValueChanged += SettingsField_ValueChanged;
            HistoryResolution.ValueChanged += SettingsField_ValueChanged;
            FanAirCapacityUnit.ValueChanged += SettingsField_ValueChanged;
            WindSpeedUnit.ValueChanged += SettingsField_ValueChanged;
            LengthUnit.ValueChanged += SettingsField_ValueChanged;
            WeightUnit.ValueChanged += SettingsField_ValueChanged;
            Tunnel.ValueChanged += SettingsField_ValueChanged;
        }

        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<GeneralSetupPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Setup"; }
        }
        public string MenuName
        {
            get { return "Setup"; }
        }
        public string SubMenu { get { return "System"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get
            {
                return ApplicationPageService.Titles;
            }
        }
        public PageInitialSetup<GeneralSetupPage> PageInitialSetup { get; set; }    

        public ReadonlyTextSettingsField VentilationMode
        {
            get { return _ventilationMode  ?? (_ventilationMode = new ReadonlyTextSettingsField("Vent Mode")); }
            set { _ventilationMode  = value; }
        }
        private ReadonlyTextSettingsField _ventilationMode;

        public ComboboxSettingsField StaticPressureUnit
        {
            get { return _staticPressureUnit ?? (_staticPressureUnit = new ComboboxSettingsField("S.Pressure Unit")); }
            set { _staticPressureUnit = value; }
        }
        private ComboboxSettingsField _staticPressureUnit;

        public ToggleButtonSettingsField TemperatureUnit
        {
            get { return _temperatureUnit  ?? (_temperatureUnit = new ToggleButtonSettingsField("Temperature Unit")); }
            set { _temperatureUnit  = value; }
        }
        private ToggleButtonSettingsField _temperatureUnit;

        public KeyPadSettingsField GrowingZones
        {
            get { return _growingZones ?? (_growingZones = new KeyPadSettingsField { Name = "Growing Zones 1 - 4", InputMethod = new BaseNumericKeyPad() }); }
            set { _growingZones = value; }
        }
        private KeyPadSettingsField _growingZones;

        public ToggleButtonSettingsField MinimumVentilation
        {
            get { return _minimumVentilation  ?? (_minimumVentilation = new ToggleButtonSettingsField("Minimum Ventilation (Power)")); }
            set { _minimumVentilation  = value; }
        }
        private ToggleButtonSettingsField _minimumVentilation;

        public ComboboxSettingsField NaturalVentilation
        {
            get { return _naturalVentilation ?? (_naturalVentilation = new ComboboxSettingsField("Natural Ventilation")); }
            set { _naturalVentilation  = value; }
        }
        private ComboboxSettingsField _naturalVentilation;

        public ComboboxSettingsField HistoryResolution
        {
            get { return _historyResolution  ?? (_historyResolution = new ComboboxSettingsField("History Resolution")); }
            set { _historyResolution  = value; }
        }
        private ComboboxSettingsField _historyResolution;

        public ToggleButtonSettingsField FanAirCapacityUnit
        {
            get { return _fanAirCapacityUnit  ?? (_fanAirCapacityUnit = new ToggleButtonSettingsField("Fan Air Capacity Unit")); }
            set { _fanAirCapacityUnit  = value; }
        }
        private ToggleButtonSettingsField _fanAirCapacityUnit;

        public ComboboxSettingsField WindSpeedUnit
        {
            get { return _windSpeedUnit  ?? (_windSpeedUnit = new ComboboxSettingsField("Wind Speed Units")); }
            set { _windSpeedUnit  = value; }
        }
        private ComboboxSettingsField _windSpeedUnit;

        public ToggleButtonSettingsField LengthUnit
        {
            get { return _lengthUnit  ?? (_lengthUnit = new ToggleButtonSettingsField("Length Unit")); }
            set { _lengthUnit  = value; }
        }
        private ToggleButtonSettingsField _lengthUnit;

        public ToggleButtonSettingsField WeightUnit
        {
            get { return _weightUnit  ?? (_weightUnit = new ToggleButtonSettingsField("Weight Unit")); }
            set { _weightUnit  = value; }
        }
        private ToggleButtonSettingsField _weightUnit;

        public ToggleButtonSettingsField Tunnel
        {
            get { return _tunnel  ?? (_tunnel = new ToggleButtonSettingsField("Tunnel")); }
            set { _tunnel  = value; }
        }
        private ToggleButtonSettingsField _tunnel;

        #region Temperature Unit

        public void SetTemperatureUnitsToCelsius()
        {
            this[GeneralSetupSettings.TemperatureUnit].SetValue("C°");
            SaveChanges();
        }
        public void SetTemperatureUnitsToFahrenheit()
        {
            this[GeneralSetupSettings.TemperatureUnit].SetValue("F°");
            SaveChanges();
        }

        #endregion

        #region Weight Unit

        public void SetWeightUnitsToKg()
        {
            Navigator.NavigateTo<GeneralSetupPage>();
            var setupPage = PagesFactory.GetPage<GeneralSetupPage>();
            setupPage[GeneralSetupSettings.WeightUnit].SetValue("Kg");
            setupPage.SaveChanges();
        }
        public void SetWeightUnitsToLb()
        {
            Navigator.NavigateTo<GeneralSetupPage>();
            var setupPage = PagesFactory.GetPage<GeneralSetupPage>();
            setupPage[GeneralSetupSettings.WeightUnit].SetValue("Lb");
            setupPage.SaveChanges();
        }

        #endregion

        # region Static Pressure Unit

        public void SetStaticPressureUnitToMiliBar()
        {
            SetStaticPressureUnitTo("Millibar");
        }
        public void SetStaticPressureUnitToInWc()
        {
            SetStaticPressureUnitTo("IN.W.C");
        }
        public void SetStaticPressureUnitToPascal()
        {
            SetStaticPressureUnitTo("PASCAL");
        }
        public void SetStaticPressureUnitToCmWc()
        {
            SetStaticPressureUnitTo("CM.W.C");
        }
        public void SetStaticPressureUnitToMmWc()
        {
            SetStaticPressureUnitTo("MM.W.C");
        }
        public void SetStaticPressureUnitToNone()
        {
            SetStaticPressureUnitTo("NONE");
        }
        public void SetStaticPressureUnitTo(string value)
        {
            StaticPressureUnit.SetValue(value);
            SaveChanges();
        }

        # endregion

        public ISettingsField<ISystemInputMethod> this[GeneralSetupSettings field]
        {
            get
            {
                var properties = GetType().GetProperties();
                var settingsFields = properties.Where(p => p.PropertyType.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(ISettingsField<>)));

                foreach (PropertyInfo settingsField in settingsFields)
                {
                    object filedProp = settingsField.GetValue(this, null);
                    PropertyInfo name = filedProp.GetType().GetProperty("Name");
                    if (name.GetValue(filedProp, null).ToString() == StringEnum.GetStringValue(field))
                    {
                        var setField = filedProp as ISettingsField<ISystemInputMethod>;
                        return setField;
                    }
                }
                return null;
            }
        }

        void SettingsField_ValueChanged(object sender, EventArgs e)
        {
            if (PageInitialSetup != null) return;
            PageInitialSetup = new PageInitialSetup<GeneralSetupPage>();
            PageInitialSetup.StoreInitialSetup();
        }

        public override void RestoreInitialSetup()
        {
            if(PageInitialSetup == null) return;
            PageInitialSetup.RestoreInitialSetup();
            SaveChanges();
        }
    }

    public enum GeneralSetupSettings
    {
        [StringValue("Vent Mode")] VentilationMode,
        [StringValue("S.Pressure Unit")] StaticPressureUnit,    
        [StringValue("Temperature Unit")] TemperatureUnit,
        [StringValue("Growing Zones (1-4)")] GrowingZones,
        [StringValue("Minimum Ventilation")] MinimumVentilation,
        [StringValue("Natural Ventilation")] NaturalVentilation,
        [StringValue("History Resolution")] HistoryResolution,
        [StringValue("Fan Air Capacity")] FanAirCapacity,
        [StringValue("Wind Speed Unit")] WindSpeedUnit,
        [StringValue("Length Unit")] LengthUnit,
        [StringValue("Weight Unit")] WeightUnit,
        [StringValue("Tunnel Ventilation")] TunnelVentilation,
    }
}
