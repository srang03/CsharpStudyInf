using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori42_DetailofList
{
    public partial class Form1 : Form
    {
        List<object> oList = new List<object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAdd();
            this.txb_value.Clear();
        }
        private void DataAdd()
        {
            int position = Convert.ToInt32(this.nud_position.Value);
            if (position < 1)
            {
                oList.Add(this.txb_value.Text);
            }
            else
            {
                oList.Insert(Convert.ToInt32(position) - 1, this.txb_value.Text);
            }
            LboxNoCreate();
            oListDataDetail();
            ListDataBind();
        }

        private void DataRemove()
        {
            int position = Convert.ToInt32(this.nud_position.Value);
            if(position-1 < 1)
            {
                oList.Remove(this.txb_value.Text);
            }
            else
            {
                oList.RemoveAt(position-1);
            }
            LboxNoCreate();
            oListDataDetail();
            ListDataBind();
        }

        private void ListDataBind()
        {
            this.list_box1.DataSource = oList.ToList<object>();
        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            DataRemove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataChange();
        }

        private void DataChange()
        {
            List<object> ListChange = oList.ConvertAll<object>(str => str.ToString().Replace(txb_search.Text, txb_modify.Text));
            this.list_box2.DataSource = ListChange.ToList<object>();
            oListChangedDataDetail(ListChange);


        }

        private void txb_value_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DataAdd();
            }
        }

        private void LboxNoCreate()
        {
            List<int> iList = Enumerable.Repeat(0, oList.Count).ToList<int>();
            for(int i =0; i<iList.Count; i++)
            {
                iList[i] = i + 1;
            }
            this.list_number.DataSource = iList;
        }

        private void oListDataDetail()
        {
            int iListCount = oList.Count;
            int iListCapacity = oList.Capacity;
            string strListData = string.Join(", ", oList);


            StringBuilder sb = new StringBuilder();
            sb.Append($"Count : {iListCount}{Environment.NewLine}");
            sb.Append($"Capacity : {iListCapacity}{Environment.NewLine}");
            sb.Append($"Data : {strListData}");
            this.txb_ListDetail.Text = sb.ToString();
            sb.Clear();
        }

        private void oListChangedDataDetail(List<object> oList)
        {
            int iListCount = oList.Count;
            int iListCapacity = oList.Capacity;
            string strListData = string.Join(", ", oList);

            StringBuilder sb = new StringBuilder();
            sb.Append($"Count : {iListCount}{Environment.NewLine}");
            sb.Append($"Capacity : {iListCapacity}{Environment.NewLine}");
            sb.Append($"Data : {strListData}");
            this.txb_changeListDetail.Text = sb.ToString();
            sb.Clear();
        }
    }
}
