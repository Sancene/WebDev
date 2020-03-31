using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveExtraBlanks;

namespace RemoveExtraBlanksTest
{
    [TestClass]
    public class RemoveExtraBlanksTests
    {
        [TestMethod]
        public void RemoveExtraBlanksEmptyString()
        {
            //Arrange
            string emptyString = "";

            //Act
            emptyString = Program.RemoveExtraBlanks(emptyString);

            //Assert
            Assert.AreEqual(emptyString, "");
        }
        [TestMethod]
        public void RemoveExtraBlanksStringWithExtraBlanks()
        {
            //Arrange
            string testString = "  1    3\t\t4 5         ";

            //Act
            testString = Program.RemoveExtraBlanks(testString);

            //Assert
            Assert.AreEqual(testString, "1 3\t4 5");
        }
        [TestMethod]
        public void RemoveExtraBlanksStringWithOnlyBlanks()
        {
            //Arrange
            string testString = "                            ";

            //Act
            testString = Program.RemoveExtraBlanks(testString);

            //Assert
            Assert.AreEqual(testString, "");
        }
        [TestMethod]
        public void RemoveExtraBlanksNoExtraBlanks()
        {
            //Arrange
            string testString = "h e l\tl o";

            //Act
            testString = Program.RemoveExtraBlanks(testString);

            //Assert
            Assert.AreEqual(testString, "h e l\tl o");
        }
    }
}
