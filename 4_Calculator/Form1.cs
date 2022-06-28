using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Calculator
{
    public partial class Form1 : Form
    {
        private string pre_number;
        private string next_number;
       

        public Form1()
        {
            InitializeComponent();
            pre_number = string.Empty;
            next_number = string.Empty;
        }

        private void btn_number1_Click(object sender, EventArgs e)
        {
            SetNum("1");


        }

        private void btn_number2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }

        public void SetNum(string number)
        {
            if (this.lbl_result.Text == "0")
            {
                this.lbl_result.Text = number;
            }
            else
            {
                this.lbl_result.Text += number;
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
         // 숫자 입력
         // 더하기 버튼 클릭 => num1에 저장
         // 숫자 입력
         // 더하기 버튼 클릭 => num
        }
    }
}
