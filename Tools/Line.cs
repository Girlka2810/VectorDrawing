using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    class Line : AbstractTool
    {

        public Line(Pen pen) : base(pen)
        {

        }

        public override void Paint(Graphics graphics)
        {
            if (_points.Count == 2)
            {
                graphics.DrawLine(_pen, _points[0], _points[1]);
            }
        }
    }
}
