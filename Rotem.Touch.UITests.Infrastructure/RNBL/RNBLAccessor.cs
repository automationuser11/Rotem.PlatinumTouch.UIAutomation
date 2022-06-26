using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using ControllersLayoutParser;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using System.Threading;

namespace Rotem.Touch.UITests.Infrastructure.RNBL
{
    public class RNBLAccessor
    {
        private readonly clsControllerLayoutParser _controllerParser;
        private readonly LevelControl _levelControl;
       
        public RNBLAccessor(RnblArgs args)
        {
            _levelControl = args.LevelControl;
            _controllerParser = new clsControllerLayoutParser(args.ControllerType, args.MemoryVersion, args.ControllerMajorVersion, args.LevelControl,args.MetadataDirectoryInfo);
        }

        #region Public API

        public DataTable GetTableMetaData(string menuItem)
        {
            var menuId = GetMenuIdByMenuItemName(menuItem, _controllerParser.ExportMenu());
            var commandId = _controllerParser.GetCommandIDByMenuID(menuId);
            var tbl = _controllerParser.GetMDTByCommandID((byte) commandId, _levelControl);

            return tbl;
        }

        public DataTable GetMetadataTableUsingMenuId(string menuId)
        {

            if (ConfigurationManagerHelper.IsFarmMode)
            {
                return GetMetadataTableUsingMenuIdForRotemWeb(menuId);
            }
            return GetMetadataTableUsingMenuIdForTouch(menuId);
        }

        private DataTable GetMetadataTableUsingMenuIdForRotemWeb(string menuId)
        {
            var dataset = new DataSet();
            var xmlSchema = ConfigurationManagerHelper.GetDataSetPath(menuId);
            
            if (File.Exists(xmlSchema) == false)
            {
                return null;
            }


            dataset.ReadXml(xmlSchema);
            var metadata = dataset.Tables["MDT"];
            return metadata;
        }

        private DataTable GetMetadataTableUsingMenuIdForTouch(string menuId)
        {
            var dataset = new DataSet();
            var xmlSchema = ConfigurationManagerHelper.GetDataSetPath(menuId);
            if (xmlSchema.Contains("127.0.0.1"))
            {
                //xmlSchema = xmlSchema.Replace("127.0.0.1", "ILTELPC157");
                xmlSchema = xmlSchema.Replace("127.0.0.1", "ILTELPC164");
            }
            else 
            {
                if (xmlSchema.Contains("10.16.0.178"))
                {
                  xmlSchema = xmlSchema.Replace("10.16.0.178", "ILTELPC164");
                }
            }

            //if (File.Exists(xmlSchema) == false) //in case that file is not ready the script wait 1 sec
            //    Thread.Sleep(2000);
            // sefi changed
            if (File.Exists(xmlSchema)== false)
            {
                return null;
            }
               

            dataset.ReadXml(xmlSchema);
            var metadata = dataset.Tables["MDT"];
            return metadata;
        }

        private TextReader ReadFileFromFtp(string xmlSchema)
        {
            const string UserName = "AutomationMTD", Password = "%Tghy678";
            var request = (FtpWebRequest)WebRequest.Create(xmlSchema);

            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(UserName, Password);

            Thread.Sleep(3000);
            var response = (FtpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();

            if(responseStream == null) throw new NullReferenceException(string.Format("The response for {0} from ftp is NULL.", xmlSchema));

            return new StreamReader(responseStream);
        }
        #endregion

        #region Private Methods

        private int GetMenuIdByMenuItemName(string name, clsMenuItem menu)
        {
            if (menu.MenuName == name)
                return menu.ID;

            if (!menu.SubMenus.Any())
                return -1;

            foreach (var subMenu in menu.SubMenus)
            {
                int id = GetMenuIdByMenuItemName(name, subMenu);
                if (id != -1)
                    return id;
            }

            return -1;
        }

        #endregion
    }
}
