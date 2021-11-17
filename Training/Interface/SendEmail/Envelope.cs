using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    
    public class Envelope:IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Envelope sended!");
        }
    }
}
