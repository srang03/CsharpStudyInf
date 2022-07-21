using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori02_DataTypeAndOverflow
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

        private void button2_Click(object sender, EventArgs e)
        {
            var str = this.textBox1.Text;
            short.TryParse(str, out short shortNum);
            this.lbl_short.Text = shortNum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var str = this.textBox1.Text;
            int.TryParse(str, out int Num);
            this.lbl_int.Text = Num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var str = this.textBox1.Text;
            Double.TryParse(str, out Double Num);
            this.lbl_double.Text = Num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = this.textBox1.Text;
            var result = string.Empty;
            if (short.TryParse(str, out short short_num))
            {
                result = short_num.ToString();
                this.lbl_short.Text = result;
            }
            else if (int.TryParse(str, out int int_num))
            {
                result = int_num.ToString();
                this.lbl_int.Text = result;
            }
            else if (double.TryParse(str, out double double_num))
            {
                result = double_num.ToString();
                this.lbl_double.Text = result;
            }
            else
            {
                result = "변환할 수 없습니다.";
                this.lbl_exception.Text = result;
            }
        }
    }
}
