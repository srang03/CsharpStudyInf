using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori24_Delegate
{
    public partial class Form1 : Form
    {
        int iTotalPrice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        delegate int delOrder(int iOrder);
        delegate T delFunc<T>(T i);
        delegate int delOrderTopping(string Order, int iEA);

       

        /// <summary>
        /// 0: 선택안함, 1: 오리지널, 2: 씬 
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fDow(int iOrder)
        {
            int price = 0;
            string message = string.Empty;
            switch (iOrder)
            {
                case 1:
                    message = $"도우는 오리지널을 선택하였습니다. (10,000)";
                    price = 10000;
                    break;
                case 2:
                    message = $"도우는 씬을 선택하였습니다. (11,000)";
                    price = 11000;
                    break;
                case 0:
                    message = $"도우를 선택해주세요.";
                    price = 0;
                    break;
            }
            iListBoxDataBind(message);

            return iTotalPrice = iTotalPrice + price;
        }

        private int fEdge(int iOrder)
        {
            int price = 0;
            string message = string.Empty;
            switch (iOrder)
            {
                case 1:
                    message = "엣지는 리치골드를 선택하였습니다. (3,000)";
                    price = 3000;
                    break;
                case 2:
                    message = "엣지는 치즈크러스트를 선택하였습니다. (2,000)";
                    price = 2000;
                    break;
                case 0:
                    message = "엣지를 선택해주세요";
                    break;
            }
            iListBoxDataBind(message);

            return iTotalPrice = iTotalPrice + price;
        }

        private int fTopping1(string Order,  int iEA)
        {
            string message = string.Empty;
            int price = iEA * 1000;

            message = $"소시지 {iEA}개를 선택하였습니다. ({price})";
            iListBoxDataBind(message);
            return iTotalPrice += price;
        }

        private int fTopping2(string Order, int iEA)
        {
            string message = string.Empty;
            int price = iEA * 800;

            message = $"감자 {iEA}개를 선택하였습니다. ({price})";
            iListBoxDataBind(message);
            return iTotalPrice += price;
        }

        private int fTopping3(string Order, int iEA)
        {
            string message = string.Empty;
            int price = iEA * 2000;

            message = $"치즈 {iEA}개를 선택하였습니다. ({price})";
            iListBoxDataBind(message);
            return iTotalPrice += price;

        }


        private void btn_purchase_Click(object sender, EventArgs e)
        {
            iTotalPrice = 0;
            int iDowOrder = 0;
            int iEdgeOrder = 0;
       
     
            // 도우 호출
            if (this.radiobtn_original.Checked)
            {
                iDowOrder = 1;
            }
            else if (this.radiobtn_thin.Checked)
            {
                iDowOrder = 2;
            }
            else
            {
                iDowOrder = 0;
            }
            

            // 엣지 호출
            if (this.radiobtn_richgold.Checked)
            {
                iEdgeOrder = 1;
            }
            else if (this.radiobtn_cheese.Checked)
            {
                iEdgeOrder = 2;
            }
            else
            {
                iEdgeOrder = 0;
            }
            delOrder delOrder_function = fDow;
            fCallbackDelegate(iDowOrder, delOrder_function);

            delOrder_function = fEdge;
            fCallbackDelegate(iEdgeOrder, delOrder_function);

            delOrderTopping delTopping = null;
            string optionName = string.Empty;
            int optionPrice = 0;
            int optionEA = (int)this.nud_count.Value;
            if (this.checkbx_option1.Checked)
            {
                optionName = this.checkbx_option1.Text.Split(' ')[0];
                optionPrice = 1000;
                delTopping += fTopping1;
            }
            if(this.checkbx_option2.Checked)
            {
                optionName = this.checkbx_option2.Text.Split(' ')[0];
                optionPrice = 800;
                delTopping += fTopping2;
            }
            if (this.checkbx_option3.Checked)
            {
                optionName = this.checkbx_option3.Text.Split(' ')[0];
                optionPrice = 2000;
                delTopping += fTopping3;
            }
            delTopping(optionName, optionEA);
            
            this.listbx_result.Items.Add($"Total 가격은 {iTotalPrice}원 입니다.");
        }

        private int fCallbackDelegate(int i, delOrder delOrder_function)
        {
            return delOrder_function(i);
        }

        private void iListBoxDataBind(string message)
        {
            this.listbx_result.Items.Add(message);
        }
    }
}