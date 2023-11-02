namespace Test_11._1
{
    struct Stu
    {
        public int x;
        public int y;

        public Stu()
        {
            this.x = 1;
            this.y = 2;
        }
    }


    internal class Program
    {
        public static void Print(MyList<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Insert(0, 3);
            list.Add(2);
            list.Add(3);

            //new System.Collections.Generic.List<int>();

            //int tmp = list[-1];

            list.RemoveAt(0);
            list.Remove(3);

            //Console.WriteLine(list.IndexOf(1));
            //Console.WriteLine(list.LastIndexOf(2));

            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 1, 2, 3 };
            //Console.WriteLine(arr1.Equals(arr2));

            Stu s1 = new Stu();
            Stu s2 = new Stu();
            s1.x = 1;
            s2.x = 1;
            s1.y = 2;
            s2.y = 2;
            Console.WriteLine(s1.Equals(s2));

            //Print(list);
        }
    }
}