using System;

namespace guppy.core.Models
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class DataColumnAttribute : Attribute
    {
        public DataColumnAttribute(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}