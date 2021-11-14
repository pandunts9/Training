using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class MyDerived : MyBase
    {
        public MyDerived(string first,string second):base(first)
        {
            //myPublicFild = "0000";
            myProtectedFild = second;
        }
    }
}
