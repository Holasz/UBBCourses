using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject
{
    public class Mercedes : AbstractCar
    {
        //public fields - visible
        //public – accessible from any class
        public string Description;
        public int Price;
        public int yearOfConstruction;
        public string fuelType;

        // private fields
        // private – accessible from the class itself only
        private string _name;
        private string _description ;
        private int _price;

        // protected fields
        // protected – accessible from the class itself and all its descendent classes
        protected string ProtectedName;
        protected string ProtectedDescription;

        // internal fields
        // internal – accessible from the current assembly (used by default)
        protected string InternalNameName;
        protected string InternalDescription;

        public struct EngineStruct
        {
            public decimal engineType;
            public string engineCode;
            public string engineName;
        }

        // default constructor
        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
            yearOfConstruction = 2014;
            fuelType = "type1";

            _name = "private Mercedes Benz name";
            _description = " private description";
            _price = 0;

            ProtectedName = "protected name";
            ProtectedDescription = "protected description";
        }

        // construstor cu parametrii
        public Mercedes( string name, int year, string fuel)
        {
            this._name = name;
            this.yearOfConstruction = year;
            this.fuelType = fuel;
        }

        public string StartEngine()
        {
            return "Engine started!";
        }

        public string StartEngine(int timeToStartEngine)
        {
            return "The car is starting in " + timeToStartEngine +  " milliseconds";
        }


        public int ShowRemainingNoOfKM(int noOfFuelLiters, int Consumption)
        {
            Console.WriteLine("Remaining km: " );
            int remainingNoOfKMrs = noOfFuelLiters / Consumption * 100;

            return remainingNoOfKMrs;
        }

        public int ReturnRemainingNoOfKM()
        {
            Console.WriteLine("Enter No. of fuel Liters:");
            int noOfFuelLiters = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Consumption:");
            int Consumption = int.Parse(Console.ReadLine());
            int remaningKm = noOfFuelLiters / Consumption * 100;
            Console.WriteLine("Remaining km: "  );
            return remaningKm;
        }

        //CalculateConsumption method that takes variable number of parameters
        public double CalculateConsumption(params int[] kms)
        {
            double sum = 0;
            foreach (int km in kms)
                sum += km;
            Console.WriteLine("Calculated Consumption is: ");
            return sum / 100 * 7;
        }

    }
}
