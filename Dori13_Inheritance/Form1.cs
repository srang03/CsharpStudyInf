using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dori13_Inheritance
{
    public partial class Form1 : Form
    {
        COneCycle one;
        CDoubleCycle two;
        CCar car;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            one = new COneCycle("스탭 원");
            two = new CDoubleCycle("스탭 투");
            car = new CCar("차");
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D)
            {
                MovingClickEvent(10);
            }
            else if(e.KeyCode == Keys.A)
            {
                MovingClickEvent(-10);
            }

        }


        private void btn_step1_Click(object sender, EventArgs e)
        {
            OneCycleDraw();
        }

        private Graphics InitCycle()
        {
            Graphics g = this.panel1.CreateGraphics();
            g.Clear(Color.Gray);
            return g;
        }

        private void OneCycleDraw()
        {
            this.label1.Text = one.strName;

            Graphics g = InitCycle();

            Pen p = one.Pen;
            g.DrawEllipse(p, one._rtCircle);
            g.DrawRectangle(p, one._rtSquare);
        }

        private void btn_step2_Click(object sender, EventArgs e)
        {
            TwoCycleDraw();
        }

        private void TwoCycleDraw()
        {
            this.label1.Text = two.strName;

            Graphics g = InitCycle();

            Pen p = one.Pen;
            g.DrawEllipse(p, two._rtCircle);
            g.DrawEllipse(p, two._rtCircle2);
            g.DrawRectangle(p, two._rtSquare);
        }

        private void btn_step3_Click(object sender, EventArgs e)
        {
            CarDraw();
        }

        private void CarDraw()
        {
            this.label1.Text = car.strName;

            Graphics g = InitCycle();

            Pen p = car.Pen;
            g.DrawEllipse(p, car._rtCircle);
            g.DrawEllipse(p, car._rtCircle2);
            g.DrawRectangle(p, car._rtSquare);
            g.DrawRectangle(p, car._rtSquare2);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            MovingClickEvent(10);
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            MovingClickEvent(-10);
        }

        private void MovingClickEvent(int iMove)
        {
            var flag = this.label1.Text;
            Graphics g = InitCycle();

            switch (flag)
            {
                case "스탭 원":
                    one.Move(iMove);
                    OneCycleDraw();
                    break;
                case "스탭 투":
                    two.Move(iMove);
                    TwoCycleDraw();
                    break;
                case "차":
                    car.Move(iMove);
                    CarDraw();
                    break;
            }
        }
    }
}
