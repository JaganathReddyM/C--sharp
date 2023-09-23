using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   // Helps to import namespace
//int x = 100;

namespace Lesson1.DayTwo    //namespace 
{
    //int y = 200;
    internal class DemoA
    {
        //GLOBAL DECLARATION
        int x = 123;       // Member variable or Class variable or Field
        static int y = 567;
        public static void FirstMethod()    // Static Method
        {
            //LOCAL VARIABLES
           // int x = 2000;
            int y = 5000;
           // Console.WriteLine(x);   // NON STATIC MEMBER can not be accesses
            Console.WriteLine(y);    // LOCAL VARIABLE
            Console.WriteLine(DemoA.y);   // Global Static variable
        }
        int variableA = 0;
        public  void SecondMethod()    // Non-Static Method
        {
            //LOCAL VARIABLES
            // int x = 2000;
            int y = 5000;
            // Console.WriteLine(x);   // NON STATIC MEMBER can not be accesses
            Console.WriteLine(y);    // LOCAL VARIABLE
            Console.WriteLine(DemoA.y);   // Global Static variable
        }
    }
    internal class DemoB
    {

    }
}

namespace Lesson1.Gavs    
{
    internal class DemoA
    {
    }
}

/*
 * using Lesson1.DayTwo;

DemoA.FirstMethod();

// DEmoA.SecondMethod(); WRONG NOT a Static Method
// Create an Object for class DemoA

DemoA demoA_obj = new DemoA();

// calling Non Static method of DemoA using an object Reference

demoA_obj.SecondMethod();
*/