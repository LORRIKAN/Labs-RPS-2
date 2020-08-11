namespace Lab4.Presenter
{
    public interface IFileExportService
    {
        string FilePath { get; set; }
        View.NestedTable.NestedTable Table { get; set; }

        void SaveAllDebtorsAndDebts();
        void SaveDebtorDebts();
    }
}