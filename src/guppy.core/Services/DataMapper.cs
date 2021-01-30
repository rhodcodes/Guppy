using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using guppy.core.Models;

namespace guppy.core.Services
{
    /// <summary>
    /// Maps a DataTable to a collection of T. Uses a DataColumn Attribute on T to map the columns
    /// to properties
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    public class DataMapper<T> where T : class, new()
    {
        public IEnumerable<T> Map(DataTable dataTable)
        {
            if (dataTable is null)
            {
                throw new ArgumentNullException(nameof(dataTable));
            }

            List<T> entities = new();
            T entity = new();

            var properties = entity.GetType().GetProperties();

            foreach (DataRow row in dataTable.Rows)
            {
                //If the entire row is empty - skip it
                if (row.ItemArray.All(o => string.IsNullOrEmpty(o?.ToString())))
                {
                    continue;
                }

                entity = new T();

                foreach (var property in properties)
                {
                    string? columnTitle = property.GetCustomAttribute<DataColumnAttribute>()?.Title;

                    if (!String.IsNullOrWhiteSpace(columnTitle) && dataTable.Columns.Contains(columnTitle))
                    {
                        property.SetValue(entity, row.Field<object>(columnTitle));
                    }
                }

                entities.Add(entity);
            }

            return entities;
        }
    }
}