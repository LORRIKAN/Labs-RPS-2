// Program.cs
// Лабораторная работа №2.
// Студент группы 485, Зобнин Илья Михайлович. 2020 год
// Варианты 5 и 1
using System;

namespace Lab2
{
    public static class Program
    {
        static string NL = Environment.NewLine;
        static void Main()
        {
            Console.WriteLine("Здравствуйте. Эта программа кодирует или декодирует введённую строку " +
                "по выбранному методу." + NL +
                "На выбор предоставляются ROT13 (только символы английского алфавита) или AES-128." + NL +
                "Программа студента 485 группы Зобнина Ильи." + NL);
            string inputStr;
            string resultStr;
            while (true)
            {
                Menu menu = new Menu();
                if (menu.WayToInputStrChoice == MenuItems.WayToInputStrOrExit.exitProgram)
                    break;
                inputStr = StrInput.GetStr(menu.WayToInputStrChoice);
                menu.SetEncodeDecodeMethod();
                menu.SetEncodeOrDecode();
                ICipher codeMethod = Gets.GetCipher(menu.ROT13AES128Choice);
                if (menu.EncodeOrDecodeChoice == MenuItems.EncodeOrDecodeMenu.encode)
                {
                    resultStr = codeMethod.Encode(inputStr);
                    ResultOutput.OutputResult(inputStr, resultStr, "Изначальная строка: ", "Закодированная строка: ", menu);
                }
                else
                {
                    resultStr = codeMethod.Decode(inputStr);
                    ResultOutput.OutputResult(inputStr, resultStr, "Закодированная строка: ", "Декодированная строка: ", menu);
                }
            }
        }
    }
}