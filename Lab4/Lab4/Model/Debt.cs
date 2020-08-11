namespace Lab4.Model
{
    public class Debt : IModel
    {
        public string PrimaryKey { get => "DebtId"; }

        public string TableName { get => "Debts"; }

        public string RelationKey { get => "DebtorId"; }
    }
}