public class Key
{
    public static int m = 3; // Число которое кодируем


    private static int p = 5;
    private static int q = 7;
    public int n(int p, int q)
    {
        return p * q;
    }
    public static int f1(int p,int q) { return (p - 1) * (q - 1); }// функция Ейлера
    public static int f =  f1( p, q); // функция Ейлера как инт


    public static int e1(int f) // Нахождение експоненты
    {
        int i = 2;
        for (; i < f;)

        {
            if (f % i != 0) { return i; }
            else { i++; }
        }
        return i;
    }
    public static int e = e1(f); // Преобразование експоненты как инт


    public static int d1(int f)  //Нахождение обратного ключа
    {
        int i = 2;
        for (; i < f;)
        {
            if ((i * e) % f == 1) { return i; }
            else { i++; }

        }
        return i;
    }
    public static int d = d1(f); // Новый ключ как инт а не функция
}

