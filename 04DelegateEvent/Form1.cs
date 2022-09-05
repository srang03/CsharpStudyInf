using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04DelegateEvent
{
    public partial class Form1 : Form
    {
        Work1 w1;
        Work2 w2;

        public Form1()
        {
            InitializeComponent();
            w1 = new Work1();
            w2 = new Work2();
            w2.OnGetIntCount += W2_OnGetIntCount;
        }

        private int W2_OnGetIntCount(int count)
        {
            Console.WriteLine(count);
            return count + 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w1.Send(w2 as IWork);
        }
    }
}
