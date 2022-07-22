using System;
using System.Windows.Forms;

namespace Dori08_Conditional
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

        private void btn_result_Click(object sender, EventArgs e)
        {
            var message = string.Empty;
            if (!int.TryParse(this.nud_num1.Value.ToString(), out int num1))
            {
                int numA = (int)this.nud_num1.Value;

                message = "num1을 올바르게 입력해주세요.";
            }
            else if (!int.TryParse(this.nud_num2.Value.ToString(), out int num2))
            {
                int numB = (int)this.nud_num2.Value;

                message = "num2을 올바르게 입력해주세요.";
            }
            else
            {
                if (num1 > num2)
                {
                    message = $"num1이 num2보다 {num1 - num2}만큼 큽니다.";
                }
                else if (num2 > num1)
                {
                    message = $"num2이 num1보다 {num2 - num1}만큼 큽니다.";
                }
                else
                {
                    message = "num1과 num2는 동일합니다.";
                }
            }
            this.txb_compareNumber.Text = message;
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            var result = this.comboBox1.SelectedItem.ToString();
            var message = string.Empty;

            switch (result)
            {
                case "월":
                    message = "선택하신 요일은 월요일 입니다.";
                    break;
                default:
                    message = "요일을 올바르게 선택해주세요.";
                    break;
            }
            this.txb_ExecuteDay.Text = message;
        }
    }
}
