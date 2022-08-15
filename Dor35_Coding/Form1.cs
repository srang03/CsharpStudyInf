using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dor35_Coding
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

        private void btn_change_Click(object sender, EventArgs e)
        {
            //string[] strArr = this.txb_before.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            //StringBuilder strbuilder = new StringBuilder();
            //foreach(var item in strArr)
            //{   
            //    item.Replace("개똥", "사탕");
            //    item.Replace("닭", "과자");
            //    item.Replace("꿩", "아이스크림");
            //    item.Replace("생선", "우유");
            //    item.Replace("알", "돈");
            //}

            StringBuilder stringAfter = new StringBuilder(this.txb_before.Text);

            ChangeWord();
        }



        private void ChangeWord()
        {
            StringBuilder stringBuilder = new StringBuilder(this.txb_before.Text);

            for(int i =0; i<dataGridView1.Rows.Count - 1 ; i++)
            {
                var beforeWord = dataGridView1["cBefore", i].Value.ToString();
                var afterWord = dataGridView1["cAfter", i].Value.ToString();

                stringBuilder.Replace(beforeWord, afterWord);
            }

            this.txb_after.Text = stringBuilder.ToString();

            //foreach (DataGridViewRow row in dt.Rows)
            //{
            //    string strBeforeWord = row.Cells["cBefore"].ToString();
            //    string strAfterWord = row.Cells["cAfter"].ToString();

            //    stringBuilder.Replace(strBeforeWord, strAfterWord);
            //}

        }
    }
}
