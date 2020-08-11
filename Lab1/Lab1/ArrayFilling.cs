using System;
using System.IO;

namespace Lab1
{
    static class ArrayFilling
    {
        static string NL = Environment.NewLine;
        static int GetArrSize(Program.MainMenuItems wayToFillArray)
        {
            const int minArrSize = 0;
            const int manualInputLim = 15;
            const string newValueAsk = "Введите размер массива ещё раз: ";
            Console.Write("Введите размер массива: ");
            int arrSize;
            while (true)
            {
                arrSize = Gets.GetInt(newValueAsk);
                if (arrSize <= minArrSize)
                {
                    ColorPrint.ErrorPrint("Размер массива должен быть больше нуля! ", newValueAsk);
                }
                else
                {
                    try
                    {
                        int[] memLimTest = new int[arrSize];
                    }
                    catch (OutOfMemoryException)
                    {
                        ColorPrint.ErrorPrint("Слишком большой размер массива! ", newValueAsk);
                        continue;
                    }
                    if (arrSize > manualInputLim && wayToFillArray == Program.MainMenuItems.manualFilling)
                    {
                        ColorPrint.ErrorPrint("Размер массива очень большой для ввода вручную. ",
                            "Вы точно хотите заполнять массив введённой длины вручную?" + NL +
                            "y - да, n - нет: ");
                        if (Gets.AskYesNo())
                            break;
                        else
                            Console.Write("Введите размер массива: ");
                    }
                    else
                        break;
                }
            }
            return arrSize;
        }
        static int[] ManualFilling()
        {
            int arrSize = GetArrSize(Program.MainMenuItems.manualFilling);
            int[] arr = new int[arrSize];
            for (int i = 0; i < arrSize; ++i)
            {
                Console.Write($"arr[{i + 1}] = ");
                arr[i] = Gets.GetInt($"arr[{i + 1}] = ");
            }
            ColorPrint.PrintWithColor(ConsoleColor.Green, "Все элементы введены успешно!" + NL + NL);
            return arr;
        }
        static int[] RandomFilling()
        {
            Random rand = new Random();
            const int minRand = -100;
            const int maxRand = 100;
            int arrSize = GetArrSize(Program.MainMenuItems.randomFilling);
            int[] arr = new int[arrSize];
            for (int i = 0; i < arrSize; ++i)
            {
                arr[i] = rand.Next(minRand, maxRand);
                Console.WriteLine($"arr[{i + 1}] = {arr[i]}");
            }
            ColorPrint.PrintWithColor(ConsoleColor.Green, "Генерация прошла успешно!" + NL + NL);
            return arr;
        }
        static int[] FileFilling()
        {
            int[] arr = null;
            bool valueReadSuccess;
            string path;
            int arrSize;
            do
            {
                path = Gets.GetFilePathForRead();
                using (StreamReader streamReader = new StreamReader(path))
                {
                    valueReadSuccess = Gets.MyParse(streamReader.ReadLine(), "Исправьте 1-ю строку с размером " +
                        "массива." + NL, out arrSize);
                    if (!valueReadSuccess)
                        continue;
                    arr = new int[arrSize];
                    for (int i = 0; i < arrSize; ++i)
                    {
                        valueReadSuccess = Gets.MyParse(streamReader.ReadLine(), $"Исправьте {i + 2} строку в " +
                            "файле." + NL, out arr[i]);
                        if (!valueReadSuccess)
                            break;
                    }
                }
            } while (!valueReadSuccess);
            ColorPrint.PrintWithColor(ConsoleColor.Green, "Массив успешно считан!" + NL);
            Console.WriteLine($"Размер массива: {arrSize}");
            for (int i = 0; i < arrSize; ++i)
                Console.WriteLine($"arr[{i + 1}] = {arr[i]}");
            return arr;
        }
        public static int[] GetArray(Program.MainMenuItems menuItem)
        {
            int[] array = null;
            switch (menuItem)
            {
                case Program.MainMenuItems.manualFilling:
                    array = ManualFilling();
                    break;
                case Program.MainMenuItems.fileFilling:
                    array = FileFilling();
                    break;
                case Program.MainMenuItems.randomFilling:
                    array = RandomFilling();
                    break;
            }
            return array;
        }
    }
}