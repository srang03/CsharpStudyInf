using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori24_DelegateReview
{
    public partial class Form1 : Form
    {
        int iTotalPrice = 0;
        public delegate int delCreate(int iOrder);
        public delegate int delTopping(int iOrder, int iEa);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            iTotalPrice = 0;
            this.listBox1.Items.Clear();
            delTopping delT = null;
            int iDowOrder = 0;
            int iEdgeOrder = 0;

            if (this.rdb_original.Checked)
            {
                iDowOrder = 1;
            }
            else if (this.rdb_thin.Checked)
            {
                iDowOrder = 2;
            }


            if (this.rdb_richgold.Checked)
            {
                iEdgeOrder = 1;
            }
            else if (this.rdb_cheese.Checked)
            {
                iEdgeOrder = 2;
            }

            CallbackCreate(iDowOrder, CreateDow);
            CallbackCreate(iEdgeOrder, CreateEdge);
            

            if (this.checkbx_option1.Checked)
            {
                delT += CreateTopping1;
            }
            if (this.checkbx_option2.Checked)
            {
                delT += CreateTopping2;
            }
            if (this.checkbx_option3.Checked)
            {
                delT += CreateTopping3;
            }

            delT(0, (int)nud_eacount.Value);

            this.listBox1.Items.Add($"전체 주문 가격은 {iTotalPrice}원 입니다.");
        }
        
        private int CallbackCreate(int iOrder, delCreate delFunc)
        {
            return delFunc(iOrder);
        }

        private int CreateTopping1(int iOrder, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 500;
            strOrder = $"토핑은 소세지를 {iEa}개를 선택하였습니다. {iPrice}원";
            this.listBox1.Items.Add(strOrder);
            return iTotalPrice += iPrice;
        }

        private int CreateTopping2(int iOrder, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 200;
            strOrder = $"토핑은 감자를 {iEa}개를 선택하였습니다. {iPrice}원";
            this.listBox1.Items.Add(strOrder);
            return iTotalPrice += iPrice;
        }

        private int CreateTopping3(int iOrder, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 300;
            strOrder = $"토핑은 치즈를 {iEa}개를 선택하였습니다. {iPrice}원";
            this.listBox1.Items.Add(strOrder);
            return iTotalPrice += iPrice;
        }


        private int CreateDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            switch (iOrder)
            {
                case 1:
                    iPrice = 10_000;
                    strOrder = $"도우는 오리지널을 선택하였습니다. {iPrice}원";
                    break;
                case 2:
                    iPrice = 11_000;
                    strOrder = $"도우는 씬을 선택하였습니다. {iPrice}원";
                    break;
                default:
                    strOrder = $"도우를 선택하지 않았습니다.";
                    break;
            }
            this.listBox1.Items.Add(strOrder);
            return iTotalPrice += iPrice;
        }

        private int CreateEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            switch (iOrder)
            {
                case 1:
                    iPrice = 1_000;
                    strOrder = $"엣지는 리치골드를 선택하였습니다. {iPrice}원";
                    break;
                case 2:
                    iPrice = 2_000;
                    strOrder = $"엣지는 치즈크러스트를 선택하였습니다. {iPrice}원";
                    break;
                default:
                    strOrder = $"엣지를 선택하지 않았습니다.";
                    break;
            }
            this.listBox1.Items.Add(strOrder);
            return iTotalPrice += iPrice;
        }
    }
}
