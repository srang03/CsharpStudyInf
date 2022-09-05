using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DelegateEvent
{
    public class Worker : IWorker
    {
        public delegate void delCount(int count);
        public event delCount OnCount;
        private int _iCount;

        public int Count 
        {
            get { return this._iCount; } 
            private set { this._iCount = value; }
        }

        public Worker()
        {
            _iCount = 0;
        }
        public void Receive()
        {
            Count += 1;
            if(OnCount != null)
            {
                OnCount(Count);
            }
        }
    }
}
