using NUnit.Framework;
using Apples;

namespace UnitTestApples
{
    [TestFixture]
    public class TestApple
    {
        [Test]
        public void TestGetApple()
        {
            //arrange
            var apple = new Apple();
            string expected = "apple";

            //act
            string output = apple.GetApple();

            //assert
            Assert.AreEqual(expected, output);
        }
    }
}
