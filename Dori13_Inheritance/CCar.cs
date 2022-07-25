using System.Drawing;

namespace Dori13_Inheritance
{
    internal class CCar : CDoubleCycle
    {
        public Rectangle _rtSquare2;

        public CCar(string name) : base(name)
        {
            base.strName = name;

            base.Pen = new Pen(Color.Red);
            _rtSquare2 = new Rectangle(90, 30, 180, 90);
            base._rtSquare = new Rectangle(30, 120, 300, 60);
            base._rtCircle = new Rectangle(60, 180, 90, 90);
            base._rtCircle2 = new Rectangle(210, 180, 90, 90);   
        }

        public override void CircleMove(int iMove)
        {
            base.CircleMove(iMove);
        }

        public override void SquareMove(int iMove)
        {
            base.SquareMove(iMove);
            Point oPoint = _rtSquare2.Location;
            oPoint.X += iMove;
            _rtSquare2.Location = oPoint; 
        }

        public override void Move(int iMove)
        {
            this.CircleMove(iMove);
            this.SquareMove(iMove);
        }
    }
}
