using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori27_ThreadReview
{
    public partial class Form1 : Form
    {

        private enum enumPlayer
        {
            아이린,
            조이,
            웬디,
            슬기,
            예리
        }
        int _locationX = 0;
        int _locationY = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X;
            _locationY = this.Location.Y;

            int count = (int)this.nud_count.Value;
            for (int i =0; i< count; i++)
            {
                var tmp = Enum.GetName(typeof(enumPlayer), i);
                // ((enumPlayer)i).ToString();
                Player frm = new Player(tmp);
                frm.eventDelMessage += Frm_eventDelMessage;
                frm.Location = new Point(_locationX + this.Size.Width, _locationY + (i * frm.Size.Height));
                frm.Show();
                frm.fThreadStart();
            }
        }

        private int Frm_eventDelMessage(object sender, string strResult)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    Player frm = sender as Player;
                    this.listbx_list.Items.Add(frm.PlayerName + " " + strResult);
                    
                }));
            }
            return 0;
        }
    }
}
