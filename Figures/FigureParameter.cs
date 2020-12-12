using System.Drawing;


namespace VectorDrawing.Figures
{
    public class FigureParameter
    {
        public PointF[] Points { get; set; }
        public PointF TemporaryPoint { get; set; }
    }
    public class EllipseFigureParameter
    {

        public PointF TemporaryPoint { get; set; }
        public PointF Center { get; set; }
        public float HorizontalRadius { get;  set; }
        public float VerticalRadius { get; set; }

    }
    public class RegularPolygonParameter
    {
        public int QuantityOfCorners { get; set; }
        public PointF Center { get; set; }
        public PointF TemporaryPoint { get; set; }
    }
}
