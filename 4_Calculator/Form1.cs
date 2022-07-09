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
    public enum  Operator { Add, Sub, Multi }
    public partial class Form1 : Form
    {
        Operator op;
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
            // sender : 이벤트를 발생시킨 객체
            Button btn = (Button)sender;
            SetNum(btn.Text);
        }

        public void SetNum(string number)
        {
            if (isNewNumber)
            {
                this.lbl_result.Text = number;
                this.isNewNumber = false;
            }
            else if (this.lbl_result.Text == "0")
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
            if (!isNewNumber) // 연산자가 두 번 눌러진 상태
            {
                int num = Convert.ToInt32(this.lbl_result.Text);
                if (op == Operator.Add)
                {
                    result += num;
                }
                else if (op == Operator.Sub)
                {
                    result -= num;
                }
                else if (op == Operator.Multi)
                {
                    result *= num;
                }
                isNewNumber = true;
            }
            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                op = Operator.Add;
            else if (optButton.Text == "-")
                op = Operator.Sub;
            else if (optButton.Text == "*")
                op = Operator.Multi;
          

            
          

            lbl_result.Text = result.ToString();
            isNewNumber = true;
           
            // 숫자 입력
            // 첫 번째 숫자 완성 num1 = 첫 번째 숫자 
            // 숫자 입력
            // 두 번째 숫자 완성 num2 = 두 번째 숫자, 첫 번째 변수와 두 번째 변수를 합, 결과를 첫번째 변수에 저장
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result = 0;
            isNewNumber = true;
            op = Operator.Add;
            this.lbl_result.Text = "0";
        }

 
    }
}
