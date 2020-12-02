using System.Drawing;

namespace VectorDrawing.Figures
{
    class LineFigure : IFigure
    {
        public Point[] GetPoints(FigureParameter parameter)
        {
            if (parameter.TemporaryPoint != null && parameter.Points.Length == 1)
            {
                return new Point[] { parameter.Points[0], parameter.TemporaryPoint };
            }
            else if (parameter.Points.Length == 2)
            {
                return new Point[] { parameter.Points[0], parameter.Points[1] };
            }
            else
            {
                return new Point[0];
            }
        }
    }
}
