using System.Drawing;

namespace VectorDrawing.RectangleConverts
{
    public interface IConvert
    {
        RectangleF ToRectangle(PointF[] points);
        PointF[] ToPoints(RectangleF rectangle);
        
    }
}