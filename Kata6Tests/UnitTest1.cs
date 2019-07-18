using System;
using Kata6.AnagramClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata6Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAnagramCheck()
        {
            //Arrange
            AnagramChecker MockAnagramChecker = new AnagramChecker();
            char[] baseValue = "anagram".ToCharArray();
            char[] truthValue = "MARGANA".ToCharArray();
            char[] falseValue = "ASDASD".ToCharArray();

            //Act
            bool isThisAnagramTrue = MockAnagramChecker.CheckAnagram(baseValue, truthValue);
            bool isThisAnagramFalse = MockAnagramChecker.CheckAnagram(baseValue, falseValue);

            //Assert
            Assert.IsTrue(isThisAnagramTrue);
            Assert.IsFalse(isThisAnagramFalse);

        }
    }
}
