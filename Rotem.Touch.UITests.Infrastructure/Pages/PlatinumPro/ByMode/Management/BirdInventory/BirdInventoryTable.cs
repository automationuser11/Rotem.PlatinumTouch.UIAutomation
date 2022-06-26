using Rotem.Touch.UITests.Infrastructure.Helpers;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.BirdInventory
{
    public class BirdInventoryTable : GridTablePage<BirdInventoryPage>
    {
        public BirdInventoryTable()
        {
            var metadata = MetadataFactory.GetMetadata<BirdInventoryPage>();
            //metadata.ContainerId = "Total";

            Total = new ReadonlyGridTablePage(metadata);
        }

        public ReadonlyGridTablePage Total { get; private set; }
    }
}
