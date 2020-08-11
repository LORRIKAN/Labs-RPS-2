using System.Windows.Forms;

namespace Lab3
{
    public partial class Interface : Form
    {
        #region BoardsAndParamsChecksForRedraw
        bool leftBoardXChecked = false;
        bool stepXChecked = false;
        bool rightBoardXChecked = false;
        public bool parametrAChecked = false;
        bool parametrBChecked = false;
        bool parametrCChecked = false;
        bool parametrDChecked = false;
        #endregion
        #region FuncParamsAndXYValues
        double leftBoardX;
        double stepX;
        double rightBoardX;
        double a;
        double b;
        double c;
        double d;
        double[] xValues;
        double[] yValues;
        #endregion
        private void TableAndGraphRedraw()
        {
            if (leftBoardXChecked && stepXChecked && rightBoardXChecked && parametrAChecked && parametrBChecked &&
                parametrCChecked && parametrDChecked)
            {
                FuncCalc();
                TableOfFunctionValuesRedraw();
                FunctionGraphRedraw();
                ExcelExportBtn.Enabled = true;
            }
            else
                ExcelExportBtn.Enabled = false;
        }
        private void ResultFuncLabelRedraw()
        {
            ResultFuncLabel.Text = "y = ";

            if (parametrAChecked)
            {
                string toAdd = ParametrATextBox.Text;
                if (ParametrATextBox.TextLength > 4)
                    toAdd = ParametrATextBox.Text.Substring(0, 4) + "...";
                ResultFuncLabel.Text += toAdd;
            }
            else
                ResultFuncLabel.Text += "a";

            ResultFuncLabel.Text += " + ";

            if (parametrBChecked)
            {
                string toAdd = ParametrBTextBox.Text + "⋅";
                if (ParametrBTextBox.TextLength > 4)
                    toAdd = ParametrBTextBox.Text.Substring(0, 4) + "..." + "⋅";
                ResultFuncLabel.Text += toAdd;
            }
            else
                ResultFuncLabel.Text += "b⋅";

            ResultFuncLabel.Text += "sin(";

            if (parametrCChecked)
            {
                string toAdd = ParametrCTextBox.Text + "⋅";
                if (ParametrCTextBox.TextLength > 4)
                    toAdd = ParametrCTextBox.Text.Substring(0, 4) + "..." + "⋅";
                ResultFuncLabel.Text += toAdd;
            }
            else
                ResultFuncLabel.Text += "c⋅";

            ResultFuncLabel.Text += "x + ";

            if (parametrDChecked)
            {
                string toAdd = ParametrDTextBox.Text;
                if (ParametrDTextBox.TextLength > 4)
                    toAdd = ParametrDTextBox.Text.Substring(0, 4) + "...";
                ResultFuncLabel.Text += toAdd;
            }
            else
                ResultFuncLabel.Text += "d";

            ResultFuncLabel.Text += ")";
        }
        private void TableOfFunctionValuesRedraw()
        {
            while (TableOfFunctionValues.RowCount != 0)
                TableOfFunctionValues.Rows.RemoveAt(0);
            while (TableOfFunctionValues.ColumnCount != 0)
                TableOfFunctionValues.Columns.RemoveAt(0);

            TableOfFunctionValues.Visible = true;
            for (int i = 0; i < xValues.Length + 1; ++i)
                TableOfFunctionValues.Columns.Add("", "");
            string[] xStr = new string[xValues.Length + 1];
            xStr[0] = "x";
            string[] yStr = new string[xValues.Length + 1];
            yStr[0] = "y";
            for (int i = 0; i < xValues.Length; ++i)
            {
                xStr[i + 1] = xValues[i].ToString("F3");
                yStr[i + 1] = yValues[i].ToString("F3");
            }
            TableOfFunctionValues.Rows.Add(xStr);
            TableOfFunctionValues.Rows.Add(yStr);
        }
        private void FunctionGraphRedraw()
        {
            FunctionGraph.Series["FunctionGraph"].Points.Clear();
            FunctionGraph.Visible = true;
            for (int i = 0; i < xValues.Length; ++i)
                FunctionGraph.Series["FunctionGraph"].Points.AddXY(xValues[i], yValues[i]);
        }
    }
}