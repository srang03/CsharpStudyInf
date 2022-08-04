using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EventReview2
{
    internal class Worker1
    {
        public void send(Worker2 w2)
        {
            w2.Receive();
        }
    }
}
