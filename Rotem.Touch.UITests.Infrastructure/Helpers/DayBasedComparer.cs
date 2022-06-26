using System;
using System.Collections.Generic;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public class DayBasedComparer : IComparer<Double>
    {
        public int Compare(double day1, double day2)
        {
            if ((day1 < day2) && (day1 == 0.0))
                return 1;
            if ((day1 < day2) && (day2 == 0.0))
                return -1;
            if (day1 == day2)
                return 0;
            return -1;
        }
    }
}