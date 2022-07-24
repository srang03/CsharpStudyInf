using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori12_Class
{
    public partial class Form1 : Form
    {
        Player _p1;
        Player _p2;
        Random _random;

        public Form1()
        {
            InitializeComponent();
            _random = new Random();
            _p1 = new Player();
            _p2 = new Player();
        }

        private void pbx_sun_Click(object sender, EventArgs e)
        {
            var number = _random.Next(1, 22);
            if (this.rbtn_player1.Checked)
            {
                _p1.iSun = number;
            }
            else
            {
                _p2.iSun = number;
            }
            ShowResult();
        }

        private void pbx_moon_Click(object sender, EventArgs e)
        {
            var number = _random.Next(1, 22);
            if (this.rbtn_player1.Checked)
            {
                _p1.iMoon = number;
            }
            else
            {
                _p2.iMoon = number;
            }
            ShowResult();
        }

        private void pbx_star_Click(object sender, EventArgs e)
        {
            var number = _random.Next(1, 22);
            if (this.rbtn_player1.Checked)
            {
                _p1.iStar = number;
            }
            else
            {
                _p2.iStar = number;
            }
            ShowResult();
        }

        private void pbx_none_Click(object sender, EventArgs e)
        {
            ShowResult();
        }
        private void iCheckedChange()
        {

            if (this.rbtn_player1.Checked)
            {

                this.rbtn_player1.Checked = false;
                this.rbtn_player2.Checked = true;
            }
            else
            {
                this.rbtn_player1.Checked = true;
                this.rbtn_player2.Checked = false;
            }
        }
        private bool IsDone(int number)
        {
            return number > 4;
        }
        private void ShowResult()
        {
            string strResult = string.Empty;

            if (this.rbtn_player1.Checked)
            {
                _p1.iCount += 1;
                strResult = _p1.ResultText();
                this.lbx_result1.Items.Add(strResult);
            }
            else
            {
                _p2.iCount += 1;
                strResult = _p2.ResultText();
                this.lbx_result2.Items.Add(strResult);
            }

            iCheckedChange();

            if (IsDone(_p1.iCount) && IsDone(_p2.iCount))
            {
                if (_p1.iCardSum > _p2.iCardSum)
                {
                    MessageBox.Show("Player1이 승리하였습니다");
                }
                else if (_p1.iCardSum < _p2.iCardSum)
                {
                    MessageBox.Show("Player2이 승리하였습니다");
                }
                else
                {
                    MessageBox.Show("비겼습니다.");
                }

            }
        }
    }

   
}
