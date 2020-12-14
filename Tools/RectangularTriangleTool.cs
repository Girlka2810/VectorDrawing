using System;
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
            Figure = new RectangularTriangleFigure();;
        }
        
        public RectangularTriangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new RectangularTriangleFigure();;
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public override void Paint(Graphics graphics)
        {
            graphics.DrawPolygon(Pen, ((CommonReturn)Figure.Get(GenerateParametrs())).Points);
        }
        
    }
}