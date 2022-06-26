using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Enums
{
    public enum TemperatureUnit
    {
        [StringValue("None")] None,
        [StringValue("F º")] Fahrenheit,
        [StringValue("C º")] Celsius,
    }
}
