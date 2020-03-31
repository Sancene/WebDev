using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckIdentifier;

namespace CheckIdentifierTests
{
    [TestClass]
    public class CheckIdentifierTests
    {
        [TestMethod]
        public void NumberInTheBeggining()
        {
            //arrange
            string[] wrong1 = new string[1] { "1asdf" };

            //act
            int min;
            min = Program.Main(wrong1);

            //assert
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void IncorrectSymbol()
        {
            //arrange
            string[] wrong1 = new string[1] { "as*df" };

            //act
            int min;
            min = Program.Main(wrong1);

            //assert
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void NormalWork()
        {
            //arrange
            string[] wrong1 = new string[1] { "asdf321" };

            //act
            int min;
            min = Program.Main(wrong1);

            //assert
            Assert.AreEqual(0, min);
        }
        [TestMethod]
        public void IncorrectArgumentsMore()
        {
            //arrange
            string[] wrong1 = new string[2] { "asdf321", "123"};

            //act
            int min;
            min = Program.Main(wrong1);

            //assert
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void IncorrectArgumentsLess()
        {
            //arrange
            string[] wrong1 = new string[0] {};

            //act
            int min;
            min = Program.Main(wrong1);

            //assert
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void WrongSymbolStillLetter()
        {
            //arrange
            string[] wrong1 = new string[1] { "������" };

            //act
            int min;
            min = Program.Main(wrong1);

            //assert
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void EmptyString()
        {
            //arrange
            string[] wrong1 = new string[1] { "" };

            //act
            int min;
            min = Program.Main(wrong1);

            //assert
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void IsLetter()
        {
            //arrange
            char ch = 'A';

            //act
            bool right = Program.IsEnglishLetter(ch);

            //assert
            Assert.IsTrue(right);
        }
        [TestMethod]
        public void IsNotLetter()
        {
            //arrange
            char ch = '4';

            //act
            bool right = Program.IsEnglishLetter(ch);

            //assert
            Assert.IsFalse(right);
        }
        [TestMethod]
        public void IsDigit()
        {
            //arrange
            char ch = '4';

            //act
            bool right = Program.IsDigit(ch);

            //assert
            Assert.IsTrue(right);
        }
        [TestMethod]
        public void IsNotDigit()
        {
            //arrange
            char ch = 'A';

            //act
            bool right = Program.IsDigit(ch);

            //assert
            Assert.IsFalse(right);
        }
    }
}