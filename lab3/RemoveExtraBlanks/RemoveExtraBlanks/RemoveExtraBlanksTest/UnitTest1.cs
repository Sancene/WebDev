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
            //arrange
            string[] wrong1 = new string[0] {  };

            //act
            int min;
            min = Program.Main(wrong1);

            //assert
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void TooManyArguments()
        {
            //arrange
            string[] wrong1 = new string[3] { "input.txt", "output.txt", "input2.txt"};

            //act
            int min;
            min = Program.Main(wrong1);

            //assert
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void CorrectWork()
        {
            //arrange
            string[] wrong1 = new string[2] { "Tests/input1.txt", "Tests/output.txt" };
            
            //act
            int min;
            min = Program.Main(wrong1);
            string[] correctoutput = System.IO.File.ReadAllLines("Tests/correctoutput1.txt");
            string[] output = System.IO.File.ReadAllLines("Tests/output.txt");
            bool correct = true;

            for(int i = 0; i < output.Length; i++)
            {
                if(output[i] != correctoutput[i])
                    correct = false;
            }

            //assert
            Assert.IsTrue(correct);
        }
    }
}
