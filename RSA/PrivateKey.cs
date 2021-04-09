public class PrivateKey : Key
{
    public PrivateKey(int value) : base(value)
    { }
        public static explicit operator PrivateKey(int v) => new PrivateKey(v) ;
    
}

