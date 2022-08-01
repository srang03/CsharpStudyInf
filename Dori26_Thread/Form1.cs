using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori26_Thread
{
    public partial class Form1 : Form
    {
        private enum _enumPlayer
        {
            P1,
            P2,
            P3,
            P4,
            P5
        }

        int _iLocationX = 0;
        int _iLocationY = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _iLocationX = this.Location.X;
            _iLocationY = this.Location.Y;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            _iLocationX = this.Location.X + this.Size.Width;
            _iLocationY = this.Location.Y;
            for (int i = 0; i < nud_playerCount.Value; i++)
            {
                Player playerForm1 = new Player(((_enumPlayer)i).ToString());
                playerForm1.Location = new Point(_iLocationX, _iLocationY + playerForm1.Height * i);
                playerForm1.Show();
                playerForm1.eventDelMessage += PlayerForm1_eventDelMessage;
               
                playerForm1.fThreadStart();
            }
        }

        private int PlayerForm1_eventDelMessage(object sender, string srtResult) 
        { 

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate
                {
                    Player oPlayer = sender as Player;
                    this.lb_player.Items.Add(srtResult);
                }));
            }
           
            return 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
