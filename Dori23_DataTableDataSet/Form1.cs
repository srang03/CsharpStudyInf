using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori23_DataTableDataSet
{
    public enum classes
    {
        class1,
        class2,
        class3
    }
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet(); // 모든 반들에 대한 테이블 집합

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var c in Enum.GetNames(typeof(classes))){
                this.combobx_class.Items.Add(c);
                this.combobx_selectClass.Items.Add(c);
            }
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
            bool bHasTable = false;
            string tableName = combobx_class.Text;
            if (ds.Tables.Contains(tableName))
            {
                bHasTable = true;
            }
            DataTable dt = null;
            if (!bHasTable) // 테이블이 없을 경우 새로 생성
            {
                dt = new DataTable(this.combobx_class.Text);

                DataColumn colName = new DataColumn("Name", typeof(string));
                DataColumn colGender = new DataColumn("Gender", typeof(string));
                DataColumn colRef = new DataColumn("Ref", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colGender);
                dt.Columns.Add(colRef);
            }
            else // 테이블이 있을 경우 DataSet에 있는 테이블 로드
            {
                dt = ds.Tables[tableName];
            }
            // 테이블 생성
           

            // 자료 등록
            DataRow row = dt.NewRow();

            row["Name"] = this.txb_name.Text;

            if (this.rdb_man.Checked)
            {
                row["Gender"] = "남자";
            }
            else if(this.rdb_woman.Checked)
            {
                row["Gender"] = "여자";
            }
            row["Ref"] = this.txb_ref.Text;


            // 생성된 Row를 Table에 등록


            if (!bHasTable)
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }
            else
            {
                ds.Tables[tableName].Rows.Add(row);
            }
            combobx_selectClass_SelectedIndexChanged(this, null);
        }

        private void combobx_selectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBind();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int iSelectedRow = this.dataGridView1.SelectedRows[0].Index;
            string tableName = combobx_class.Text;

            ds.Tables[tableName].Rows.RemoveAt(iSelectedRow);
            DataBind();
        }

        private void DataBind()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = ds.Tables[this.combobx_selectClass.Text];
        }
    }
}
