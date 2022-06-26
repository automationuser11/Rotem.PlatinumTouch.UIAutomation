using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Configuration;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.TimeAndDate;
using Unitronics.ComDriver;
using Unitronics.ComDriver.Messages.DataRequest;

namespace Rotem.Platinum.Weights
{
    [TestClass]
    public class Weights
    {
        public INavigator Navigator
        {
            get
            {
                return ConfigurationManagerHelper.IsFarmMode ? (INavigator)new RotemWebNavigator() : (INavigator)new Navigator();
            }
        }

        private static PLC PLC;
        private int timeOnScale;
        private int timeScaleEmpty;
        private ReadWriteRequest[] data = new ReadWriteRequest[1];
        private ReadWriteRequest[] reset = new ReadWriteRequest[1];
        private bool isLastMesurement;

        public TestContext TestContext { get; set; }
        public TimeAndDatePage TimeAndDatePage 
        {
            get
            {
                return _timeAndDatePage ?? (_timeAndDatePage = new TimeAndDatePage());
            }
        }
        private TimeAndDatePage _timeAndDatePage;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Ethernet ethernet = new Ethernet("10.16.0.176", 80, EthProtocol.TCP, 3, 3000);
            PLC = PLCFactory.GetPLC(ethernet, 0);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            var a2dValue = TestContext.DataRow["A2D"].ToString();
            int timeOnScaleValue = int.Parse(TestContext.DataRow["TimeOnScale"].ToString());
            int timeScaleEmptyValue = int.Parse(TestContext.DataRow["TimeScaleEmpty"].ToString());
            if (timeOnScaleValue == -1)
            {
                isLastMesurement = true;
                return;
            }

            object[] a2d = { a2dValue };
            object[] resetData = { 1000 };

            timeOnScale = timeOnScaleValue;
            timeScaleEmpty = timeScaleEmptyValue;

            data[0] = new WriteOperands()
            {
                NumberOfOperands = 1,
                OperandType = OperandTypes.ML,
                StartAddress = 0,
                Values = a2d
            };

            reset[0] = new WriteOperands()
            {
                NumberOfOperands = 1,
                OperandType = OperandTypes.ML,
                StartAddress = 0,
                Values = resetData
            };

            PLC.ReadWrite(ref data);
            Waits.Wait(timeOnScale);
            PLC.ReadWrite(ref reset);
            Waits.Wait(timeScaleEmpty);
        }

        [TestCleanup]
        public void TestCleaup()
        {
            if (!isLastMesurement) return;

            Navigator.NavigateTo<TimeAndDatePage>();
            TimeAndDatePage.MoveToNextDay();
            Browser.Close();
        }

        [TestMethod]
        [DataSource("Day_01")]
        public void Scale_WeightMesurementsForDay01() { }

        [TestMethod]
        [DataSource("Day_02")]
        public void Scale_WeightMesurementsForDay02() { }

        [TestMethod]
        [DataSource("Day_03")]
        public void Scale_WeightMesurementsForDay03() { }

        [TestMethod]
        [DataSource("Day_04")]
        public void Scale_WeightMesurementsForDay04() { }

        [TestMethod]
        [DataSource("Day_05")]
        public void Scale_WeightMesurementsForDay05() { }

        [TestMethod]
        [DataSource("Day_06")]
        public void Scale_WeightMesurementsForDay06() { }
        
        [TestMethod]
        [DataSource("Day_07")]
        public void Scale_WeightMesurementsForDay07() { }
        
        [TestMethod]
        [DataSource("Day_08")]
        public void Scale_WeightMesurementsForDay08() { }

        [TestMethod]
        [DataSource("Day_09")]
        public void Scale_WeightMesurementsForDay09() { }

        [TestMethod]
        [DataSource("Day_10")]
        public void Scale_WeightMesurementsForDay10() { }

        [TestMethod]
        [DataSource("Day_11")]
        public void Scale_WeightMesurementsForDay11() { }

        [TestMethod]
        [DataSource("Day_12")]
        public void Scale_WeightMesurementsForDay12() { }

        [TestMethod]
        [DataSource("Day_13")]
        public void Scale_WeightMesurementsForDay13() { }

        [TestMethod]
        [DataSource("Day_14")]
        public void Scale_WeightMesurementsForDay14() { }

        [TestMethod]
        [DataSource("Day_15")]
        public void Scale_WeightMesurementsForDay15() { }

        [TestMethod]
        [DataSource("Day_16")]
        public void Scale_WeightMesurementsForDay16() { }

        [TestMethod]
        [DataSource("Day_17")]
        public void Scale_WeightMesurementsForDay17() { }

        [TestMethod]
        [DataSource("Day_18")]
        public void Scale_WeightMesurementsForDay18() { }

        [TestMethod]
        [DataSource("Day_19")]
        public void Scale_WeightMesurementsForDay19() { }

        [TestMethod]
        [DataSource("Day_20")]
        public void Scale_WeightMesurementsForDay20() { }

        [TestMethod]
        [DataSource("Day_21")]
        public void Scale_WeightMesurementsForDay21() { }

        [TestMethod]
        [DataSource("Day_22")]
        public void Scale_WeightMesurementsForDay22() { }

        [TestMethod]
        [DataSource("Day_23")]
        public void Scale_WeightMesurementsForDay23() { }

        [TestMethod]
        [DataSource("Day_24")]
        public void Scale_WeightMesurementsForDay24() { }

        [TestMethod]
        [DataSource("Day_25")]
        public void Scale_WeightMesurementsForDay25() { }

        [TestMethod]
        [DataSource("Day_26")]
        public void Scale_WeightMesurementsForDay26() { }

        [TestMethod]
        [DataSource("Day_27")]
        public void Scale_WeightMesurementsForDay27() { }

        [TestMethod]
        [DataSource("Day_28")]
        public void Scale_WeightMesurementsForDay28() { }

        [TestMethod]
        [DataSource("Day_29")]
        public void Scale_WeightMesurementsForDay29() { }

        [TestMethod]
        [DataSource("Day_30")]
        public void Scale_WeightMesurementsForDay30() { }

        [TestMethod]
        [DataSource("Day_31")]
        public void Scale_WeightMesurementsForDay31() { }

        [TestMethod]
        [DataSource("Day_32")]
        public void Scale_WeightMesurementsForDay32() { }

        [TestMethod]
        [DataSource("Day_33")]
        public void Scale_WeightMesurementsForDay33() { }

        [TestMethod]
        [DataSource("Day_34")]
        public void Scale_WeightMesurementsForDay34() { }

        [TestMethod]
        [DataSource("Day_35")]
        public void Scale_WeightMesurementsForDay35() { }

        [TestMethod]
        [DataSource("Day_36")]
        public void Scale_WeightMesurementsForDay36() { }

        [TestMethod]
        [DataSource("Day_37")]
        public void Scale_WeightMesurementsForDay37() { }

        [TestMethod]
        [DataSource("Day_38")]
        public void Scale_WeightMesurementsForDay38() { }

        [TestMethod]
        [DataSource("Day_39")]
        public void Scale_WeightMesurementsForDay39() { }

        [TestMethod]
        [DataSource("Day_40")]
        public void Scale_WeightMesurementsForDay40() { }
        
        [TestMethod]
        [DataSource("Day_41")]
        public void Scale_WeightMesurementsForDay41() { }

        [TestMethod]
        [DataSource("Day_42")]
        public void Scale_WeightMesurementsForDay42() { }
    }
}
