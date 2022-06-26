using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;
using Rotem.Touch.UITests.Infrastructure.RNBL;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class RNBLAccessorTests
    {
        [TestMethod]
        [InfrastructureTest]
        public void RNBL_GetTableMetaData_Passed()
        {
            var rnbl = new RNBLAccessor(ConfigurationsManager.ActiveConfiguration.RnblArgs);
            var metadata = rnbl.GetTableMetaData("Bird Inventory");

            Assert.IsNotNull(metadata);
        }

        [TestMethod]
        [InfrastructureTest]
        public void RnbAccessor_GetMetaDataByMenuId_Passed()
        {
            var rnbl = new RNBLAccessor(ConfigurationsManager.ActiveConfiguration.RnblArgs);
            var metadata = rnbl.GetMetadataTableUsingMenuId("18");
            
            Assert.IsNotNull(metadata);
        }
    }
}
