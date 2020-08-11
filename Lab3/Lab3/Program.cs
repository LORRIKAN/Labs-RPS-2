// Program.cs
// Лабораторная работа №3.
// Студент группы 485, Зобнин Илья Михайлович. 2020 год
// Вариант 5 с усложнённым заданием
using System;
using System.Windows.Forms;

namespace Lab3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface());
        }
    }
}
