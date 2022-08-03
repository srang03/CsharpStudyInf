using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Delegate
{
 
    public partial class Form1 : Form
    {
        CWorker1 worker1;
        CWorker2 worker2;
        public Form1()
        {
            InitializeComponent();

            worker1 = new CWorker1();
            worker2 = new CWorker2();
            //worker2.OnFull += CallEvent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker1.Send(worker2);
            
        }

        private void CallEvent()
        {
            Console.WriteLine("이벤트 발생2");
        }
    }
}
