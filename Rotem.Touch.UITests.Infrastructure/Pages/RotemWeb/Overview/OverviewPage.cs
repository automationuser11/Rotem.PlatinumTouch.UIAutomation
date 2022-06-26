using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Overview
{
    public class OverviewPage : IRotemWebPage
    {
        public Uri PageUrl
        {
            get
            {
                //return new Uri(string.Format("http://{0}/rotemWebApp/Main.html#/dashboard?token={1}", ConfigurationManagerHelper.FarmAddress, Navigator.RotemWebUserToken));
                return UrlFactory.GetUrl<OverviewPage>();
            }
        }
        public string Name { get; private set; }
        public string SubMenu { get { return ""; } }
        public string MenuName { get { return ""; } }
        public IEnumerable<string> Titles { get; private set; }
    }
}