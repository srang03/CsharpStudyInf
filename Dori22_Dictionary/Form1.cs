using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dori22_Dictionary
{
    public enum ePeople
    {
        Ho,
        Ru,
        Rang,
        Ti
    }

    public enum eClassPeople
    {
        Ho,
        Tx,
        Pi,
        Pill,
        Tony,
        TomBoy,
        Ru,
        Rang,
        Ti,
        An,
        KingDom,
        Daru,
        Ill,
        Pang
    }
    public partial class Form1 : Form
    {
        Hashtable _ht = new Hashtable();
        Dictionary<string, string> _dPepole;
        int iTotalCount = Enum.GetValues(typeof(eClassPeople)).Length;
        int iPeopleCount = 0;


        public Form1()
        {
            InitializeComponent();
            _dPepole = new Dictionary<string, string>();
        }

        private void lbl_person1_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            string name = lb.Text;

            if (iTotalCount > iPeopleCount)
            {
                switch (lb.Name)
                {
                    case "lbl_person1":
                        this.lbl_count1.Text = (int.Parse(this.lbl_count1.Text) + 1).ToString();
                        break;
                    case "lbl_person2":
                        this.lbl_count2.Text = (int.Parse(this.lbl_count2.Text) + 1).ToString();
                        break;
                    case "lbl_person3":
                        this.lbl_count3.Text = (int.Parse(this.lbl_count3.Text) + 1).ToString();
                        break;
                    case "lbl_person4":
                        this.lbl_count4.Text = (int.Parse(this.lbl_count4.Text) + 1).ToString();
                        break;
                    default:

                        break;
                }
                eClassPeople eName = (eClassPeople)iPeopleCount;
                _dPepole.Add(eName.ToString(), name);
                //_ht.Add("", name);

                iPeopleCount += 1;
               
                this.lbl_name.Text = eName.ToString();
                this.lbl_progressCounter.Text = $"{iPeopleCount} / {iTotalCount}";
               
            }
            else
            {
                // 종료
                MessageBox.Show("투표가 종료되었습니다.");
            }
            DataBind();
        }

        private void DataBind()
        {       
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = _dPepole.Select(x => new {Name = x.Key, Vote = x.Value}).ToList();
            this.dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

