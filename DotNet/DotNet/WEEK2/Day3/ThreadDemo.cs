using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Training.WEEK2.Day3
{
    internal class ThreadDemo
    {
        public static void DemoCurrentTh()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID="+id);
            Console.WriteLine("IsAlive=" + t1.IsAlive);
            Console.WriteLine("Priority="+t1.Priority);
            Console.WriteLine("ThreadState="+t1.ThreadState);
            Console.WriteLine("CurentCulture="+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture="+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture="+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
