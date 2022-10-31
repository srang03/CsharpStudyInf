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

namespace TaskTokenCancelation
{
    public partial class DeviceConnection : UserControl
    {
        CancellationTokenSource cts = null;
        CancellationToken token;
        bool isReadDevice = false;
        bool isReadInternalStorage = false;
        public DeviceConnection()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
        }

        public void DeviceConnectionCancel()
        {
            cts.Cancel();
        }

        private void DeviceConnection_Load(object sender, EventArgs e)
        {

        }

        public void RunDeviceConnection()
        {
            token = cts.Token;
            Task.Run(async () =>
            {
                await ReadDevice();
                await ReadInternalStorage();
            }, token);
        }

        private async Task ReadDevice()
        {
           
            Console.WriteLine("ReadDevice Start");
            do
            {
                if (cts.IsCancellationRequested)
                {
                    break;
                }
                await Task.Delay(1000);
                Console.WriteLine("ReadDevice Running...");
            } while (!isReadDevice);
                Console.WriteLine("ReadDevice End");
        }

        private async Task ReadInternalStorage()
        {
           
            Console.WriteLine("ReadInternalStorage Start");
            do
            {
                if (cts.IsCancellationRequested)
                {
                    break;
                }
                await Task.Delay(2000);
                Console.WriteLine("ReadInternalStorage Running...");
            } while (!isReadInternalStorage);
            Console.WriteLine("ReadInternalStorage End");
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            isReadDevice = true;
        }
    }
}
