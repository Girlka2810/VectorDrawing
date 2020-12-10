using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Figures
{
    public class SquareFigure : IFigure
    {
        public PointF[] GetPoints(FigureParameter parameter)
        {
            PointF prev = parameter.Points[0];
            PointF crnt = parameter.TemporaryPoint;
            PointF[] points;

            float width = Module(prev.X - crnt.X);
            float height = Module(prev.Y - crnt.Y);
            if (width >= height)
            {
                crnt.X = crnt.X >= prev.X ? prev.X + height : prev.X - height;
            }
            else
                crnt.Y = crnt.Y >= prev.Y ? prev.Y + width : prev.Y - width;
            points = new PointF[]
            {
                prev,
                new PointF(crnt.X, prev.Y),
                crnt,
                new PointF(prev.X, crnt.Y),
            };
            return points;
        }

        private float Module(float n)
        {
            return n < 0 ? n * -1 : n;
        }
    }
}