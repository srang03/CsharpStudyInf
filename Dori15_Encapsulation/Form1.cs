using System;
using System.Windows.Forms;

namespace Dori15_Encapsulation
{
    public partial class Form1 : Form
    {
        private cData _data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _data = new cData();
            var prodcut = Enum.GetValues(typeof(EnumProduct));
            var rate = Enum.GetValues(typeof(EnumRate));
            
            foreach (var p in Enum.GetValues(typeof(EnumProduct)))
            {
                this.cbx_product.Items.Add(p);
            }

            foreach( var r in Enum.GetValues(typeof(EnumRate)))
            {
                this.cbx_sales.Items.Add(r);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.cbx_product.Text))
            {
                MessageBox.Show("You have to select Product");
            }
            else
            {
                _data.ProductName = this.cbx_product.SelectedItem.ToString();
            }
            
            _data.iRate = int.Parse(this.cbx_sales.SelectedItem.ToString());
            _data.iCount = (int)(this.numericUpDown1.Value);
        }


    }
}
