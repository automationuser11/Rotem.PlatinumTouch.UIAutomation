using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.NaturalVentilation
{
    public class NaturalVentilationPage : SimpleSettingsPage, IApplicationPage, ISettingsModalViewProvider<NaturalVentilationSettingsPage>, IMetadataDependentPageObject
    {
        #region Elements Mapping

        internal IWebElement NaturalConditionsTable
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div[class='setting-control Ctrl1 col-xs-12']"));
            }
        }

        internal IWebElement NaturalOperationTable
        {
            get
            {
                return DriverManager.Driver.FindElement(By.CssSelector("div[class='setting-control Ctrl2 col-xs-12']"));
            }
        }

        #endregion

        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<NaturalVentilationPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Natural Ventilation"; }
        }
        public string MenuName
        {
            get { return "Natural Ventilation"; }
        }
        public string SubMenu { get { return "Control"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get
            {
                return ApplicationPageService.Titles;
            }
        }
        public NaturalVentilationSettingsPage SettingsView
        {
            get { return _settingsPage ?? (_settingsPage = new NaturalVentilationSettingsPage()); }
        }
        private NaturalVentilationSettingsPage _settingsPage;

        #region Building Blocks Validation

        public bool IsNaturalConditionsTableExists()
        {
            return DriverManager.Driver.IsElementExists(() => NaturalConditionsTable);
        }

        public bool IsNaturalOperationTableExists()
        {
            return DriverManager.Driver.IsElementExists(() => NaturalOperationTable);
        }

        #endregion

        #region Group Name: Natural Conditions

        public KeyPadSettingsField FromDay
        {
            get { return _fromDay ?? (_fromDay = new KeyPadSettingsField() { Name = "From Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _fromDay = value; }
        }
        private KeyPadSettingsField _fromDay;
        public KeyPadSettingsField ToDay
        {
            get { return _toDay ?? (_toDay = new KeyPadSettingsField() { Name = "To Day", InputMethod = new MinusNumericKeyPad() }); }
            set { _toDay = value; }
        }
        private KeyPadSettingsField _toDay;
        public KeyPadSettingsField FromTime
        {
            get { return _fromTime ?? (_fromTime = new KeyPadSettingsField() { Name = "From Time", InputMethod = new TimeKeyPad() }); }
            set { _fromTime = value; }
        }
        private KeyPadSettingsField _fromTime;
        public KeyPadSettingsField ToTime
        {
            get { return _toTime ?? (_toTime = new KeyPadSettingsField() { Name = "To Time", InputMethod = new TimeKeyPad() }); }
            set { _toTime = value; }
        }
        private KeyPadSettingsField _toTime;
        public KeyPadSettingsField LowOutTempTargetDiff
        {
            get { return _lowOutTempTargetDiff ?? (_lowOutTempTargetDiff = new KeyPadSettingsField() { Name = "Low Outside Temperature Diff. from Target", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _lowOutTempTargetDiff = value; }
        }
        private KeyPadSettingsField _lowOutTempTargetDiff;
        public KeyPadSettingsField HighOutTempTargetDiff
        {
            get { return _highOutTempTargetDiff ?? (_highOutTempTargetDiff = new KeyPadSettingsField() { Name = "High Outside Temperature Diff. from Target", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _highOutTempTargetDiff = value; }
        }
        private KeyPadSettingsField _highOutTempTargetDiff;
        public KeyPadSettingsField MinWindSpeedToEnter
        {
            get { return _minWindSpeedToEnter ?? (_minWindSpeedToEnter = new KeyPadSettingsField() { Name = "Min Wind Speed to Enter", InputMethod = new PointNumericKeyPad() }); }
            set { _minWindSpeedToEnter = value; }
        }
        private KeyPadSettingsField _minWindSpeedToEnter;
        public KeyPadSettingsField MaxWindSpeedToExit
        {
            get { return _maxWindSpeedToExit ?? (_maxWindSpeedToExit = new KeyPadSettingsField() { Name = "Max Wind Speed to Exit", InputMethod = new PointNumericKeyPad() }); }
            set { _maxWindSpeedToExit = value; }
        }
        private KeyPadSettingsField _maxWindSpeedToExit;

        public KeyPadSettingsField MinimumSpeedForTunnelTemp
        {
            get { return _minimumSpeedForTunnelTemp ?? (_minimumSpeedForTunnelTemp = new KeyPadSettingsField() { Name = "Min Speed For Tunnel Temp.", InputMethod = new PointNumericKeyPad() }); }
            set { _minimumSpeedForTunnelTemp = value; }
        }
        private KeyPadSettingsField _minimumSpeedForTunnelTemp;

        #endregion

        #region Group Name: Natural Operation

        public KeyPadSettingsField LowTempDiffFromTarget
        {
            get { return _lowTempDiffFromTarget ?? (_lowTempDiffFromTarget = new KeyPadSettingsField() { Name = "Low Temperature Diff. from Target", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _lowTempDiffFromTarget = value; }
        }
        private KeyPadSettingsField _lowTempDiffFromTarget;
        public KeyPadSettingsField HighTempDiffFromTarget
        {
            get { return _highTempDiffFromTarget ?? (_highTempDiffFromTarget = new KeyPadSettingsField() { Name = "High Temperature Diff. from Target", InputMethod = new MinusPointNumericKeyPad() }); }
            set { _highTempDiffFromTarget = value; }
        }
        private KeyPadSettingsField _highTempDiffFromTarget;
        public KeyPadSettingsField CurtainStepSize
        {
            get { return _curtainStepSize ?? (_curtainStepSize = new KeyPadSettingsField() { Name = "Curtain Step Size", InputMethod = new BaseNumericKeyPad() }); }
            set { _curtainStepSize = value; }
        }
        private KeyPadSettingsField _curtainStepSize;
        public KeyPadSettingsField MinimumCurtainPositionFirstDay
        {
            get { return _minimumCurtainPositionFirstDay ?? (_minimumCurtainPositionFirstDay = new KeyPadSettingsField() { Name = "Min. Curtain Position 1st day", InputMethod = new BaseNumericKeyPad() }); }
            set { _minimumCurtainPositionFirstDay = value; }
        }
        private KeyPadSettingsField _minimumCurtainPositionFirstDay;
        public KeyPadSettingsField MinimumCurtainPositionLastDay
        {
            get { return _minimumCurtainPositionLastDay ?? (_minimumCurtainPositionLastDay = new KeyPadSettingsField() { Name = "Min. Curtain Position Last day", InputMethod = new BaseNumericKeyPad() }); }
            set { _minimumCurtainPositionLastDay = value; }
        }
        private KeyPadSettingsField _minimumCurtainPositionLastDay;
        public KeyPadSettingsField MaximumCurtainPosition
        {
            get { return _maximumCurtainPosition ?? (_maximumCurtainPosition = new KeyPadSettingsField() { Name = "Max Curtain Position", InputMethod = new BaseNumericKeyPad() }); }
            set { _maximumCurtainPosition = value; }
        }
        private KeyPadSettingsField _maximumCurtainPosition;
        public ToggleButtonSettingsField WindandRainEffect
        {
            get { return _windandRainEffect ?? (_windandRainEffect = new ToggleButtonSettingsField("Wind & Rain Effect")); }
            set { _windandRainEffect = value; }
        }
        private ToggleButtonSettingsField _windandRainEffect;
        public KeyPadSettingsField DelayBetweenSteps
        {
            get { return _delayBetweenSteps ?? (_delayBetweenSteps = new KeyPadSettingsField() { Name = "Curtain Delay Between Steps (Sec.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _delayBetweenSteps = value; }
        }
        private KeyPadSettingsField _delayBetweenSteps;
        #endregion
    }
}
