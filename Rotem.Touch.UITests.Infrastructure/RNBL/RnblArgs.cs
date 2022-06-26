using System.IO;
using ControllersLayoutParser;

namespace Rotem.Touch.UITests.Infrastructure.RNBL
{
    public class RnblArgs
    {
        public ControllerType ControllerType { get; set; }
        public int MemoryVersion { get; set; }
        public int ControllerMajorVersion { get; set; }
        public LevelControl LevelControl { get; set; }
        public DirectoryInfo MetadataDirectoryInfo { get; set; }
    }
}
