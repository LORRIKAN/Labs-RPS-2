using System;
using System.IO;

namespace Lab2
{
    static class Gets
    {
        public static bool MyParse(string stringValue, string askMessage, out int value)
        {
            try
            {
                value = int.Parse(stringValue);
                return true;
            }
            catch (ArgumentNullException)
            {
                ColorPrint.ErrorPrint("Число не было введено! ", askMessage);

            }
            catch (FormatException)
            {
                ColorPrint.ErrorPrint("Неверный формат! ", askMessage);
            }
            catch (OverflowException)
            {
                ColorPrint.ErrorPrint("Слишком большое или маленькое число! ", askMessage);
            }
            value = 0;
            return false;
        }
        public static int GetInt(string askMessage)
        {
            int value;
            string stringValue;
            bool parseSuccess;
            do
            {
                stringValue = Console.ReadLine();
                parseSuccess = MyParse(stringValue, askMessage, out value);
            } while (!parseSuccess);
            return value;
        }
        public static EnumType GetMenuItem<EnumType>()
        {
            int value = GetInt("Введите пункт меню ещё раз: ");
            while (!Enum.IsDefined(typeof(EnumType), value))
            {
                ColorPrint.ErrorPrint("Такого пункта меню нет! ", "Введите пункт меню ещё раз: ");
                value = GetInt("Введите пункт меню ещё раз: ");
            }
            return (EnumType)Enum.ToObject(typeof(EnumType), value);
        }
        public static bool AskYesNo()
        {
            char yn;
            while (true)
            {
                yn = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (yn != 'y' && yn != 'n')
                {
                    ColorPrint.ErrorPrint("Неверный формат! ", "Введите y/n: ");
                }
                else
                    break;
            }
            return true ? yn == 'y' : false;
        }
        static bool ExtensionCheck(string filePath)
        {
            const int minPathLength = 4;
            const string newValueAsk = "Введите путь ещё раз: ";
            if (filePath.Length > minPathLength)
            {
                if (filePath.EndsWith(".txt"))
                {
                    return true;
                }
                else
                {
                    ColorPrint.ErrorPrint("Неверное расширение! ", newValueAsk);
                    return false;
                }
            }
            else
            {
                ColorPrint.ErrorPrint("Слишком короткий путь к файлу! ", newValueAsk);
                return false;
            }
        }
        public static string GetFilePathForRead()
        {
            string path;
            const string newValueAsk = "Введите путь ещё раз: ";
            Console.Write("Введите путь к файлу для чтения текста (допускаются только .txt файлы): ");
            while (true)
            {
                path = Console.ReadLine();
                if (ExtensionCheck(path))
                {
                    try
                    {
                        using (StreamReader streamReader = new StreamReader(path)) { }
                        break;
                    }
                    catch (FileNotFoundException)
                    {
                        ColorPrint.ErrorPrint("Файла по указанному пути не существует! ", newValueAsk);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        ColorPrint.ErrorPrint("Доступ к файлу запрещён! ", newValueAsk);
                    }
                    catch (System.NotSupportedException)
                    {
                        ColorPrint.ErrorPrint("Запрещённое имя файла! ", newValueAsk);
                    }
                }
            }
            return path;
        }
        public static string GetFilePathForWrite()
        {
            string path;
            Console.Write("Введите путь для сохранения результата в файл (допускаются только .txt файлы): ");
            while (true)
            {
                path = Console.ReadLine();
                if (ExtensionCheck(path))
                {
                    try
                    {
                        if (File.Exists(path))
                        {
                            ColorPrint.ErrorPrint("Файл уже существует. ", "y - перезаписать, n - указать другой путь: ");
                            if (AskYesNo())
                            {
                                using (StreamWriter streamWriter = new StreamWriter(path)) { }
                                break;
                            }
                            else
                            {
                                Console.Write("Введите путь к файлу: ");
                                continue;
                            }
                        }
                        else
                        {
                            using (StreamWriter streamWriter = new StreamWriter(path)) { }
                            return path;
                        }
                    }
                    catch
                    {
                        ColorPrint.ErrorPrint("Доступ к файлу запрещён или было использовано запрещённое имя! ", "Введите путь ещё раз: ");
                    }
                }
            }
            return path;
        }
        public static ICipher GetCipher(MenuItems.ROT13AES128Menu ROT13AES128Choice)
        {
            switch (ROT13AES128Choice)
            {
                case MenuItems.ROT13AES128Menu.ROT13:
                    return new ROT13();
                case MenuItems.ROT13AES128Menu.AES128:
                    return new AES128();
                default:
                    return null;
            }
        }
    }
}