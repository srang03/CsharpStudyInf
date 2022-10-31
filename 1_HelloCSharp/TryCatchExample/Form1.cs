using System;
using System.Windows.Forms;

namespace TryCatchExample
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

        private void button1_Click(object sender, EventArgs e)
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            try
            {

            Console.WriteLine(func());
            }
            catch
            {
                this.textBox1.Text = string.Empty;
                Console.WriteLine("bye");
            }
        }

        private bool func()
        {
            bool res = false;
            try
            {
                var result = int.Parse(this.textBox1.Text);
                res = true;
            }
            catch (FormatException)
            {
                throw;
                
            }
            return res;
        }
    }
}
