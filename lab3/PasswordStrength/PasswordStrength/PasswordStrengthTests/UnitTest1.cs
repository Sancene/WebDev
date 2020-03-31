using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordStrength;

namespace PasswordStrengthTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcPasswordStrengthEmptyString()
        {
            string emptyStr = "";
            int passwordStrength;

            passwordStrength = Program.CalcPasswordStrength(emptyStr);

            Assert.AreEqual(passwordStrength, 0);
        }

        [TestMethod]
        public void CalcPasswordStrengthOnlyDuplicateLetters()
        {
            string duplicatesString = "aaa";
            int passwordStrength;

            passwordStrength = Program.CalcPasswordStrength(duplicatesString);

            Assert.AreEqual(passwordStrength, 6);
        }

        [TestMethod]
        public void CalcPasswordStrengthNormalWork()
        {
            string NormalString = "Qwer12345";
            int passwordStrength;

            passwordStrength = Program.CalcPasswordStrength(NormalString);

            Assert.AreEqual(passwordStrength, 84);
        }


        [TestMethod]
        public void CalcPasswordStrengthOnlyNums()
        {
            string numsString = "12345";
            int passwordStrength;

            passwordStrength = Program.CalcPasswordStrength(numsString);

            Assert.AreEqual(passwordStrength, 35);
        }

        [TestMethod]
        public void CalcPasswordStrengthStringWithDuplicates()
        {
            string stringWithDuplicates = "ab12NeO";
            int passwordStrength;

            passwordStrength = Program.CalcPasswordStrength(stringWithDuplicates);

            Assert.AreEqual(passwordStrength, 54);
        }
    }
}
