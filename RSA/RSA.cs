using System;

public class RSA : ICipher
{
    private int _n;
    public RSA(int n) 
    {
        _n = n;  
    }
    public int Decrypt(int text, PrivateKey key)
    {

        return  Convert.ToInt32(Math.Pow(text, key.Value)) % _n;
    }

    public int Encrypt(int text, PublicKey key)
    {
        return Convert.ToInt32(Math.Pow(text, key.Value)) % _n; //Шифрование
    }
}

