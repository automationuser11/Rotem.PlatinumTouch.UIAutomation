using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.Communication
{
    public class CommunicationPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<CommunicationPage>()); }
        }
        private Uri _pageUri;
        public string Name
        {
            get { return "Communication"; }
        }
        public string MenuName
        {
            get { return "Communication"; }
        }
        public string SubMenu { get { return "System"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles
        {
            get { return ApplicationPageService.Titles; }
        }

        #region Group Name: Communication
        public ComboboxSettingsField BoudeRate
        {
            get { return _boudeRate ?? (_boudeRate = new ComboboxSettingsField("Baud Rate")); }
            set { _boudeRate = value; }
        }
        private ComboboxSettingsField _boudeRate;

        public KeyPadSettingsField HouseNo
        {
            get { return _houseNo ?? (_houseNo = new KeyPadSettingsField() { Name = "House No.", InputMethod = new BaseNumericKeyPad() }); }
            set { _houseNo = value; }
        }
        private KeyPadSettingsField _houseNo;

        #endregion

        #region Group Name: Light Dimmers

        public ComboboxSettingsField Channela
        {
            get { return _channela ?? (_channela = new ComboboxSettingsField("Channel - a")); }
            set { _channela = value; }
        }
        private ComboboxSettingsField _channela;

        public ComboboxSettingsField Channelb
        {
            get { return _channelb ?? (_channelb = new ComboboxSettingsField("Channel - b")); }
            set { _channelb = value; }
        }
        private ComboboxSettingsField _channelb;

        public ComboboxSettingsField Channelc
        {
            get { return _channelc ?? (_channelc = new ComboboxSettingsField("Channel - c")); }
            set { _channelc = value; }
        }
        private ComboboxSettingsField _channelc;

        public ComboboxSettingsField Channeld
        {
            get { return _channeld ?? (_channeld = new ComboboxSettingsField("Channel - d")); }
            set { _channeld = value; }
        }
        private ComboboxSettingsField _channeld;

        #endregion
        public int LightDimmerDefinedCount()
        {
            int lightDimmerCount = 0;

            if (Channela.CurrentValue != StringEnum.GetStringValue(Device.NONE)) lightDimmerCount++;
            if (Channelb.CurrentValue != StringEnum.GetStringValue(Device.NONE)) lightDimmerCount++;
            if (Channelc.CurrentValue != StringEnum.GetStringValue(Device.NONE)) lightDimmerCount++;
            if (Channeld.CurrentValue != StringEnum.GetStringValue(Device.NONE)) lightDimmerCount++;

            return lightDimmerCount;
        }
    }
}
