using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DelegateEvent
{
    internal class Work1
    {
        public void Send(IWork work)
        {
            work.Receive(); 
        }
    }
}
