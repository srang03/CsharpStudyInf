using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori11_Struct
{

    public struct Player
    {
        public int iCount; // 플레이어 진행 횟수

        public int iSun; // 해 카드 값
        public int iStar; // 별 카드 값
        public int iMoon; // 달 카드 값
        public int iCardSum; // 카드 총합

        // 값 들을 더해서 값을 반환
        public int CardSum(int iSun, int iStar, int iMoon)
        {
            return iSun + iStar + iMoon;
        }

        public string ResultText()
        
        {
            this.iCardSum = iSun + iStar + iMoon;
            return $"해: {this.iSun}, 달: {this.iMoon}, 별: {this.iStar}의 합계는 {this.iCardSum}입니다.";
        }
    }

    public partial class Form1 : Form
    {
        private Player _p1;
        private Player _p2;
        private Random _random;

        public Form1()
        {
            InitializeComponent();
            _random = new Random();
        }

        private bool IsDone(int count)
        {
            return count > 4;
        }

        private void pbx_sun_Click(object sender, EventArgs e)
        {

            var number = _random.Next(1, 21);
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
            var number = _random.Next(1, 21);
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
            _random = new Random();
            var number = _random.Next(1, 21);
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

            if(_p1.iCount == _p2.iCount)
            {
                this.listBox1.Items.Add(PlayerPair(_p2.iCount, _p1.iCardSum, _p2.iCardSum));
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

                this.pbx_moon.Enabled = false;
                this.pbx_star.Enabled = false;
                this.pbx_sun.Enabled = false;
                this.pbx_none.Enabled = false;
            }
        }
        public string PlayerPair(int iCount, int p1_iCardSum, int p2_iCardSum)
        {
            int iCheck = p1_iCardSum - p2_iCardSum;
            if (iCheck > 0)
            {
                return $"{iCount}회차 Player1이 Player2보다 {iCheck}만큼 큽니다.";
            }
            else if (iCheck < 0)
            {
                return $"{iCount}회차 Player2이 Player1보다 {Math.Abs(iCheck)}만큼 큽니다.";
            }
            else
            {
                return $"{iCount}회차 Player2이 Player1가 동일합니다.";
            }
        }
    }
}
