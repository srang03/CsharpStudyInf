using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTokenCancelation
{
    public partial class Form1 : Form
    {
        DeviceConnection _deviceConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            InitationView();
            _deviceConnection.RunDeviceConnection();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if(_deviceConnection != null)
            {
                _deviceConnection.DeviceConnectionCancel();
                _deviceConnection.Dispose();
                _deviceConnection = null;
            }
        }

        private void InitationView()
        {
            this.panel1.Controls.Clear();
            if(_deviceConnection == null)
            {
                _deviceConnection = new DeviceConnection();
                this.panel1.Controls.Add(_deviceConnection);
            }
        }
    }
}
