using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayOne
{
    internal class ValueTypeLesson
    {
        public static void TestValueTypes()
        {
            Console.WriteLine("Hello, World!");
            byte b1 = 255;

            Console.WriteLine(b1);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);


            float f1 = 52.678f;     //float declaration
            long l1 = int.MaxValue + 1000L;   //long declaration
            Console.WriteLine(l1);
            double d1 = 123456789L;
            Console.WriteLine(d1);
            //decimal dec = 2354465.72357;

            char c1 = 'b';
            Console.WriteLine(c1);

            int x = c1;
            Console.WriteLine(x); Console.WriteLine();

            bool flag = true;
            Console.WriteLine(flag);


            int y = 68;
            char c2 = (char)y;
            Console.WriteLine(c2);
        }
        public static void TestMethod()          //Header of the Method
        {
            Console.WriteLine("Test");    // Method Body - It executes by how many times method is calling
        }
    }
}
