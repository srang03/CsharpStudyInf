using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_.InterfaceEvent
{
    public class Worker1
    {
        public void Send(IWorker w)
        {
            w.Receive();
        }
    }
}
