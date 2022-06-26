using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class LoadColdStartConfiguration
    {
        [TestMethod]
        [TestCategory("ColdStart")]
        public void LoadColdStartConfigurations()
        {
            ColdStartConfiguration.SetBroeilerConfiguration();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Browser.Close();
        }
    }
}
