using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Courier:Employee,ICarType
    {
        public Courier(string name,string lastName ) :base(name,lastName)
        {

        }
        public override void Work()
        {
            Console.WriteLine("I deliver the product!");
        }
        public new void GetFullName()
        {
            base.GetFullName();
        }
        public new void GetCarType()
        {
            Console.WriteLine("Mercedes");
        }
        public new void GetInfo()
        {
            Console.WriteLine("Courier");
        }
    }
}
