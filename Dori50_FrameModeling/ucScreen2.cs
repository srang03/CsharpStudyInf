using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dori50_FrameModeling.Common;

namespace Dori50_FrameModeling
{
    public partial class ucScreen2 : UserControl
    {
        public event delLogSender eLogSender;
        public ucScreen2()
        {
            InitializeComponent();
        }      

        private void ucScreen2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eLogSender(sender, e, enLogLevel.info, "Button Click");
        }
    }
}
