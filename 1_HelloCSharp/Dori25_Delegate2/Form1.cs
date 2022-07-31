using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori25_Delegate2
{
    public partial class Form1 : Form
    {
        Timer timer;
        frmPizza fPizza;
        delegate int dOrder(int iOrder);
        delegate int dOrderOption(int iOrder, string strOption);
        int iTotal;
       
        public Form1()
        {
            InitializeComponent();
            iTotal = 0;
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            dOrder dfOrderDow = null;
            dOrderOption dfOrderOption = null;
            Dictionary<string, int> dOrderDictionary = new Dictionary<string, int>();

            int iOrderDow = 0;
            int iOrderEdge = 0;
            if (this.radiobtn_original.Checked)
            {
                iOrderDow = 1;
                dOrderDictionary.Add("오리지널", 1);
            }
            else if (this.radiobtn_thin.Checked)
            {
                iOrderDow = 2;
                dOrderDictionary.Add("씬", 1);
            }

            dfOrderDow = fOrderDow;
            fCallbackOrder(iOrderDow, dfOrderDow);

            if (this.radiobtn_ricigold.Checked)
            {
                iOrderEdge = 1;
                dOrderDictionary.Add("리치골드", 1);
            }
            else if (this.radiobtn_cheese.Checked)
            {
                iOrderEdge = 2;
                dOrderDictionary.Add("치즈크러스트", 1);
            }

            dfOrderDow = fOrderEdge;
            fCallbackOrder(iOrderEdge, dfOrderDow);

            
            if (this.checkbx_1.Checked)
            {
                dfOrderOption += GetOption1;
                dOrderDictionary.Add("소시지", (int)this.numericUpDown1.Value);
            }
            if (this.checkbx_2.Checked)
            {
                dfOrderOption += GetOption2;
                dOrderDictionary.Add("감자", (int)this.numericUpDown1.Value);
            }
            if (this.checkbx_3.Checked)
            {
                dfOrderOption += GetOption3;
                dOrderDictionary.Add("치즈", (int)this.numericUpDown1.Value);
            }

            dfOrderOption((int)this.numericUpDown1.Value, "옵션");
         ;

            fFormLoading(dOrderDictionary);
        }

        private void fFormLoading(Dictionary<string, int> dOrderDictionary)
        {
            if(fPizza != null){
                fPizza.Dispose();
            }
            fPizza = new frmPizza();
            fPizza.eventDelPizzaComplete += fPizza_eventdelPizzaComplete;
            fPizza.Show();

            fPizza.fPizzaCheck(dOrderDictionary);

            //timer = new Timer();
            //timer.Interval = 1000;
            //timer.Tick += _timerTick;
            //timer.Start();
        }
        //private void _timerTick(object sender, EventArgs e)
        //{
        //    if (fPizza.OrderComplete)
        //    {

        //    }
        //}

        private int fPizza_eventdelPizzaComplete(string strResult, int iTime)
        {
            this.listBox1.Items.Add($"[{strResult}] 걸린시간 {iTime}초 총 가격: {iTotal}");
            return 0;
        }

        private int GetOption1(int iEA, string strOption)
        {
            int price = iEA * 2000;
            ShowMessage($"(옵션) 소시지(2000) {iEA}개 선택 완료");
            return iTotal += price;
        }

        private int GetOption2(int iEA, string strOption)
        {
            int price = iEA * 500;
            ShowMessage($"(옵션) 감자(500) {iEA}개 선택 완료");
            return iTotal += price;
        }

        private int GetOption3(int iEA, string strOption)
        {
            int price = iEA * 1000;
            ShowMessage($"(옵션) 치즈(1000) {iEA}개 선택 완료");
            return iTotal += price;
        }

        private int fOrderDow(int iOrderDow)
        {
            int iPrice = 0;
            string strMessage = string.Empty;
            switch (iOrderDow)
            {
                case 1:
                    strMessage = "(도우) 오리지널을 선택하셨습니다. (10,000원)";
                    iPrice = 10000;
                    break;
                case 2:
                    strMessage = "(도우) 씬을 선택하셨습니다. (12,000원)";
                    iPrice = 12000;
                    break;
                case 0:
                    strMessage = "도우를 선택해주세요";
                    break;
            }
            ShowMessage(strMessage);
            return iTotal += iPrice;
        }

        private int fOrderEdge(int iOrderEdge)
        {
            int iPrice = 0;
            string strMessage = string.Empty;
            switch (iOrderEdge)
            {
                case 1:
                    strMessage = "(엣지) 리치골드을 선택하셨습니다. (2,000원)";
                    iPrice = 2000;
                    break;
                case 2:
                    strMessage = "(엣지) 치즈크러스트를 선택하셨습니다. (3,000원)";
                    iPrice = 3000;
                    break;
                case 0:
                    strMessage = "엣지를 선택해주세요";
                    break;
            }
            ShowMessage(strMessage);
            return iTotal += iPrice;
        }

        private void fCallbackOrder(int iOrder, dOrder dOrder)
        {
            dOrder(iOrder);
        }

        private void ShowMessage(string Strmssage)
        {
            this.listBox1.Items.Add(Strmssage);
        }
    }
}
