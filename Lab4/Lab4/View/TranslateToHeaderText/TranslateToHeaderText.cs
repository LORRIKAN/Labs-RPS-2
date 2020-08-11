using System.Collections.Generic;
using System.Linq;

namespace Lab4.View.TranslateToHeaderText
{
    public static class TranslateToHeaderText
    {
        static readonly Dictionary<string, string> headerTextDict = new Dictionary<string, string>
            {
                //debtors
                { "Id", "№" },
                { "Category", "Категория" },
                { "Name", "Наименование" },
                { "INN", "ИНН" },
                { "OGRN", "ОГРН" },
                { "Adress", "Адрес" },
                { "Phone", "Телефон" },
                { "Email", "Электронная почта" },
                //debts
                { "DebtId", "№ долга" },
                { "DebtorId", "№ должника" },
                { "Sum", "Сумма" },
                { "TakenDate", "Дата взятия" },
                { "LimitDate", "Должен оплатить до" },
                { "Status", "Статус" },
                { "PaidDate", "Дата оплаты" }
            };

        public static string HeaderText(this string toTranslate)
        {
            return headerTextDict[toTranslate];
        }

        public static string ColumnName(this string toTranslate)
        {
            return headerTextDict.Where(pair => pair.Value == toTranslate)
                    .Select(pair => pair.Key)
                    .FirstOrDefault();
        }
    }
}