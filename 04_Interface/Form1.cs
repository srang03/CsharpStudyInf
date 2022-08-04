using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Interface
{
    public partial class Form1 : Form
    {
        Worker1 w1;
        Worker2 w2;
        Worker3 w3;

        public Form1()
        {
            InitializeComponent();
            w1 = new Worker1();
            w2 = new Worker2();
            w3 = new Worker3();

            w2.OnFull += OnFull_Event;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w1.Send(w3 as IWorker);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnFull_Event()
        {
            Console.WriteLine("callback");
        }
    }
}
