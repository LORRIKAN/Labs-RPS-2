using Lab4.View.DataTableExtension;
using Lab4.View.FillingForms;
using Lab4.View.TranslateToHeaderText;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Lab4.View
{
    partial class View
    {

        private void CommitSave(EventHandler eventHandler, object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.ExportPath = saveFileDialog.FileName;
                eventHandler?.Invoke(sender, e);
            }
        }

        private void CancelSearch(object sender, EventArgs e)
        {
            Table.Reset();
        }

        private void MakeSearch(object sender, EventArgs e)
        {
            var searchForm = new SearchForm.SearchForm(Table.ParentDataSource);
            searchForm.FormClosed += Search;
            searchForm.Show();
        }

        private void Search(string searchColumn, string searchValue)
        {
            var translatedSearchColumn = searchColumn.ColumnName();
            Table.FilterBy(translatedSearchColumn, searchValue);
        }

        private void DeleteRows(object sender, EventArgs e)
        {
            if (MessageService.ShowOkCancel("Вы уверены, что хотите удалить выбранную(ые) запись(и)?") == DialogResult.OK)
            {
                if (Table.ChildDataGridView.Visible)
                    for (int i = 0; i < Table.ChildDataGridView.SelectedRows.Count; ++i)
                    {
                        var rowToDelete = Table.ChildDataGridView.SelectedRows[i];
                        var id = rowToDelete.Cells[0].Value;
                        Table.ChildDataSource.Rows.Find(id).Delete();
                    }
                else
                {
                    for (int i = 0; i < Table.SelectedRows.Count; ++i)
                    {
                        var rowToDelete = Table.SelectedRows[i];
                        var id = rowToDelete.Cells[1].Value;
                        Table.ParentDataSource.Rows.Find(id).Delete();
                    }
                }
            }
            MessageService.ShowMessage("Запись(и) успешно удалена(ы)");
        }

        private void AddDebtorOrDebt(object sender, EventArgs e)
        {
            if (Table.ChildDataGridView.Visible)
            {
                fillForm = new FillDebtForm();
                fillForm.FormClosed += (record) => AddNewDebt(record, Table.ChildDataSource);
                debtorId = Table.SelectedRows[0].Cells[1].Value;
            }
            else
            {
                fillForm = new FillDebtorForm();
                fillForm.FormClosed += (record) => AddNewDebtor(record, Table.ParentDataSource);
            }
            fillForm.Show();
        }

        private object debtorId;

        private void AddNewDebt(List<Control> recordToInsert, DataTable dataTable)
        {
            var record = new Dictionary<string, string>
            {
                { "DebtorId", debtorId.ToString() }
            };
            foreach (var element in recordToInsert)
                record.Add(element.Name, element.Text);
            dataTable.AddRow(record);
            MessageService.ShowMessage("Запись успешно добавлена!");
        }

        private void AddNewDebtor(List<Control> recordToInsert, DataTable dataTable)
        {
            var record = new Dictionary<string, string>();
            foreach (var element in recordToInsert)
                record.Add(element.Name, element.Text);
            dataTable.AddRow(record);
            MessageService.ShowMessage("Запись успешно добавлена!");
        }

        private object editingId;

        private void EditDebtorOrDebt(object sender, EventArgs e)
        {
            if (Table.ChildDataGridView.Visible)
            {
                if (Table.ChildDataGridView.SelectedRows.Count > 1)
                {
                    MessageService.ShowError("Нельзя редактировать более одной строки! Выберите одну!");
                    return;
                }
                fillForm = new FillDebtForm();
                var selectedId = Table.ChildDataGridView.SelectedRows[0].Cells[0].Value;
                editingId = selectedId;
                fillForm.Show(Table.ChildDataSource.Rows.Find(selectedId));
                fillForm.FormClosed += (record) => EditRecord(record, Table.ChildDataSource);
            }
            else
            {
                if (Table.SelectedRows.Count > 1)
                {
                    MessageService.ShowError("Нельзя редактировать более одной строки! Выберите одну!");
                    return;
                }
                fillForm = new FillDebtorForm();
                var selectedId = Table.SelectedRows[0].Cells[1].Value;
                editingId = selectedId;
                fillForm.Show(Table.ParentDataSource.Rows.Find(selectedId));
                fillForm.FormClosed += (record) => EditRecord(record, Table.ParentDataSource);
            }
        }

        private void EditRecord(List<Control> recordToInsert, DataTable dataTable)
        {
            for (int i = 0; i < recordToInsert.Count; ++i)
            {
                var editingRow = dataTable.Rows.Find(editingId);
                editingRow[recordToInsert[i].Name] = recordToInsert[i].Text;
            }
            MessageService.ShowMessage("Запись успешно изменена!");
        }
    }
}