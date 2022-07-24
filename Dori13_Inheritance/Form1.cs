using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori13_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_step1_Click(object sender, EventArgs e)
        {
            COneCycle one = new COneCycle("스탭 원");
            this.label1.Text = one.strName;

            Graphics g = this.panel1.CreateGraphics();
            Pen p = one.GetPen();
            g.DrawRectangle(p, one._rtCircle);
            g.DrawRectangle(p, one._rtSquare);
        }
    }
}
