// See https://aka.ms/new-console-template for more information
using Assinments;
using System;

namespace Assinments.Week1Test
{
    class Answers
    {
        // What are Value types? Declare a variable for each Value type, and print its Max Value.
        /**
          * Value types are predefined datatypes in C#
          * Value types are loaded in the stack
          * Value types need not be instantiated
          * Value types have default value
          * Value types can not be set to NULL
          * Value types contain value in the memory allocated to them
          * When a value type is assigned to another value type a copy of the value will be created
          * Struct and Enums are Value types
          */
        public static void QuestionOne()
        {
            byte byteOne = 1;
            sbyte sbyteOne = 1;
            short shortOne = 1;
            int intOne = 1;
            long longOne = 1;
            float floatOne = 1.543f;
            double doubleOne = 2345.76534d;
            decimal decimalOne = 627637263.36263726372M;
            char charOne = 'A';
            bool boolOne = true;
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MaxValue);
        }
        /*  static void Main(string[] args)
          {
              QuestionOne();
          }*/

        /***

          * What are Global variables, and what are local variables? Give an example

          * Variables Declared at the class level are global Variables.

          * Global Variables can be accessed in all the methods of the class.

          * Local Variables are declared with in a method.

          * The scope of the local Variable is limited to the block in which it is declared

          */
        // Global Variable
        int x = 0;
        public void QuestionTwo()
        {
            // Local Variable
            int y = 100;
            Console.WriteLine($"Global Variable x={x}");
            Console.WriteLine($"Local Variable y={y}");
        }
        /*      public static void Main(string[] args)
              {
                  Answers myObject = new Answers();
                  myObject.QuestionTwo();

              }*/
        /*3. String strFriends = "Tom and Jerry are good friends";
        a. Write a function that can count the words in a string */

        public static void QuestionThreeA()
        {
            string strFriends = "Tom and Jerry are good friends"; string[] words = strFriends.Split(" ");
            int wordCount = words.Length;
            Console.WriteLine($"Word Count {wordCount}");
        }
        // c. Write a function that counts the no of characters in the string 
        public static void QuestionThreeC()
        {
            string strFriends = "Tom and Jerry are good friends";
            Console.WriteLine($"Char Count: {strFriends.Length} ");
        }
        // d.Change the string to Uppercase and print
        public static void QuestionThreeD()
        {
            string strFriends = "Tom and Jerry are good friends";
            string strInUpper = strFriends.ToUpper();
            Console.WriteLine(strFriends);
            Console.WriteLine(strInUpper);
        }
        // e.Print from 10th char to the 15th char
        public static void QuestionThreeE()
        {
            string strFriends = "Tom and Jerry are good friends";
            string strPart = strFriends.Substring(10, 5);
            Console.WriteLine(strFriends);
            Console.WriteLine(strPart);
        }


    }
}