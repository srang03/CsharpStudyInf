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

        private int result;
        private bool isNewNumber;
       

        public Form1()
        {
            InitializeComponent();

            result = 0;
            isNewNumber = true;
        }

        private void btn_number1_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                this.lbl_result.Text = "1";
                this.isNewNumber = false;
            }
            else
            {
                if(this.lbl_result.Text == "0")
                {
                    this.lbl_result.Text = "1";
                }
                else
                {
                    this.lbl_result.Text += "1"; 
                }
            }
            SetNum("1");
        }

        private void btn_number2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetNum("0");
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
            int num = Convert.ToInt32(this.lbl_result.Text);
            result += num;

            lbl_result.Text = result.ToString();
            isNewNumber = true;
           
            // 숫자 입력
            // 첫 번째 숫자 완성 num1 = 첫 번째 숫자 
            // 숫자 입력
            // 두 번째 숫자 완성 num2 = 두 번째 숫자, 첫 번째 변수와 두 번째 변수를 합, 결과를 첫번째 변수에 저장
        }

      
    }
}
