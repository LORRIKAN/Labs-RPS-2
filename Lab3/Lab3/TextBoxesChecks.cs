using System.Windows.Forms;

namespace Lab3
{
    public partial class Interface : Form
    {
        const double lowerLimit = -10000000000000000000.0;
        const double upperLimit = 10000000000000000000.0;
        const int xAndYValuesNumLimit = 200;
        private void TextBoxFormatCheckAndRedraw(TextBox ParamTextBox, out bool paramCheck, Label ParamWarningLabel,
            PictureBox ParamWarningPic, out double value)
        {
            paramCheck = double.TryParse(ParamTextBox.Text, out value);
            if (!paramCheck)
            {
                if (ParamTextBox.TextLength != 0)
                    ShowOrHideWarnings(ParamWarningLabel, ParamWarningPic, true);
                else
                    ShowOrHideWarnings(ParamWarningLabel, ParamWarningPic, false);
                ExcelExportBtn.Enabled = false;
            }
            else
            {
                if (value <= lowerLimit || value >= upperLimit)
                {
                    ShowOrHideWarnings(ParamWarningLabel, ParamWarningPic, true,
                        "Значение слишком большое или маленькое!");
                    paramCheck = false;
                    ExcelExportBtn.Enabled = false;
                }
                else
                {
                    ShowOrHideWarnings(ParamWarningLabel, ParamWarningPic, false);
                    ExcelExportBtn.Enabled = false;
                }
            }
        }
        private void ParamsAndXCheckAndRedraw(TextBox ParamTextBox, out bool paramCheck,
            Label ParamWarningLabel, PictureBox ParamWarningPic, out double value, string paramOrXCheck)
        {
            TextBoxFormatCheckAndRedraw(ParamTextBox, out paramCheck, ParamWarningLabel, ParamWarningPic, out value);
            if (paramOrXCheck == "Param")
            {
                ResultFuncLabelRedraw();
                TableAndGraphRedraw();
            }
            else
                BoardsAndStepXCheck();
        }
        private void BoardsAndStepXCheck()
        {
            if (!leftBoardXChecked || !stepXChecked || !rightBoardXChecked)
                return;

            if (leftBoardX >= rightBoardX)
            {
                ShowOrHideWarnings(WrongBoardsOrStepWarningLabel, WrongBoardsOrStepWarningPicture, true,
                    "Левая граница не может быть больше или равна правой!");
                return;
            }

            if (stepX <= 0)
            {
                ShowOrHideWarnings(WrongBoardsOrStepWarningLabel, WrongBoardsOrStepWarningPicture, true,
                    "Шаг не может быть меньше или равен нулю!");
                return;
            }

            if ((leftBoardX + stepX) > rightBoardX)
            {
                ShowOrHideWarnings(WrongBoardsOrStepWarningLabel, WrongBoardsOrStepWarningPicture, true,
                    "График не может состоять из одной точки!");
                return;
            }
            //подсчёт количества точек x
            xAndYValuesNum = 0;
            for (double x = leftBoardX; x <= rightBoardX; x += stepX, ++xAndYValuesNum) { }

            if (xAndYValuesNum > xAndYValuesNumLimit)
            {
                ShowOrHideWarnings(WrongBoardsOrStepWarningLabel, WrongBoardsOrStepWarningPicture, true,
                    "Слишком много точек x! Лимит 200.");
                return;
            }
            ShowOrHideWarnings(WrongBoardsOrStepWarningLabel, WrongBoardsOrStepWarningPicture, false);
            TableAndGraphRedraw();
        }
    }
}