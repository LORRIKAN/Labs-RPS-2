using Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiphersTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestROT13Encode()
        {
            var rot13 = new ROT13();
            string origStr = "Hello world!";
            string expected = "Uryyb jbeyq!";
            string actual = rot13.Encode(origStr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestROT13Decode()
        {
            var rot13 = new ROT13();
            string origStr = "Uryyb jbeyq!";
            string expected = "Hello world!";
            string actual = rot13.Decode(origStr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAES128Encode()
        {
            var aes128 = new AES128();
            string origStr = "This is a message we will encrypt with AES!";
            string expected = "tksnuxYVpvUyGGzF+pS1XlxU6hvflx494xv8AnUidlLVe9VCug9oUM39WbjrDoPR";
            string actual = aes128.Encode(origStr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAES128Decode()
        {
            var aes128 = new AES128();
            string origStr = "tksnuxYVpvUyGGzF+pS1XndfDK/RdUwsYeXyywypR7XVe9VCug9oUM39WbjrDoPR";
            string expected = "This is a message we will decrypt with AES!";
            string actual = aes128.Decode(origStr);
            Assert.AreEqual(expected, actual);
        }
    }
}