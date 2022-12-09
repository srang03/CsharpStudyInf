using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace USBConnection
{
    public partial class Form1 : Form
    {

        public const int WM_DEVICECHANGE = 0x219;
        public const int DBT_DEVTYP_VOLUME = 0x00000002;
        public const int DBT_DEVICEARRIVAL = 0x8000;


        [StructLayout(LayoutKind.Sequential)]
        internal class DEV_BROADCAST_HDR
        {
            public int dbch_size;
            public int dbch_devicetype;
            public int dbch_reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct DEV_BROADCAST_DEVICEINTERFACE
        {
            public int dbcc_size;
            public int dbcc_devicetype;
            public int dbcc_reserved;
            [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 16)]
            public byte[] dbcc_classguid;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public char[] dbcc_name;
        }


        public Form1()
        {
            InitializeComponent();



        }


        protected override void OnClosing(CancelEventArgs e)
        {


            base.OnClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {

            if (m.Msg == WM_DEVICECHANGE) //Device state has changed
            {
                if (m.WParam.ToInt64() == DBT_DEVICEARRIVAL)
                {


                }
            }
            base.WndProc(ref m);
        }

        private static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity where ClassGuid = '{eec5ad98-8080-425f-922a-dabf3de3f69a}'"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("DeviceID"),
                (string)device.GetPropertyValue("ClassGuid"),
                (string)device.GetPropertyValue("PNPDeviceID")
       
                ));
                string[] temp = (string[])device["HardwareID"];

                foreach(var t in temp)
                {
                    Console.WriteLine(t);
                }
            }

            collection.Dispose();
            return devices;
        }

        class USBDeviceInfo
        {
            public USBDeviceInfo(string deviceID, string classGuid, string pNPDeviceID)
            {
                this.DeviceID = deviceID;
                this.ClassGuid = classGuid;
                this.PNPDeviceID = pNPDeviceID;
           
            }
            public string DeviceID { get; private set; }
            public string ClassGuid { get; set; }
            public string PNPDeviceID { get; set; }
            public string[] HardwareID { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usbDevices = GetUSBDevices();

            foreach (var usbDevice in usbDevices)
            {
                Console.WriteLine("Device ID: {0}, Guid: {1}, PNPID: {2}",
                    usbDevice.DeviceID, usbDevice.ClassGuid, usbDevice.PNPDeviceID);
            }
        }
    }
}