namespace Test_11._29
{
    class Test
    {
        static int[] a = {1, 2, 3, 4, 5, 6, 7, 8};

        public static void Main()
        {
            int i = 10;
            object o = i;
            o = 5;
            Console.WriteLine(o);
            int j = (int)o;
            j = 6;
            Console.WriteLine(o);
            object obj = o;
            obj = 6;
            Console.WriteLine(o);
        }
    }
}