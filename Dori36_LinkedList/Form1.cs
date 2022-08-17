using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori36_LinkedList
{
    public partial class Form1 : Form
    {
        SortedList<DateTime, string> sList = new SortedList<DateTime, string>();
        Dictionary<DateTime, string> dList = new Dictionary<DateTime, string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
           
            DateTime dateTime = this.mCalendar.SelectionStart.Date;
            string strInput = this.txb_input.Text;

            if (sList.ContainsKey(dateTime))
            {
                MessageBox.Show("이미 등록된 날짜입니다.");
            }
            else
            {
                sList.Add(dateTime, strInput);
                this.mCalendar.AddBoldedDate(dateTime);
                this.mCalendar.UpdateBoldedDates();
                DateBindOnList();
            }
        }

        private void DateBindOnList()
        {
            this.lbx_list.Items.Clear();
            foreach(var item in sList)
            {
                this.lbx_list.Items.Add($"[{item.Key.Date:yyyy-MM-dd}] {item.Value}");
            }
        }

        private void mCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dateTime = this.mCalendar.SelectionStart;
            if (sList.ContainsKey(dateTime))
            {
                this.txb_input.Text = sList[dateTime];
            }
            else
            {
                this.txb_input.Text = string.Empty;
            }

        }
    }
}
