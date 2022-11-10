using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Font f;

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> fonts = new List<string>();
            
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
                
                this.listBox1.Items.Add(font.Name);
            }
            string temp = "20221104165337_OPPO R11t\0";
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = listBox1.SelectedItem.ToString();
            f = new Font(fontName, 30, FontStyle.Regular);
            this.label1.Text = fontName;
            this.label1.Font = f;
        }

        

    }
}
