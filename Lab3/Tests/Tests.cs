using Lab3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestFormatBad()
        {
            Interface tested = new Interface();
            tested.ParametrATextBox.Text = "1asdads";
            bool expected = false;
            bool actual = tested.parametrAChecked;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFormatGood()
        {
            Interface tested = new Interface();
            tested.ParametrATextBox.Text = "1,2";
            bool expected = true;
            bool actual = tested.parametrAChecked;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestLeftRightLimits()
        {
            Interface tested = new Interface();
            tested.LeftBoardXTextBox.Text = "5";
            tested.RightBoardXTextBox.Text = "4";
            string expected = "Левая граница не может быть больше или равна правой!";
            string actual = tested.WrongBoardsOrStepWarningLabel.Text;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestStepLimit()
        {
            Interface tested = new Interface();
            tested.StepXTextBox.Text = "-0,5";
            string expected = "Шаг не может быть меньше или равен нулю!";
            string actual = tested.WrongBoardsOrStepWarningLabel.Text;
            Assert.AreEqual(expected, actual);
        }
    }
}
