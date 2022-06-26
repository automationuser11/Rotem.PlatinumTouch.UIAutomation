using System;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Extensions
{
    public static class UnitsExtension
    {
        public static string ToCelsius(this string valueAsFahrenhietUnits)
        {
            return ((double.Parse(valueAsFahrenhietUnits) - 32)/1.8).ToString("f1");
        }

        public static string ToFahrenhiet(this string valueAsCelsiusUnits)
        {
            return Math.Truncate((double.Parse(valueAsCelsiusUnits) * 1.8 + 32)).ToString("f1");
        }
    }
}
