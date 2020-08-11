using Lab4.Model;
using Lab4.Repository;
using Lab4.View.DataTableExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace Tests
{
    [TestClass]
    public class DBTest
    {
        bool TablesCompare(DataTable table1, DataTable table2)
        {
            for (int i = 0; i < table1.Rows.Count; ++i)
                for (int j = 0; j < table1.Rows[i].ItemArray.Length; ++j)
                    if (!table1.Rows[i].ItemArray[j].Equals(table2.Rows[i].ItemArray[j]))
                        return false;
            return true;
        }

        [TestMethod]
        public void InsertUpdateDelete()
        {
            IRepository<Debtor> repository = new Repository<Debtor>(new Debtor());
            var table = repository.GetAllRecords();
            var generatedIds = new List<int>();

            var idGenerator = new Random();

            var rowToInsert = new Dictionary<string, string>
            {
                { "Category", "Физическое лицо" },
                { "Name", "Иван" },
                { "INN", "1234567891" },
                { "Adress", "ул. Крышкина, дом 15" },
                { "Phone", "89567854321" }
            };

            var rowToUpdate = new Dictionary<string, string>
            {
                { "Category", "Физическое лицо1" },
                { "Name", "Иван1" },
                { "INN", "1234567892" },
                { "Adress", "ул. Крышкина, дом 151" },
                { "Phone", "89567854322" }
            };

            Func<int> funcIdGenerator = () => { 
                int randId = idGenerator.Next(1, 10000); 
                while (generatedIds.Contains(randId))
                    randId = idGenerator.Next(1, 10000); 
                generatedIds.Add(randId); return randId; };

            for (int i = 0; i < 330; ++i)
            {
                int randId = funcIdGenerator();
                var row = table.Rows[randId];
                foreach (var element in rowToUpdate)
                    row[element.Key] = element.Value;

                randId = funcIdGenerator();
                table.Rows[randId].Delete();

                table.AddRow(rowToInsert);
            }

            var changedOnly = table.GetChanges();

            repository.UpdateDB(changedOnly);
        }

        [TestMethod]
        public void DebtorsTest()
        {
            IRepository<Debtor> repository = new Repository<Debtor>(new Debtor());
            var table = repository.GetAllRecords();
            var rowToInsert = new Dictionary<string, string>
            {
                { "Category", "Физическое лицо" },
                { "Name", "Иван" },
                { "INN", "1234567891" },
                { "Adress", "ул. Крышкина, дом 15" },
                { "Phone", "89567854321" }
            };
            for (int i = 0; i < 10000; ++i)
                table.AddRow(rowToInsert);

            repository.UpdateDB(table);
        }

        //[TestMethod]
        //public void DebtsTest()
        //{
        //    IRepository<Debt> repository = new Repository<Debt>(new Debt());
        //    var table = repository.GetAllRecords();
        //    var rowToInsert = new Dictionary<string, string>
        //    {
        //        { "DebtorId", "1" },
        //        { "Sum", "22522" },
        //        { "TakenDate", "15/01/2000" },
        //        { "LimitDate", "15/02/2000" },
        //        { "Status", "Оплачен" }
        //    };
        //    table.AddRow(rowToInsert);

        //    var updatedTable = repository.UpdateDB(table);

        //    Assert.IsTrue(TablesCompare(table, updatedTable));
        //    Assert.IsTrue(TablesCompare(updatedTable, table));


        //Assert.IsTrue(TablesCompare(table, updatedTable));
        //Assert.IsTrue(TablesCompare(updatedTable, table));
        //}
    }
}