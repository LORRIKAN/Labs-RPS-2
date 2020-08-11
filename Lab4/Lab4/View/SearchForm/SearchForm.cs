using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4.View.SearchForm
{
    public partial class SearchForm : Form
    {
        readonly string placeHolder = "Введите запрос и нажмите Enter";

        public DataTable DataForAutoComplete { get; set; }

        public new event Action<string, string> FormClosed;

        public SearchForm(DataTable dataForAutoComplete)
        {
            InitializeComponent();
            DataForAutoComplete = dataForAutoComplete;
            SearchByComboBox.SelectedIndex = 0;
        }

        void SearchTextBox_Enter(object sender, EventArgs e)
        {
            SearchTextBoxPlaceHolderHide();
        }

        void SearchTextBox_Leave(object sender, EventArgs e)
        {
            SearchTextBoxPlaceHolderShow();
        }

        void SearchTextBoxPlaceHolderShow()
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = placeHolder;
                SearchTextBox.ForeColor = Color.Gray;
            }
        }

        void SearchTextBoxPlaceHolderHide()
        {
            if (SearchTextBox.Text == placeHolder)
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;
            }
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close(SearchByComboBox.SelectedItem as string, SearchTextBox.Text);
            }
        }

        private void Close(string searchColumn, string searchValue)
        {
            this.Close();
            this.FormClosed(searchColumn, searchValue);
        }
    }
}