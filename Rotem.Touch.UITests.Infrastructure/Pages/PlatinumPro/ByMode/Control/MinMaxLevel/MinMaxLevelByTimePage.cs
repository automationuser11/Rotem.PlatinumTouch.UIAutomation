using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel
{
    public class MinMaxLevelByTimePage : SimpleMinMaxLevelPage<MinMaxLevelByTimePage>
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<MinMaxLevelByTimePage>()); }
        }
        private Uri _pageUri;
    }
}
 