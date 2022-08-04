using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_.InterfaceEvent
{
    // 플러그인
    internal class Worker3 : INotify
    {
        public event DelOnNotify OnNotify;

        public Worker3()
        {
            // 이벤트 발생
            
        }
        public void working3()
        {
            if(OnNotify != null)
            {
                OnNotify();
            }
            else
            {
                Console.WriteLine("이벤트가 연결되지 않았습니다.");
            }
        }
    }
}
