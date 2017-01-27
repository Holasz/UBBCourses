using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MVCProject.Mercedes;

namespace MVCProject
{
    class Program
    {

        static void Main(string[] args)
        {

            Mercedes mercedes = new Mercedes(); // instantiem clasa Mercedes
            EngineStruct engine = new EngineStruct(); // instantiem struct EngineStruct

            // abstract classes cannot be instantiated
            // AbstractCar aCar = new AbstractCar();

            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();

            Console.WriteLine("This is my first C# project!");

            // accesam proprietatile publice ale clasei Mercedes
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);
            Console.WriteLine("Mercedes fuel type is  " + mercedes.fuelType);
            Console.WriteLine("Mercedes year of construction is  " + mercedes.yearOfConstruction);

            // proprietatile private nu sunt vizibile
            /*
            Console.WriteLine("Mercedes is " + mercedes._description);
            Console.WriteLine("Mercedes costs " + mercedes._price);
            */

            // proprietati interne
            /*
            Console.WriteLine("Mercedes is " + mercedes.InternalNameName);
            Console.WriteLine("Mercedes description " + mercedes.InternalDescription);
            */

            // proprietati protected
            /*
            Console.WriteLine("Mercedes is " + mercedes.ProtectedName);
            Console.WriteLine("Mercedes description " + mercedes.ProtectedDescription);
            */

            Console.WriteLine(mercedes.StartEngine());
            Console.WriteLine(mercedes.StartEngine(10));

            Console.WriteLine(mercedes.ShowRemainingNoOfKM(100, 6));

            // showing remaining no of Km by reading values directy as input
            Console.WriteLine(mercedes.ReturnRemainingNoOfKM());

            // CalculateConsumption method that takes variable number of parameters
            Console.WriteLine(mercedes.CalculateConsumption(10,2,5));
            Console.WriteLine(mercedes.CalculateConsumption(100, 56, 3, 12, 5, 69));

            Console.ReadKey();
        }
    }
}
