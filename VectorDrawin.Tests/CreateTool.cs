using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Tools;
using VectorDrawing.Tools.Brushes;
using VectorDrawing.Tools.Ellipse;
using VectorDrawing.Tools.Lines;
using VectorDrawing.Tools.Polygons;

namespace VectorDrawin.Tests
{
    public static class CreateTool
    {
        public static AbstractTool Circle(List<PointF> points, Pen pen)
        {
            return new CircleTool(points, pen);
        }
        
        public static AbstractTool RegularPolygon(List<PointF> points, Pen pen, int quantityOfCorners)
        {
            var tool = new RegularPolygonTool(points, pen);
            tool.QuantityOfCorners = quantityOfCorners;
            return tool;
        }

        
        public static AbstractTool Ellipse(List<PointF> points, Pen pen)
        {
            return new EllipseTool(points, pen);
        }
        
        public static AbstractTool Line(List<PointF> points, Pen pen)
        {
            return new SingleLine(points, pen);
        }
        
        public static AbstractTool Brush(List<PointF> points, Pen pen)
        {
            return new BasicBrush(points, pen);
        }
        
        public static AbstractTool NLine(List<PointF> points, Pen pen)
        {
            return new NLine(points, pen);
        }
        
        public static AbstractTool Rectangle(List<PointF> points, Pen pen)
        {
            return new RectangleTool(points, pen);
        }
        
        public static AbstractTool RectangularTriangle(List<PointF> points, Pen pen)
        {
            return new RectangularTriangleTool(points, pen);
        }
        
        public static AbstractTool Square(List<PointF> points, Pen pen)
        {
            return new SquareTool(points, pen);
        }
        
        public static AbstractTool Triangle(List<PointF> points, Pen pen)
        {
            return new TriangleTool(points, pen);
        }
    }
}