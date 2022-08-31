using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DelegateEvent
{
    public class Worker2
    {
        int count;
        public delegate void delFull(int count);
        public event delFull onFull;

        public delFull onFull2;

        public Worker2()
        {
            count = 0;
        }
        public void Receive()
        {
            count++;
            Console.WriteLine(count);
            if(count % 5 == 0)
            {
                if(onFull != null)
                {
                    onFull(count);
                    onFull2(count);
                }
            }
        }
    }
}
