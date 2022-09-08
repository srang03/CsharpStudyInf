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

namespace DisposeAndNullAndThread
{
    public partial class ConnectWorkUserControl : UserControl
    {
        public bool IsRead;
        public bool IsReadInternalStorage;
        public Thread thread1;
        public Thread thread2;
        public ConnectWorkUserControl()
        {
            InitializeComponent();
            IsRead = false;
            IsReadInternalStorage =false;
        }

        private void ConnectWorkUserControl_Load(object sender, EventArgs e)
        {
            thread1 = new Thread(() =>
            {
                bool _isConnected = false;

                try
                {
                    do
                    {
                        Thread.Sleep(1000);
                        _isConnected = ReadDevice();
                    } while (!_isConnected);
                }
                catch (ThreadInterruptedException t1)
                {
                    Console.WriteLine($"t1 스레드 종료: {t1.Message} -{thread1.Name}");
                    return;
                }


               

            });

            thread2 = new Thread(() => {
                bool _isInternalStorageConnected = false;
                try
                {
                    do
                    {
                        Thread.Sleep(1000);
                        _isInternalStorageConnected = ReadInternalStorage();
                    } while (!_isInternalStorageConnected);
                }
                catch (ThreadInterruptedException t2)
                {
                    Console.WriteLine($"t2 스레드 종료: {t2.Message} -{thread2.Name}");
                    return;
                }
            });

            thread1.Start();
            thread2.Start();
      
            //thread.Join();
        }

        private bool ReadDevice()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => { this.listBox1.Items.Add("연결 중 : " + i.ToString()); }));
                }
            }
            return IsRead;
        }

        private bool ReadInternalStorage()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => { this.listBox1.Items.Add("Internal Storage 찾는 중 : " + i.ToString()); }));
                }
            }
            return IsReadInternalStorage;
        }
    }
}
