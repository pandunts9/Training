using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class WarehouseWorker : Employee,IInfo
    {
        public WarehouseWorker(string name, string lastName ) : base(name, lastName)
        {

        }
        public override void Work()
        {
            Console.WriteLine("I sort the product ");
        }
        public new void GetInfo()
        {
            Console.WriteLine("WarehouseWorker");
        }
    }
}
