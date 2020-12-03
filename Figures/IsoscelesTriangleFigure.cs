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
                Point[] tmp = new Point[parameter.Points.Length+1];
                Array.Copy(parameter.Points, tmp, parameter.Points.Length);
                tmp[tmp.Length - 1] = parameter.TemporaryPoint;
                return tmp;
            }
            else
            {
                return parameter.Points;
            }
        }
    }
}