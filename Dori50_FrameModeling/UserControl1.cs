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
    public partial class UserControl1 : UserControl
    {
        public event delLogSender eLogSender;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            eLogSender(sender, e, enLogLevel.info, "Button Click");
        }
    }
}
