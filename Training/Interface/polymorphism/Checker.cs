using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Checker:Employee,IInfo
    {
        public Checker(string name,string lastName) :base(name,lastName)
        {

        }
        public override void Work()
        {
            Console.WriteLine("I check the count of product!");
        }
        public new void GetInfo()
        {
            Console.WriteLine(" Checker!");
        }
    }
}
