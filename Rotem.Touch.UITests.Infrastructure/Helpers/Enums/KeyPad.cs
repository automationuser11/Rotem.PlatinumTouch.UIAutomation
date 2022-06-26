using System.ComponentModel;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Enums
{
    [DefaultValue(None)]
    public enum KeyPad
    {
        None,
        BaseNumericKeyPad,
        MinusNumericKeyPad,
        MinusPointNumericKeyPad,
        PointNumericKeyPad,
        TimeKeyPad,
        DateKeyPad,
        NumericUpDownKeyPad,
        StateCycleKeyPad
    }
}
