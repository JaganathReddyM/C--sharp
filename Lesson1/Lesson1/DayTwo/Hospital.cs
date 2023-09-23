using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayTwo
{
    internal class Hospital
    {
        public string HospitalName { get; set; }=string.Empty;
        public string Located { get; set; } = string.Empty;
        public int Patients { get; set; }
        public int PatientRooms { get; set; }
        public int Id { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string PatientDisease { get; set; } = string.Empty;
        public int CabinNumber { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"ID:{this.Id}, PatientName:{PatientName} ,PatientDisease:{PatientDisease},\n" +
                $"Address:{Address},HospitalPlace:{Located},  \n" +
                $"Phone:{Phone}, CabinNumber:{CabinNumber}, Age{Age}";
        }
        internal class TestHospital
        {
            public static void TestOne()
            {
                Hospital details = new Hospital();
                details.Id = 1;
                details.PatientName = "Jaganath";
                details.Address = "Kurnool";
                details.Located = "Nandyal";            
                details.Phone = 934780833L;
                details.PatientDisease = "Covid";
                details.CabinNumber= 6;
                String value = details.ToString();
                Console.WriteLine(value);


            }
        }

    }
}
