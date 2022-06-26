using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods
{
    public class InputRange
    {
        /// <summary>
        /// Field or Column whos is that under test.
        /// </summary>
        public string Name { get; set; }    
        public string Minimum
        {
            get { return _minimum ?? (_minimum = string.Empty); }
            set { _minimum = value; }
        }
        private string _minimum;

        public string MinimumHours
        {
            get { return _minimumHours ?? (_minimumHours = string.Empty); }
            set { _minimumHours = value; }
        }
        private string _minimumHours;

        public string MinimumMinutes
        {
            get { return _minimumMinutes ?? (_minimumMinutes = string.Empty); }
            set { _minimumMinutes = value; }
        }
        private string _minimumMinutes;

        public string Maximum
        {
            get { return _maximum ?? (_maximum = string.Empty); }
            set { _maximum = value; }
        }
        private string _maximum;

        public string MaximumHours
        {
            get { return _maximumHours ?? (_maximumHours = string.Empty); }
            set { _maximumHours = value; }
        }
        private string _maximumHours;

        public string MaximumMinutes
        {
            get { return _maximumMinutes ?? (_maximumMinutes = string.Empty); }
            set { _maximumMinutes = value; }
        }
        private string _maximumMinutes;

        public string DefaultValue
        {
            get { return _defaultValue ?? (_defaultValue = string.Empty); }
            set { _defaultValue = value; }
        }
        private string _defaultValue;

        public List<string> RangeList
        {
            get { return _rangeList ?? (_rangeList = new List<string>()); }
            set { _rangeList = value; }
        }
        private List<string> _rangeList;

        protected bool Equals(InputRange other)
        {
            if (RangeList.Count != other.RangeList.Count) return false;
            //bool AreEqual = string.Equals(Minimum, other.Minimum) && string.Equals(Maximum, other.Maximum) && string.Equals(DefaultValue, other.DefaultValue);
            //if (!AreEqual) return false;
            if (!string.Equals(Minimum, other.Minimum) && string.Equals(Maximum, other.Maximum)) return false;
            return RangeList.All(item => other.RangeList.Contains(item));
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((InputRange) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (Minimum != null ? Minimum.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Maximum != null ? Maximum.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (RangeList != null ? RangeList.GetHashCode() : 0);
                return hashCode;
            }
        }

        //        public override string ToString()
        //        {
        //            string msg = string.Format(@"
        //Minimum: {0},
        //Maximum: {1},
        //Default Value: {3},
        //Range List: {2}]", Minimum, Maximum, string.Join(", ", RangeList), DefaultValue);

        //            return msg;
        //        }
        public override string ToString()
        {
            string msg = string.Format(@"
Minimum: {0},
Maximum: {1},
Range List: {2}]", Minimum, Maximum, string.Join(", ", RangeList));

            return msg;
        }
    }

    public class RangeUnderTest
    {
        public RangeUnderTest(InputRange rangeUnderTest)
        {
            var rgx = new Regex("[,]");

            rangeUnderTest.Minimum = rgx.Replace(rangeUnderTest.Minimum, "");
            rangeUnderTest.Maximum = rgx.Replace(rangeUnderTest.Maximum, "");
            Range = rangeUnderTest;
            MinValue = rangeUnderTest.Minimum;
            MaxValue = rangeUnderTest.Maximum;
        }
        public InputRange Range { get; set; }
        public bool IsTestPassed { get { return IsBelowTestPassed && IsInsideTestPassed && IsAboveTestPassed && IsMinValueTestPassed && IsMaxValueTestPassed; } }
        public bool IsBelowTestPassed { get; internal set; }
        public bool IsMinValueTestPassed { get; internal set; }
        public bool IsInsideTestPassed { get; internal set; }
        public bool IsMaxValueTestPassed { get; internal set; }
        public bool IsAboveTestPassed { get; internal set; }
        public string Below { get; internal set; }
        public string MinValue { get; internal set; }
        public string Inside { get; internal set; }
        public string MaxValue { get; internal set; }
        public string Above { get; internal set; }

        internal void TestValueBelowRange()
        {
            try
            {
                Below = (int.Parse(Range.Minimum) - 1).ToString();
            }
            catch (FormatException)
            {
                try
                {
                    var minimum = double.Parse(Range.Minimum);
                    Below = (minimum - 1).ToString("f2");
                }
                catch (FormatException)
                {
                    throw new FormatException("The number format for this range currntly not supported.");
                }
            }
        }
        internal void TestValueInsideRange()
        {
            var rnd = new Random();
            try
            {
                Inside = rnd.Next(int.Parse(Range.Minimum), int.Parse(Range.Maximum)).ToString();
            }
            catch (FormatException)
            {
                try
                {

                    //var minimum =  double.Parse(Range.Minimum);
                    //var maximum =  double.Parse(Range.Maximum);
                    // var value = (double) rnd.Next(minimum, maximum);
                    // Inside = (value * rnd.NextDouble()).ToString("f1");

                    Inside  = (rnd.NextDouble() * (Math.Abs(double.Parse(Range.Maximum) - double.Parse(Range.Minimum))) + double.Parse(Range.Minimum)).ToString("f1");
                    //Inside = "45.0";
                }
                catch (FormatException)
                {
                    throw new FormatException("The number format for this range currntly not supported.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //Inside = "1.0";
                throw new ArgumentOutOfRangeException(string.Format("{0}. The min value is: {1}, the max value is: {2}.", ex.Message, double.Parse(Range.Minimum), double.Parse(Range.Maximum)));
            }
        }
        internal void TestValueAboveRange()
        {
            try
            {
                Above = (int.Parse(Range.Maximum) + 1).ToString();
            }
            catch (FormatException)
            {
                try
                {
                    var maximum = double.Parse(Range.Maximum);
                    Above = (maximum + 1).ToString("f2");
                }
                catch (FormatException)
                {
                    throw new FormatException("The number format for this range currntly not supported.");
                }
            }
        }
        internal void TestTimeInsideRange()
        {
            var rnd = new Random();
            try
            {
                var randomHour = rnd.Next(int.Parse(Range.MinimumHours), int.Parse(Range.MaximumHours)).ToString();
                var randomMinute = rnd.Next(int.Parse(Range.MinimumMinutes), int.Parse(Range.MaximumMinutes)).ToString();
                Inside = string.Format("{0}:{1}", randomHour, randomMinute);
            }
            catch (FormatException)
            {
                throw new FormatException("The number format for this range currntly not supported.");
            }
        }

        internal void TestRandomStateCycle(RangeUnderTest testingRange)
        {
            List<string> valueOptions = new List<string>();
            Random r = new Random();
            int index = r.Next(testingRange.Range.RangeList.Count);
            testingRange.Inside = testingRange.Range.RangeList[index];
        }
    }
}
