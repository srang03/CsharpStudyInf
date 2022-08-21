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

namespace Dori41_MenuControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileSave();

        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLoad();
        }

        private void 공백제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 모두삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void 공백제거ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 클립보드ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 모두삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FileLoad()
        {
            OpenFileDialog ofdMenu = new OpenFileDialog();

            string strFilePath = string.Empty;
         
            ofdMenu.FileName = "*.txt";
            ofdMenu.Filter = "txt files (*.txt)|*.txt|모든 파일 (*.*)|*.*";

            try
            {
                if(ofdMenu.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = ofdMenu.FileName;
                    StreamReader sr = new StreamReader(strFilePath, Encoding.UTF8, true);

                    while (sr.EndOfStream == false)
                    {
                        this.listBox1.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        private void FileSave()
        {
            uint iCount = Convert.ToUInt32(this.listBox1.Items.Count);
            string strFilePath = string.Empty;

            SaveFileDialog sfdMenu = new SaveFileDialog();
            sfdMenu.InitialDirectory = Application.StartupPath;
            sfdMenu.FileName = "*.txt";
            sfdMenu.Filter = "txt files (*.txt)|*.txt|모든 파일 (*.*)|*.*";

            try
            {
                if(sfdMenu.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = sfdMenu.FileName;
                    StreamWriter sw = new StreamWriter(strFilePath);
                    for(int i = 0; i<iCount; i++)
                    {
                        sw.WriteLine(this.listBox1.Items[i].ToString());
                    }
                    sw.Close();
                    MessageBox.Show("저장이 완료되었습니다.");
                }
            }
            catch
            {

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.txb_input.Text);
        }

        private void ShowProgramInfo()
        {
            string strProgramInfo = "하이";
            
        }
    }
}
