using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori33_DynamicLayout
{
    public partial class UT : UserControl
    {
        public UT()
        {
            InitializeComponent();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            this.label1.Text = $"{this.Width}, {this.Height}";
        }
    }
}
