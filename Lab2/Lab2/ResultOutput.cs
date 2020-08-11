using System;
using System.IO;

namespace Lab2
{
    static class ResultOutput
    {
        static string NL = Environment.NewLine;
        public static void OutputResult(string origStr, string resultStr, string firstMessage, string secondMessage, Menu menu)
        {
            ColorPrint.PrintWithColor(ConsoleColor.Yellow, firstMessage + origStr + NL + NL);
            ColorPrint.PrintWithColor(ConsoleColor.Green, secondMessage + resultStr + NL + NL);
            menu.SetWhatToSaveInFile();
            switch (menu.WhatToSaveInFileChoice)
            {
                case MenuItems.WhatToSaveInFile.originalStr:
                    OutputStr(origStr);
                    ColorPrint.PrintWithColor(ConsoleColor.Green, "Успешно сохранено!" + NL + NL);
                    break;
                case MenuItems.WhatToSaveInFile.changedStr:
                    OutputStr(resultStr);
                    ColorPrint.PrintWithColor(ConsoleColor.Green, "Успешно сохранено!" + NL + NL);
                    break;
                case MenuItems.WhatToSaveInFile.originalAndChangedStr:
                    OutputOrigAndChangedStr(origStr, resultStr);
                    ColorPrint.PrintWithColor(ConsoleColor.Green, "Успешно сохранено!" + NL + NL);
                    break;
                default:
                    break;
            }
        }
        static void OutputStr(string str)
        {
            using (var streamWriter = new StreamWriter(Gets.GetFilePathForWrite()))
                streamWriter.Write(str);
        }
        static void OutputOrigAndChangedStr(string origStr, string changedStr)
        {
            OutputStr(origStr + NL + changedStr);
        }
    }
}