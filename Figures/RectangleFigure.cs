using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Figures
{
    public class RectangleFigure : IFigure
    {
        public PointF[] GetPoints(FigureParameter parameter)
        {
            if(parameter.TemporaryPoint != null && parameter.Points.Length == 1)
            {
                return new PointF[] { parameter.Points[0], new PointF(parameter.Points[0].X, parameter.TemporaryPoint.Y), parameter.TemporaryPoint, new PointF(parameter.TemporaryPoint.X, parameter.Points[0].Y) };
            }
            else if(parameter.Points.Length == 2)
            {
                return new PointF[] { parameter.Points[0], new PointF(parameter.Points[0].X, parameter.Points[1].Y), parameter.Points[1], new PointF(parameter.Points[1].X, parameter.Points[0].Y) };
            }
            else
            {
                throw new NullReferenceException("Points can't be null!");
            }
            
           
        }
    }
}
