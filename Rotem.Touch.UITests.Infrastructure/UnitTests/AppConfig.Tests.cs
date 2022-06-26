using System.Collections.Generic;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;

namespace Rotem.Touch.UITests.Infrastructure.UnitTests
{
    [TestClass]
    public class AppConfigTests
    {
        [TestMethod]
        public void CustomConfigurationSection_WhenSearchForAnEntry_DataRecives()
        {
            var endpoints = new List<ConnectionManagerEndpoint>();
            var connectionManagerDataSection = ConfigurationManager.GetSection(ConnectionManagerDataSection.SectionName) as ConnectionManagerDataSection;
            if (connectionManagerDataSection != null)
            {
                foreach (ConnectionManagerEndpointElement endpointElement in connectionManagerDataSection.ConnectionManagerEndpoints)
                {
                    var endpoint = new ConnectionManagerEndpoint() { Name = endpointElement.Name, ServerInfo = new ConnectionInfo() { ServerAddress = endpointElement.ControllerAddress, PlcAddress = endpointElement.PlcAddress}};
                    endpoints.Add(endpoint);
                }
            }

            Assert.IsTrue(endpoints.Count == 2);
        }

        [TestMethod]
        public void ConfigurationManagerHelper_WhenCallToControllerAddress_ShouldRecivesTheCorrectAddress()
        {
            Assert.IsTrue(ConfigurationManagerHelper.ControllerAddress == "10.16.1.201");
        }
    }

    public class ConnectionInfo
    {
        public string ServerAddress { get; set; }
        public string PlcAddress { get; set; }
    }

    public class ConnectionManagerEndpoint
    {
        public string Name { get; set; }
        public ConnectionInfo ServerInfo { get; set; }
    }
}
