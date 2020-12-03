using System;
using System.Drawing;

namespace VectorDrawing.Figures
{
    public class TriangleFigure : IFigure
    {
        public Point[] GetPoints(FigureParameter parameter)
        {
            if(parameter.Points.Length==0) throw  new NullReferenceException("Points count can't be null");
            if (parameter.Points.Length < 3)
            {
                Point[] tmp = new Point[parameter.Points.Length+1];
                Array.Copy(parameter.Points, tmp, parameter.Points.Length);
                tmp[tmp.Length - 1] = parameter.TemporaryPoint;
                return tmp;
            }
            
            return parameter.Points;
            
        }
    }
}