using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class MyBase
    {
        public string myPublicFild;
        protected string myProtectedFild;
        private string myPrivateFild;
        public MyBase()
        {
                
        }
        public MyBase(string myPublicFild)
        {
            this.myPublicFild = myPublicFild;
        }

    }
}
