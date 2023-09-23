using Lesson1.DayThree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayThree
{
    internal class StringLessons
    {
        public static void DemoA()
        {
            String firstString = "Hello";
            char[] data = { 'H', 'e', 'l', 'l', 'o' };
            String secondString= new String(data);
            Console.WriteLine(firstString+" "+secondString);
           // String thirdString=String.Empty;
           // int x = 0;
        }
        public static void DemoB()
        {
            String s1 = "abcdefg";
            Console.WriteLine("Length"+s1.Length);
            Char[] data = s1.ToCharArray();
            foreach(char c1 in data)
            {
                Console.WriteLine(c1);
            }
        }
        public static void DemoC()
        {
            String s1 = "abcdefg";
            String[] words = s1.Split();
            Console.WriteLine("Word count" +words.Count());
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
        public static void DemoD()
        {
            String firstString = "Tom and jerry";
            String stringInUpper=firstString.ToUpper();
            Console.WriteLine("firstString:"+firstString);
            Console.WriteLine("stringInUpper:"+stringInUpper);
            String stringInLower = firstString.ToLower();
            Console.WriteLine("firstString:" + firstString);
            Console.WriteLine("stringInLower:" + stringInLower);

        }
        public static void DemoE()
        {
            String secondString = "    abcdef    ";
            String trimmedString = secondString.Trim();
            Console.WriteLine(secondString);
            Console.WriteLine("secondString Length: " + secondString.Length);
            Console.WriteLine(trimmedString);
            Console.WriteLine("trimmedString Length: " + trimmedString.Length);
            String trimmedAtEnd = secondString.TrimEnd();
            Console.WriteLine(trimmedAtEnd);
            Console.WriteLine("trimmedAtEnd Length: " + trimmedAtEnd.Length);
            String trimmedAtStart = secondString.TrimStart();
            Console.WriteLine(trimmedAtStart);
            Console.WriteLine("trimmedAtStart Length: " + trimmedAtStart.Length);
        }
    }
}