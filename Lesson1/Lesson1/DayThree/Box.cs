using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                            // Inheritance
namespace Lesson1.DayThree
{
    internal class Box
    {

        public int Height;
        public int Length;
        public int Width;



        public Box()
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }

        public override string ToString()
        {
            return $"Height: {Height}, Lenght:{Length}, Width: {Width}";
        }


    }
    internal class WoodenBox : Box
    {
        public int Area;
        public WoodenBox():base(1)
        {
            Console.WriteLine("Wodden Box Constructor");
        }
        public WoodenBox(int x):base(x)
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public WoodenBox(int x,int y) : base(x)
        {
            Console.WriteLine("Wooden BOX Constructor");
        }
        public void Move()
        {
            Console.WriteLine("Wooden Box Shifted");
        }



    }
    internal class BoxTester
    {
        public static void TestOne()
        {

            Box box = new Box();
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();
            Console.WriteLine(output);
            



        }
        public static void TestTwo()
        {

            WoodenBox box = new WoodenBox();
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();
            Console.WriteLine(output);
            box.Area = 300;
            box.Move();


        }
    }
}