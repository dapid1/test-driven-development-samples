using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCore;

namespace StackTest
{
    [TestClass]
    public class UnitTest1
    {
        TempStack tempPushStack;
        TempStack tempPopStack;
        public UnitTest1()
        {
            tempPushStack = new TempStack(5);
            tempPopStack = new TempStack(5);
        }

        [TestMethod]
        public void CanPushItemsOntoStack()
        {
            Assert.AreEqual(1, tempPushStack.Push(2));
            Assert.AreEqual(2, tempPushStack.Push(4));
            Assert.AreEqual(3, tempPushStack.Push(8));
            Assert.AreEqual(4, tempPushStack.Push(16));
            Assert.AreEqual(5, tempPushStack.Push(32));

            //stack is full
            Assert.AreEqual(-1, tempPushStack.Push(64));

        }

        [TestMethod]
        public void CanPopElementsOfStack()
        {
            tempPopStack.Push(10);
            tempPopStack.Push(20);

            Assert.AreEqual(1, tempPopStack.Pop());
            Assert.AreEqual(0, tempPopStack.Pop());

        }

    }
}
