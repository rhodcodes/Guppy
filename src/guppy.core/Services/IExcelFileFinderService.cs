using System.Collections.Generic;
using System.IO;

namespace guppy.core.Services
{
    internal interface IExcelFileFinderService
    {
        IEnumerable<FileInfo> Execute();
    }
}