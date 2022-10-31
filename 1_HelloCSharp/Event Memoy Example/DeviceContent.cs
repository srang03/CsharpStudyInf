using System;
using System.Runtime.Remoting.Contexts;

namespace Event_Memoy_Example
{
    public class DeviceContent
    {
        public string _content;
        public int _set;

        public DeviceContent()
        {
            _content = "created";
            Random rd = new Random();
            var temp = rd.Next(1, 100);
            for (int i = 0; i < 100; i++)
            {
                if (temp == i)
                {
                    _set = i;
                    break;
                }
            }
        }
    }
}
