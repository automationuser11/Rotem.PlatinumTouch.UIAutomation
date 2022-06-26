using System;
using System.Linq;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpaces(this string str)
        {
            var strWords = str.Split(new string[]{" ", "  ", "   ", "    ", Environment.NewLine},StringSplitOptions.RemoveEmptyEntries);
            return strWords.Aggregate("", (current, word) => current + (word + " ")).Trim();
        }
    }
}
