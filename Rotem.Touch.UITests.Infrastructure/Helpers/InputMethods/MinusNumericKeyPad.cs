using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class MinusNumericKeyPad : BaseNumericKeyPad
    {
        public override KeyPad Type
        {
            get { return KeyPad.MinusNumericKeyPad; }
        }
        public override RangeUnderTest GetTestingRange(InputRange range)
        {
            var testingRange = new RangeUnderTest(range)
            {
                Below = (double.Parse(range.Minimum) - 1).ToString(),
                Above = (double.Parse(range.Maximum) + 1).ToString(),
            };

            testingRange.TestValueInsideRange();

            return testingRange;
        }
    }
}
