using fizzbuzz_tdd;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace fizzbuzz_test
{
    [TestClass]
    public class UnitTest1
    {
        private Program fb;

        public UnitTest1()
        {
            fb = new Program();
        }

        [TestMethod]
        public void ShouldPrintFizz()
        {
            Assert.AreEqual("Fizz", fb.Print(333));            
        }

        [TestMethod]
        public void ShouldPrintBuzz()
        {
            Assert.AreEqual("Buzz", fb.Print(5));
        }

        [TestMethod]
        public void ShouldPrintFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", fb.Print(16515));
        }

        [TestMethod]
        public void ShouldPrintNumber()
        {
            Assert.AreEqual("9997", fb.Print(9997));
        }


    }
}
