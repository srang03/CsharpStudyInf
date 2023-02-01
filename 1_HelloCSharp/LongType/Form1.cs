using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num = long.Parse(txb_number.Text);

            this.lbl_result.Text = FormatBytes(num, 2);
        }

        public string FormatBytes(long pDrvSize, int pi)
        {
            int mok = 0;
            double drvSize = pDrvSize;
            string Space = "Byte";
            string returnStr;

            while (drvSize > 1024.0)
            {
                drvSize /= 1024.0;
                mok++;
            }

            if (mok == 1)
                Space = "KB";
            else if (mok == 2)
                Space = "MB";
            else if (mok == 3)
                Space = "GB";
            else if (mok == 4)
                Space = "TB";

            if (mok != 0)
                if (pi == 1)
                    returnStr = string.Format("{0:F1}{1}", drvSize, Space);
                else if (pi == 2)
                    returnStr = string.Format("{0:F2}{1}", drvSize, Space);
                else if (pi == 3)
                    returnStr = string.Format("{0:F3}{1}", drvSize, Space);
                else
                    returnStr = string.Format("{0}{1}", Convert.ToInt32(drvSize), Space);
            else
                returnStr = string.Format("{0}{1}", Convert.ToInt32(drvSize), Space);

            return returnStr;
        }
    }
}
