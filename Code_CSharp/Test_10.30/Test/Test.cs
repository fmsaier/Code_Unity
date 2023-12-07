namespace Test1
{
    public class Test
    {
        private int x;
        static void Swap(ref int x, ref int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }
        void Swap(int y)
        {
            x ^= y;
            y ^= y;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a + ":" + b);
            Swap(ref a, ref b);
            Console.WriteLine(a + ":" + b);
        }
        void Print()
        {
            x++;
            Swap(1);
        }
    }
}