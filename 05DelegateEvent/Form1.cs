using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05DelegateEvent
{
    public partial class Form1 : Form
    {
        Worker worker;
        CWorker3 w3;
        public Form1()
        {
            InitializeComponent();
            worker = new Worker();
            worker.OnCount += Worker_OnCount;

            w3 = new CWorker3();
            w3.OnNotify += W3_OnNotify;
        }

        private void W3_OnNotify()
        {
            Console.WriteLine("플러그인 생성");
        }

        private void Worker_OnCount(int count)
        {
            Console.WriteLine(count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send(worker as IWorker);
            w3.Test();
                
        }

        private void Send(IWorker worker)
        {
            worker.Receive();
        }
    }
}
