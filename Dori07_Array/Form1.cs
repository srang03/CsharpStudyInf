using System;
using System.Threading;
using System.Windows.Forms;

namespace Dori07_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetArray();
        }

        private int[] GetArray()
        {
            Thread.Sleep(100);
            Random random = new Random();
            int[] arr = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                var temp = random.Next(i + i, (100));
                arr[i] = temp;
            }

            return arr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dgv_day.Rows.Clear();
            var arr = GetArray();
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                this.dgv_day[$"Day{i + 1}", 0].Value = arr[i];
                total += arr[i];
            }
            this.lbl_total.Text = total.ToString();
        }

        private void dgv_day_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dgv_day.Rows.Clear();
            this.dgv_day.Rows.Add();
            int total = 0;
            for (int i = 0; i < this.dgv_day.RowCount; i++)
            {
                var arr = GetArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    this.dgv_day[$"Day{j + 1}", i].Value = arr[j];
                    total += arr[j];
                }
            }
            this.lbl_total.Text = total.ToString();
        }
    }
}
