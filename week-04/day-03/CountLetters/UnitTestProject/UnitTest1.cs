using NUnit.Framework;
using CountLetters;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        Count myCount = new Count();

        [Test]
        public void TestCountEmpty()
        {
            //arrange
            string text = string.Empty;
            Dictionary<char, int> expected = new Dictionary<char, int>();
            //act
            Dictionary<char, int> output = myCount.CountLetters(text);
            //assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestCountSingle()
        {
            //arrange
            string text = "t";
            Dictionary<char, int> expected = new Dictionary<char, int>() { { 't', 1 } };
            //act
            Dictionary<char, int> output = myCount.CountLetters(text);
            //assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestCountMoreLetters()
        {
            //arrange
            string text = "ted";
            Dictionary<char, int> expected = new Dictionary<char, int>() {
                { 't', 1 },
                { 'e', 1 },
                { 'd', 1 } };
            //act
            Dictionary<char, int> output = myCount.CountLetters(text);
            //assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestCountMoreLettersMultiple()
        {
            //arrange
            string text = "teddy";
            Dictionary<char, int> expected = new Dictionary<char, int>() {
                { 't', 1 },
                { 'e', 1 },
                { 'd', 2 },
                { 'y', 1 } };
            //act
            Dictionary<char, int> output = myCount.CountLetters(text);
            //assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestCountMoreLettersSpaces()
        {
            //arrange
            string text = "teddy bear";
            Dictionary<char, int> expected = new Dictionary<char, int>() {
                { 't', 1 },
                { 'e', 2 },
                { 'd', 2 },
                { 'y', 1 },
                { ' ', 1 },
                { 'b', 1 },
                { 'a', 1 },
                { 'r', 1 } };
            //act
            Dictionary<char, int> output = myCount.CountLetters(text);
            //assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestCountWrongMultiplicity()
        {
            //arrange
            string text = "teddy bear";
            Dictionary<char, int> expected = new Dictionary<char, int>() {
                { 't', 1 },
                { 'e', 2 },
                { 'd', 2 },
                { 'y', 4 },
                { ' ', 1 },
                { 'b', 1 },
                { 'a', 1 },
                { 'r', 1 } };
            //act
            Dictionary<char, int> output = myCount.CountLetters(text);
            //assert
            Assert.AreNotEqual(expected, output);
        }

        [Test]
        public void TestCountWrongOccurance()
        {
            //arrange
            string text = "teddy bear";
            Dictionary<char, int> expected = new Dictionary<char, int>() {
                { 't', 1 },
                { 'e', 2 },
                { 'd', 2 },
                { 'y', 4 },
                { ' ', 1 },
                { 'b', 1 },
                { 'f', 1 },
                { 'a', 1 },
                { 'r', 1 } };
            //act
            Dictionary<char, int> output = myCount.CountLetters(text);
            //assert
            Assert.AreNotEqual(expected, output);
        }

        [Test]
        public void TestCountMissingOccurance()
        {
            //arrange
            string text = "teddy bear";
            Dictionary<char, int> expected = new Dictionary<char, int>() {
                { 't', 1 },
                { 'e', 2 },
                { 'd', 2 },
                { 'y', 4 },
                { ' ', 1 },
                { 'b', 1 },
                { 'f', 1 },
                { 'r', 1 } };
            //act
            Dictionary<char, int> output = myCount.CountLetters(text);
            //assert
            Assert.AreNotEqual(expected, output);
        }
    }
}
