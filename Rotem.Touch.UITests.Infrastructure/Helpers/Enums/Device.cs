using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Enums
{
    public enum Device
    {
        [StringValue("Tunnel Fan")]TunnelFan,
        [StringValue("Variable Heater")]VariableHeater,
        [StringValue("Exhaust Fan")]ExhaustFan,
        [StringValue("Vent Open")]VentOpen,
        [StringValue("Vent Close")]VentClose,
        [StringValue("Stir Fan")] StirFan,
        [StringValue("Water On Demand")]WaterOnDemand,
        [StringValue("W.O.D")]WOD,
        // sefi delete space for Cool Pad test define relay layout
        [StringValue("Cool Pad")]CoolPad,
        [StringValue("Fogger")]Fogger,
        [StringValue("Feeder")]Feeder,
        // sefi delete space for Light test define relay layout
        [StringValue("Light")]Light,
        [StringValue("Water")]Water,
        [StringValue("Auger")]Auger,
        [StringValue("Feed Line Up")]FeedLineUp,
        [StringValue("Feed Line Down")]FeedLineDown,
        [StringValue("Drink Line Up")]DrinkLineUp,
        [StringValue("Drink Line Down")]DrinkLineDown,
        [StringValue("Tunnel Open")]TunnelOpen,
        [StringValue("Curtain Open")]CurtainOpen,
        [StringValue("Light Dimmer")]LightDimmer ,
        [StringValue("None")]None,
        [StringValue("NONE")]NONE,
        [StringValue("Heat")]Heat,
        [StringValue("Temperature Sensor")]TemperatureSensor,
        [StringValue("Humidity Sensor In")]HumiditySensorIn,
        [StringValue("Humidity Sensor Out")]HumiditySensorOut,
        [StringValue("CO2 Sensor")]CO2Sensor,
        [StringValue("Feeder Window Open")]FeederWindowOpen,
        [StringValue("Feeder Window Close")]FeederWindowClose,
        [StringValue("Nest Open")]NestOpen,
        [StringValue("Nest Close")]NestClose,

    }
}
