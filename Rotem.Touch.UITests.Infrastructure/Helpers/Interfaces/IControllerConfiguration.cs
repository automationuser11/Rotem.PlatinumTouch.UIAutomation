using System.Collections.Generic;
using ControllersLayoutParser;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.RNBL;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;
using System;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface IControllerConfiguration
    {
        Dictionary<Type, ControllerPageSetup> PagesSetupDictionary { get; }
        Dictionary<Type, ControllerPageSetup> FixedPagesSetupDictionary { get; }
        string Name { get; set; }
        string FamilyType { get; set; }
        TemperatureUnit TemperatureUnit { get; set; }
        WeightUnit WeightUnit { get; set; }
        RnblArgs RnblArgs { get; set; }
        int WaterDevices { get; set; }
        int FeedDevices { get; set; }
        int AugerDevices { get; set; }
        int LightDevices { get; set; }
        int LightDimmerDevices { get; set; }
        int SiloDevices { get; set; }
        int HeatersDevices { get; set; }
        int LowRadiantHeatersDevices { get; set; }
        int HighRadiantHeatersDevices { get; set; }
        LevelControl LevelControl { get; set; }
    }
}
