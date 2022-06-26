using Rotem.Touch.UITests.Infrastructure.Helpers;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Control.Nests
{
    public class NestsTable : GridTablePage<NestsPage>
    {
        public NestsTable()
        {
            var metadata = MetadataFactory.GetMetadata<NestsPage>();
            Total = new ReadonlyGridTablePage(metadata);
        }

        public ReadonlyGridTablePage Total { get; private set; }
    }
}
