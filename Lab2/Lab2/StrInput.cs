using System;
using System.IO;

namespace Lab2
{
    static class StrInput
    {
        static string NL = Environment.NewLine;
        static string ManualInput()
        {
            Console.Write("Введите строку: ");
            string inputStr;
            while (true)
            {
                inputStr = Console.ReadLine();
                if (inputStr.Length != 0)
                {
                    Console.WriteLine();
                    return inputStr;
                }
                else
                    ColorPrint.ErrorPrint("Вы не ввели строку! ", "Введите строку ещё раз: ");
            }
        }
        static string FileInput()
        {
            while (true)
            {
                using (StreamReader streamReader = new StreamReader(Gets.GetFilePathForRead()))
                {
                    string inputStr = streamReader.ReadToEnd();
                    if (inputStr.Length != 0)
                    {
                        ColorPrint.PrintWithColor(ConsoleColor.Green, "Строка введена: ");
                        Console.WriteLine(inputStr + NL);
                        return inputStr;
                    }
                    else
                        ColorPrint.PrintWithColor(ConsoleColor.Red, "Файл пуст или строку считать не удалось!" + NL);
                }
            }
        }
        public static string GetStr(MenuItems.WayToInputStrOrExit wayToInputStrChoice)
        {
            switch (wayToInputStrChoice)
            {
                case MenuItems.WayToInputStrOrExit.manualInput:
                    return ManualInput();
                case MenuItems.WayToInputStrOrExit.fileInput:
                    return FileInput();
                default:
                    return null;
            }
        }
    }
}