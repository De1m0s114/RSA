using System;
class Program
{
    static void Main(string[] args)
    {
        Key chislo1 = new Key();
        Console.WriteLine(chislo1.n(5, 7));
        Decode chislo2 = new Decode();
        Console.WriteLine(chislo2.v);
        Console.ReadKey();

    }
}

