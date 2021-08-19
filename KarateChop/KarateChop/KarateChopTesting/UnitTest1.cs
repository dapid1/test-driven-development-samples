using KarateChop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace KarateChopTesting
{
    [TestClass]
    public class UnitTest1
    {
        //Red > Green > Refractor
        private int[] GenerateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        KarateChopBS obj;
        [TestInitialize]
        public void TestInit()
        {
            obj = new KarateChopBS();
        }

        //For each test test efficiency (count)
        //Middle Value (Found)
        //First Value
        //Last Value
        //Negative values
        //Duplicate values
        //Not found
        //Empty dataset
        //Null target
        //test count

        [TestMethod]
        public void EmptyDataSet()
        {
            Assert.AreEqual(-1, obj.Chop(target: 3, GenerateArray(size: 0)));
            Assert.AreEqual(-1, obj.Chop(target: -2, GenerateArray(size: 0)));
            Assert.AreEqual(-1, obj.Chop(target: 300, GenerateArray(size: 0)));
            Assert.AreEqual(-1, obj.Chop(target: 0, GenerateArray(size: 0)));
        }
        [TestMethod]
        public void MiddleValue()
        {
            //0123456
            Assert.AreEqual(3, obj.Chop(target: 3, GenerateArray(size: 7)));
            //0123 
            Assert.AreEqual(2, obj.Chop(target: 2, GenerateArray(size: 4)));
            //0 - 100000
            Assert.AreEqual(50000, obj.Chop(target: 50000, GenerateArray(size: 100001)));
        }
        [TestMethod]
        public void FirstValue()
        {
            //0 - 100000
            Assert.AreEqual(0, obj.Chop(target: 0, GenerateArray(size: 100001)));
        }
        [TestMethod]
        public void FirstValueEfficiency()
        {
            //0 - 100000
            obj.Chop(target: 50000, GenerateArray(size: 100001));
            Assert.AreEqual(1, obj.Count);
        }
        [TestMethod]
        public void LastValue()
        {
            //0 - 100000
            Assert.AreEqual(0, obj.Chop(target: 0, GenerateArray(size: 100001)));
        }
        [TestMethod]
        public void GreaterThanMiddle()
        {

        }
        [TestMethod]
        public void LessThanMiddle()
        {

        }
        [TestMethod]
        public void RandomValue()
        {

        }
        //
        [TestMethod]
        public void VeryHighValue()
        {

        }
    }
}
