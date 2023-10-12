using System;

namespace Test_10._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a + b) / 2f);

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine(a);
            Console.WriteLine(b);

            char c = 'a';
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} + {1} = {2}", c, b, a + b);

            int d = 92;

        }
    }
}