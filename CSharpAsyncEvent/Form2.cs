using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAsyncEvent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void ChangeLabel(string str)
        {
            this.lbl_text.Text = str;
        }

        public void printList(string str)
        {
            this.listBox1.Items.Add(str);
        }

        public void printList2(string str)
        {
            this.listBox2.Items.Add(str);
        }
    }
}
