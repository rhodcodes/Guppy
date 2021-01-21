using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace guppy.core.Services
{
    internal class ExcelDataReaderService : IDataReaderService
    {
        private readonly FileInfo _file;
        private DataSet _dataSet = new DataSet();

        public ExcelDataReaderService(FileInfo file)
        {
            _file = file;
        }

        public DataTable GetTable(string key)
        {
            return _dataSet.Tables[key];
        }

        public IEnumerable<string> GetTableNames()
        {
            var tableNames = new List<string>();

            foreach(DataTable table in _dataSet.Tables)
            {
                tableNames.Add(table.TableName);
            }

            return tableNames;
        }

        public void Read()
        {
            using var stream = File.Open(_file.FullName, FileMode.Open, FileAccess.Read);
            using var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                UseColumnDataType = true,
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true,
                    FilterRow = (rowReader) =>
                    {
                        int progress = (int)Math.Ceiling((decimal)rowReader.Depth / (decimal)rowReader.RowCount * (decimal)100);
                        return true;
                    }
                }
            });

            _dataSet = result;
        }
    }
}