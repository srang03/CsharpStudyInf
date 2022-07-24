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

        public Pen GetPen()
        {
            return this._pen;
        }
    }
}
