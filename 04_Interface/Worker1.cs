using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Interface
{
    internal class Worker1
    {
        public void Send(IWorker w2)
        {
            w2.Receive();
            //w2.re(); // 인터페이스에 정의되어 있지 않는 함수를 사용할 수 없다.
        }
    }
}
