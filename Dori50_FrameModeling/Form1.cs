using Dori50_FrameModeling.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori50_FrameModeling
{
    public partial class Form1 : Form
    {

        UserControl1 frm1 = new UserControl1();
        ucScreen2 frm2 = new ucScreen2();
        ucScreen3 frm3 = new ucScreen3();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMain.Controls.Add(frm2);
            frm1.eLogSender += Frm_eLogSender;
            frm2.eLogSender += Frm_eLogSender;
        }

        private void Frm_eLogSender(object sender, EventArgs e, Common.enLogLevel eLevel, string strLog)
        {
            Button btn = sender as Button;
            LogPrint(eLevel, $"[{btn.Text}]버튼 클릭");
        }

        private void Button_OnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            LogPrint(enLogLevel.info, $"[{btn.Text}]버튼 클릭");
            switch (btn.Name)
            {
                case "btn_input":
                    pMain.Controls.Clear();
                    pMain.Controls.Add(frm1);
                    break;
                case "btn_chart":
                    pMain.Controls.Clear();
                    pMain.Controls.Add(frm2);
                    break;
                case "btn_config":
                    pMain.Controls.Clear();
                    pMain.Controls.Add(frm3);
                    break;
                case "btn_exit":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void LogPrint(enLogLevel eLevel, string LogDesc)
        {
            DateTime dTime = DateTime.Now;
            string Loginfo = $"DateTime: {dTime:yyyy-MM-dd hh:mm:ss} [{eLevel.ToString()}] {LogDesc}";
            this.listBox1.Items.Insert(0, Loginfo);
        }
    }
}
