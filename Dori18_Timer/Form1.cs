using System;
using System.Windows.Forms;

namespace Dori18_Timer
{
    public partial class Form1 : Form
    {
        private double dTick = 0;
        private double dTotal = 0;

        private int iAdd1 = 1;
        private int iAdd1Level = 1;
        private int iAdd3 = 0;
        private int iAdd3Level = 0;
        private int iAdd50 = 0;
        private int iAdd50Level = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer oTimer = new Timer();

            oTimer.Enabled = true;
            oTimer.Interval = 100;
            oTimer.Tick += OTimer_Tick;
            oTimer.Start();
            // oTimer.Stop();
        }
        // Interval 간격 기준으로 타이머에서 호출되는 이벤트
        // 이벤트가 종료되는 시점에서 다시 Interval 간격 이후에 재호출
        // 1) Interval 0.1초 > 이벤트 호출
        // 2) 이벤트는 10초 정도 기능 수행
        // 3) 10초 이후에 0.1(Interval)초 이후에 이벤트 재호출
        private void OTimer_Tick(object sender, EventArgs e)
        {
            dTick = iAdd1 + iAdd3 + iAdd50;
            dTotal += dTick;

            this.lbl_tickPoint.Text = $"{dTick} (1:{iAdd1Level}) (3:{iAdd3Level}) (50:{iAdd50Level})";
            this.lbl_total.Text = dTotal.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string str = string.Empty;

            switch (button.Name)
            {
                case "btn_add1":
                    if(dTotal > 100)
                    {
                        iAdd1Level += 1;
                        iAdd1 = 1 * iAdd1Level;
                        dTotal -= 100;
                    }
                    break;

                case "btn_add3":
                    if(dTotal > 500)
                    {
                        iAdd3Level += 1;
                        iAdd3 = 3 * iAdd3Level;
                        dTotal -= 500;
                    }
             
                    break;

                case "btn_add50":
                    if(dTotal > 5000)
                    {
                        iAdd50Level += 1;
                        iAdd50 = 50 * iAdd50Level;
                        dTotal -= 5000;
                    }
                    break;
            }
        }
    }
}
