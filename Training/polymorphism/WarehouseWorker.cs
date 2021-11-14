using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class WarehouseWorker : Employee
    {
        public override void Work()
        {
            Console.WriteLine("I sort the product ");
        }
    }
}
