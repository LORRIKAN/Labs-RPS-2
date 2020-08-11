using System;
using System.IO;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Interface : Form
    {
        readonly static string NL = Environment.NewLine;
        readonly string AboutText = "Эта программа вычисляет значения функции синусоиды в точках x, " +
            $"заданных левой и правой границами, а также шагом и строит соответствующий график.{NL}" +
            "Программа студента 485 группы Зобнина Ильи.";
        public Interface()
        {
            InitializeComponent();
            // обработчики изменения текста
            LeftBoardXTextBox.TextChanged += delegate (object sender, EventArgs e)
            {
                ParamsAndXCheckAndRedraw((TextBox)sender, out leftBoardXChecked, LeftBoardXWarningLabel,
                    LeftBoardXWarningPicture, out leftBoardX, "X");
            };
            StepXTextBox.TextChanged += delegate (object sender, EventArgs e)
            {
                ParamsAndXCheckAndRedraw((TextBox)sender, out stepXChecked, StepXWarningLabel,
                    StepXWarningPicture, out stepX, "X");
            };
            RightBoardXTextBox.TextChanged += delegate (object sender, EventArgs e)
            {
                ParamsAndXCheckAndRedraw((TextBox)sender, out rightBoardXChecked, RightBoardXWarningLabel,
                    RightBoardXWarningPicture, out rightBoardX, "X");
            };

            ParametrATextBox.TextChanged += delegate (object sender, EventArgs e)
            {
                ParamsAndXCheckAndRedraw((TextBox)sender, out parametrAChecked, ParametrAWarningLabel, ParametrAWarningPicture,
                  out a, "Param");
            };
            ParametrBTextBox.TextChanged += delegate (object sender, EventArgs e)
            {
                ParamsAndXCheckAndRedraw((TextBox)sender, out parametrBChecked, ParametrBWarningLabel, ParametrBWarningPicture,
                  out b, "Param");
            };
            ParametrCTextBox.TextChanged += delegate (object sender, EventArgs e)
            {
                ParamsAndXCheckAndRedraw((TextBox)sender, out parametrCChecked, ParametrCWarningLabel, ParametrCWarningPicture,
                  out c, "Param");
            };
            ParametrDTextBox.TextChanged += delegate (object sender, EventArgs e)
            {
                ParamsAndXCheckAndRedraw((TextBox)sender, out parametrDChecked, ParametrDWarningLabel, ParametrDWarningPicture,
                  out d, "Param");
            };
            RestoreTextBoxes();
        }
        private void ShowOrHideWarnings(Label label, PictureBox picture, bool showOrHide,
            string labelMessage = "")
        {
            if (labelMessage != "")
                label.Text = labelMessage;
            label.Visible = showOrHide;
            picture.Visible = showOrHide;
        }
        private void RestoreTextBoxes()
        {
            using (var streamReader = new StreamReader("TextBoxesSave.txt"))
            {
                var controls = Controls;
                for (int i = 0; i < controls.Count; ++i)
                    if (controls[i].GetType().Name == "TextBox")
                        controls[i].Text = streamReader.ReadLine();
            }
        }
        private void SaveTextBoxesAfterClose(object sender, FormClosingEventArgs e)
        {
            using (var streamWriter = new StreamWriter("TextBoxesSave.txt"))
            {
                var controls = Controls;
                for (int i = 0; i < controls.Count; ++i)
                    if (controls[i].GetType().Name == "TextBox")
                        streamWriter.WriteLine(controls[i].Text);
            }
        }
        private void AboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AboutText);
        }
        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}