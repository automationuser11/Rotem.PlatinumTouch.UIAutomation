using System;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class PointNumericKeyPad : BaseNumericKeyPad
    {
        public override KeyPad Type
        {
            get { return KeyPad.PointNumericKeyPad; }
        }
        public override RangeUnderTest GetTestingRange(InputRange range)
        {
            var testingRange = new RangeUnderTest(range);

            if (double.Parse(range.Minimum) >= 0.1)
            {
                testingRange.Below = (double.Parse(range.Minimum) - 1).ToString();//Gutman change from 0.1 to 1
            }
            else
            {
                testingRange.IsBelowTestPassed = true;
            }

            testingRange.Above = (double.Parse(range.Maximum) + 1).ToString();//Gutman change from 0.1 to 1
            testingRange.TestValueInsideRange();

            return testingRange;
        }
    }
}
