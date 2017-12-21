using NUnit.Framework;
using SharpieSetNS;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {

        SharpieSet sharpieSet =  new SharpieSet(new List<Sharpie>()
            {new Sharpie("blue", 30), new Sharpie("red", 17), new Sharpie("green", 25)});

        [Test]
        public void TestCountUsable()
        {
            sharpieSet.SharpieList[0].InkAmount = 0;
            sharpieSet.SharpieList[1].InkAmount = 2;
            sharpieSet.SharpieList[2].InkAmount = 1;
            int expected = 2;        
            int result = sharpieSet.CountUsable();
            Assert.AreEqual(expected, result);
        }
    }
}
