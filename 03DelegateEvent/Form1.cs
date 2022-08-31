using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03DelegateEvent
{
    public partial class Form1 : Form
    {
        Worker1 w1;
        Worker2 w2;

        public Form1()
        {
            InitializeComponent();

            w1 = new Worker1();
            w2 = new Worker2();
            w2.onFull += W2_onFull;
            w2.onFull2 = W2_onFull;
        }

        private void W2_onFull(int count)
        {

            Console.WriteLine($"이벤트 발생 : {count}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w1.Send(w2);
        }
    }
}
