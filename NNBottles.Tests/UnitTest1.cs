using System.Runtime.InteropServices;
using NUnit.Framework;
using NNBottles;
    
namespace NNBottles.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestTheFirstVerse()
        {
            const string expected = "99 bottles of beer on the wall, 99 bottles of beer." +
                              "\nTake one down and pass it around, 98 bottles of beer on the wall.\n";
            var actual = Bottles.Verse(99);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestAnotherVerse()
        {
            const string expected = "3 bottles of beer on the wall, 3 bottles of beer." +
                                    "\nTake one down and pass it around, 2 bottles of beer on the wall.\n";
            var actual = Bottles.Verse(3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestVerse2()
        {
            const string expected = "2 bottles of beer on the wall, 2 bottles of beer." +
                                    "\nTake one down and pass it around, 1 bottle of beer on the wall.\n";
            var actual = Bottles.Verse(2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestVerse1()
        {
            const string expected = "1 bottle of beer on the wall, 1 bottle of beer." +
                                    "\nTake it down and pass it around, no more bottles of beer on the wall.\n";
            var actual = Bottles.Verse(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestVerse0()
        {
            const string expected = "No more bottles of beer on the wall, no more bottles of beer." +
                                    "\nGo to the store and buy some more, 99 bottles of beer on the wall.\n";
            var actual = Bottles.Verse(0);
            Assert.AreEqual(expected, actual);
        }
    }
}