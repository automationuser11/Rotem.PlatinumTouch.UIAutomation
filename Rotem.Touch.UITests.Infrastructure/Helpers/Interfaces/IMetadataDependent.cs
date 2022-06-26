using System;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces
{
    public interface IMetadataDependentPageObject
    {
        Metadata Metadata { get; set; }
    }

    public class Metadata
    {
        public string MenuId { get; set; }
        public string MenuItem { get; set; }
        public string ContainerId { get; set; }
        public string ParentId { get; set; }
        
    }
}
