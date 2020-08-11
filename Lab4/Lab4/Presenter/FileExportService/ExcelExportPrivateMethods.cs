using System;
using System.Data;

namespace Lab4.Presenter
{
    partial class ExcelExport
    {
        void ChangeHeaders(DataSet debtorsAndDebts, Func<string, string> headerTextOrColumnName)
        {
            DataTable debtors = debtorsAndDebts.Tables[0];
            foreach (DataColumn column in debtors.Columns)
                column.ColumnName = headerTextOrColumnName(column.ColumnName);

            DataTable debts = debtorsAndDebts.Tables[1];
            foreach (DataColumn column in debts.Columns)
                column.ColumnName = headerTextOrColumnName(column.ColumnName);
        }
    }
}