using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        // Abstract
namespace Lesson1.DayThree
{
    internal abstract class Vehicle
    {
        public Vehicle() { Console.WriteLine("Vehicle Constructor"); }
        public void Start() { Console.WriteLine("Vehicle Started"); }

    }
    // End of Class
    internal class Car : Vehicle
    {
        public Car() { Console.WriteLine("Car Constructor"); }
    }
    class VehicleTester
    {
        public static  void TestOne()
        {
            VehicleTester=new Car();
            tester.Car()
        }
    }
}
