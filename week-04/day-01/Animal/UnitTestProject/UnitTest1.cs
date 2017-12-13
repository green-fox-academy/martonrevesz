using NUnit.Framework;
using FarmNS;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestEat()
        {
            Animal tiger = new Animal();
            tiger.HungerValue = 7;
            Assert.AreEqual(6, tiger.Eat());
        }

        [Test]
        public void TestDrink()
        {
            Animal lion = new Animal();
            lion.ThirstValue = 70;
            Assert.AreEqual(69, lion.Drink());
        }

        [Test]
        public void TestPlay()
        {
            Animal lion = new Animal();
            lion.HungerValue = 34;
            lion.ThirstValue = 20;
            int[] testArray = new int[] { 35, 21 };
            Assert.AreEqual(testArray, lion.Play());
        }

        [Test]
        public void TestBreedAlreadyFull()
        {
            Animal zebra = new Animal();
            Animal lion = new Animal();
            Animal tiger = new Animal();
            Farm farm = new Farm(new List<Animal>() { tiger, lion, zebra }, 3);
            Assert.AreEqual(3, farm.Breed());
        }

        [Test]
        public void TestBreedNotFull()
        {
            Animal zebra = new Animal();
            Animal lion = new Animal();
            Farm farm = new Farm(new List<Animal>() { lion, zebra }, 3);
            Assert.AreEqual(3, farm.Breed());
        }

        [Test]
        public void TestSlaughter()
        {
            Animal zebra = new Animal();
            Animal lion = new Animal();
            Animal tiger = new Animal();
            Farm farm = new Farm(new List<Animal>() { tiger, lion, zebra }, 3);
            tiger.HungerValue = 25;
            lion.HungerValue = 26;
            zebra.HungerValue = 27;
            Assert.AreEqual(tiger, farm.Slaughter());
        }

        [Test]
        public void TestSlaughterEqualHunger()
        {
            Animal zebra = new Animal();
            Animal lion = new Animal();
            Animal tiger = new Animal();
            Farm farm = new Farm(new List<Animal>() { tiger, lion, zebra }, 3);
            tiger.HungerValue = 25;
            lion.HungerValue = 24;
            zebra.HungerValue = 24;
            Assert.AreEqual(lion, farm.Slaughter());
        }
    }
}
