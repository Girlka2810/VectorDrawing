using System;
using System.Drawing;

namespace VectorDrawing.Figures
{
    public class TriangleFigure : IFigure
    {
        public PointF[] GetPoints(FigureParameter parameter)
        {
            if(parameter.Points.Length==0) throw  new NullReferenceException("Points count can't be null");
            if (parameter.Points.Length < 3)
            {
                PointF[] tmp = new PointF[parameter.Points.Length+1];
                Array.Copy(parameter.Points, tmp, parameter.Points.Length);
                tmp[tmp.Length - 1] = parameter.TemporaryPoint;
                return tmp;
            }
            
            return parameter.Points;
            
        }
    }
}