using System.Configuration;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Configuration
{
    public class ConnectionManagerDataSection : ConfigurationSection
    {
        /// <summary>
        /// The name of this section in the app.config.
        /// </summary>
        public const string SectionName = "ConnectionManagerDataSection";

        private const string EndpointCollectionName = "ConnectionManagerEndpoints";

        [ConfigurationProperty(EndpointCollectionName)]
        [ConfigurationCollection(typeof(ConnectionManagerEndpointsCollection), AddItemName = "add")]
        public ConnectionManagerEndpointsCollection ConnectionManagerEndpoints { get { return (ConnectionManagerEndpointsCollection)base[EndpointCollectionName]; } }
    }

    public class ConnectionManagerEndpointsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConnectionManagerEndpointElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ConnectionManagerEndpointElement)element).Name;
        }
    }

    public class ConnectionManagerEndpointElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("controllerAddress", IsRequired = false, DefaultValue = "0.0.0.0")]
        public string ControllerAddress
        {
            get { return (string)this["controllerAddress"]; }
            set { this["controllerAddress"] = value; }
        }

        [ConfigurationProperty("plcAddress", IsRequired = false, DefaultValue = "0.0.0.0")]
        public string PlcAddress
        {
            get { return (string)this["plcAddress"]; }
            set { this["plcAddress"] = value; }
        }

        [ConfigurationProperty("farmAddress", IsRequired = false, DefaultValue = "0.0.0.0")]
        public string FarmAddress
        {
            get { return (string)this["farmAddress"]; }
            set { this["farmAddress"] = value; }
        }

        [ConfigurationProperty("isActive", IsRequired = false, DefaultValue = false)]
        public bool IsActive
        {
            get { return (bool)this["isActive"]; }
            set { this["isActive"] = value; }
        }

        [ConfigurationProperty("isCellularMode", IsRequired = false, DefaultValue = false)]
        public bool IsCellularMode
        {
            get { return (bool)this["isCellularMode"]; }
            set { this["isCellularMode"] = value; }
        }
    }
}