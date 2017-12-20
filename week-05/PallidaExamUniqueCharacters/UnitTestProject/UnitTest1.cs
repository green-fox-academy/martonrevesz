using NUnit.Framework;
using PallidaExamUniqueCharacters;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        HandleStrings handleStrings = new HandleStrings();

        [Test]
        public void TestUniqueCharactersEmpty()
        {
            string test = string.Empty;
            var expected = new List<char>();

            var resultList = handleStrings.UniqueCharacters(test);

            Assert.AreEqual(expected, resultList);
        }

        [Test]
        public void TestUniqueCharactersSingle()
        {
            string test = "a";
            var expected = new List<char>() {'a' };

            var resultList = handleStrings.UniqueCharacters(test);

            Assert.AreEqual(expected, resultList);
        }

        [Test]
        public void TestUniqueCharactersWord()
        {
            string test = "anagram";
            var expected = new List<char>() { 'n', 'g', 'r', 'm' };

            var resultList = handleStrings.UniqueCharacters(test);

            Assert.AreEqual(expected, resultList);
        }

        [Test]
        public void TestUniqueCharactersMultipleWords()
        {
            string test = "schmehl gerzson";
            var expected = new List<char>() { 'c', 'm', 'l', ' ', 'g', 'r', 'z', 'o', 'n' };

            var resultList = handleStrings.UniqueCharacters(test);

            Assert.AreEqual(expected, resultList);
        }
    }
}
