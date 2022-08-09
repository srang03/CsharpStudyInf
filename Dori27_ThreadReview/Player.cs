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
        private Thread _thread;

        private bool _blnThreadStop = false; 

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
            _thread = new Thread(new ThreadStart(Run)); // ThreadStart 델리게이트 타입의 객체를 생성 후 함수로 넘김
            _thread.Start();

            //Thread _thread2 = new Thread(Run);// 컴파일러에서 델리게이트 객체를 추론해서 생서
            //_thread2.Start();

            //Thread _thread3 = new Thread(delegate () { Run(); }); // 익명함수에 담아서 사용
            //_thread3.Start();
        }

        public void Run()
        {
            // UI 컨트롤이 자신이 만들어진 Thread가 아닌 다른 Thread에서 접근할 경우 크로스 스레드가 발생한다.

            try
            {
                int iVal = 0;
                Random rd = new Random();

                while (this.progressBar1.Value < 100 && !_blnThreadStop)
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

                if (_blnThreadStop)
                {
                    eventDelMessage(this, $"이 중단되었습니다.");
                }
                else
                {
                    eventDelMessage(this, $"이 완료되었습니다.");
                }
                
            }
            catch(ThreadInterruptedException ex)
            {
                ex.ToString();
            }
            
            catch(Exception ex)
            {
                ex.ToString();
            }
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //ThreadInterrupt();
            if (_thread.IsAlive)
            {
                _blnThreadStop = true;
            }
        }

        public void ThreadAbort()
        {
            if (_thread.IsAlive) // Thread가 살아 있는지 확인
            {
                _thread.Abort();
            }
        }

        public void ThreadJoin()
        {
            if (_thread.IsAlive)
            {
                bool blnThreadEnd = _thread.Join(3000);
                // Join을 할 경우 계속 대기한 상태로 Thread를 끝내지 않고 중단시킨다.
                // 초를 설정하면 해당 초 동안 멈췄다 다시 Thread는 실행된다.
            }
        }

        public void ThreadInterrupt()
        {
            if (_thread.IsAlive)
            {
                _thread.Interrupt();
            }
        }
    }
}
