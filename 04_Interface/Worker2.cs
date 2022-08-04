using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Interface
{
    internal class Worker2: IWorker
    {
        int iCount = 0;
        public delegate void delWorkFull();
        public event delWorkFull OnFull;

        public void Receive()
        {
            iCount += 1;
            Console.WriteLine($"Receviced: {iCount}");
            if(iCount % 5 == 0)
            {
                if(OnFull != null)
                {
                    OnFull();
                }
                else
                {
                    Console.WriteLine("이벤트를 등록해주세요");
                }
            }
        }

        public void re()
        {
            return;
        }

 
    }
}
