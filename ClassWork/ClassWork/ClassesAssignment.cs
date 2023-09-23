using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assinments
{
    public enum FuelType
    {
        Petrol,
        Diesel,
        Ethanol,
        HydrogenFuel
    }
    internal class Car
    {
        public string RegistrationNo { get; set; }
        public string Model { get; set; }
        public FuelType CarFuelType { get; set; }
        public Wheel[] Wheels { get; }
        public Engine CarEngine { get; }

        public Car(string registrationNo, string model, FuelType fuelType)
        {
            RegistrationNo = registrationNo;
            Model = model;
            CarFuelType = fuelType;
            Wheels = new Wheel[4];
            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
            }
            CarEngine = new Engine();
        }

        public class Wheel
        {
            // Wheel properties 

        }

        public class Engine
        {
            // Engine properties 
        }

        internal static void TestCar()
        {
            throw new NotImplementedException();
        }
    }



    class Testing
    {
        public static void TestCar()
        {
            Car myCar = new Car("7995", "Mercedes Benz", FuelType.Petrol);

            // Accessing inner classes
            Car.Wheel wheel = new Car.Wheel();
            Car.Engine engine = new Car.Engine();

            // Using properties and methods of the Car class
            Console.WriteLine($"Car Registration No: {myCar.RegistrationNo}");
            Console.WriteLine($"Car Model: {myCar.Model}");
            Console.WriteLine($"Car Fuel Type: {myCar.CarFuelType}");
            Console.WriteLine($"Car wheelstype:HCM");
            Console.WriteLine($"Car Engine:v2 510");

            
        }
    }
}