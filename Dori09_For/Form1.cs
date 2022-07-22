using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori09_For
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

        private void FuncFor()
        {
            this.txb_result.Text = string.Empty;

            StringBuilder sb = new StringBuilder();
            var result = 0;
            for (int i = 1; i <= 100; i++)
            {
                result += i;
                sb.Append(String.Format("1부터 {0}까지의 합은 {1}입니다.\r\n", i, result));
            }

            this.txb_result.Text = sb.ToString();
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            FuncFor();
        }

        private void btn_foreach_Click(object sender, EventArgs e)
        {
            var arr = new string[] { "나연", "소현", "모모", "사나", "다현"};

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            int i = 0;
            foreach (var item in arr)
            {
                sb.AppendLine($"{++i}반 선생님은 {item}입니다.");
            }

            this.txb_result.Text = sb.ToString();
        }
    }
}
