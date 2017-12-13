using NUnit.Framework;
using System.Collections.Generic;

namespace Extension
{
    [TestFixture]
    public class ExtensionTests
    {
        Extension extension = new Extension();

        [Test]
        public void TestAdd_2and3is5()
        {
            Assert.AreEqual(6, extension.Add(2, 4));
        }

        [Test]
        public void TestAdd_1and4is5()
        {
            Assert.AreEqual(8, extension.Add(1, 7));
        }

        [Test]
        public void TestMaxOfThree_First()
        {
            Assert.AreEqual(9, extension.MaxOfThree(5, 4, 9));
        }

        [Test]
        public void TestMaxOfThree_Fhird()
        {
            Assert.AreEqual(4, extension.MaxOfThree(3, 4, 2));
        }

        [Test]
        public void TestMedian_Four()
        {
            Assert.AreEqual(2.5, extension.Median(new List<int>() { 1, 2, 3, 4 }));
        }

        [Test]
        public void TestMedian_Five()
        {
            Assert.AreEqual(3, extension.Median(new List<int>() { 3, 4, 5, 2, 1 }));
        }

        [Test]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('á'));
        }

        [Test]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('ú'));
        }

        [Test]
        public void TestTranslate_bemutatkozik()
        {
            Assert.AreEqual("vávásávár", extension.Translate("vásár"));
        }

        [Test]
        public void TestTranslate_kolbice()
        {
            Assert.AreEqual("keverüvülõvõ", extension.Translate("kerülõ"));
        }
    }
}