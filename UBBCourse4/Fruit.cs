using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBBCourse4
{
    public abstract class Fruit
    {
        public string Name { get; private set; }

        private void Grow()
        {
            Console.WriteLine("Fruits are growing...");
        }

        protected bool Float()
        {
            Console.WriteLine("Floating ... or not... ");
            return false;
        }

        public string PublicFruit()
        {
            return "public fruit";
        }

        public abstract bool isFloating();
    }
}
