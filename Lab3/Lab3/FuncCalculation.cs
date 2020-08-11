using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Interface : Form
    {
        int xAndYValuesNum = 0;
        private void FuncCalc()
        {
            xValues = new double[xAndYValuesNum];
            yValues = new double[xAndYValuesNum];
            int i = 0;
            for (double x = leftBoardX; x <= rightBoardX; x += stepX, ++i)
            {
                xValues[i] = x;
                yValues[i] = a + b * Math.Sin(c * x + d);
            }
        }
    }
}