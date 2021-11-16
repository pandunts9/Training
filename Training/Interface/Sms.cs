using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Sms : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Sms sended!");
        }
    }
}
