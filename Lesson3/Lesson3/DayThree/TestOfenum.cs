using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson3.DayThree
{
    #region
    public enum City { Chennai, Bangalore, Hyderabad,Pune}
    public enum Designation { Manager, Admin, Developer}
    public class TestOfenum
    {
        public readonly int Id;
        public string Name=string.Empty;
        public  City ECity;     // public string Ecity;
        public Designation JobTitle;      // public string JobTitle
        public TestOfenum(int v1) { Id = v1; }
        public override String ToString()
        {
            String output = string.Empty;
            output = $"Details of the employee are:\nEmp Id is: {Id} \nName:{Name} \nCity:{ECity}\n{JobTitle}";
            return output;
        }
    }
#endregion
    class TestEmployee
    {
        public static void TestOne()
        {
            TestOfenum e1 = new TestOfenum(123);
            //e1.eid = 123;
            e1.Name = "Leo";
            e1.ECity = City.Bangalore;   //ecity="chennai";
            e1.JobTitle=Designation.Developer; //edept="Testing";
            String output = e1.ToString();
            Console.WriteLine(output);
        }

    }
    class TestEnum
    {
     public static void TestMovieRating()
        {
            Type t1 = typeof(MovieRating);
            String[] enumNames = Enum.GetNames(t1);
            String name = String.Empty;
            int len = enumNames.Length;
            for (int i = 0; i < len; i++)
            {
                name = enumNames[i];
                MovieRating movies = (MovieRating)Enum.Parse(t1, name);
                Console.WriteLine(name + " " + (int)movies);
            }
        }
    }
}

