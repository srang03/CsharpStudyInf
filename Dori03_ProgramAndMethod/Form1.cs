using System;
using System.Windows.Forms;

namespace Dori03_ProgramAndMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var op = ((Button)sender).Text;
            var result = string.Empty;
            if (!int.TryParse(this.txb_num1.Text, out int num1))
            {
                result = "num1에 올바른 숫자를 입력해주세요.";
                this.txb_num1.Focus();
            
            }

            else if(!int.TryParse(this.txb_num2.Text, out int num2))
            { 
                result = "num2에 올바른 숫자를 입력해주세요.";
                this.txb_num2.Focus();
            
            }
            else
            {
                this.txb_result.Text = Calculate(num1, num2, op);
                return;
            }
            this.txb_result.Text = result;
            return;
        }

        private string Calculate(int num1, int num2, string op)
        {
            var result = string.Empty;
            switch (op)
            {
                case "+":
                    result = (num1 + num2).ToString();
                    break;
                case "-":
                    result = (num1 - num2).ToString();
                    break;
                case "/":
                    result = (num1 / num2).ToString();
                    break;
                case "*":
                    result = (num1 * num2).ToString();
                    break;
                default:
                    result = "오류가 발생했습니다.";
                    break;
            }
            return result;
        }

        private void txb_result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
