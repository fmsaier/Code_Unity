using System;

namespace Test_10._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str1 = "aaa";
            Console.WriteLine(str1);

            string str2 = "aaa";
            Console.WriteLine(str2);

            int j = 0;
            string str = Console.ReadLine();
            str = str.Trim();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            foreach (string number in strArray)
            {
                intArray[j++] = Convert.ToInt32(number);
            }
            for(int i = 0; i < intArray.Length; i++)
            {
                Console.Write(strArray[i] + " ");
            }
            Console.WriteLine();

            for(int i = 0;i < intArray.Length - 1; i++)
            {
                bool isOK = false;
                int tmp;
                for(int k = 0; k < intArray.Length - 1 -i ; k++)
                {
                    if (intArray[k] < intArray[k + 1])
                    {
                        tmp = intArray[k];
                        intArray[k] = intArray[k + 1];
                        intArray[k + 1] = tmp;
                        isOK = true;
                    }
                }
                if (!isOK)
                {
                    break;
                }
            }
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }
        }
    }
}