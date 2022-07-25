using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dori13_Inheritance
{
    class CBase
    {

        public Rectangle _rtCircle;
        public Rectangle _rtSquare;

        public string strName;
        private Pen _pen;

        public CBase()
        {
            _pen = new Pen(Color.Aqua);

            _rtCircle = new Rectangle(120, 150, 120, 120);
            _rtSquare = new Rectangle(150, 30, 60, 120);
        }

        public Pen Pen
        {
            get { return _pen; }
            protected set { this._pen = value; }
        }

        public virtual void Move(int iMove)
        {
            CircleMove(iMove);
            SquareMove(iMove);
        }

        public virtual void CircleMove(int iMove)
        {
            Point oPoint = _rtCircle.Location; // 현재 위치
            oPoint.X += iMove;
            _rtCircle.Location = oPoint;
        }

        public virtual void SquareMove(int iMove)
        {
            Point oPoint = _rtSquare.Location; // 현재 위치
            oPoint.X += iMove;
            _rtSquare.Location = oPoint;
        }

    }
}
