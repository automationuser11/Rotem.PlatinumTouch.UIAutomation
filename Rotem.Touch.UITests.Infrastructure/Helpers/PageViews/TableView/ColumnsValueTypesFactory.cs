using System;
using System.Collections.Generic;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView
{
    public class ColumnsValueTypesFactory
    {
        private readonly Dictionary<string, Type> ColumnsTypeDictionary = new Dictionary<string, Type>()
        {
            {"DT_Number", typeof (int)},
            {"DT_Time", typeof (DateTime)},
            {"DT_Boolean", typeof (bool)},
            {"DT_String", typeof (string)},
            {"DT_String ", typeof (string)},
            {"DT_Date", typeof (DateTime)},
            {"DT_Float", typeof (float)},
        };

        public Type GetColumnValueType(string type)
        {
            return ColumnsTypeDictionary[type];
        }
    }
}
