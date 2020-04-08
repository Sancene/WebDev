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
            string identifier = "1asdf";

            //act
            bool result;
            result = Program.CheckIdentifier(identifier);

            //assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IncorrectSymbol()
        {
            //arrange
            string identifier = "as*df";

            //act
            bool result;
            result = Program.CheckIdentifier(identifier);

            //assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NormalWork()
        {
            //arrange
            string identifier = "asdf321";

            //act
            bool result;
            result = Program.CheckIdentifier(identifier);

            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmptyString()
        {
            //arrange
            string identifier = "";

            //act
            bool result;
            result = Program.CheckIdentifier(identifier);

            //assert
            Assert.IsFalse(result);
        }
    }
    [TestClass]
    public class IsEnglishLetterTests
    {
        [TestMethod]
        public void WrongSymbolStillLetter()
        {
            //arrange
            char character = 'Ï';

            //act
            bool result;
            result = Program.IsEnglishLetter(character);

            //assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsLetter()
        {
            //arrange
            char ch = 'A';

            //act
            bool result = Program.IsEnglishLetter(ch);

            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsNotLetter()
        {
            //arrange
            char ch = '4';

            //act
            bool result = Program.IsEnglishLetter(ch);

            //assert
            Assert.IsFalse(result);
        }
    }
    [TestClass]
    public class IsDigitTests
    {
        [TestMethod]
        public void IsDigit()
        {
            //arrange
            char ch = '4';

            //act
            bool result = Program.IsDigit(ch);

            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsNotDigit()
        {
            //arrange
            char ch = 'A';

            //act
            bool result = Program.IsDigit(ch);

            //assert
            Assert.IsFalse(result);
        }
    }
}
