using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{

    public interface IMessage
    {
        void SendMessage();
    }
    public class Notification
    {
        private IMessage _iMessage;
        
        public Notification(IMessage anyMessage)
        {
            _iMessage = anyMessage;
        }
        public void DoNotify()
        {
            _iMessage.SendMessage();
        }
       
    }
}
    