using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskReview
{
    public partial class Form1 : Form
    {
        delegate bool delCancel();
        event delCancel OnCancel;
        

        private bool isStop;

        public Form1()
        {
            isStop = false;

            InitializeComponent();
            this.OnCancel += Form1_OnCancel;
        }

        private bool Form1_OnCancel()
        {
            return isStop;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await ReadRun();
        }
        public void Cancel() {
            isStop = true;
        }


        private async Task ReadRun()
        {
            if (!isStop)
            {
                Task t1 = Task.Run(() => { ReadDevice(); });
                await t1;
                Task t2 = Task.Run(() => { ReadStorage(); });
                await t2;
            }
        }

        private void ReadDevice()
        {
            var isReDevice = false;
            Console.WriteLine("ReadDevice Task Start");
            int count = 0;
            do
            {
                count += 1;
                Thread.Sleep(1000);
                Console.WriteLine($"ReadDevice Reading {count}");
                if (count == 3)
                {
                    isReDevice = true;
                }
                isReDevice = OnCancel.Invoke();
            } while (!isReDevice);
            Console.WriteLine("ReadDevice Task End");
        }

        private void ReadStorage()
        {
            var isReadStorage = false;
            Console.WriteLine("ReadStorage Task Start");
            int count = 0;
            do
            {
                count += 1;
                Thread.Sleep(1000);
                Console.WriteLine($"ReadStorage Reading {count}");
                if (count == 3)
                {
                    isReadStorage = true;
                }
                isReadStorage = OnCancel.Invoke();
            } while (!isReadStorage);
            Console.WriteLine("ReadStorage Task End");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
