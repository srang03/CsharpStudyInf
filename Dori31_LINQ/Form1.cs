using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori31_LINQ
{
    public partial class Form1 : Form
    {
        const string cLevel = "Level";
        const string cName = "Name";
        const string cAttribute = "Attribute";
        DataTable dt;
        enum EnumName
        {
            슬라임,
            가고일,
            믹스골렘,
            고블린,
            고스트,
            앤더드래곤,
            레드드래곤,
            서큐버스,
            바실리스트,
            데빌,
            사이언,
            노움,
            언데드,
            데블윙
        }

        enum EnumAttribute
        {
            불,
            물,
            바람,
            나무,
            번개
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTableCreate();
            EnemyCreate();
            ComboBoxCreate();
        }

        private void ComboBoxCreate()
        {
            foreach (var oName in Enum.GetNames(typeof(EnumAttribute)))
            {
                this.combobx_attrivute.Items.Add(oName);
            }
        }

        private void DataTableCreate()
        {
            // 테이블 생성
            
            dt = new DataTable("Enemy");

            
            // 데이터 Column 생성
            //DataColumn colLevel = new DataColumn(cLevel, typeof(int));
            //DataColumn colName = new DataColumn(cName, typeof(string));
            //DataColumn colAttribute = new DataColumn(cAttribute, typeof(string));

            //dt.Columns.Add(colLevel);
            //dt.Columns.Add(colName);
            //dt.Columns.Add(colAttribute);

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(cLevel, 1);
            dic.Add(cName, 2);
            dic.Add(cAttribute, 2);
            CreateColumn(dic);
        }

        private void CreateColumn(Dictionary<string, int> dic)
        {
            foreach(var s in dic)
            {
                Type type = null;
                switch (s.Value)
                {
                    case 1:
                        type = typeof(int);
                        break;
                    case 2:
                        type = typeof(string);
                        break;
                }
                dt.Columns.Add(new DataColumn(s.Key, type));
            }
        }

        private void EnemyCreate()
        {
            Random rd = new Random();
            foreach (EnumName oName in Enum.GetValues(typeof(EnumName)))
            {
                DataRow dr = dt.NewRow();

                dr[cLevel] = rd.Next(1, 11);
                dr[cName] = oName;

                int iLength = Enum.GetValues(typeof(EnumAttribute)).Length;
                int iAttribute = rd.Next(iLength);
                dr[cAttribute] = (EnumAttribute)iAttribute;

                dt.Rows.Add(dr);
            }
            this.dataGridView1.DataSource = dt;
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DataTable dtCopy = this.dataGridView1.DataSource as DataTable;

            OrderedEnumerableRowCollection<DataRow> SortedTable = null;

            switch (btn.Name)
            {
                case "btn_sortLevel":
                    SortedTable = from row in dtCopy.AsEnumerable()
                                           orderby row.Field<int>(cLevel)
                                           select row;
                    break;
                case "btn_sortName":
                    SortedTable = from row in dtCopy.AsEnumerable()
                                  orderby row.Field<string>(cName)
                                  select row;
                    break;
                case "btn_sortAttribute":
                    SortedTable = from row in dtCopy.AsEnumerable()
                                  orderby row[cAttribute]
                                  select row;
                    break;
            }
            // dt = this.dataGridView1.DataSource as DataTable;

            dtCopy = SortedTable.CopyToDataTable();
            this.dataGridView1.DataSource = dtCopy;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            DataTable dtCopy = this.dataGridView1.DataSource as DataTable;
            string attribute = this.combobx_attrivute.Text;
            int iStart = (int)this.nud_start.Value ;
            int iEnd = (int)this.nud_end.Value;
            var SortedTable = from row in dtCopy.AsEnumerable()
                              where row.Field<string>(cAttribute) == attribute
                              &&
                              row.Field<int>(cLevel) >= iStart && row.Field<int>(cLevel) <= iEnd select row;

            if(SortedTable.Count() > 0)
            {
                dtCopy = SortedTable.CopyToDataTable();
                this.dataGridView1.DataSource = dtCopy;
            }
            else
            {
                MessageBox.Show("조건에 맞는 데이터가 존재하지 않습니다.");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = dt;
        }
    }
}
