public class PublicKey : Key
{
    public PublicKey(int value) : base(value)
    {
    }
    public static explicit operator PublicKey(int v) => new PublicKey(v);
}

