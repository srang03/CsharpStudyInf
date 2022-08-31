using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DelegateEvent
{
    public class Worker1
    {
        public void Send(Worker2 w2)
        {
            w2.Receive();
        }
    }
}
