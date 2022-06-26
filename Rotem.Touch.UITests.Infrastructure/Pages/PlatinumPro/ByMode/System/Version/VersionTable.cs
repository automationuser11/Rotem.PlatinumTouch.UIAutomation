using Rotem.Touch.UITests.Infrastructure.Helpers;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.Version
{
    public class VersionTable : GridTablePage<VersionPage>
    {

        public VersionTable()
        {
            var metadata = MetadataFactory.GetMetadata<VersionPage>();

            ControllerVersion = new ReadonlyGridTablePage(metadata);
            UIServerVersion = new ReadonlyGridTablePage(metadata);
            UIClientVersion = new ReadonlyGridTablePage(metadata);
        }


        public ReadonlyGridTablePage ControllerVersion { get; private set; }
        public ReadonlyGridTablePage UIServerVersion { get; private set; }
        public ReadonlyGridTablePage UIClientVersion { get; private set; }

    }
}
