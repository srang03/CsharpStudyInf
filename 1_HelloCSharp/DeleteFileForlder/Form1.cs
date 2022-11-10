using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteFileForlder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo("C:\\Users\\Ian\\Desktop\\de");
            di.Delete(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\Users\\Ian\\Desktop\\de");
        }
    }
}
