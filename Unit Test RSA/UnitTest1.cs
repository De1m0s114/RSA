using NUnit.Framework;
using System;


namespace Unit_test1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Result()
        {
            var e = new RSA(35);
            var word = 12;

            var result = e.Encrypt(word, (PublicKey)5);
            var expected = e.Decrypt(result, (PrivateKey)5);
            Assert.AreEqual(word, expected);
        }
        [Test]
        public void KeyGeneratorCheck()
        {
            var s = new KeyGenerator();
            var result = s.GenerateKeys(7, 5);
            var expected = ((PrivateKey)5, (PublicKey)5);
            Assert.AreEqual(result, expected);
        }
    }


}

