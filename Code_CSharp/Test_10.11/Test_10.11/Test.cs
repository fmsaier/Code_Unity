using System;

namespace Test_10._11
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("\\\"");
            Console.WriteLine("他说：\"what is \\n\"");
            int b = 0;
            float f = 0;
            Console.WriteLine(f);
            Console.WriteLine(b);
            Console.WriteLine('a');
            Console.WriteLine("aa" + 'a' + b);


            int c = -1;
            char d = (char)c;
            int e = d;
            Console.WriteLine(e);

            string s = @"\

adasdsdadasd
adadadsasdasdad
\";
            string p = "\\";
            Console.WriteLine(s);
            Console.WriteLine(p);

            string str = @"ss""
                s";
            Console.WriteLine(str + 1.1f);
        }
    }
}

//Console.WriteLine("Hello, World!");