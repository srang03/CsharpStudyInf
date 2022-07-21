using System;
using System.Windows.Forms;

namespace Dori05_Enum
{
    public partial class Form1 : Form
    {

        private enum DaySet
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sun
        }

        private enum TimeSet
        {
            Morning,
            Afternoon,
            Evening
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var day in Enum.GetValues(typeof(DaySet)))
            {
                this.lbx_Day.Items.Add(day);
            }

            foreach (var time in Enum.GetValues(typeof(TimeSet)))
            {
                this.lbx_Time.Items.Add(time);
            }

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            var str = string.Empty;

            str = $"{this.textBox1.Text}님이 {this.lbx_Day.SelectedItem.ToString()}(요일) {this.lbx_Time.SelectedItem.ToString()}에 보기로 함";
            this.txb_result.Text = str;
        }
    }
}
