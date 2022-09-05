using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DelegateEvent
{
    class Work2 : IWork
    {
        public delegate int DelIntCount(int count);
        public event DelIntCount OnGetIntCount;
        int count;

        public Work2()
        {
            this.count = 0;
        }

        public void Receive()
        {
            count++;
            if(count % 5 == 0)
            {
                OnGetIntCount(count);
            }
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
