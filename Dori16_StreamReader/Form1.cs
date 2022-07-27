using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Dori16_StreamReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 설정 저장하기
        private void btn_setConfig_Click(object sender, EventArgs e)
        {
            string strText = this.txb_text.Text.ToString();
            bool bCheckBox = this.checkbx_value.Checked;
            int iNumber = (int)this.nud_number.Value;

            var enter = Environment.NewLine;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + enter);
            sb.Append(bCheckBox.ToString() + enter);
            sb.Append(iNumber.ToString() + enter);

            this.txb_result.Text = sb.ToString();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            this.saveFileDialog1.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 디렉토리
            this.saveFileDialog1.FileName = "*.txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if(this.saveFileDialog1.ShowDialog() == DialogResult.OK) // 저장을 하면
            {
                strFilePath = this.saveFileDialog1.FileName; // 저장하는 파일의 디렉토리 경로 + 파일명

                //StreamWriter sw = new StreamWriter(strFilePath);
                //sw.WriteLine(this.txb_result.Text);
                //sw.Close();

                File.WriteAllText(strFilePath, this.txb_result.Text);
                //File.WriteAllLines(strFilePath, this.txb_result.Lines);
            }
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            this.openFileDialog1.InitialDirectory = Application.StartupPath;
            this.saveFileDialog1.FileName = "*.txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder(strFilePath);

            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFilePath = this.openFileDialog1.FileName;

                //StreamReader sr = new StreamReader(strFilePath, Encoding.UTF8, true);
                //var enter = Environment.NewLine;

                //while (!sr.EndOfStream)
                //{
                //    sb.Append(sr.ReadLine());
                //    sb.Append(enter);
                //}
                

                sb.Append(File.ReadAllText(strFilePath));
                // string[] str = File.ReadAllLines(strFilePath);
                this.txb_result.Text = sb.ToString();
            }
            sb.Clear();

        }

        private void btn_getConfig_Click(object sender, EventArgs e)
        {
            string[] strConfig = this.txb_result.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            this.txb_text.Text = strConfig[0];
            this.checkbx_value.Checked = bool.Parse(strConfig[1]);
            this.nud_number.Value = int.Parse(strConfig[2]);
        }
    }
}
