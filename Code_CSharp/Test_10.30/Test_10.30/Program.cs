using System.Reflection.Metadata;
using Test1;

namespace Test_10._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();

            Fly fly = new Boss();
            fly.Attack();

            List<int> list = new List<int>(20) { 1, 5, 1, 5, 6, 1, 6, 1, 5 };
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}