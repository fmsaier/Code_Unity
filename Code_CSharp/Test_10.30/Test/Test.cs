namespace Test1
{
    public class Test
    {
        static void Swap(ref int x, ref int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a + ":" + b);
            Swap(ref a, ref b);
            Console.WriteLine(a + ":" + b);
        }
    }
}