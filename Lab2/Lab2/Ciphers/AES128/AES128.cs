using System.Linq;
using System.Text;

namespace Lab2
{
    public partial class AES128 : ICipher
    {
        const int blockSize = 128 / 8; // величина блока шифрования
        const int keySize = blockSize; // величина ключа, равна блоку шифрования
        const int numberOfRounds = 9; // количество раундов шифрования за исключением последнего, 10

        public AES128()
        {
            SetKey();
            expandedKey = KeyExpansion();
        }
        // преобразование строки в последовательность байт
        byte[] FromStringToBytes(string text)
        {
            var utf8Encoding = new UTF8Encoding();
            byte[] textBytes = utf8Encoding.GetBytes(text);
            // паддинг байтов
            while (textBytes.Length % 16 != 0)
                textBytes = textBytes.Append<byte>(0).ToArray();
            return textBytes;
        }
        // преобразование последовательности байт обратно в строку
        string FromBytesToString(byte[] bytes)
        {
            var uft8Encoding = new UTF8Encoding();
            // анпаддинг байтов
            var unpaddedBytes = bytes.Where(i => i != 0).ToArray();
            return uft8Encoding.GetString(unpaddedBytes);
        }
    }
}