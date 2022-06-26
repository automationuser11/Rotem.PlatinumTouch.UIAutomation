using System.Data;
using System.Linq;
using Rotem.Touch.UITests.Infrastructure.Helpers.ControllerConfigurations;
using Rotem.Touch.UITests.Infrastructure.RNBL;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode.System.BirdWeight
{
    public class BirdWeightTable : GridTablePage<BirdWeightPage>
    {
        public ReadonlyGridTablePage CurrentDay
        {
            get
            {
                if (_currentDay != null) return _currentDay;

                var rnbl = new RNBLAccessor(ConfigurationsManager.ActiveConfiguration.RnblArgs);
                var mtTable = rnbl.GetTableMetaData("Bird Weight");

                var dataTable = mtTable.Copy();
                dataTable.Clear();

                foreach (var row in mtTable.Rows.Cast<object>().Where(row => (row as DataRow)["ContainerID"].ToString() == "Totals"))
                {
                    dataTable.Rows.Add((row as DataRow).ItemArray);
                }
            
                _currentDay = new ReadonlyGridTablePage(dataTable);

                return _currentDay ;
            }
            set { _currentDay = value; }
        }
        private ReadonlyGridTablePage _currentDay;
    }
}
