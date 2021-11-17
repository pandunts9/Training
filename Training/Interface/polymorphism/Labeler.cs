using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Labeler : Employee,IInfo
    {
        public Labeler(string name, string lastName) : base(name, lastName)
        {

        }
        public override void Work()
        {
            Console.WriteLine("I put labels on the bottle!");
        }
        public new void GetFullName()
        {
            base.GetFullName();
        }
        public new void GetInfo()
        {
            Console.WriteLine("Labeler!");
        }
    }
}
