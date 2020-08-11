using System;
using System.IO;

namespace Lab1
{
    static class ResultOutput
    {
        enum SaveFileMenu
        {
            saveOnlyArr = 1,
            saveOnlyResult,
            saveArrAndResult,
            saveNothing
        }
        static string NL = Environment.NewLine;
        static void SaveArr(int[] arr)
        {
            using (StreamWriter streamWriter = new StreamWriter(Gets.GetFilePathForWrite()))
            {
                streamWriter.WriteLine(arr.Length.ToString());
                for (int i = 0; i < arr.Length; ++i)
                    streamWriter.WriteLine(arr[i].ToString());
            }
            ColorPrint.PrintWithColor(ConsoleColor.Green, "Успешно сохранено!" + NL + NL);
        }
        static void SaveResult(double result)
        {
            using (StreamWriter streamWriter = new StreamWriter(Gets.GetFilePathForWrite()))
            {
                streamWriter.Write("Среднее арифметическое: " + result.ToString("F3"));
            }
            ColorPrint.PrintWithColor(ConsoleColor.Green, "Успешно сохранено!" + NL + NL);
        }
        static void SaveArrAndResult(int[] arr, double result)
        {
            using (StreamWriter streamWriter = new StreamWriter(Gets.GetFilePathForWrite()))
            {
                streamWriter.WriteLine(arr.Length.ToString());
                for (int i = 0; i < arr.Length; ++i)
                    streamWriter.WriteLine(arr[i].ToString());
                streamWriter.Write("Среднее арифметическое: " + result.ToString("F3"));
            }
            ColorPrint.PrintWithColor(ConsoleColor.Green, "Успешно сохранено!" + NL + NL);
        }
        static void OutputInFile(int[] arr, double result)
        {
            Console.Write("Сохранение в файл:" + NL +
                "1.Сохранить исходный массив" + NL +
                "2.Сохранить среднее арифметическое" + NL +
                "3.Сохранить исходный массив и среднее арифметическое" + NL +
                "4.Ничего не сохранять" + NL +
                "Ввод: ");
            SaveFileMenu menuChoice = Gets.GetMenuItem<SaveFileMenu>();
            switch (menuChoice)
            {
                case SaveFileMenu.saveOnlyArr:
                    SaveArr(arr);
                    break;
                case SaveFileMenu.saveOnlyResult:
                    SaveResult(result);
                    break;
                case SaveFileMenu.saveArrAndResult:
                    SaveArrAndResult(arr, result);
                    break;
                case SaveFileMenu.saveNothing:
                    Console.WriteLine();
                    break;
            }
        }
        public static void OutputResult(int[] arr, double result)
        {
            ColorPrint.PrintWithColor(ConsoleColor.Green, "Среднее арифметическое: ");
            ColorPrint.PrintWithColor(ConsoleColor.Magenta, result.ToString("F3") + NL + NL);
            OutputInFile(arr, result);
        }
    }
}