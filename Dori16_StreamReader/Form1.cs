using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            StringBuilder sb = new StringBuilder();
            sb.Append(strText);
            sb.Append(bCheckBox.ToString());
            sb.Append(iNumber.ToString());

            this.txb_result.Text = sb.ToString();
        }
    }
}
