using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Memoy_Example
{


    public partial class ConnectView : UserControl
    {
        public delegate Device delDeviceFromForm();
        public delegate void delDevice();
        public event delDeviceFromForm OnDeviceFromForm;
        public event delDevice OnDevice;

        public ConnectView()
        {
            InitializeComponent();
        }

        private void ConnectView_Load(object sender, EventArgs e)
        {
            InitConnect();
        }

        private void InitConnect()
        {
            Thread.Sleep(2000);
            var device = OnDeviceFromForm?.Invoke();
            device.DeviceName = "삼성 겔럭시";
            device.GetContnt();
            OnDevice?.Invoke();
        }
    }
}
