using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dori26_ThreadReview
{
    // 스레드: 프로세스 내에서 실행 되는 동작의 단위
    // 여러개의 프로세스가 동시에 실행될 수 있도록한다.
    // 하나의 자원에 대해서 여러 개의 Thread가 동시에 접근하게 되면 자원 관리에 문제가 발생할 수 있다. (Cross Thread)
    // 크로스 스레드를 해결하기 위해 Invoke를 사용하여 Thread를 잠시 Main Thread로 위임할 수 있다.

    // Start()
    // IsAlive()
    // Abort(): 강제 종료
    // Join(): 다른 스레드 종료될 때 까지 대기
    // Interrupt(): 스레드가 대기 상태일 경우 Exception 발생시킴
    // Suspend(): 스레드 일시 중지
    // Resume(): 일시 중지된 Thread 다시 시작
    // Sleep(): 설정시간 동안 스레드 일시 중단


    public partial class Form1 : Form
    {
        int _locationX = 0;
        int _locationY = 0;

        public Form1()
        {
            InitializeComponent();

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;


            var iPlayerCount = (int)this.nud_inputPlayer.Value;

            for (int i = 0; i < iPlayerCount; i++)
            {
                Player player = new Player($"p{i}");

                player.Location = new Point(_locationX + this.Width, _locationY + (player.Height * i));

                Console.WriteLine($"{this.Width}, {_locationX}, {_locationY + player.Height * i}");
                player.Show();
                
            }

        }
    }
}
