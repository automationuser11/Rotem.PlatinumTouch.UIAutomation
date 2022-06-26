using System;
using System.Data;
using System.Linq;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Extensions
{
    public class DataTableExtension
    {
        public static void ExtendGroupMembers(DataTable table, string groupName, int extensionCount)
        {
            var row = table.Rows.Cast<DataRow>().Single(item => item["GroupName"].ToString() == groupName);
            for (var i = 1; i < extensionCount; i++)
                table.ImportRow(row);

            var selectedRows = table.Rows.Cast<DataRow>().Where(item => item["GroupName"].ToString() == groupName).ToList(); 
            if (selectedRows.Count() != extensionCount)  
                throw new ConstraintException("DataTable extending failed.");

            for (int i = 0; i < selectedRows.Count; i++)
                selectedRows[i]["HeaderText"] = i + 1;

            table.AcceptChanges();
        }

        public static void DeleteRows(DataTable table, string fieldCriteria, string value)
        {
            foreach (DataRow row in table.Rows.Cast<DataRow>().Where(row => row[fieldCriteria].ToString() == value))
            {
                row.Delete();
            }

            table.AcceptChanges();
        }

        public static DataTable SortTableByField(DataTable table, string field, string order = "desc")
        {
            DataView dv = table.DefaultView;
            dv.Sort = field + " " + order;
            return dv.ToTable();
        }

        public static void DuplicateDataRow(DataTable table, int rowIdx)
        {
            table.ImportRow(table.Rows[rowIdx]);
            SortTableByGroupName(table);
        }

        private static void SortTableByGroupName(DataTable table)
        {
            string[] names = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                names[i] = table.Rows[i]["GroupName"].ToString();
            }

            Array.Sort(names);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["GroupName"] = names[i];
            }

            table.AcceptChanges();
        }

        public static int GetRoundedValue(string value)
        {
            int RoundedValueOfEditedValue = 0;
            if (double.Parse(value) > 0)
            {
                RoundedValueOfEditedValue = (int)(double.Parse(value) + 0.5);
            }
            else
            {
                RoundedValueOfEditedValue = (int)(double.Parse(value) - 0.5);
            }
            return RoundedValueOfEditedValue;
        }
    }
}
