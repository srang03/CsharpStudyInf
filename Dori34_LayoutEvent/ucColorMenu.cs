using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori34_LayoutEvent
{
    // 1. 
    public partial class ucColorMenu : UserControl
    {
        public ucColorMenu()
        {
            InitializeComponent();
        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dResult = cDialog_color.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                this.pColor.BackColor = this.cDialog_color.Color;
            }
        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i=0; i<4; i++)
            {
                Button obtn = new Button();

                obtn.Name = $"btn_{i+1}";
                obtn.Text = $"p{i+1} 색상변경";
                obtn.BackColor = Color.Gray;
                obtn.Margin = new Padding(10, 10, 10, 10);
                obtn.Size = new Size(100, 30);
                obtn.Click += Obtn_Click;

                this.flowLayoutPanel1.Controls.Add(obtn);
            }


        }

        private void Obtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
