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

namespace Dori27_ThreadReview
{
    public partial class Player : Form
    {
        public delegate int delMessage(object sender, string strResult);
        public event delMessage eventDelMessage;

        public string PlayerName { get; set; }

        public Player()
        {
            InitializeComponent();
        }

        public Player(string strPlayerName)
        {
            InitializeComponent();
            PlayerName = strPlayerName;
        }

        private void Play_Load(object sender, EventArgs e)
        {
            this.lbl_playerName.Text = PlayerName;
        }

        public void fThreadStart()
        {
            Thread _thread = new Thread(new ThreadStart(Run)); // ThreadStart 델리게이트 타입의 객체를 생성 후 함수로 넘김
            _thread.Start();

            //Thread _thread2 = new Thread(Run);// 컴파일러에서 델리게이트 객체를 추론해서 생서
            //_thread2.Start();

            //Thread _thread3 = new Thread(delegate () { Run(); }); // 익명함수에 담아서 사용
            //_thread3.Start();
        }

        public void Run()
        {
            // UI 컨트롤이 자신이 만들어진 Thread가 아닌 다른 Thread에서 접근할 경우 크로스 스레드가 발생한다.
            int iVal = 0;
            Random rd = new Random();

            while(this.progressBar1.Value < 100)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        iVal = rd.Next(1, 11);
                        if (this.progressBar1.Value + iVal > 100)
                        {
                            this.progressBar1.Value = 100;
                        }
                        else
                        {
                            this.progressBar1.Value += iVal;
                        }
                        this.Refresh();
                        this.lbl_progress.Text = $"진행 상황: {this.progressBar1.Value}%";
                    }));
                }
                Thread.Sleep(300);
            }
            eventDelMessage(this, $"이 완료되었습니다.");
        }
    }
}
