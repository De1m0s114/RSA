public abstract class Key 

{

    public override bool Equals(object obj)
    {
        if (obj is Key key) { return this.Value == key.Value; }

        else { return false; }
    }
    protected Key(int value) { Value = value; }
    public int Value { get; private set; }
}

