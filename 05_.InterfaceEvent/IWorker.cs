using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_.InterfaceEvent
{
    // C#에 인터페이스에서 Event 추가 가능
    public delegate void DelOnNotify();
    

    public interface IWorker
    {
        void Receive();
    }

    public interface INotify
    {
        event DelOnNotify OnNotify;
    }
}
