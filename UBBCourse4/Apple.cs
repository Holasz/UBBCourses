using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBBCourse4
{
    public class Apple: Fruit
    {
        public int Fibres { get; private set; }
        // public string Name { get; private set; }
        string name;
        int fibres;
        int weight = 10;
        int volume = 2;

        public Apple()
        {
            // can be invoked here because its public
            base.PublicFruit();

            //base.Grow(); cannot be invoked because private
            base.Float(); // can be invoked because its protected

            name = this.Name; // can be read but not modified here
        }

        public Apple(int fibres, string name)
        {

            Fibres = fibres;
        }

       public override bool isFloating()
        {

            return weight/volume>1 ;
        }
    }
}
