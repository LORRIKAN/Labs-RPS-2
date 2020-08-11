namespace Lab4.Model
{
    public class Debtor : IModel
    {
        public string PrimaryKey { get => "Id"; }

        public string TableName { get => "Debtors"; }

        public string RelationKey { get => "Id"; }
    }
}