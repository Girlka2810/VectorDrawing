using System;
using System.Drawing;

namespace VectorDrawing.Figures
{
    public class IsoscelesTriangleFigure : IFigure
    {
        public Point[] GetPoints(FigureParameter parameter)
        {
            if (parameter.Points.Length == 1)
            {
                Point[] tmp = new Point[parameter.Points.Length+2];
                Array.Copy(parameter.Points, tmp, parameter.Points.Length);
                tmp[tmp.Length - 1] = parameter.TemporaryPoint;
                tmp[tmp.Length - 2] = new Point(tmp[2].X+tmp[2].X*2,tmp[2].Y);
                return tmp;
            }
            else
            {
                return parameter.Points;
            }
        }
    }
}