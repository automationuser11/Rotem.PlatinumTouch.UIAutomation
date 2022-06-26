using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.MyAccount;

namespace Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Login
{
    public delegate void LoggedInEventHandler(object sender, EventArgs e);

    public class LoginPage : IRotemWebPage
    {
        public Uri PageUrl
        {
            get { return new Uri(string.Format("https://{0}", ConfigurationManagerHelper.FarmAddress)); }
        }
        public string Name { get; private set; }
        public string MenuName { get { return ""; } }
        public string SubMenu { get { return ""; } }
        public IEnumerable<string> Titles { get; private set; }
        public event LoggedInEventHandler LoggedIn;
        protected virtual void OnLogIn(object sender, EventArgs eventArgs)
        {
            if (LoggedIn != null)
                LoggedIn(this, eventArgs);   
        }
        public static bool IsLoggedIn { get; private set; }
        
        #region Elements Mapping

        internal IWebElement UserNameTbx
        {
            get { return DriverManager.Driver.FindElement(By.Id("userName")); }
        }
        internal IWebElement PasswordTbx
        {
            get { return DriverManager.Driver.FindElement(By.Id("password")); }
        }
        internal IWebElement FarmTbx
        {
            get { return DriverManager.Driver.FindElement(By.Id("farm")); }
        }
        internal IWebElement LoginButton
        {
            get { return DriverManager.Driver.FindElement(By.Id("Button1")); }
        }

        #endregion
        public void Login(LoginArgs args)
        {
            UserNameTbx.SendKeys(args.UserName);
            PasswordTbx.SendKeys(args.Password);
            LoginButton.Click();
            WaitForServerTokenToBeReceived();
            IsLoggedIn = true;
            //var farmsPage = PagesFactory.GetPage<FarmsPage>();
            //farmsPage.SelectFarm("alon2019");
            OnLogIn(this, EventArgs.Empty);
        }
        public static void Logout()
        {
            IsLoggedIn = false;
        }
        private void WaitForServerTokenToBeReceived(int timeoutInMinutes = 2)
        {
            var timeout = new TimeSpan(0, timeoutInMinutes, 0);
            Stopwatch sw = Stopwatch.StartNew();
            
            while (sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
            {
                var urlParts = DriverManager.Driver.Url.Split(new[] { "token=" }, StringSplitOptions.None);
                
                if(urlParts.Count() != 2)
                    Thread.Sleep(2500);
                else if (urlParts.Count() == 2)
                    break;
                else
                    throw new FormatException(@"Url format has changed! - reformat the split query.");
            }
        }
    }

    [Serializable]
    public class LoginFailureException : Exception
    {
        private readonly string _userToken, _farmId, _activeHouseId;
        private const string MessageFormat = "Login failure. UserToken: {0}, FarmID: {1}, ActiveHouseID: {2}.";

        public LoginFailureException(string userToken, string farmId, string activeHouseId, Exception inner) : base(inner.Message, inner)
        {
            _userToken = userToken ?? string.Empty;
            _farmId = farmId ?? string.Empty;
            _activeHouseId = activeHouseId ?? string.Empty;
        }
        public override string Message
        {
            get { return string.Format(MessageFormat, _userToken, _farmId, _activeHouseId); }
        }
    }
}