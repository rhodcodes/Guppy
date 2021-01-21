using System.Collections.Generic;
using System.Data;

namespace guppy.core.Services
{
    internal interface IDataReaderService
    {
        DataTable GetTable(string key);

        IEnumerable<string> GetTableNames();

        void Read();
    }
}