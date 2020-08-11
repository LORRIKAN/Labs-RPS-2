using Lab4.Model;
using System.Data;

namespace Lab4.Repository
{
    public interface IRepository<T> where T : IModel, new()
    {

        DataTable GetAllRecords();

        void UpdateDB(DataTable toUpdate);

        DataSet ConnectTwoTables<ParentModel, ChildModel>(DataTable parentTable, DataTable childTable)
            where ParentModel : IModel, new() where ChildModel : IModel, new();
    }
}