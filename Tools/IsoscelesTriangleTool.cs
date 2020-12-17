using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class IsoscelesTriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 2;

        public IsoscelesTriangleTool(Pen pen) : base(pen)
        {
            Figure = new IsoscelesTriangleFigure();
        }
        
        public IsoscelesTriangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new IsoscelesTriangleFigure();
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
            
        }

    }
}