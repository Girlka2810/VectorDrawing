using System.Drawing;

namespace VectorDrawing.Figures.Parameters
{
    public class RegularPolygonParameter : FigureParameter
    {
        public int QuantityOfCorners { get; set; }
        public PointF Center { get; set; }

    }
}