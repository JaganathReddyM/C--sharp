using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Training.WEEK2.Day4
{
    internal class StreamDemo
    {
        //Char Streams
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("Press a key follewed by ENTER:");
            int X =Console.Read();
            ch=(char)X;             // Get a char
            Console.WriteLine("\n"+X+"Your key is: "+ch);
        }
        public static void TestTwo() 
        {
            char ch = ' ';
            Console.WriteLine("press any key q to exit");
            while(ch!='q')
            {
                ch=(char)Console.Read();
                Console.WriteLine("Your key is: "+ch);
            }
        }
        public static void TestThree()
        {
            Console.Out.WriteLine("Enter a Sentence");
            string? str=Console.ReadLine();
            Console.Out.WriteLine(" "+str);
        }
        public static void TestNullableTypes()
        {
            int? x=0;
            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
                Console.WriteLine(x.GetValueOrDefault());
        }
    }
}
/*
using Training.WEEK2.Day4;

StreamDemo.TestOne();
StreamDemo.TestTwo();
StreamDemo.TestThree();
StreamDemo.TestNullableTypes();

 */

