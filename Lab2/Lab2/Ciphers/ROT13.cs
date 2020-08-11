using System.Text;

namespace Lab2
{
    public class ROT13 : ICipher
    {
        const byte symbolA = 65;
        const byte symbolM = 77;
        const byte symbolN = 78;
        const byte symbolZ = 90;
        const byte symbola = 97;
        const byte symbolm = 109;
        const byte symboln = 110;
        const byte symbolz = 122;
        const byte shift = 13;
        public string Encode(string textToEncode)
        {
            //Преобразование строки в последовательность байт
            var utf8Encoding = new UTF8Encoding();
            byte[] encodedBytes = utf8Encoding.GetBytes(textToEncode);
            //Шифрование
            for (int i = 0; i < encodedBytes.Length; ++i)
            {
                //сдвиг букв верхнего регистра
                if (encodedBytes[i] >= symbolA && encodedBytes[i] <= symbolM)
                    encodedBytes[i] += shift;
                else if (encodedBytes[i] >= symbolN && encodedBytes[i] <= symbolZ)
                    encodedBytes[i] -= shift;
                //сдвиг букв нижнего регистра
                if (encodedBytes[i] >= symbola && encodedBytes[i] <= symbolm)
                    encodedBytes[i] += shift;
                else if (encodedBytes[i] >= symboln && encodedBytes[i] <= symbolz)
                    encodedBytes[i] -= shift;
            }
            return utf8Encoding.GetString(encodedBytes);
        }
        public string Decode(string textToDecode)
        {
            return Encode(textToDecode); //так как функция ROT13 является обратной для самой себя, то её можно 
                                         //использовать и для дешифровки
        }
    }
}