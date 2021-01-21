using System.Collections.Generic;
using System.IO;

namespace guppy.core.Services
{
    internal class ExcelFileFinderService : IExcelFileFinderService
    {
        private readonly FileInfo _root;

        public ExcelFileFinderService(FileInfo root)
        {
            _root = root;
        }

        public IEnumerable<FileInfo> Execute()
        {
            var targets = new List<FileInfo>();

            if(_root.Attributes.HasFlag(FileAttributes.Directory))
            {
                foreach(var file in Directory.EnumerateFiles(_root.FullName, "*.xlsx", SearchOption.AllDirectories))
                {
                    targets.Add(new FileInfo(file));
                }
            }

            if(_root.Extension is ".xlsx")
            {
                return new List<FileInfo>() { _root };
            }

            return targets;
        }
    }
}