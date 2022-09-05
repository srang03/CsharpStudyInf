using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DelegateEvent
{
    public delegate void delOnNotify();
   
        
    public interface INotify
    {
        event delOnNotify OnNotify;
    }
}
