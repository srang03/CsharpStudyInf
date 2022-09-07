using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Dori25_Delegate2
{
    public partial class frmPizza : Form
    {
        public delegate int delPizzaComplete(string strResult, int iTime); // Delegate 선언
        public event delPizzaComplete eventDelPizzaComplete; // 이벤트 선언
        private bool bOrderComplete;
        public bool OrderComplete { get { return bOrderComplete; } }
        public frmPizza()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close(); // 폼 닫기
        }

        public void fPizzaCheck(Dictionary<string, int> dOrderDictionary)
        {
            int iTotal = 0;
            foreach(KeyValuePair<string,int> order in dOrderDictionary)
            {
                bOrderComplete = false;
                int iTotalTime = 0;
                int iTime = 0;
                int iCOunt = order.Value;
                string strType = string.Empty;
                switch (order.Key)
                {
                    case "오리지널":
                        iTime = 3000;
                        strType = "도우";
                        break;
                    case "씬":
                        iTime = 3500;
                        strType = "도우";
                        break;
                    case "리치골드":
                        iTime = 2000;
                        strType = "엣지";
                        break;
                    case "치즈크러스트":
                        iTime = 1500;
                        strType = "엣지";
                        break;
                    case "소시지":
                        iTime = 80;
                        strType = "토핑";
                        break;
                    case "감자":
                        iTime = 30;
                        strType = "토핑";
                        break;
                    case "치즈":
                        iTime = 20;
                        strType = "토핑";
                        break;
                }
                iTotalTime = iTime * iCOunt;
                iTotal += iTotalTime;
                ShowMessage($"({strType}) {order.Key} : {iTotalTime}초, {iCOunt}");
                Thread.Sleep(1000);
                this.Refresh();
            }
            int i = 0;
  
            int result = eventDelPizzaComplete("Pizza 완성 완료", iTotal);
            bOrderComplete = true;
            if (result == 0)
            {
                ShowMessage("정상 주문 완료");
            }
            else
            {
                ShowMessage("주문 실패");
            }
        }

        private void ShowMessage(string strMessage)
        {
            this.listbx_result.Items.Add(strMessage);
        }
    }
}
