using System;

namespace Lab2
{
    class MenuItems
    {
        public enum WayToInputStrOrExit
        {
            manualInput = 1,
            fileInput,
            exitProgram
        }
        public enum EncodeOrDecodeMenu
        {
            encode = 1,
            decode,
        }
        public enum ROT13AES128Menu
        {
            ROT13 = 1,
            AES128,
            back
        }
        public enum WhatToSaveInFile
        {
            originalStr = 1,
            changedStr,
            originalAndChangedStr,
            saveNothing
        }
    }
    class Menu
    {
        string NL = Environment.NewLine;
        public MenuItems.WayToInputStrOrExit WayToInputStrChoice { get; private set; }
        public MenuItems.EncodeOrDecodeMenu EncodeOrDecodeChoice { get; private set; }
        public MenuItems.ROT13AES128Menu ROT13AES128Choice { get; private set; }
        public MenuItems.WhatToSaveInFile WhatToSaveInFileChoice { get; private set; }
        public void SetWayToInputStrOrExit()
        {
            Console.Write("Выберите способ ввода строки:" + NL +
                "1.Ручной ввод" + NL +
                "2.Ввод из файла" + NL +
                "3.Выйти из программы" + NL +
                "Ввод: ");
            WayToInputStrChoice = Gets.GetMenuItem<MenuItems.WayToInputStrOrExit>();
            Console.WriteLine();
        }
        public void SetEncodeOrDecode()
        {
            Console.Write("Выберите действие:" + NL +
                "1.Кодировать строку" + NL +
                "2.Декодировать строку" + NL +
                "Ввод: ");
            EncodeOrDecodeChoice = Gets.GetMenuItem<MenuItems.EncodeOrDecodeMenu>();
            Console.WriteLine();
        }
        public void SetEncodeDecodeMethod()
        {
            while (true)
            {
                Console.Write("Выберите метод:" + NL +
                    "1.ROT13 (ВНИМАНИЕ! Данный метод шифрования предназначен только для букв английского алфавита. " +
                    "Любые другие символы будут проигнорированы." + NL +
                    "2.AES-128" + NL +
                    "3.Назад" + NL +
                    "Ввод: ");
                ROT13AES128Choice = Gets.GetMenuItem<MenuItems.ROT13AES128Menu>();
                Console.WriteLine();
                if (ROT13AES128Choice == MenuItems.ROT13AES128Menu.back)
                    SetEncodeOrDecode();
                else
                    break;
            }
        }
        public void SetWhatToSaveInFile()
        {
            Console.Write("Что сохранить в файл:" + NL +
                "1.Исходную строку" + NL +
                "2.Преобразованную строку" + NL +
                "3.Исходную и преобразованную строки" + NL +
                "4.Ничего не сохранять" + NL +
                "Ввод: ");
            WhatToSaveInFileChoice = Gets.GetMenuItem<MenuItems.WhatToSaveInFile>();
            Console.WriteLine();
        }
        public Menu()
        {
            SetWayToInputStrOrExit();
        }
    }
}