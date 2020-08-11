using Lab4.Model;
using Lab4.Repository;
using Lab4.View;
using System;

namespace Lab4.Presenter
{
    class Presenter : IPresenter
    {
        readonly IRepository<Debtor> debtorRepository;
        readonly IRepository<Debt> debtRepository;
        readonly IView view;
        readonly IFileExportService fileExportService;

        public void RunApplication() => view.Show();

        public Presenter(IRepository<Debtor> debtorRepository, IRepository<Debt> debtRepository,
            IView view, IFileExportService fileExportService)
        {
            this.debtorRepository = debtorRepository;
            this.debtRepository = debtRepository;

            this.view = view;
            this.fileExportService = fileExportService;

            this.view.FormLoad += PopulateTable;

            this.view.RefreshBut_Click += PopulateTable;
            this.view.SaveBut_Click += SaveToDB;

            this.view.ExportAllDebtorsAndDebtsBut_Click += ExportAllDebtorsAndDebts;
            this.view.ExportCertainDebtorBut_Click += ExportCertainDebtors;
        }

        private void ExportCertainDebtors(object sender, EventArgs e)
        {
            fileExportService.Table = view.Table;
            fileExportService.FilePath = view.ExportPath;
            fileExportService.SaveDebtorDebts();
            view.MessageService.ShowMessage("Успешно сохранено!");
        }

        private void ExportAllDebtorsAndDebts(object sender, EventArgs e)
        {
            fileExportService.Table = view.Table;
            fileExportService.FilePath = view.ExportPath;
            fileExportService.SaveAllDebtorsAndDebts();
            view.MessageService.ShowMessage("Успешно сохранено!");
        }

        private void SaveToDB(object sender, EventArgs e)
        {
            debtorRepository.UpdateDB(view.TableDataSet.Tables[0]);
            debtRepository.UpdateDB(view.TableDataSet.Tables[1]);
            view.MessageService.ShowMessage("Успешно сохранено!");
        }

        void PopulateTable(object sender, EventArgs e)
        {
            var debtors = debtorRepository.GetAllRecords();
            var debts = debtRepository.GetAllRecords();
            view.TableDataSet = debtorRepository.ConnectTwoTables<Debtor, Debt>(debtors, debts);
        }
    }
}