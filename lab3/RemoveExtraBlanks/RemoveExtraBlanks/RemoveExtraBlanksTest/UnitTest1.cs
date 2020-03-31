using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveExtraBlanks;

namespace RemoveExtraBlanksTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoArguments()
        {
            string[] wrong1 = new string[0] {  };

            int min = Program.Main(wrong1);

            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void TooManyArguments()
        {
            string[] wrong1 = new string[3] { "input.txt", "output.txt", "input2.txt"};

            int min;
            min = Program.Main(wrong1);

            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void FileWithExtraSpacesAndTabs()
        {
            string[] wrong1 = new string[2] { "Tests/input1.txt", "Tests/output.txt" };

            Program.Main(wrong1);
            string[] correctoutput = System.IO.File.ReadAllLines("Tests/correctoutput1.txt");
            string[] output = System.IO.File.ReadAllLines("Tests/output.txt");
            bool correct = true;

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] != correctoutput[i])
                    correct = false;
            }

            Assert.IsTrue(correct);
        }

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
    }
}
