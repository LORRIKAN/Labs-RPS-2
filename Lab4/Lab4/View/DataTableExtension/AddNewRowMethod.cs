using System.Collections.Generic;
using System.Data;

namespace Lab4.View.DataTableExtension
{
    public static class AddNewRowExtension
    {

        public static void AddRow(this DataTable dataTable, IDictionary<string, string> rowToInsert)
        {
            var newRow = dataTable.NewRow();
            foreach (var element in rowToInsert)
            {
                newRow[element.Key] = element.Value;
            }
            dataTable.Rows.Add(newRow);
        }
    }
}