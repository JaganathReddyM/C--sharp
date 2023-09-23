using Lesson28.Day28;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28.Day28
{
    internal class ByRefDemo
    {
        public static void Dotask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void DotaskA(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void TestOne()
        {
            int v1 = 1000;
            Console.WriteLine($"v1:{v1}");
            Dotask(v1);
            Console.WriteLine($"v1:{v1}");
            DotaskA(v1);
            Console.WriteLine($"v1:{v1}");
        }
        
    }
}
/*using Lesson28.Day28;
ByRefDemo.Dotask(5);      //We need  to pass the value
ByRefDemo.Dotask(5); 
ByRefDemo.TestOne();*/
