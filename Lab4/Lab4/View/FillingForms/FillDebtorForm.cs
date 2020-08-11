using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4.View.FillingForms
{

    public partial class FillDebtorForm : Form, IFillForm
    {

        public new event Action<List<Control>> FormClosed;

        readonly Dictionary<TextBoxBase, Regex> regexDict = new Dictionary<TextBoxBase, Regex>();

        readonly Dictionary<TextBoxBase, Label> warningLabels = new Dictionary<TextBoxBase, Label>();

        void InitializeDicts()
        {
            regexDict.Add(DebtorName, new Regex(@"(^.{3,}$)"));
            regexDict.Add(Adress, new Regex(@"(^.{5,}$)"));
            regexDict.Add(Email, new Regex(@"^([\w\-]+\.)*[\w\-]+@([\w\-]+\.)+([\w\-]{2,3})|(^$)"));

            warningLabels.Add(DebtorName, NameErrorLbl);
            warningLabels.Add(INN, INNErrorLbl);
            warningLabels.Add(OGRN, OGRNErrorLbl);
            warningLabels.Add(Phone, PhoneErrorLbl);
            warningLabels.Add(Adress, AdressErrorLbl);
            warningLabels.Add(Email, EmailErrorLbl);
        }

        public FillDebtorForm()
        {
            InitializeComponent();
            InitializeDicts();
            this.DebtorName.Name = "Name";
        }

        public new void Show()
        {
            Category.SelectedIndex = 0;
            InitializeShow("Добавить запись о должнике");
        }

        public void Show(DataRow dataSource)
        {
            foreach (Control control in Controls)
                try
                {
                    control.Text = dataSource[control.Name].ToString();
                }
                catch { }
            InitializeShow("Редактировать запись о должнике");
        }

        private void InitializeShow(string formTitle)
        {
            this.Text = formTitle;
            foreach (Control control in this.Controls)
            {
                if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Enter += MoveCaretToStart;
                    maskedTextBox.KeyDown += EnterPressed;
                }
                if (control is TextBox textBox)
                {
                    textBox.KeyDown += EnterPressed;
                }
                if (control is ComboBox comboBox)
                {
                    comboBox.KeyDown += EnterPressed;
                }
            }
            base.Show();
            DebtorName.Focus();
        }

        private void EnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                okBut.PerformClick();
        }

        private void MoveCaretToStart(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox textBox)
            {
                MaskFormat oldFormat = textBox.TextMaskFormat;
                textBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                string fullText = textBox.Text;
                textBox.TextMaskFormat = oldFormat;

                int index = fullText.IndexOf(textBox.PromptChar);
                if (index > -1)
                {
                    BeginInvoke(new Action(() => textBox.Select(index, 0)));
                }
            }
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            bool noErrors = true;
            var resultTextBoxes = new List<Control>();
            var category = new Control { Name = "Category", Text = Category.SelectedItem.ToString() };
            resultTextBoxes.Add(category);

            foreach (Control control in this.Controls)
            {
                if (control is MaskedTextBox maskedTextBox)
                {
                    if (maskedTextBox.MaskCompleted)
                    {
                        resultTextBoxes.Add(maskedTextBox);
                        warningLabels[maskedTextBox].Visible = false;
                    }
                    else
                    {
                        if (maskedTextBox.Equals(OGRN) && maskedTextBox.Text == " -  -  -  -     -")
                        {
                            resultTextBoxes.Add(new Control { Name = "OGRN", Text = "" });
                            warningLabels[maskedTextBox].Visible = false;
                            continue;
                        }
                        warningLabels[maskedTextBox].Visible = true;
                        noErrors = false;
                    }
                }
                if (control is TextBox textBox)
                {
                    if (regexDict[textBox].IsMatch(textBox.Text))
                    {
                        resultTextBoxes.Add(new Control { Name = textBox.Name, Text = textBox.Text });
                        warningLabels[textBox].Visible = false;
                    }
                    else
                    {
                        warningLabels[textBox].Visible = true;
                        noErrors = false;
                    }
                }
            }

            if (noErrors)
                this.Close(resultTextBoxes);
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close(List<Control> resultTextBoxes)
        {
            this.Close();
            this.FormClosed(resultTextBoxes);
        }
    }
}