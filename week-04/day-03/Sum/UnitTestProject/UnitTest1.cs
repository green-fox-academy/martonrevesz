using NUnit.Framework;
using Sum;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestFixture]
    public class TestSumElements
    {
        [Test]
        public void TestSumEmpty()
        {
            //arrange
            List<int> inputList = new List<int>();
            var sumElements = new SumElements();
            int expected = 0;
            //act
            int output = sumElements.Sum(inputList);
            //assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestSumSingle()
        {
            //arrange
            List<int> inputList = new List<int>() { 5 };
            var sumElements = new SumElements();
            int expected = 5;
            //act
            int output = sumElements.Sum(inputList);
            //assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestSumMultiple()
        {
            //arrange
            List<int> inputList = new List<int>() { 3, 4, 5 };
            var sumElements = new SumElements();
            int expected = 12;
            //act
            int output = sumElements.Sum(inputList);
            //assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestSumNull()
        {
            //arrange
            var sumElements = new SumElements();
            List<int> myList = null;
            int expected = 0;
            //act
            int output = sumElements.Sum(myList);
            //assert
            Assert.AreEqual(expected, output);
        }
    }
}
