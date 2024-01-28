namespace Test_1._28
{
    internal class Program
    {
        static int y;
        private string name;
        public string Name => name;
        void Test(int x) => y = x * x;
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Queue<int> q = new Queue<int>();
            //Console.WriteLine("Hello, World!");
            Func<int, int> f = y => y = 1;
            Console.Write(f(1)) ;
            Func<int, bool> s = y => true;
            Func<int, bool> w = delegate (int y)
            {
                return true;
            };
            Action a = () => y = 1;
        }
    }
}