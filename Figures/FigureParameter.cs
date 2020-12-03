using System.Drawing;


namespace VectorDrawing.Figures
{
    public class FigureParameter
    {
        public Point[] Points { get; set; }
        public Point TemporaryPoint { get; set; }
    }
    public class EllipseFigureParameter
    {
        public Point TemporaryPoint { get; set; }
        public Point Center { get; set; }
    }
    public class RegularPolygonParameter
    {
        public int QuantityOfCorners { get; set; }
        public Point Center { get; set; }
        public Point TemporaryPoint { get; set; }
    }
}
