using System.Drawing;

namespace VectorDrawing.Figures
{
   public class LineFigure : IFigure
    {
        public PointF[] GetPoints(FigureParameter parameter)
        {

            if (parameter.TemporaryPoint != null && parameter.Points.Length == 1)
            {
                return new PointF[] { parameter.Points[0], parameter.TemporaryPoint };
            }
            else if (parameter.Points.Length == 2)
            {
                return new PointF[] { parameter.Points[0], parameter.Points[1] };
            }
            else
            {
                return new PointF[0];
            }
        }
    }
}
