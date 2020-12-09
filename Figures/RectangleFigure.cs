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
        public Point[] GetPoints(FigureParameter parameter)
        {
            if(parameter.TemporaryPoint != null && parameter.Points.Length == 1)
            {
                return new Point[] { parameter.Points[0], new Point(parameter.Points[0].X, parameter.TemporaryPoint.Y), parameter.TemporaryPoint, new Point(parameter.TemporaryPoint.X, parameter.Points[0].Y) };
            }
            else if(parameter.Points.Length == 2)
            {
                return new Point[] { parameter.Points[0], new Point(parameter.Points[0].X, parameter.Points[1].Y), parameter.Points[1], new Point(parameter.Points[1].X, parameter.Points[0].Y) };
            }
            else
            {
                throw new NullReferenceException("Points can't be null!");
            }
            
           
        }
    }
}
