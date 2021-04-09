using System;
 class Program

{
     static void Main(string[] args)
    {
        var keyGenerator = new KeyGenerator();
        var (privatKey,publicKey) = keyGenerator.GenerateKeys(5, 7);
        var rsa = new RSA(5*7);
        var text = 4;
        var encrypted = rsa.Encrypt(text,publicKey);
        var decrypted = rsa.Decrypt(encrypted, privatKey);
        if (text == decrypted)
        {
            Console.WriteLine("all is ok");

            Console.ReadKey();
        }
    }
}

