using System.Data;
using System.Linq;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;
using Rotem.Touch.UITests.Infrastructure.RNBL;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.Management.FeedInventory
{
    public class FeedInventoryTable : GridTablePage<FeedInventoryPage>
    {
        public ReadonlyGridTablePage TotalFeed
        {
            get
            {
                if (_totalFeed != null) return _totalFeed;

                var rnbl = new RNBLAccessor(ConfigurationsManager.ActiveConfiguration.RnblArgs);
                var mtTable = rnbl.GetTableMetaData("Feed Inventory");

                var dataTable = mtTable.Copy();
                dataTable.Clear();

                foreach (var row in mtTable.Rows.Cast<object>().Where(row => (row as DataRow)["ContainerID"].ToString() == "Totals"))
                {
                    dataTable.Rows.Add((row as DataRow).ItemArray);
                }

                _totalFeed = new ReadonlyGridTablePage(dataTable);

                return _totalFeed;
            }
            set { _totalFeed = value; }
        }
        private ReadonlyGridTablePage _totalFeed;

        public ReadonlyGridTablePage Active
        {
            get
            {
                if (_active != null) return _active;

                var rnbl = new RNBLAccessor(ConfigurationsManager.ActiveConfiguration.RnblArgs);
                var mtTable = rnbl.GetTableMetaData("Feed Inventory");

                var dataTable = mtTable.Copy();
                dataTable.Clear();

                foreach (var row in mtTable.Rows.Cast<object>().Where(row => (row as DataRow)["ContainerID"].ToString() == "ActiveSilos"))
                {
                    dataTable.Rows.Add((row as DataRow).ItemArray);
                }

                _active = new ReadonlyGridTablePage(dataTable);

                return _active;
            }
            set { _active = value; }
        }
        private ReadonlyGridTablePage _active;
    }
}
