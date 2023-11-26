using System.Reflection.Metadata;
using Test1;

namespace Test_10._30
{
    delegate void Dele(int s, int d);
    struct Test
    {
        public int x;
    }
    class Test2
    {
        private Test test1;

        public static Test2 operator +(Test2 t1, Test2 t2)
        {
            return t1;
        }

        public Test Test1 { get => test1; set => test1 = value; }
        
    }
    class Program
    {
        private static void Add(params int[] x) 
        {

        }

        static void Main(string[] args)
        {
            //Dele dele = Add;
            Test2 test = new Test2();
            //test.test.x = 1;

            //Test t = new Test();

            //Fly fly = new Boss();
            //fly.Attack();

            //List<int> list = new List<int>(20) { 1, 5, 1, 5, 6, 1, 6, 1, 5 };
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}