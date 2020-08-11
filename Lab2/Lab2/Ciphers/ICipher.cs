namespace Lab2
{
    interface ICipher
    {
        string Encode(string textToEncode);
        string Decode(string textToDecode);
    }
}