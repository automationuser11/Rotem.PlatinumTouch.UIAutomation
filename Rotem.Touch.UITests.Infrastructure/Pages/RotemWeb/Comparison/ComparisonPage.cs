using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.RotemWeb.Comparison
{
    public class ComparisonPage : IRotemWebPage
    {
        public Uri PageUrl { get; private set; }
        public string Name { get; private set; }
        public IEnumerable<string> Titles { get; private set; }
        public string SubMenu { get { return ""; } }
        public string MenuName { get { return ""; } }
    }
}
