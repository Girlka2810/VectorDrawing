using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class TriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 3;
        
        public TriangleTool(Pen pen) : base(pen)
        {
        }

        public TriangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {

        }
        
        public override void Paint(Graphics graphics)
        {
            TriangleFigure triangleFigure = new TriangleFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            graphics.DrawPolygon(Pen, ((CommonReturn)triangleFigure.Get(figureParameter)).Points);
        }
        
        
        
        public override void AddPoint(PointF point)
        {
            if (Points.Count > 2)
            {
                Points.RemoveAt(2);
            }

            Points.Add(point);
        }
    }
}