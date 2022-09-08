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

namespace AsyncAwaitExcerise0908
{
    public partial class Form1 : Form
    {
        ListUp listUp;
        uint icount;
        public Form1()
        {
            InitializeComponent();
            icount = 0;
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            listUp = new ListUp();
            listUp.Show();

            await Task.Run(() =>
            {
                Scan();
            });
            Console.WriteLine("분석 종료");

        }

        private void Scan()
        {
            Random rd = new Random();

            for(int i = 0; i < 1_000; i++)
            {
                uint uiData = Convert.ToUInt32((i * (100 / 10) * 2 * 2) + rd.Next(1, 11));
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.lbx_listup.Items.Add(uiData + 1);
                        this.lbx_listup.SelectedIndex = this.lbx_listup.Items.Count - 1;
                        this.lbx_listup.SelectedIndex = -1;
                    }));
                    if (uiData % 2 != 0)
                    {
                        listUp.GetAnomolyDataFromView(uiData);
                    }
                }
                icount += 1;
                this.Invoke(new Action(delegate ()
                {
                    this.lbl_count.Text = icount.ToString();
                }));
              
                listUp.GetDataFromView(uiData, icount);
            }

            Console.WriteLine("분석 완료");
        }
    }
}
