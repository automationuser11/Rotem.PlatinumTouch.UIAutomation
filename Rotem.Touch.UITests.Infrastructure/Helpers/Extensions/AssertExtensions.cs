using System;
using System.Collections.Generic;
using System.Linq;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Extensions
{
    public static class Validate
    {
        public static void That(bool condition)
        {
            if (!condition)
                throw new ValidationException("Validation of the given condition failed.");
        }

        public static void That(bool condition, string errorMsg)
        {
            if (!condition)
                throw new ValidationException(errorMsg);
        }

        public static void AreEqual(TableHeader actual, TableHeader expected, string message)
        {
            foreach (var header in expected.HeaderStructure)
            {
                if (actual.HeaderStructure.Any(actualHeader => actualHeader.Name == header.Name))
                    return;
            }
            throw new Exception(message);
        }

        public static bool AreEqual(List<string> EditedValuesList, List<string> ValuesAfterReloadPageList, string message)
        {
            bool areEqual = false;

            for (int i = 0; i < EditedValuesList.Count; i++)
            {
                areEqual = (EditedValuesList[i] == ValuesAfterReloadPageList[i]) ? true : false;
            }
            return areEqual;
        }

        public static bool AreEqual(string EditedValuesList, string ValuesAfterReloadPageList)
        {
            bool areEqual = false;

            areEqual = (EditedValuesList == ValuesAfterReloadPageList) ? true : false;
            return areEqual;
        }

        public static bool AreEqual(List<string> EditedValuesList, List<string> ValuesAfterReloadPageList)
        {
            bool areEqual = false;

            for (int i = 0; i < EditedValuesList.Count; i++)
            {
                if(EditedValuesList[i] == ValuesAfterReloadPageList[i])
                {
                    areEqual = true;
                }
                else
                {
                    return false;
                }
            }
            return areEqual;
        }
    }

    public class ValidationException : Exception
    {
        public string ErrorMessage { get; set; }
        public ValidationException()
        {

        }
        public ValidationException(string msg)
        {
            ErrorMessage = msg + Environment.NewLine + base.Message;
        }
    }
}
