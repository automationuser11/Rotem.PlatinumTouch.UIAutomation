using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.UrlCreators;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.MinMaxLevel
{
    public class MinMaxLevelByDaysCurvePage : SimpleMinMaxLevelPage<MinMaxLevelByDaysCurvePage>
    {
        public override Uri PageUrl
        {
            get { return _pageUri ?? (_pageUri = UrlFactory.GetUrl<MinMaxLevelByDaysCurvePage>()); }
        }
        private Uri _pageUri;
    }
}
 