using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.SiloSettings
{
    public class SiloSettingsPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<SiloSettingsPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Silo Settings"; }
        }
        public string MenuName
        {
            get { return "Silo Settings"; }
        }
        public string SubMenu { get { return "System"; } }

        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        #region Group Name:

        public KeyPadSettingsField MinFillingWeight
        {
            get { return _minFillingWeight ?? (_minFillingWeight = new KeyPadSettingsField() { Name = "Min Filling Weight", InputMethod = new BaseNumericKeyPad() }); }
            set { _minFillingWeight = value; }
        }
        private KeyPadSettingsField _minFillingWeight;

        public KeyPadSettingsField FillingDetectionWeight
        {
            get { return _fillingDetectionWeight ?? (_fillingDetectionWeight = new KeyPadSettingsField() { Name = "Filling Detection Weight", InputMethod = new BaseNumericKeyPad() }); }
            set { _fillingDetectionWeight = value; }
        }
        private KeyPadSettingsField _fillingDetectionWeight;

        public KeyPadSettingsField ResumeTimeMin
        {
            get { return _resumeTimeMin ?? (_resumeTimeMin = new KeyPadSettingsField() { Name = "Resume Time (Min.)", InputMethod = new BaseNumericKeyPad() }); }
            set { _resumeTimeMin = value; }
        }
        private KeyPadSettingsField _resumeTimeMin;
        #endregion

        public Metadata Metadata { get; set; }

    }
}
