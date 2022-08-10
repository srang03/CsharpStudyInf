using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori29_UserControl
{
    public partial class Form1 : System.Windows.Forms.Form
    {
       
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form_Load(object sender, EventArgs e)
        {
            foreach(var item in this.panel1.Controls)
            {
                if(item is UserControlP)
                {
                    var info = item as UserControlP;

                    info.eventIntObjStr += UserControlP1_eventIntObjStr1;

                }
            }
        }
        private int UserControlP1_eventIntObjStr1(object sender, string strText)
        {
            UserControlP info = sender as UserControlP;
            this.listBox1.Items.Add($"[{info.UserNo}] {strText}");
            return 0;
        }
    }
}
