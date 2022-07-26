using System;
using System.Windows.Forms;

namespace Dori15_Encapsulation
{
    public partial class Form1 : Form
    {
        private cData _data;
        private double total;
        public Form1()
        {
            InitializeComponent();
            total = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            _data = new cData();

            _data.ProductName = this.cbx_product.Text;
            _data.iRate = (int)Enum.Parse(typeof(EnumRate), this.cbx_sales.Text);
            _data.iCount = (int)(this.numericUpDown1.Value);

            if (!string.IsNullOrEmpty(_data.message))
            {
                this.tbx_message.Text = _data.message;
                return;
            }
            
            double dPrice = _data.GetItemPrice();
            this.listBox1.Items.Add(_data.fResult(dPrice));
            total += dPrice;
            this.txb_total.Text = total.ToString();
        }


    }
}
