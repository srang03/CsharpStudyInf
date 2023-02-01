using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortProject
{
    public partial class Form1 : Form
    {
        List<PortableDeivceFile> _list;
        public Form1()
        {
            InitializeComponent();
            _list = new List<PortableDeivceFile>();
            Random rd = new Random();
            for(int i = 0; i< 10; i++)
            {
                var temp = rd.Next(100);
                _list.Add(new PortableDeivceFile()
                {
                    Name = i.ToString() + "파일",
                    ModifiedDate= DateTime.Now.AddDays(temp),
                });
  
            }

            PrintList(_list, listBox3);


        }

        private void PrintList(List<PortableDeivceFile> list, ListBox listBox)
        {
            foreach (var i in list)
            {
                listBox.Items.Add($"{i.Name}, {i.ModifiedDate.ToString("yyyy-MM-dd")}");
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            _list.Sort((file1, file2)=>  file1.ModifiedDate.CompareTo(file2.ModifiedDate));
      
            PrintList(_list, listBox1);
        }
    }
}
