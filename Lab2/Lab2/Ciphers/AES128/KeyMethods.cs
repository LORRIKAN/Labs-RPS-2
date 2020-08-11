//#define UnitTest
using System;
using System.Text.RegularExpressions;

namespace Lab2
{
    public partial class AES128 : ICipher
    {
        readonly string NL = Environment.NewLine;

        readonly byte[] defaultKey = new byte[keySize] {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }; // стандартный ключ, если пользователь не захочет ввести собственный
        byte[] key; // изначальный ключ шифрования
        byte[] expandedKey; // ключ шифрования на 10 раундов (расширенный ключ)
        readonly byte[] RCon = new byte[numberOfRounds + 2] { 0x8d, 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80, 0x1b, 0x36 };

        // запрос ключа у пользователя или присвоение ключа по умолчанию, создание расширенного ключа
        void SetKey()
        {
#if (!UnitTest)
            Console.Write("Хотите задать ключ шифрования вручную (не более 16 символов, только латиница и цифры)?" +
                $"{NL} y - да, n - задать ключ автоматически: ");
            if (Gets.AskYesNo())
            {
                Console.Write("Введите ключ: ");
                while (true)
                {
                    string userKey = Console.ReadLine();
                    if (userKey.IsRegular(keySize))
                    {
                        key = FromStringToBytes(userKey);
                        break;
                    }
                }
            }
            else
                key = defaultKey;
#else
            key = defaultKey;
#endif
        }
        // методы для расширения ключа
        void KeyExpansionCore(byte[] keyBytes, int roundNumber)
        {
            // сдвиг влево
            byte tmp = keyBytes[0];
            keyBytes[0] = keyBytes[1];
            keyBytes[1] = keyBytes[2];
            keyBytes[2] = keyBytes[3];
            keyBytes[3] = tmp;

            SubBytes(keyBytes);

            keyBytes[0] ^= RCon[roundNumber];
        }
        // расширение ключа
        byte[] KeyExpansion()
        {
            // первые 16 байт - начальный ключ
            byte[] expandedKey = new byte[(numberOfRounds + 2) * keySize];
            for (int i = 0; i < keySize; ++i)
                expandedKey[i] = key[i];
            // далее идёт расширения до ключа, нужного для метода AddRoundKey
            int bytesGenerated = keySize;
            int roundIteration = 1;
            byte[] tmp = new byte[4];

            while (bytesGenerated < (numberOfRounds + 2) * keySize)
            {
                for (int i = 0; i < 4; ++i)
                    tmp[i] = expandedKey[i + bytesGenerated - 4];
                if (bytesGenerated % 16 == 0)
                    KeyExpansionCore(tmp, roundIteration++);
                for (int i = 0; i < 4; ++i)
                {
                    expandedKey[bytesGenerated] = (byte)(expandedKey[bytesGenerated - 16] ^ tmp[i]);
                    ++bytesGenerated;
                }
            }
            return expandedKey;
        }
    }
    static class StringExpansion
    {
        public static bool IsRegular(this string key, int keySize)
        {
            Regex regex = new Regex(@"^[a-zA-z0-9]*$");
            if (key.Length == 0)
            {
                ColorPrint.ErrorPrint("Ключ не был введён! ", "Введите ключ: ");
                return false;
            }
            if (key.Length >= keySize)
            {
                ColorPrint.ErrorPrint("Введён ключ слишком большой длины! ", "Введите ключ длиной не более 16 символов: ");
                return false;
            }
            if (!regex.IsMatch(key))
            {
                ColorPrint.ErrorPrint("В ключе содержатся запрещённые символы! ", "Введите ключ, в котором содержатся только латиница и цифры: ");
                return false;
            }
            return true;
        }
    }
}