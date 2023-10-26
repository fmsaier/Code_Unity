using System.Diagnostics.CodeAnalysis;

namespace Test_10._25
{
    internal class Program
    {
        struct Stu
        {
            //public:
            public int a;
            public int b;

            public int Test()
            {
                return 0;
            }
        }

        enum Color
        {
            Red,
            Green,
            Black
        };

        static int F1(int n)
        {
            if (n == 1)
                return 1;
            return F1(n - 1) * n;
        }
        static int F2(int n)
        {
            if (n == 1)
                return 1;
            return F2(n - 1) + F1(n);
        }
        static int Func(int x)
        {
            if (x == 0 || x == 1)
                return 1;
            else
                return Func(x - 1) + Func(x - 2);
        }
        static void Print(string text)
        {
            Console.WriteLine(text);
        }
        static void Test(int[] intArray)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
        }
        static int Test(int j, params int[] intArray)
        {
            int sum = 0;
            foreach (int i in intArray)
            {
                sum += i;
            }
            return sum;
        }
        //static int[] Test(int[] intArray)
        //{
        //    return intArray;
        //}
        delegate int Dele(int x);
        static void Main(string[] args)
        {
            //int[] intArray = { 1, 2, 3 };
            //Test(intArray);
            //Test(new int[] { 1, 2, 3});
            //Test(new int[3]);
            //Test(6, 8, 9, 4);

            //Console.Write(Func(5));

            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length]; 
            //int i = 0;
            //foreach(string number in strArray)
            //{
            //    intArray[i] = Convert.ToInt32(strArray[i]);
            //    ++i;
            //}
            //Array.Sort(intArray);
            //foreach(int number in intArray)
            //{
            //    Console.WriteLine(number);
            //}
            //Print(str);

            Color color = Color.Red;
            Console.WriteLine(color);
            int number = (int)color;
            Console.WriteLine(number);
            Console.Write(F2(10));

            //Stu s1 = { 4, 5 };
            //s1.b = 10;
            int[] intArray = new int[] { 5, 6, 4 };
            //Stu[] stu = new Stu[2] { { 1, 2 }, { 5, 6 } };

            Dele dele = Func;
        }
    }
}
