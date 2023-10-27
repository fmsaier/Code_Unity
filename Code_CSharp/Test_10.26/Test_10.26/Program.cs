namespace Test_10._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            //while (flag)
            //{

            //    try
            //    {
            //        int n1 = Convert.ToInt32(Console.ReadLine());
            //        int n2 = Convert.ToInt32(Console.ReadLine());
            //        flag = false;
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("have a try");
            //    }

            //}

            Custom cus = new Custom();
            cus.Age = 20;
            Console.WriteLine(cus.Age);

            cus.Name = "Test";
            Console.WriteLine(cus.Name);

            int[] intArr = new int[10] { 4,5,4,64,6,1,9,41,321,4};
            intArr[0] = 0;
        }
    }
}