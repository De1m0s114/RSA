public interface ICipher
{
    int Encrypt(int text,PublicKey key);
    int Decrypt(int text, PrivateKey key);
}

