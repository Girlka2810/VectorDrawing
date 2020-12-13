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
        }
        
        public IsoscelesTriangleTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
            
        }

        
        public override void Paint(Graphics graphics)
        {
            IsoscelesTriangleFigure isoscelesTriangleFigure = new IsoscelesTriangleFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            graphics.DrawPolygon(Pen, ((CommonReturn)isoscelesTriangleFigure.Get(figureParameter)).Points);
        }

        public override void SavePoints()
        {
            IsoscelesTriangleFigure isoscelesTriangleFigure = new IsoscelesTriangleFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            EndShapePoints = ((CommonReturn)isoscelesTriangleFigure.Get(figureParameter)).Points;
        }
    }
}