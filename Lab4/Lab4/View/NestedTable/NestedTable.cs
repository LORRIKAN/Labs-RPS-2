using Lab4.NestedTable.Images;
using Lab4.View.TranslateToHeaderText;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab4.View.NestedTable
{
    public partial class NestedTable : DataGridView
    {

        private DataTable childDataSource;

        private DataTable parentDataSource;

        public DataTable ChildDataSource
        {
            get => childDataSource;
            set { childDataSource = value; ChildDataGridView.DataSource = value; HideAll(); }
        }

        public DataTable ParentDataSource
        {
            get => parentDataSource;
            set { parentDataSource = value; base.DataSource = value; HideAll(); }
        }

        public DataGridView ChildDataGridView { get; } = new DataGridView
        {
            Visible = false,
            AutoSize = true,
            RowHeadersVisible = false,
            ReadOnly = true,
            AllowUserToDeleteRows = false,
            AllowUserToAddRows = false,
            AllowUserToOrderColumns = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        };

        public NestedTable()
        {
            this.Controls.Add(ChildDataGridView);
            var hideExpandCol = new DataGridViewImageColumn(valuesAreIcons: false)
            {
                Image = NestedTableResources.expand,
                Name = "ExpandHide",
                HeaderText = ""
            };
            this.Columns.Add(hideExpandCol);
            this.CellClick += this_CellClick;
        }

        public void FilterBy(string columnName, string value)
        {
            var filter = new DataView(ParentDataSource)
            {
                RowFilter = columnName + " = '" + value + "'"
            };
            this.DataSource = filter;
        }

        public void SetHeaderText()
        {
            for (int i = 1; i < base.Columns.Count; ++i)
            {
                this.Columns[i].HeaderText = this.Columns[i].Name.HeaderText();
            }

            foreach (DataGridViewColumn column in ChildDataGridView.Columns)
            {
                column.HeaderText = column.Name.HeaderText();
            }
        }

        public void Reset()
        {
            base.DataSource = ParentDataSource;
        }

        void this_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var currentCell = this[e.ColumnIndex, e.RowIndex] as DataGridViewImageCell;

                if ((currentCell.Value as Bitmap).IsEqual(NestedTableResources.expand as Bitmap))
                {
                    HideAll();
                    var dataSet = (base.DataSource as DataTable).DataSet;
                    var parentRelationColumn = dataSet.Relations[0].ParentColumns.Single();
                    var childRelationColumn = dataSet.Relations[0].ChildColumns.Single();

                    int parentRelationIndex = dataSet.Tables[0].Columns.IndexOf(parentRelationColumn) + 1;

                    string idName = childRelationColumn.ColumnName;
                    string id = this[parentRelationIndex, e.RowIndex].Value.ToString();

                    Rectangle childRectangle = this.GetCellDisplayRectangle(1, e.RowIndex, true);
                    ChildDataGridView.Location = new Point(childRectangle.X, childRectangle.Y + 20);

                    DataView selectedByID = new DataView(ChildDataSource)
                    {
                        RowFilter = idName + " = '" + id + "'"
                    };
                    ChildDataGridView.DataSource = selectedByID;

                    ChildDataGridView.Visible = true;

                    currentCell.Value = NestedTableResources.hide;
                }
                else
                {
                    ChildDataGridView.Visible = false;
                    this[e.ColumnIndex, e.RowIndex].Value = NestedTableResources.expand;
                }
            }
            else
            {
                HideAll();
            }
        }

        void HideAll()
        {
            foreach (DataGridViewRow row in this.Rows)
                row.Cells["ExpandHide"].Value = NestedTableResources.expand;
            ChildDataGridView.Visible = false;
        }
    }
}