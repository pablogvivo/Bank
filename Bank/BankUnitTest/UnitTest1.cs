using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;

namespace BankUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_floatNumber()
        {
            float res1 = Utils.fNumber("50.5");
            Assert.AreEqual(res1, 50.5);
            float res2 = Utils.fNumber("50,5");
            Assert.AreEqual(res2, 50.5);
        }
        [TestMethod]
        public void Test_IBANCheck()
        {
            bool res1 = Utils.IBANCheck("NL67ABNA6839136159");
            Assert.IsTrue(res1);
            bool res2 = Utils.IBANCheck("NL67ABNA6839136158");
            Assert.IsFalse(res2);
            bool res3 = Utils.IBANCheck("6839136158");
            Assert.IsFalse(res3);
        }
        [TestMethod]
        public void Test_justLetter()
        {
            bool res1 = Utils.justLetter("NL67ABNA6839136159");
            Assert.IsFalse(res1);
            bool res2 = Utils.justLetter("fDFSHh");
            Assert.IsTrue(res2);
            bool res3 = Utils.justLetter("fd ge");
            Assert.IsFalse(res3);
        }
        [TestMethod]
        public void Test_emailcheck()
        {
            bool res1 = Utils.emailCheck("BNA6839136159");
            Assert.IsFalse(res1);
            bool res2 = Utils.emailCheck("pepe@gmail.com");
            Assert.IsTrue(res2);
            bool res3 = Utils.emailCheck("pepe @gmail.com");
            Assert.IsFalse(res3);

        }
    }
}
