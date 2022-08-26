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

namespace Dori26_ThreadReview0826
{
    public partial class Player : Form
    {
        public delegate int del_Message(object sender, string strReulst);
        public event del_Message onMessage;
        public string PlayerName { get; set; }
        Thread _thread;
        public Player()
        {
            InitializeComponent();
            _thread = null;
        }

        public Player(string strPlayerName): this()
        {
            this.lbl_playerName.Text = PlayerName = strPlayerName;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {

        }
        public void fThreadStart()
        {
            // [1] ThreadStart 델리게이트 타입 객체를 생성 후 함수를 넘김
            _thread = new Thread(new ThreadStart(Process)); 
            _thread.Start();

            //// [2] 컴파일러가 델리게이트 객체를 추론해서 생성
            //_thread = new Thread(Process);
            //_thread.Start();

            //// [3] 익명 메소드르 사용하여 생성 후 함수를 넘김
            //_thread = new Thread(delegate () { Process(); });
            //_thread.Start();
        }

        public void Process()
        {

            // UI 컨트롤이 자신이 만들어진 Thread가 아닌 다른 Thread에서 접근할 경우 Cross Thread 발생
            // Process() 함수가 접근하는 progressBar는 Form에서 만들어졌기 때문에 Cross Thread 발생
            int iVar = 0;

            Random rd = new Random();

            while (this.progressBar1.Value < 100)
            {
                if (this.InvokeRequired)
                {

                this.Invoke(new Action(delegate ()
                {
                    iVar = rd.Next(1, 11);
                    if (this.progressBar1.Value + iVar > 100)
                    {
                        this.progressBar1.Value = 100;
                    }
                    else
                    {
                        this.progressBar1.Value += iVar;
                    }

                    this.label1.Text = $"진행상황 : {this.progressBar1.Value}%";
                    this.Refresh();
                }));
                Thread.Sleep(300);
                }
            }
            onMessage(this, "Thread Completed");
        }
    }
}
