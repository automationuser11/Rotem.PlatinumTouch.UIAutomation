using Rotem.Touch.UITests.Infrastructure.Helpers;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedLinesCalibration
{
    public class FeedLinesCalibrationTable : GridTablePage<FeedLinesCalibrationPage>
    {
        public FeedLinesCalibrationTable()
        {
            var metadata = MetadataFactory.GetMetadata<FeedLinesCalibrationPage>();

            Total = new ReadonlyGridTablePage(metadata);
        }

        public ReadonlyGridTablePage Total { get; private set; }
    }
}
