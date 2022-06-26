using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public class MultiLanguageHelper
    {
        public string language_val { get; set; }
        public DataTable dt;
        public List<DataRow> list;
        public string SetValueToSearch;
        public MultiLanguageHelper() { }
        public MultiLanguageHelper(string set_value_to_search) {
            SetValueToSearch = set_value_to_search;
        }
        public List<DataRow> CreateListFromLanguageCSV()
        {
            try
            {
                dt = ReadDataFromCsv.ConvertCSVtoDataTable(Path.GetFullPath(ConfigurationManagerHelper.GetPathOfMultiLanguageFile));
                list = dt.AsEnumerable().ToList();
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string FindHeaderValueByLanguage() {
            try
            {
                list = CreateListFromLanguageCSV();
                foreach (var key_item in list)
                {
                    var header = key_item["HEADER"];
                    if (header.ToString().CompareTo(SetValueToSearch) == 0)
                    {
                        language_val = key_item[ConfigurationManagerHelper.GetLanguage].ToString();
                        break;
                    }
                }
                return (language_val != null ? language_val : SetValueToSearch);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

    public class ReadDataFromCsv
    {
        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split('\t');
                var headersNew = headers.Take(headers.Count() - 1).ToArray();
                foreach (string header in headersNew)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split('\t');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headersNew.Length; i++)
                    {
                        try
                        {
                            dr[i] = rows[i];
                        }
                        catch (Exception) { }
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}
