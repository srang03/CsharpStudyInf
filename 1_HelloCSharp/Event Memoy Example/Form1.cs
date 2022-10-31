using System;
using System.Windows.Forms;

namespace Event_Memoy_Example
{
    public partial class Form1 : Form
    {
        Device _device;
        ConnectView connectView;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._device = new Device();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            BindControlView();
        }

        private void BindControlView()
        {
            this.panel1.Controls.Clear();

            if (connectView == null)
            {
                connectView = new ConnectView();
                connectView.OnDeviceFromForm += ConnectView_OnDeviceFromForm;
                connectView.OnDevice += ConnectView_OnDevice;

                this.Controls.Add(connectView);
                connectView.Dock = DockStyle.Fill;
            }
        }

        private void ConnectView_OnDevice()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.Add(new Label() { Dock = DockStyle.Fill, Text= "The End" });
                }));
                if (connectView != null)
                {
                    this.Invoke
                        (new Action(() =>
                        {
                            connectView.Dispose();
                            connectView = null;
                        }));
                }
            }
        }

        private Device ConnectView_OnDeviceFromForm()
        {
            return this._device;
        }

    }
}
