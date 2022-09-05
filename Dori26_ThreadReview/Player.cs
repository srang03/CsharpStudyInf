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

namespace Dori26_ThreadReview
{
    public partial class Player : Form
    {
        string _name;
        Thread thread;
        public Player()
        {
            InitializeComponent();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {

        }

        public Player(string strName) : this()
        {
            this._name = strName;
            ThreadStart();
                

        }

        public void ThreadStart()
        {
            thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        private void Run()
        { 
            int iVar = 0;
            Random rd = new Random();

            while(this.progressBar1.Value < 100)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => {
                        iVar = rd.Next(1, 11);
                        if (iVar + this.progressBar1.Value < 100)
                            this.progressBar1.Value += iVar;

                        else
                            this.progressBar1.Value = 100;

                        this.lbl_progress.Text = $"현재 진행률 : {this.progressBar1.Value}%";
                       
                    }));

                    Thread.Sleep(200);
                }
              
            }
        }
    }
}
