using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Figures
{
    public class NLineFigure : IFigure
    {
        public Point[] GetPoints(FigureParameter parameter)
        {
            if (parameter.TemporaryPoint != null)
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
