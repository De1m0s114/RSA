using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_test1
{   [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_for_n()
        {
            var n = new Key();
            var result = n.n(7, 11);
            var expected = 77;

            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void Test_for_e1()
        {
            
            var result = Key.e1(24);
            var expected = 5;

            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void Test_for_d1()
        {
            
            var result = Key.d1(13);
            var expected = 8;

            Assert.AreEqual(result, expected);
        }
       
    }
}
