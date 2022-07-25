using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dori13_Inheritance
{
    internal class CDoubleCycle: CBase
    {
        public Rectangle _rtCircle2;
        public CDoubleCycle(string name)
        {
            base.strName = name;
            this.Pen = new Pen(Color.Black);

            _rtCircle2 = new Rectangle(210, 150, 120, 120);
            base._rtCircle = new Rectangle(30, 150, 120, 120);
            base._rtSquare = new Rectangle(60, 90, 240, 60);
        }

        public override void CircleMove(int iMove)
        {
            base.CircleMove(iMove);
            Point oPoint = _rtCircle2.Location;
            oPoint.X += iMove;
            _rtCircle2.Location = oPoint;
           
        }

        public override void SquareMove(int iMove)
        {
            base.SquareMove(iMove);
        }

        public override void Move(int iMove)
        {
            this.CircleMove(iMove);
            this.SquareMove(iMove);
        }
    }
}
