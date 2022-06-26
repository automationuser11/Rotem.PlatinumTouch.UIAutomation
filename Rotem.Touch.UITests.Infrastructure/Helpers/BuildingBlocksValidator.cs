using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers
{
    public class BuildingBlocksValidator<T> where T: IApplicationPage
    {
        public T Page { get; set; }


        public void ValidateBuildingBlocks()
        {
            IEnumerable<PropertyInfo> buildingBlocks = GetBuildingBlocks();

            foreach (var buildingBlock in buildingBlocks)
            {
                // 
                var result = DriverManager.Driver.IsElementExists(() => buildingBlock.GetValue(Page, null) as IWebElement);


            }
        }

        private IEnumerable<PropertyInfo> GetBuildingBlocks()
        {
            throw new NotImplementedException();
        }

    }
}
