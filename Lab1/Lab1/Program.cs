// Program.cs
// Лабораторная работа №1.
// Студент группы 485, Зобнин Илья Михайлович. 2020 год
// Вариант 5
using System;
using System.Linq;

namespace Lab1
{
    public static class Program
    {
        public enum MainMenuItems
        {
            manualFilling = 1,
            fileFilling,
            randomFilling,
            exitProgram
        }
        static string NL = Environment.NewLine;
        static MainMenuItems Menu()
        {
            Console.Write("Выберите способ ввода массива:" + NL +
                    "1.Ввести значения в консоль вручную" + NL +
                    "2.Ввести значения из файла" + NL +
                    "3.Заполнить массив случайными значениями" + NL +
                    "4.Выход из программы" + NL +
                    "Ввод: ");
            return Gets.GetMenuItem<MainMenuItems>();
        }
        public static double DoTask(int[] arr)
        {
            int[] arrCopy = new int[arr.Length];
            Array.Copy(arr, arrCopy, arr.Length);
            try
            {
                for (int i = 0; i < arrCopy.Length; ++i)
                    if (arrCopy[i] < 0)
                        arrCopy[i] *= -1;
                return arrCopy.Average();
            }
            catch
            {
                ColorPrint.ErrorPrint("Вам как-то удалось дойти до этой части программы" +
                    "и сломать её. ", "Поздравляю, вы профессиональный хакер!");
                return double.NaN;
            }
        }
        static void Main()
        {
            Console.WriteLine("Здравствуйте. Эта программа вычисляет среднее арифметическое значение всех " +
                "элементов целочисленного массива." + NL +
                "Для отрицательных элементов будут использоваться их абсолютные значения." + NL +
                "Программа студента 485 группы Зобнина Ильи." + NL);
            MainMenuItems menuChoice;
            int[] arr;
            double result;
            while (true)
            {
                menuChoice = Menu();
                if (menuChoice == MainMenuItems.exitProgram)
                    break;
                arr = ArrayFilling.GetArray(menuChoice);
                result = DoTask(arr);
                ResultOutput.OutputResult(arr, result);
            }
        }
    }
}