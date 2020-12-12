using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class RectangularTriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 2;
        
        public RectangularTriangleTool(Pen pen) : base(pen)
        {
        }
        
        public RectangularTriangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {

        }
        
        public override void Paint(Graphics graphics)
        {
            RectangularTriangleFigure rectangularTriangleFigure = new RectangularTriangleFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            graphics.DrawPolygon(Pen, ((CommonReturn)rectangularTriangleFigure.Get(figureParameter)).Points);
        }

        
    }
}