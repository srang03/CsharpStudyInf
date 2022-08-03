using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate
{
    internal class CWorker1
    {
        public void Send(CWorker2 worker)
        {
            worker.receive();
        }
    }
}
