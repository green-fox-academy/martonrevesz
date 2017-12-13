using NUnit.Framework;
using Sum;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestFixture]
    public class TestSumElements
    {
        [Test]
        public void TestSum()
        {
            //arrange
            var inputList = new List<int>() { 1, 2, 3, 0, -2 };
            var sumElements = new SumElements();
            int expected = 4;
            //act
            int output = sumElements.Sum(inputList);
            //assert
            Assert.AreEqual(expected, output);
        }
    }
}
