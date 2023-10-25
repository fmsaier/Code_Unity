namespace Test_10._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length]; 
            int i = 0;
            foreach(string number in strArray)
            {
                intArray[i] = Convert.ToInt32(strArray[i]);
                ++i;
            }
            Array.Sort(intArray);
            foreach(int number in intArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}