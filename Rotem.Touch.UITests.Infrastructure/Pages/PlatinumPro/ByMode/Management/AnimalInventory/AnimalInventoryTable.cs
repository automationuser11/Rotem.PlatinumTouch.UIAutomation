using Rotem.Touch.UITests.Infrastructure.Helpers;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.AnimalInventory
{
    public class AnimalInventoryTable : GridTablePage<AnimalInventoryPage>
    {
        public AnimalInventoryTable()
        {
            var metadata = MetadataFactory.GetMetadata<AnimalInventoryPage>();
            //metadata.ContainerId = "Total";

            Total = new ReadonlyGridTablePage(metadata);
        }

        public ReadonlyGridTablePage Total { get; private set; }
    }
}
