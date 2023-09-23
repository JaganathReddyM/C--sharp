using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                //No need to call in Program.cs 
namespace DotNet.WEEK1.Day1
{
    internal class Calculater
    {
        public static int Add(int p1, int p2)   // Parameters
        {
            return p1 + p2;
        }
        public static int Divide(int p1, int p2)
        {
            return p1 / p2;
        }
        public static int Multiply(int p1, int p2)
        {
            return p1 * p2;
        }
        public static int Subtract(int p1, int p2)
        {
            return p1 - p2;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Value for First Parameter");
            String x = Console.ReadLine();
            Console.WriteLine("Enter Value for second  Parameter");
            String y = Console.ReadLine();

            int firstvalue = int.Parse(x);
            int secondvalue = int.Parse(y);

            int addresult = Calculater.Add(firstvalue, secondvalue);
            Console.WriteLine(addresult);

            int divideResult = Calculater.Add(firstvalue, secondvalue);
            Console.WriteLine(divideResult);

            int multiplyresult = Calculater.Add(firstvalue, secondvalue);
            Console.WriteLine(multiplyresult);

            int subresult = Calculater.Add(firstvalue, secondvalue);
            Console.WriteLine(subresult);

            addresult = Calculater.Add(10, 20);
            Console.WriteLine(addresult);
            addresult = Calculater.Add(100, 25);
            Console.WriteLine(addresult);
        }
    }
}
