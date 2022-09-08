using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitExcerise0908
{
    public partial class ListUp : Form
    {

        uint iAnomolyCount;

        public ListUp()
        {
            InitializeComponent();
            iAnomolyCount = 0;

        }

        public async void GetAnomolyDataFromView(uint uiData)
        {
            iAnomolyCount += 1;
            await Task.Run(() =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                       this.lbx_anomolyList.Items.Add(uiData);
                       this.lbl_listAnomoly.Text = iAnomolyCount.ToString();
                        this.lbx_anomolyList.SelectedIndex = this.lbx_anomolyList.Items.Count - 1;
                        this.lbx_anomolyList.SelectedIndex = -1;
                    }));
                }
            });
        }


        public async void GetDataFromView(uint uiData, uint count)
        {
            await Task.Run(() =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.lbx_list.Items.Add(uiData);
                        this.lbl_listCount.Text = count.ToString();
                        this.lbx_list.SelectedIndex = this.lbx_list.Items.Count - 1;
                        this.lbx_list.SelectedIndex = -1;
                    }));
                }
            });
        }
    }
}
