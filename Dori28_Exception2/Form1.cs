using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori28_Exception2
{
    public partial class Form1 : Form
    {
        Dictionary<string, Color> DictColors;
        Color oColorselected;
        public Form1()
        {
            InitializeComponent();
            DictColors = new Dictionary<string, Color>();
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            
            DialogResult dRes = this.cdl_colors.ShowDialog();
            if(dRes == DialogResult.OK)
            {
                this.pColor.BackColor = this.cdl_colors.Color;
            }
            this.lbl_text.Text = this.pColor.BackColor.ToString();
        }

        private void tb_alpha_Scroll(object sender, EventArgs e)
        {
            this.pColor.BackColor = Color.FromArgb(tb_alpha.Value, this.pColor.BackColor);
            this.lbl_text.Text = this.pColor.BackColor.ToString();
        }

        private void btn_colorSave_Click(object sender, EventArgs e)
        {
            try
            {
                Color oColor = pColor.BackColor;
                DictColors.Add(oColor.ToString(), oColor);
            }
            catch
            {
             
            }
            ListBox_DataBind();


        }

        private void ListBox_DataBind()
        {
            try
            {
                this.lbx_color.Items.Clear();
                foreach (string c in DictColors.Keys)
                {
                    this.lbx_color.Items.Add(c);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbx_color.SelectedItem != null)
                {
                    var strKey = lbx_color.SelectedItem.ToString();

                    if (DictColors.ContainsKey(strKey))
                    {
                        DictColors.Remove(strKey);
                        ListBox_DataBind();
                    }
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lbx_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_color.SelectedItem != null)
            {
                string strKey = lbx_color.SelectedItem.ToString();
                oColorselected = DictColors[strKey];
            }
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Panel p = sender as Panel; // Panel로 형변환 하지 않는다면 null 값 발생

            if (lbx_color.SelectedItem != null)
            {
                p.BackColor = oColorselected;
            }
            else
            {
                MessageBox.Show("색상을 선택해주세요");
            }
                
        }
    }
}
