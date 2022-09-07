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

namespace LogProject
{
    public partial class Form1 : Form
    {
        LogLib logLib;
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("앱 시작");

            logLib = new LogLib(Application.StartupPath);
            Task t1 = new Task( () =>{  for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i + 1);
            } });
            t1.Start();

            Console.WriteLine("앱 종료");
        }

        private async void btn_logA_Click(object sender, EventArgs e)
        {
            await logLib.CreateLogFileAsnyc("A가 클릭되었습니다.");
        }

        private async void btn_logB_Click(object sender, EventArgs e)
        {
            await logLib.CreateLogFileAsnyc("B가 클릭되었습니다.");
        }

        private async void btn_logC_Click(object sender, EventArgs e)
        {
            await logLib.CreateLogFileAsnyc("C가 클릭되었습니다.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
