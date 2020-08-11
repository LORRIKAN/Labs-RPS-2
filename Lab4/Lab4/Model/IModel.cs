namespace Lab4.Model
{
    public interface IModel
    {
        string PrimaryKey { get; }

        string TableName { get; }

        string RelationKey { get; }
    }
}