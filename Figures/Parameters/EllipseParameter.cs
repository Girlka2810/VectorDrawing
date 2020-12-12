using System.Drawing;

namespace VectorDrawing.Figures.Parameters
{
    public class EllipseParameter : FigureParameter
    {
        public PointF Center { get; set; }
        public float HorizontalRadius { get;  set; }
        public float VerticalRadius { get; set; }
    }
}