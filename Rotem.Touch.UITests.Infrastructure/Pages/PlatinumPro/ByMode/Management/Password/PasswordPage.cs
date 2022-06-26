using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.SettingsView;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.Password
{
    public class PasswordPage : SimpleSettingsPage, IApplicationPage, IMetadataDependentPageObject
    {
        public Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<PasswordPage>()); }
        }
        private Uri _pageUri;

        public string Name
        {
            get { return "Password"; }
        }
        public string MenuName
        {
            get { return "Password"; }
        }
        public string SubMenu { get { return "Management"; } }
        public Metadata Metadata { get; set; }
        public IEnumerable<string> Titles { get { return ApplicationPageService.Titles; } }

        public KeyPadSettingsField FarmManager
        {
            get { return _farmManager ?? (_farmManager = new KeyPadSettingsField() { Name = "Owner", InputMethod = new BaseNumericKeyPad() }); }
            set { _farmManager = value; }
        }
        private KeyPadSettingsField _farmManager;

        public KeyPadSettingsField User1
        {
            get { return _user1 ?? (_user1 = new KeyPadSettingsField() { Name = "User 1", InputMethod = new BaseNumericKeyPad() }); }
            set { _user1 = value; }
        }
        private KeyPadSettingsField _user1;

        public KeyPadSettingsField User2
        {
            get { return _user2 ?? (_user2 = new KeyPadSettingsField() { Name = "User 2", InputMethod = new BaseNumericKeyPad() }); }
            set { _user2 = value; }
        }
        private KeyPadSettingsField _user2;

        public KeyPadSettingsField Visitor
        {
            get { return _visitor ?? (_visitor = new KeyPadSettingsField() { Name = "Visitor", InputMethod = new BaseNumericKeyPad() }); }
            set { _visitor = value; }
        }
        private KeyPadSettingsField _visitor;

        public KeyPadSettingsField User3
        {
            get { return _user3 ?? (_user3 = new KeyPadSettingsField() { Name = "User 3", InputMethod = new BaseNumericKeyPad() }); }
            set { _user3 = value; }
        }
        private KeyPadSettingsField _user3;

        public KeyPadSettingsField User4
        {
            get { return _user4 ?? (_user4 = new KeyPadSettingsField() { Name = "User 4", InputMethod = new BaseNumericKeyPad() }); }
            set { _user4 = value; }
        }
        private KeyPadSettingsField _user4;

        public KeyPadSettingsField User5
        {
            get { return _user5 ?? (_user5 = new KeyPadSettingsField() { Name = "User 5", InputMethod = new BaseNumericKeyPad() }); }
            set { _user5 = value; }
        }
        private KeyPadSettingsField _user5;
    }
}
