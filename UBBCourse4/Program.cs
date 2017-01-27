using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBBCourse4
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple myApple = new Apple(40, "Golden");
            Console.WriteLine(myApple.Name);
            Console.WriteLine(myApple.Fibres);

            // myApple.Float(); is protected and canoot be invoked
            // myApple.Grow(); is private and cannot be  invoked
            // myApple.Fibres = 10; can't be modified from here
            // myApple.Name = ""; can't access from here

            Console.WriteLine(myApple.PublicFruit()); // public inherited class can be invoked
            Console.WriteLine(myApple.isFloating());
            Console.ReadKey();

        }
    }
}
