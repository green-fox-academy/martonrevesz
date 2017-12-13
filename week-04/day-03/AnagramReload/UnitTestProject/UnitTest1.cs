using NUnit.Framework;
using AnagramReload;

namespace UnitTestProject
{
    [TestFixture]
    public class TestAnagram
    {
        [Test]
        public void TestMethodDefault()
        {
            //arrange
            string text1 = "gerzson";
            string text2 = "ongerzs";
            //act
            bool output = Anagram.IsAnagram(text1, text2);
            //assert
            Assert.True(output);
        }

        [Test]
        public void TestMethodCaseInsensitive()
        {
            //arrange
            string text1 = "gerZSon";
            string text2 = "onGerzs";
            //act
            bool output = Anagram.IsAnagram(text1, text2);
            //assert
            Assert.True(output);
        }

        [Test]
        public void TestMethodSpace()
        {
            //arrange
            string text1 = "ger   ZSon";
            string text2 = "onGerzs";
            //act
            bool output = Anagram.IsAnagram(text1, text2);
            //assert
            Assert.True(output);
        }

        [Test]
        public void TestMethodMultiplicity()
        {
            //arrange
            string text1 = "gerZZSon";
            string text2 = "oengrzs";
            //act
            bool output = Anagram.IsAnagram(text1, text2);
            //assert
            Assert.False(output);
        }

        [Test]
        public void TestMethodSpecialChars()
        {
            //arrange
            string text1 = "geZZZZZSon";
            string text2 = "onGer_zs";
            //act
            bool output = Anagram.IsAnagram(text1, text2);
            //assert
            Assert.False(output);
        }
    }
}
