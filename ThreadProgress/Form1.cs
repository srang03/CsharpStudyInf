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

namespace ThreadProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressbar_proceeding()
        {
            Random rd = new Random();

            var iVar = 0;
            this.progressBar1.Value = 0;
            while (this.progressBar1.Value < 100) { 
                if (this.progressBar1.InvokeRequired)
                {
             this.progressBar1.Invoke(new Action(delegate ()
            {

                iVar = rd.Next(1, 11);
                if (this.progressBar1.Value + iVar < 100)
                {
                    this.progressBar1.Value += iVar;
                }
                else
                {
                    this.progressBar1.Value = 100;
                }
                this.lbl_progress.Text = $"진행도 : {this.progressBar1.Value}%";

            }));
                
        }
            Thread.Sleep(300);
    }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(progressbar_proceeding));
            t1.Start();
        }

        private void InvokeProgress()
        {
            //this.progressBar1.Invoke(new Action(delegate (){ progressbar_proceeding(); }));
            this.progressBar1.Invoke(new MethodInvoker(()=> { progressbar_proceeding(); }));
        }
    }
}
