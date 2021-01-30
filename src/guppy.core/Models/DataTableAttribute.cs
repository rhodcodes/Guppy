using System;

namespace guppy.core.Models
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class DataTableAttribute : Attribute
    {
        public DataTableAttribute(string sheetName)
        {
            SheetName = sheetName;
        }

        public string SheetName { get; }
    }
}