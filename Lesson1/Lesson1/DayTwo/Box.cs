using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayTwo
{
    internal class Box    // class1
    {
        public static int height;    // Static used to access
        public  int width;      // global
        public const String type = "Wooden";
        public int GetHeight() { return height; }
    }
    internal class TestBox  // class 2
    {
        public static void TestOne()
        {
            Box.height = 100;
           // Box.width = 200;
           Box firstBox = new Box();  // Local
           Box secondBox = new Box();  //Local
            firstBox.width = 12345;
            secondBox.width = 98765;

            Console.WriteLine($"First Box= {firstBox.width}, {firstBox.GetHeight()}");
            Console.WriteLine($"Second Box= {secondBox.width}, {secondBox.GetHeight()}");
            Console.WriteLine(Box.type);
            // Box.type = "Glass";
            Box.height = 5555;
            Console.WriteLine($"First Box= {firstBox.width}, {firstBox.GetHeight()}");
            Console.WriteLine($"Second Box= {secondBox.width}, {secondBox.GetHeight()}");
        }

    }
}
/*
 * using Lesson1.DayTwo;

TestBox.TestOne();
*/