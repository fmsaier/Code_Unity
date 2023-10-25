using System.Diagnostics.CodeAnalysis;

namespace Test_10._25
{
    internal class Program
    {
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
        static int Test1(int j, params int[] intArray)
        {
            int sum = 0;
            foreach (int i in intArray)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {           
            int[] intArray = { 1, 2, 3 };
            Test(intArray);
            Test(new int[] { 1, 2, });
            Test1(6, 8, 9, 4);

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
        }
    }
}