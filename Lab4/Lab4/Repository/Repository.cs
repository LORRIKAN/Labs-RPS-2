using Lab4.Model;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Lab4.Repository
{
    public class Repository<T> : IRepository<T> where T : IModel, new()
    {
        T model;

        public Repository(T model)
        {
            this.model = model;
        }

        public DataTable GetAllRecords()
        {
            var table = new DataTable();

            string selectionStatement = "SELECT * FROM " + model.TableName;

            string connectionString = GetConnectionString();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var dataAdapter = new SQLiteDataAdapter(selectionStatement, connection);
                DataColumn col = table.Columns.Add(model.PrimaryKey, typeof(long));

                col.AllowDBNull = false;
                col.AutoIncrement = true;
                col.AutoIncrementSeed = 1;
                col.AutoIncrementStep = 1;

                table.PrimaryKey = new DataColumn[] { col };
                dataAdapter.Fill(table);
            }
            return table;
        }

        public void UpdateDB(DataTable toUpdate)
        {
            string connectionString = GetConnectionString();

            string selectionStatement = "SELECT * FROM " + model.TableName;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var dataAdapter = new SQLiteDataAdapter(selectionStatement, connection);
                var commandBuilderForDebtors = new SQLiteCommandBuilder(dataAdapter);
                dataAdapter.Update(toUpdate);

                toUpdate.AcceptChanges();
            }
        }

        public DataSet ConnectTwoTables<ParentModel, ChildModel>(DataTable parentTable, DataTable childTable)
            where ParentModel : IModel, new() where ChildModel : IModel, new()
        {
            ParentModel parentModel = new ParentModel();
            ChildModel childModel = new ChildModel();

            var dataSet = new DataSet();
            dataSet.Tables.AddRange(new[] { parentTable, childTable });
            dataSet.Relations.Add
                (parentTable.Columns[parentModel.RelationKey], childTable.Columns[childModel.RelationKey]);

            return dataSet;
        }

        private static string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}