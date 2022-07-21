using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori01_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_toUpper_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lbx_split.Items.Clear();
            string input = this.txb_input.Text;
            this.lbl_contain.Text = input.Contains("Hello").ToString();
            this.lbl_equals.Text = input.Equals("Hello").ToString();
            this.lbl_length.Text = input.Length.ToString();
            this.lbl_replace.Text = input.Replace('l', 'p');
            this.lbl_substring.Text = input.Substring(0, 2).ToString();
            this.lbl_tolower.Text = input.ToLower();
            this.lbl_toUpper.Text = input.ToUpper();
            this.lbl_trim.Text = input.Trim();
            var str = input.Split(' ');
            foreach(var s in str)
            {
                this.lbx_split.Items.Add(s);
            }
          
        }
    }
}
