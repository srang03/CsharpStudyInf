using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EventReview2
{
    internal class Worker2
    {
        int iCount = 0;
        public delegate void delFull();
        public event delFull OnFull;
     


        internal void Receive()
        {
            iCount += 1;
            if(iCount % 5 == 0)
            {
                OnFull();
            }
        }
    }
}
