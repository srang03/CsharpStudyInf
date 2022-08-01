using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dori26_Thread
{
    public partial class Player : Form
    {
        public delegate int delMessage(object sender, string srtResult);// delegate 선언
        public event delMessage eventDelMessage;

        private string _strPlayerName;
        Thread thread = null;
        public Player()
        {
            InitializeComponent();
        }

        public Player(string strPlayerName)
        {
            InitializeComponent();
            lbl_playerName.Text = _strPlayerName = strPlayerName;
        }

        private void Player_Load(object sender, EventArgs e)
        {

        }

        public void fThreadStart()
        {
            // 1번 방법
            // thread = new Thread(new ThreadStart(Run)); // ThreadStart 델리게이트 타입 객체를 생성 후 함수를 델리게이트로 넘겨준다.
            // thread.Start();

            // 2번 방법
            // thread = new Thread(Run); // 컴파일러에서 델리게이트 객체를 추론해서 생성 후 함수를 넘김 (new ThreadStart(Run)을 생략한다.)

            // 3번 방법
            // thread = new Thread(delegate () { Run(); }); // 익명 메서드를 사용하여 생성 후 함수를 넘김

            thread = new Thread(new ThreadStart(Run));
            thread.Start();


        }

        public void Run()
        {
            // UI Control이 자신의 스레드가 아닌 다른 스레드에서 생성하여 접근할 경우 Cross Thread 발생
            int iVar = 0;
            Random rd = new Random();

            while (this.progressBar1.Value < 100)
            {
                if (this.InvokeRequired) // 요청한 Thread가 현재 Main Thread에 있는 컨트롤에 접근할 수 있는지
                {
                    this.Invoke(new Action(delegate ()
                    {
                        iVar = rd.Next(1, 11);
                        if (progressBar1.Value + iVar > 100)
                        {
                            progressBar1.Value = 100;
                        }
                        else
                        {
                            progressBar1.Value += iVar;
                        }

                        lbl_progressBar.Text = $"진행 상황 : {progressBar1.Value}%";
                    }));
                }
                Thread.Sleep(300);
            }

            eventDelMessage(this, $"{_strPlayerName}이 종료되었습니다.");
        }
    
    }
}
