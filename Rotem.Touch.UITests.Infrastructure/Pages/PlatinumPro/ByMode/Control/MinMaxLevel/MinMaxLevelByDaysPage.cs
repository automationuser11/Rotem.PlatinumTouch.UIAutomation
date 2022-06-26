using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel
{
    public class MinMaxLevelByDaysPage : SimpleMinMaxLevelPage<MinMaxLevelByDaysPage>
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<MinMaxLevelByDaysPage>()); }
        }
        private Uri _pageUri;
    }
}
 