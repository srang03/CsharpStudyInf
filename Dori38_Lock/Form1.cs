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

namespace Dori38_Lock
{
    public partial class Form1 : Form
    {
        Thread T1;
        Thread T2;
        object RoomLock = new object();
        object RoomLock2 = new object();

        int iRoom1Count = 1;
        int iRoom2Count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_room1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add($"Room 1 : {iRoom1Count}번 예약");
            T1 = new Thread(new ParameterizedThreadStart(Run));
            T1.Start(iRoom1Count);
            iRoom1Count += 1;
        }

        private void btn_room2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Add($"Room 2 : {iRoom2Count}번 예약");
            T1 = new Thread(new ParameterizedThreadStart(Run2));
            T1.Start(iRoom2Count);
            iRoom2Count += 1;
        }

        private void Run(object obj)
        {
           
            lock (RoomLock)
            {
                InvokeFunction(this.textBox1, $"Room 1 : {obj}번 사용 중");
                for (int i = 0; i<5; i++)
                {
                    if (this.InvokeRequired)
                    {
                         Invoke(new Action(delegate {
                             listBox3.Items.Add($"Room 1 : {iRoom1Count}번 ... {i} sec ");

                    }));
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                }
            }
            InvokeFunction(this.textBox1, string.Empty);
            Thread.Sleep(1000);
        }

        private void InvokeFunction(TextBox textbox, string str)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action(delegate
                {
                    textbox.Text = str;
                }));
            }
        }

        private void Run2(object obj)
        {

            lock (RoomLock)
            {
                InvokeFunction(this.textBox1, $"Room 2 : {obj}번 사용 중");
                for (int i = 0; i < 5; i++)
                {
                    if (this.InvokeRequired)
                    {
                        Invoke(new Action(delegate {
                            listBox3.Items.Add($"Room 2 : {iRoom2Count}번 ... {i} sec ");

                        }));
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                }
            }
            InvokeFunction(this.textBox1, string.Empty);
            Thread.Sleep(1000);
        }

    }

}
