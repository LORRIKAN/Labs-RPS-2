using ClosedXML.Excel;
using Lab4.View.TranslateToHeaderText;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab4.Presenter
{
    public partial class ExcelExport : IFileExportService
    {
        public string FilePath { get; set; }

        public View.NestedTable.NestedTable Table { get; set; }
        public void SaveAllDebtorsAndDebts()
        {
            var debtors = new DataTable();
            var debts = new DataTable();

            var toMerge = new DataView(Table.ParentDataSource);
            debtors.Merge(toMerge.ToTable());

            toMerge = new DataView(Table.ChildDataSource);
            debts.Merge(toMerge.ToTable());

            var debtorsAndDebts = new DataSet();
            debtorsAndDebts.Tables.AddRange(new[] { debtors, debts });

            ChangeHeaders(debtorsAndDebts, TranslateToHeaderText.HeaderText);

            debtorsAndDebts.Tables[0].TableName = "Должники";
            debtorsAndDebts.Tables[1].TableName = "Долги";

            using (var wb = new XLWorkbook())
            {
                wb.AddWorksheet(debtorsAndDebts);
                wb.Worksheets.ToList().ForEach(ws => { ws.Rows().AdjustToContents(); ws.Columns().AdjustToContents(); });
                wb.SaveAs(FilePath);
            }

            ChangeHeaders(debtorsAndDebts, TranslateToHeaderText.ColumnName);
        }

        public void SaveDebtorDebts()
        {
            var debtors = new DataTable();
            var debts = new DataTable();

            foreach (DataGridViewRow row in Table.SelectedRows)
            {
                var id = row.Cells[1].Value;
                var toMerge = new DataView(Table.ParentDataSource) { RowFilter = "Id = '" + id + "'" };
                debtors.Merge(toMerge.ToTable());

                toMerge = new DataView(Table.ChildDataSource) { RowFilter = "DebtorId = '" + id + "'" };
                debts.Merge(toMerge.ToTable());
            }
            var debtorsAndDebts = new DataSet();
            debtorsAndDebts.Tables.AddRange(new[] { debtors, debts });

            ChangeHeaders(debtorsAndDebts, TranslateToHeaderText.HeaderText);

            debtorsAndDebts.Tables[0].TableName = "Должники";
            debtorsAndDebts.Tables[1].TableName = "Долги";

            using (var wb = new XLWorkbook())
            {
                wb.AddWorksheet(debtorsAndDebts);
                wb.Worksheets.ToList().ForEach(ws => { ws.Rows().AdjustToContents(); ws.Columns().AdjustToContents(); });
                wb.SaveAs(FilePath);
            }

            ChangeHeaders(debtorsAndDebts, TranslateToHeaderText.ColumnName);
        }
    }
}