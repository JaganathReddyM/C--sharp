using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK2.Aug29
{
    internal class WorkingWithObjects
    {
        public static void TestOne()
        {
            object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            string stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001; empOne.Name = "Sam";
            Emp empTwo = empOne; //new Emp();
            empTwo.ID = 1001; empTwo.Name = "Sam";
            Emp empThree = empOne;  //new Emp();
            empThree.ID = 1001; empThree.Name = "Sam";
            bool flag = empOne.Equals(empTwo);
            Console.WriteLine(flag);
            flag = empOne.Equals(empThree);
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());
        }
    }

}
/*
using Lesson28.Day28;
using System;

WorkingWithObjects.TestOne();
WorkingWithObjects.TestTwo();
*/
