using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Interface : Form
    {
        private void ExportToExcel()
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            excel.DisplayAlerts = false;
            var wb = excel.Workbooks.Add();
            Worksheet ws = (Worksheet)excel.ActiveSheet;

            ws.Cells[1, 1] = "Синусоида: y = a + b⋅sin(c⋅x + d)";
            ws.Range["A1:D1"].Merge();

            ws.Cells[3, 1] = "a";
            ws.Cells[4, 1] = a;
            ws.Cells[3, 2] = "b";
            ws.Cells[4, 2] = b;
            ws.Cells[3, 3] = "c";
            ws.Cells[4, 3] = c;
            ws.Cells[3, 4] = "d";
            ws.Cells[4, 4] = d;
            ws.Cells[3, 6] = "Left limit x";
            ws.Cells[4, 6] = leftBoardX;
            ws.Cells[3, 7] = "Step x";
            ws.Cells[4, 7] = stepX;
            ws.Cells[3, 8] = "Right limit x";
            ws.Cells[4, 8] = rightBoardX;
            ws.Columns["F"].AutoFit();
            ws.Columns["H"].AutoFit();
            ws.Range["A3:H3"].Style.HorizontalAlignment = XlHAlign.xlHAlignLeft;


            ws.Cells[6, 1] = ResultFuncLabel.Text;
            ws.Range["A6:D6"].Merge();

            ws.Cells[8, 1] = "x";
            ws.Cells[9, 1] = "y";
            for (int i = 0; i < xAndYValuesNum; ++i)
            {
                ws.Cells[8, i + 2] = xValues[i];
                ws.Cells[9, i + 2] = yValues[i];
            }

            Range xValuesRange = ws.Range[ws.Cells[8, 2], ws.Cells[8, xAndYValuesNum + 1]];
            Range yValuesRange = ws.Range[ws.Cells[9, 2], ws.Cells[9, xAndYValuesNum + 1]];
            Chart chart = ws.Shapes.AddChart2(Type.Missing, Type.Missing, 150, 150, 350, 300).Chart;
            chart.ChartWizard(yValuesRange, XlChartType.xlXYScatterSmoothNoMarkers, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                "Синусоида", "x", "y");
            Series series = chart.SeriesCollection(1);
            series.XValues = xValuesRange;

            ws.SaveAs(saveFileDialog.FileName);
            wb.Close(true);
            excel.Quit();
            ws = null;
            wb = null;
            excel = null;
            GC.Collect();
        }
        private void ExcelExportBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelExportBtn.Enabled = false;
                ExportToExcel();
                MessageBox.Show("Успешно сохранено!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExcelExportBtn.Enabled = true;
            }
        }
    }
}