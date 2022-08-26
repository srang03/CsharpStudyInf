using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori26_ThreadReview0826
{
    public enum Players
    {
        아이린,
        슬기,
        웬디,
        조이,
        예리,
    }
    public partial class Form1 : Form
    {
        int _locationX;
        int _locationY;
        public Form1()
        {
            InitializeComponent();

            _locationX = 0;
            _locationY = 0;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            int intPlayerCount = (int)(this.nud_player.Value);

            _locationX = this.Location.X;
            _locationY = this.Location.Y;

            for (int i =0; i<intPlayerCount; i++)
            {
                Player player = new Player(Enum.GetName(typeof(Players), i));
                player.onMessage += Player_onMessage;
                // new Player((Players)i).ToString())
                player.Location = new Point(_locationX + this.Width, _locationY + (player.Height * i));
                player.Show();
                player.fThreadStart();
            }
            
        }

        private int Player_onMessage(object sender, string strReulst)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    Player oPlayer = sender as Player;
                    lbx_list.Items.Add(oPlayer.PlayerName + " " + strReulst);
                    
                }));
            }
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
