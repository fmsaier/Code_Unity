using Test_1._26;
using System.Text;
using System.Text.RegularExpressions;

//int Add(int a, int b)
//{
//    return a + b;
//}
//public static bool operator==(Program p1, Program p2)
//{
//    return true;
//}
//public static bool operator !=(Program p1, Program p2)
//{
//    return true;
//}
namespace Test_1._26
{
    public class Program
    {
        string s;
        private T t;
        delegate void Callback(string s, int t);
        delegate int Add<T>(T a, T b);
        static void Main(string[] args)
        {
            Callback callback = Test;
            string str = "";
            Program program = new Program();
            program.Add1<int>(1, 2);
            callback("s",1);
            Add<int> add = program.Add1;
            

            Console.WriteLine(Regex.IsMatch(str, @"^\w+([0-9A-Z][a-z]){1,9}$"));
        }
        private static void Test(string s, int t)
        {

        }

        public int Add1<T>(T a, T b)
        {
            string s = "ss";
            s.Remove(0);
            //t = new T();
            //t.x = a;
            //t.Test();
            return Add1(a,b);
        }
    }

}
class T
{
    public int x;
    public void Test(params int[] x)
    {
        Program p = new Program();
    }
}


