public class KeyGenerator
{
    public (PrivateKey,PublicKey) GenerateKeys(int p,int q) 
    {
        var f = EulerFunc( p, q);
        var e = GetPublicKey(f);
        var d = GetPrivatKey(f,e);
        return (new PrivateKey(d),new PublicKey(e) );  
    }
    
    private static int EulerFunc(int p, int q) { return (p - 1) * (q - 1); }// функция Ейлера
    


    private static int GetPublicKey(int f) // Нахождение експоненты
    {
        int i = 2;
        for (; i < f;)

        {
            if (f % i != 0) { return i; }
            else { i++; }
        }
        return i;
    }
   


    private static int GetPrivatKey(int f,int e)  //Нахождение обратного ключа
    {
        int i = 2;
        for (; i < f;)
        {
            if ((i * e) % f == 1) { return i; }
            else { i++; }

        }
        return i;
    }
    
}

