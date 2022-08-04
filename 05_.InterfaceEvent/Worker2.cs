using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_.InterfaceEvent
{
    public class Worker2 : IWorker
    {
        public delegate void delFull();
        public event delFull OnFull;
        int iCount = 0;
        public void Receive()
        {
            iCount += 1;
            Console.WriteLine($"Received: {iCount}");

            if (iCount % 5 == 0)
            {
                if (OnFull != null)
                {
                    OnFull();
                }
                else
                {
                    Console.WriteLine("이벤트를 등록해주세요.");
                }
            }
        }
    }
}
