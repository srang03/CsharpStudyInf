using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Memoy_Example
{
    public class Device
    {
        int id;
        string deviceName;
        int option;
        public string DeviceName { get { return deviceName; } set { this.deviceName = value; } }
        public int Option { get { return option; } set { this.Option = value; } }

        DeviceContent deviceContent;

        public int GetContnt()
        {
            deviceContent = new DeviceContent();
            return deviceContent._set;
        }
        public Device()
        {
            option = 10;
            id = 223;
        }
    }
}
