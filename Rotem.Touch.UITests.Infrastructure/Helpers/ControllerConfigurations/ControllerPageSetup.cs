using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations
{
    public class ControllerPageSetup
    {
        public IEnumerable<string> PageTitles { get; set; }
        public IEnumerable<ITableColumn> TableColumns { get; set; }
        public IEnumerable<string> SettingsPageTitles { get; set; }
        public IEnumerable<string> RegionsCollection { get; set; }
        public IEnumerable<string> TabsCollection { get; set; }
    }
}
