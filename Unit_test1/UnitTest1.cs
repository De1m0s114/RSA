using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Result()
        {
            var e = new RSA(35);
            var word = 12;
            
            var result=e.Encrypt(word, (PublicKey)5);
            var expected = e.Decrypt(result, (PrivateKey)5);
            Assert.AreEqual(word, expected);
        }
        [TestMethod]
        public void KeyGeneratorCheck()
        {
            var s = new KeyGenerator();
            var result = s.GenerateKeys(7, 5);
            var expected = (5, 5);
            Assert.Equals(result, expected);
        }
    }
    

}

