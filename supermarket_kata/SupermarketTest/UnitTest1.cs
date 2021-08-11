using Microsoft.VisualStudio.TestTools.UnitTesting;
using supermarket_kata;
using System.Collections.Generic;

namespace SupermarketTest
{
    [TestClass]
    public class UnitTest1
    {
        Supermarket supermarket;
        public UnitTest1()
        {
            supermarket = new Supermarket();
        }

        [TestMethod]
        public void UnitPriceIsNumericTest()
        {
            Assert.AreEqual(supermarket.CheckIfUnitPriceIsNumeric("1.2f"), true);
        }

        [TestMethod]
        public void UnitPricesIsNumericTest()
        {
            Assert.AreEqual(supermarket.CheckIfUnitPricesIsNumeric(new List<dynamic> {1, 2, 4, 5, 6, 2.3, 2.3f, "2.3f" }), true);
        }

        [TestMethod]
        public void NullTest()
        {
            Assert.AreEqual(supermarket.CheckIfValueIsNull((new List<dynamic> { 1.2, 1, 52, null })), true);
        }

        [TestMethod]
        public void FreeItemTest()
        {
            Assert.AreEqual(supermarket.CheckIfItemIsFree((new List<double> { 1.2, 1, 52, -5})), true);
        }


        [TestMethod]
        public void TwoOccurencesTest()
        {
            Assert.AreEqual(supermarket.CheckTwoOccurences((new Dictionary<string, int> { { "beans", 3 }, { "bread", 1 }, { "milk" , 2 } })), true);
        }

        public void ThreeOccurencesTest()
        {
            Assert.AreEqual(supermarket.CheckThreeOccurences((new Dictionary<string, int> { { "beans", 3 }, { "bread", 1 }, { "milk", 2 } })), true);
        }

        public void OneOccurenceTest()
        {
            Assert.AreEqual(supermarket.CheckOneOccurence((new Dictionary<string, int> { { "beans", 3 }, { "bread", 1 }, { "milk", 2 } })), true);
        }

    }
}
