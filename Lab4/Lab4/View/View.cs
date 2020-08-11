using Lab4.View.FillingForms;
using Lab4.View.MessageService;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace Lab4.View
{
    public partial class View : Form, IView
    {
        public IMessageService MessageService { get; }

        public NestedTable.NestedTable Table { get; private set; }

        public DataSet TableDataSet
        {
            get => Table.ParentDataSource.DataSet;
            set
            {
                Table.ParentDataSource = value.Tables[0];
                Table.ChildDataSource = value.Tables[1];

                Table.ChildDataGridView.Columns[0].Visible = false;

                Table.SetHeaderText();
            }
        }

        public string ExportPath { get; private set; }

        IFillForm fillForm;

        public View(IMessageService messageService)
        {

            InitializeComponent();

            this.Text = this.ProgramName;

            this.MessageService = messageService;

            SetEventHandlers();
        }

        #region Events
        public event EventHandler FormLoad;

        public event EventHandler RefreshBut_Click;
        public event EventHandler SaveBut_Click;

        public event EventHandler ExportCertainDebtorBut_Click;
        public event EventHandler ExportAllDebtorsAndDebtsBut_Click;
        #endregion

        private void SetEventHandlers()
        {
            this.Load += (sender, e) => FormLoad?.Invoke(sender, e);

            refreshBut.Click += (sender, e) => RefreshBut_Click?.Invoke(sender, e);
            addBut.Click += AddDebtorOrDebt;
            searchBut.Click += MakeSearch;
            noSearchBut.Click += CancelSearch;
            editBut.Click += EditDebtorOrDebt;
            deleteBut.Click += DeleteRows;
            saveBut.Click += (sender, e) => SaveBut_Click?.Invoke(sender, e);

            exportCertainDebtorBut.Click += (sender, e) => CommitSave(ExportCertainDebtorBut_Click, sender, e);
            exportAllDebtorsAndDebtsBut.Click += (sender, e) => CommitSave(ExportAllDebtorsAndDebtsBut_Click, sender, e);
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public string ProgramName
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
    }
}