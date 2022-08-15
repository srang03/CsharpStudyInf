using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori34_LayoutEvent
{
    public partial class ucPanel : UserControl
    {
        public EventHandler eLabelDoubleClickHandler;
        public ucPanel()
        {
            InitializeComponent();


        }

        private void panel_ucPancel_SizeChanged(object sender, EventArgs e)
        {
            this.lbl_text.Text = $"{this.panel_ucPancel.Width}, {this.panel_ucPancel.Height}";
        }

        private void lbl_text_DoubleClick(object sender, EventArgs e)
        {
            eLabelDoubleClickHandler(this, e);
        }
    }
}
