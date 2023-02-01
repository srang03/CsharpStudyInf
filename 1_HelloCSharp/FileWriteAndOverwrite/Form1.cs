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

namespace FileWriteAndOverwrite
{
    public partial class Form1 : Form
    {
        private string _path = string.Empty;
        private long _size = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_overwrite_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[_size];

            using(FileStream fs = new FileStream(_path, FileMode.Create, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

        }

        

        private void btn_selectFile_Click(object sender, EventArgs e)
        {
            this.openFileDialog1= new OpenFileDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.FileName;
                _path = openFileDialog1.FileName;
                
                FileInfo fi = new FileInfo(_path);
                _size = fi.Length;
            }
            return;
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            using(FileStream fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                int bufferSize = 1024;
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = fs.Read(buffer, 0, bufferSize)) > 0)
                {
                    if (count < 1)
                    {
                        sb.AppendLine(System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead));

                    }
                    count += 1;
                }

    
            }

            Console.WriteLine(sb.ToString());
            MessageBox.Show("End");
        }
    }
}
