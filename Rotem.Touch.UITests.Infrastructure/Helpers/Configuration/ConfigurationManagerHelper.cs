using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Configuration
{
    public static class ConfigurationManagerHelper
    {
        private static readonly ConnectionManagerEndpointElement ActiveEndpoint;
        private static readonly NameValueCollection InfrastructureSettings;
        static ConfigurationManagerHelper()
        {
            var connectionManagerDataSection = ConfigurationManager.GetSection(ConnectionManagerDataSection.SectionName) as ConnectionManagerDataSection;
            if (connectionManagerDataSection == null) return;
            ActiveEndpoint = (connectionManagerDataSection.ConnectionManagerEndpoints.Cast<ConnectionManagerEndpointElement>().Where(item => item.IsActive)).Single();

            InfrastructureSettings = (NameValueCollection)ConfigurationManager.GetSection("InfrastructureSettings");
            if (InfrastructureSettings == null)
                throw new ConfigurationErrorsException("The sectino you've serach for does not exist.");
        }

        public static string ControllerType
        {
            get
            {
                return InfrastructureSettings["ControllerType"];
            }
        }
        public static string ControllerMajorVersion
        {
            get
            {
                return InfrastructureSettings["ControllerMajorVersion"];
            }
        }
        public static string ControllerAddress
        {
            get
            {
                return ActiveEndpoint.ControllerAddress;
            }
        }
        public static string PlcAddress
        {
            get
            {
                return ActiveEndpoint.PlcAddress;
            }
        }
        public static string FarmAddress
        {
            get
            {
                return ActiveEndpoint.FarmAddress;
            }
        }
        public static bool IsCellularMode
        {
            get
            {
                return ActiveEndpoint.IsCellularMode;
            }

        }
        public static string WebDriverFolder
        {
            get
            {
                return InfrastructureSettings["WebDriverFolder"];
            }
        }
        public static string DataSetsFolder
        {
            get
            {
                if (IsFarmMode)
                    return InfrastructureSettings["RotemNetWEBDataSetsFolder"];

                return InfrastructureSettings["TouchDataSetsFolder"];

            }
        }
        public static string AgentConfigFile
        {
            get
            {
                return InfrastructureSettings["AgentConfigFile"];
            }
        }
        public static string GetDataSetPath(string menuId)
        {
            //string host = ControllerAddress == "0.0.0.0" ? "10.16.0.178" : ControllerAddress;
            string host = ControllerAddress == "0.0.0.0" ? "rotemdev.net" : ControllerAddress;
            var directory = DataSetsFolder; //string.Format(DataSetsFolder, host);
            return string.Format(@"{0}{1}_DataSet.xml",directory, menuId);
        }
        public static bool IsFarmMode
        {
            get { return FarmAddress != "0.0.0.0"; }
        }
        public static string GetPathOfMultiLanguageFile
        {
            get
            {
                return InfrastructureSettings["MultiLanguagePath"];
            }
        }

        public static string GetLanguage
        {
            get
            {
                return InfrastructureSettings["Language"];
            }
        }
    }
}
