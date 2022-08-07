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

namespace Dori24_DelegateReview
{
    public partial class frmPopup : Form
    {
        public delegate int delPizzaComplete(string strResult, int iTime);
        public event delPizzaComplete eventDelPizzaComplete;
        public frmPopup()
        {
            InitializeComponent();
        }
        public frmPopup(Dictionary<string, int> dPizzaOrder)
        {
            InitializeComponent();
        }

        private void frmPopup_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PizzaCheck(Dictionary<string, int> dPizzaOrder)
        {
            int iNowTime = 0;
            int iTotalTime = 0;
            string strMessage = string.Empty;
            foreach(KeyValuePair<string, int> oOrder in dPizzaOrder)
            {
                switch (oOrder.Key)
                {
                    case "오리지널":
                        iNowTime = 3000;
                        strMessage = "도우";
                        break;
                    case "씬":
                        iNowTime = 3500;
                        strMessage = "도우";
                        break;
                    case "리치골드":
                        iNowTime = 1000;
                        strMessage = "엣지";
                        break;
                    case "치즈크러스트":
                        iNowTime = 1200;
                        strMessage = "엣지";
                        break;
                    case "소시지":
                        iNowTime = 50;
                        strMessage = "토핑";
                        break;
                    case "감자":
                        iNowTime = 20;
                        strMessage = "토핑";
                        break;
                    case "치즈":
                        iNowTime = 30;
                        strMessage = "토핑";
                        break;     
                }
                iTotalTime += iNowTime;
                this.lbx_make.Items.Add($"{strMessage} {iNowTime}초");

                Refresh();
                Thread.Sleep(1000);
            }
            eventDelPizzaComplete("생성완료", iTotalTime);
        }
    }
}
