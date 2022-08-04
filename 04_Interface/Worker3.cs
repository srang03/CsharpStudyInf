using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Interface
{
    internal class Worker3 : IWorker
    {
        int iPass = 100;
        public void Receive()
        {
            Console.WriteLine($"receive {iPass}");
        }
    }
}
